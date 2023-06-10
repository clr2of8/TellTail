using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace TellTail
{
    public partial class TellTailForm : Form
    {
        private List<DataGridView> dataGridViews = new List<DataGridView>();

        public TellTailForm()
        {
            InitializeComponent();

            AddTab("Microsoft-Windows-PowerShell/Operational");
            AddTab("Windows PowerShell");
            AddTab("PowerShellCore/Operational");

            try
            {
                this.Text = "TellTail v" + System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion;

            }
            catch
            {
                this.Text = "TellTail v" + Application.ProductVersion;
            }

        }

        private void AddTab(String LogName)
        {
            TabPage tabPage1 = new System.Windows.Forms.TabPage();
            DataGridView dataGridView1 = new System.Windows.Forms.DataGridView();
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            ((System.ComponentModel.ISupportInitialize)(dataGridView1)).BeginInit();

            tabPage1.Controls.Add(dataGridView1);
           // tabPage1.Location =logTabControl.Location;
            tabPage1.Name = "tabPage4";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            //tabPage1.Size = logTabControl.Size;
            tabPage1.TabIndex = 0;
            tabPage1.Text = "-->" + LogName;
            tabPage1.UseVisualStyleBackColor = true;
            if (LogName == "Microsoft-Windows-PowerShell/Operational")
            {
                tabPage1.BackColor = Color.Blue;
            }
            else if (LogName == "PowerShellCore/Operational")
            {
                tabPage1.BackColor = Color.Black;
            }
            else {
                tabPage1.BackColor = Color.White;
            }

            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(tabPage1.Location.X+2, tabPage1.Location.Y);
            dataGridView1.Name = "dataGridView";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new System.Drawing.Size(tabPage1.Size.Width -16, tabPage1.Size.Height - 42);
            dataGridView1.TabIndex = 0;
            dataGridView1.Tag = LogName;

            // Set up the DataGridView columns
            dataGridView1.Columns.Add("EventTime", "Event Time");
            dataGridView1.Columns.Add("EventID", "Event ID");
            dataGridView1.Columns.Add("EventLevel", "Level");
            dataGridView1.Columns.Add("EventDescription", "Description");
            dataGridView1.Columns.Add("LogType", "Log Type");

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Sort(dataGridView1.Columns[0],ListSortDirection.Descending);
            dataGridView1.CellContentClick += new DataGridViewCellEventHandler(this.dataGridView1_CellMouseClick);
            dataGridView1.DefaultCellStyle.BackColor = Color.Black;

            dataGridViews.Add(dataGridView1);


            tabPage1.Controls.Add(dataGridView1);
            this.logTabControl.Controls.Add(tabPage1);

            // Load the Event Log entries
            LoadEventLogs(LogName);
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellEventArgs e)
        {
            detailedMessage.Text = ((System.Windows.Forms.DataGridView)sender).Rows[e.RowIndex].Cells[3].Value.ToString();
        }
        public void LoadEventLogs(String log)
        {
            EventLogSession session = new EventLogSession();

            EventLogQuery query = new EventLogQuery(log, PathType.LogName, "*[System/EventID>=1]")
            {
                TolerateQueryErrors = true,
                Session = session
            };

            EventLogWatcher logWatcher = new EventLogWatcher(query);

            logWatcher.EventRecordWritten += new EventHandler<EventRecordWrittenEventArgs>(LogWatcher_EventRecordWritten);

            try
            {
                logWatcher.Enabled = true;
            }
            catch (EventLogException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        private void LogWatcher_EventRecordWritten(object sender, EventRecordWrittenEventArgs e)
        {
            var time = e.EventRecord.TimeCreated;
            var id = e.EventRecord.Id;
            var level = e.EventRecord.Level;
            var desc = e.EventRecord.FormatDescription();
            string logType = "";

            Console.ForegroundColor = ConsoleColor.White;
            var scriptBlockLoggingEventId = 4104; var scriptBlockColor = Color.Yellow;
            var moduleLoggingEventId = 4103; var moduleColor = Color.Cyan;
            var scriptBlockExecutionStartEventId = 4105; var scriptBlockExecutionStartColor = Color.Green;
            var scriptBlockExecutionStopEventId = 4106; var scriptBlockExecutionStopColor = Color.Red;
            var theColor = Color.White;


            // From PowerShell Cookbook: PowerShell automatically logs all script blocks (using a logging level of Warning) that contain keywords and techniques commonly used in malicious contexts.
            if (id == scriptBlockLoggingEventId)
            {
                if (level == 5) // 1-Critical 2-Error 3-Warning 4-Info 5-verbose 0-LogAlways
                {
                    theColor = scriptBlockColor;
                    logType = "Script Block Log";
                }
                else if (level == 3)
                {
                    theColor = Color.Orange;
                    logType = "Automatic Script Block Log";
                }
            }
            else if (id == moduleLoggingEventId)
            {
                theColor = moduleColor;
                logType = "Module Log";
            }
            else if (id == scriptBlockExecutionStartEventId)
            {
                theColor = scriptBlockExecutionStartColor;
                logType = "Script Execution Start Log";
            }
            else if (id == scriptBlockExecutionStopEventId)
            {
                theColor = scriptBlockExecutionStopColor;
                logType = "Script Execution Stop Log";
            }


            foreach (DataGridView dataGridView in dataGridViews)
            {
                if (dataGridView.Tag.ToString() == e.EventRecord.LogName)
                {
                    int index = dataGridView.RowCount - 1;
                    if (dataGridView.SortOrder == SortOrder.Descending) { index = 0; }
                    dataGridView.Invoke(new Action(() =>
                     {
                         dataGridView.Rows.Insert(index, new Object[] { time, id, level, desc, logType });
                         dataGridView.Rows[index].DefaultCellStyle.ForeColor = theColor;
                     }
                    ));
                }
            }
 
        }


    }
}
