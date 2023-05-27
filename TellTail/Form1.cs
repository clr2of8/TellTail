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
        private TellTailForm TTform;
        public TellTailForm()
        {
            InitializeComponent();
            // Set up the DataGridView columns
            this.dataGridView.Columns.Add("EventTime", "Event Time");
            this.dataGridView.Columns.Add("EventID", "Event ID");
            this.dataGridView.Columns.Add("EventLevel", "Level");
            this.dataGridView.Columns.Add("EventDescription", "Description");

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
            dataGridView.Invoke(new Action(() => dataGridView.Rows.Add(time, id, level, desc)));
 
        }


    }
}
