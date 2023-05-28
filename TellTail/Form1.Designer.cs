using System.Windows.Forms;

namespace TellTail
{
    partial class TellTailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LogTabsPanel = new System.Windows.Forms.Panel();
            this.logTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.LogTabsPanel.SuspendLayout();
            this.logTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LogTabsPanel
            // 
            this.LogTabsPanel.Controls.Add(this.logTabControl);
            this.LogTabsPanel.Location = new System.Drawing.Point(81, 73);
            this.LogTabsPanel.Name = "LogTabsPanel";
            this.LogTabsPanel.Size = new System.Drawing.Size(2080, 1050);
            this.LogTabsPanel.TabIndex = 0;
            // 
            // logTabControl
            // 
            this.logTabControl.Controls.Add(this.tabPage1);
            this.logTabControl.Controls.Add(this.tabPage2);
            this.logTabControl.Controls.Add(this.tabPage3);
            this.logTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logTabControl.Location = new System.Drawing.Point(17, 24);
            this.logTabControl.Name = "logTabControl";
            this.logTabControl.SelectedIndex = 0;
            this.logTabControl.Size = new System.Drawing.Size(1726, 829);
            this.logTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1718, 791);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PowerShell Operational Log";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1709, 791);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.Tag = "xxx";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1718, 791);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PowerShell Default Log";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1718, 791);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "PowerShell Core";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // TellTailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2189, 1165);
            this.Controls.Add(this.LogTabsPanel);
            this.Name = "TellTailForm";
            this.Text = "TellTail";
            this.LogTabsPanel.ResumeLayout(false);
            this.logTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LogTabsPanel;
        private System.Windows.Forms.TabControl logTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView;
        private TabPage tabPage3;
    }
}

