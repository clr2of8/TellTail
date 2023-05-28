using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TellTail
{
    public partial class TellTailForm : Form
    {
        private List<TabPage> tabPages = new List<TabPage>();
        private List<DataGridView> dataGridViews = new List<DataGridView>();

        public TellTailForm()
        {
            InitializeComponent();
            // Set up the DataGridView columns
            this.dataGridView.Columns.Add("EventTime", "Event Time");
            this.dataGridView.Columns.Add("EventID", "Event ID");
            this.dataGridView.Columns.Add("EventLevel", "Level");
            this.dataGridView.Columns.Add("EventDescription", "Description");

            this.dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridView.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;



            AddTab("Microsoft-Windows-PowerShell/Operational");

        }

        private void AddTab(String LogName)
        {
            TabPage tabPagePSOperational = new System.Windows.Forms.TabPage();
            DataGridView dataGridViewPSOperational = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(dataGridViewPSOperational)).BeginInit();

            tabPagePSOperational.Controls.Add(dataGridViewPSOperational);
            tabPagePSOperational.Location = new System.Drawing.Point(4, 34);
            tabPagePSOperational.Name = "tabPage4";
            tabPagePSOperational.Padding = new System.Windows.Forms.Padding(3);
            tabPagePSOperational.Size = new System.Drawing.Size(1718, 791);
            tabPagePSOperational.TabIndex = 0;
            tabPagePSOperational.Text = LogName;
            tabPagePSOperational.UseVisualStyleBackColor = true;
            tabPages.Add(tabPagePSOperational);

            dataGridViewPSOperational.AllowUserToOrderColumns = true;
            dataGridViewPSOperational.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPSOperational.Location = new System.Drawing.Point(3, 3);
            dataGridViewPSOperational.Name = "dataGridView";
            dataGridViewPSOperational.ReadOnly = true;
            dataGridViewPSOperational.RowHeadersWidth = 51;
            dataGridViewPSOperational.RowTemplate.Height = 24;
            dataGridViewPSOperational.Size = new System.Drawing.Size(1709, 791);
            dataGridViewPSOperational.TabIndex = 0;
            dataGridViewPSOperational.Tag = LogName;

            // Set up the DataGridView columns
            dataGridViewPSOperational.Columns.Add("EventTime", "Event Time");
            dataGridViewPSOperational.Columns.Add("EventID", "Event ID");
            dataGridViewPSOperational.Columns.Add("EventLevel", "Level");
            dataGridViewPSOperational.Columns.Add("EventDescription", "Description");

            dataGridViewPSOperational.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewPSOperational.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewPSOperational.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewPSOperational.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewPSOperational.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViews.Add(dataGridViewPSOperational);


            tabPagePSOperational.Controls.Add(dataGridViewPSOperational);
            this.logTabControl.Controls.Add(tabPagePSOperational);

            // Load the Event Log entries
            LoadEventLogs("Microsoft-Windows-PowerShell/Operational");
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
            foreach (DataGridView dataGridView in dataGridViews)
            {
                if (dataGridView.Tag.ToString() == e.EventRecord.LogName)
                {
                    dataGridView.Invoke(new Action(() => dataGridView.Rows.Add(time, id, level, desc)));
                }
            }
 
        }


    }
}
