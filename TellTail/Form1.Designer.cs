namespace TellTail
{
    partial class TellTailForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TellTailForm));
            splitContainer1 = new SplitContainer();
            logTabControl = new TabControl();
            detailedMessage = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(logTabControl);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(detailedMessage);
            splitContainer1.Size = new Size(1782, 853);
            splitContainer1.SplitterDistance = 1268;
            splitContainer1.SplitterWidth = 6;
            splitContainer1.TabIndex = 0;
            // 
            // logTabControl
            // 
            logTabControl.Dock = DockStyle.Fill;
            logTabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            logTabControl.Location = new Point(0, 0);
            logTabControl.Name = "logTabControl";
            logTabControl.SelectedIndex = 0;
            logTabControl.Size = new Size(1268, 853);
            logTabControl.TabIndex = 0;
            logTabControl.DrawItem += logTabControl_DrawItem_1;
            // 
            // detailedMessage
            // 
            detailedMessage.Dock = DockStyle.Fill;
            detailedMessage.Location = new Point(0, 0);
            detailedMessage.Name = "detailedMessage";
            detailedMessage.Size = new Size(508, 853);
            detailedMessage.TabIndex = 0;
            detailedMessage.Text = "";
            // 
            // TellTailForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1782, 853);
            Controls.Add(splitContainer1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "TellTailForm";
            Text = "TellTail";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TabControl logTabControl;
        private RichTextBox detailedMessage;
    }
}