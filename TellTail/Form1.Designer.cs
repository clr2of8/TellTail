using System.Reflection;
using System;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TellTailForm));
            this.LogTabsPanel = new System.Windows.Forms.Panel();
            this.detailedMessage = new System.Windows.Forms.RichTextBox();
            this.logTabControl = new System.Windows.Forms.TabControl();
            this.LogTabsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogTabsPanel
            // 
            this.LogTabsPanel.AutoSize = true;
            this.LogTabsPanel.Controls.Add(this.detailedMessage);
            this.LogTabsPanel.Controls.Add(this.logTabControl);
            this.LogTabsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogTabsPanel.Location = new System.Drawing.Point(0, 0);
            this.LogTabsPanel.MinimumSize = new System.Drawing.Size(1902, 1031);
            this.LogTabsPanel.Name = "LogTabsPanel";
            this.LogTabsPanel.Size = new System.Drawing.Size(1902, 1033);
            this.LogTabsPanel.TabIndex = 0;
            // 
            // detailedMessage
            // 
            this.detailedMessage.Dock = System.Windows.Forms.DockStyle.Right;
            this.detailedMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailedMessage.Location = new System.Drawing.Point(1317, 0);
            this.detailedMessage.Name = "detailedMessage";
            this.detailedMessage.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.detailedMessage.Size = new System.Drawing.Size(585, 1033);
            this.detailedMessage.TabIndex = 1;
            this.detailedMessage.Text = "";
            this.detailedMessage.WordWrap = false;
            // 
            // logTabControl
            // 
            this.logTabControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.logTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logTabControl.Location = new System.Drawing.Point(0, 0);
            this.logTabControl.MinimumSize = new System.Drawing.Size(1305, 1022);
            this.logTabControl.Name = "logTabControl";
            this.logTabControl.SelectedIndex = 0;
            this.logTabControl.Size = new System.Drawing.Size(1305, 1033);
            this.logTabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.logTabControl.TabIndex = 0;
            // 
            // TellTailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.LogTabsPanel);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "TellTailForm";
            this.Text = "TellTail";
            this.LogTabsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LogTabsPanel;
        private System.Windows.Forms.TabControl logTabControl;
        private RichTextBox detailedMessage;
    }
}

