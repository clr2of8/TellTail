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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.detailedMessage = new System.Windows.Forms.RichTextBox();
            this.logTabControl = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.logTabControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.detailedMessage);
            this.splitContainer1.Size = new System.Drawing.Size(1782, 853);
            this.splitContainer1.SplitterDistance = 1268;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // detailedMessage
            // 
            this.detailedMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailedMessage.Location = new System.Drawing.Point(0, 0);
            this.detailedMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.detailedMessage.Name = "detailedMessage";
            this.detailedMessage.Size = new System.Drawing.Size(508, 853);
            this.detailedMessage.TabIndex = 0;
            this.detailedMessage.Text = "";
            this.detailedMessage.WordWrap = false;
            // 
            // logTabControl
            // 
            this.logTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.logTabControl.Location = new System.Drawing.Point(0, 0);
            this.logTabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logTabControl.Name = "logTabControl";
            this.logTabControl.SelectedIndex = 0;
            this.logTabControl.Size = new System.Drawing.Size(1268, 853);
            this.logTabControl.TabIndex = 0;
            this.logTabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.logTabControl_DrawItem);
            // 
            // TellTailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1782, 853);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TellTailForm";
            this.Text = "TellTail";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private RichTextBox detailedMessage;
        private TabControl logTabControl;
    }
}

