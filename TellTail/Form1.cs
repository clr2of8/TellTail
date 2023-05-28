﻿using System;
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
        private List<TabPage> tabPages = new List<TabPage>();
        private List<DataGridView> dataGridViews = new List<DataGridView>();

        public TellTailForm()
        {
            InitializeComponent();

            AddTab("Microsoft-Windows-PowerShell/Operational");
            AddTab("Windows PowerShell");
            AddTab("PowerShellCore/Operational");

        }

        private void AddTab(String LogName)
        {
            TabPage tabPage1 = new System.Windows.Forms.TabPage();
            DataGridView dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(dataGridView1)).BeginInit();

            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location =logTabControl.Location;
            tabPage1.Name = "tabPage4";
            tabPage1.Padding = new System.Windows.Forms.Padding(3);
            tabPage1.Size = logTabControl.Size;
            tabPage1.TabIndex = 0;
            tabPage1.Text = "* " + LogName;
            tabPage1.UseVisualStyleBackColor = true;
            tabPages.Add(tabPage1);

            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = tabPage1.Location;
            dataGridView1.Name = "dataGridView";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = tabPage1.Size;
            dataGridView1.TabIndex = 0;
            dataGridView1.Tag = LogName;

            // Set up the DataGridView columns
            dataGridView1.Columns.Add("EventTime", "Event Time");
            dataGridView1.Columns.Add("EventID", "Event ID");
            dataGridView1.Columns.Add("EventLevel", "Level");
            dataGridView1.Columns.Add("EventDescription", "Description");

            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.CellContentClick += new DataGridViewCellEventHandler(this.dataGridView1_CellMouseClick);


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
