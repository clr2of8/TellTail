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
            this.logTabControl = new System.Windows.Forms.TabControl();
            this.detailedMessage = new System.Windows.Forms.RichTextBox();
            this.LogTabsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogTabsPanel
            // 
            this.LogTabsPanel.Controls.Add(this.detailedMessage);
            this.LogTabsPanel.Controls.Add(this.logTabControl);
            this.LogTabsPanel.Location = new System.Drawing.Point(3, 5);
            this.LogTabsPanel.Name = "LogTabsPanel";
            this.LogTabsPanel.Size = new System.Drawing.Size(2185, 1159);
            this.LogTabsPanel.TabIndex = 0;
            // 
            // logTabControl
            // 
            this.logTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logTabControl.Location = new System.Drawing.Point(3, 5);
            this.logTabControl.Name = "logTabControl";
            this.logTabControl.SelectedIndex = 0;
            this.logTabControl.Size = new System.Drawing.Size(1305, 1151);
            this.logTabControl.TabIndex = 0;
            // 
            // detailedMessage
            // 
            this.detailedMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailedMessage.Location = new System.Drawing.Point(1314, 7);
            this.detailedMessage.Name = "detailedMessage";
            this.detailedMessage.Size = new System.Drawing.Size(868, 1150);
            this.detailedMessage.TabIndex = 1;
            this.detailedMessage.Text = "";
            this.detailedMessage.WordWrap = false;
            // 
            // TellTailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2194, 1173);
            this.Controls.Add(this.LogTabsPanel);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TellTailForm";
            this.Text = "TellTail";
            this.LogTabsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LogTabsPanel;
        private System.Windows.Forms.TabControl logTabControl;
        private RichTextBox detailedMessage;
    }
}

