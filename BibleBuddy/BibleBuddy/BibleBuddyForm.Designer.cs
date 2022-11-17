namespace BibleBuddy
{
    partial class BibleBuddyForm
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
            this.AppWrapper = new System.Windows.Forms.ToolStripContainer();
            this.Panel_View = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.AppWrapper.BottomToolStripPanel.SuspendLayout();
            this.AppWrapper.ContentPanel.SuspendLayout();
            this.AppWrapper.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AppWrapper
            // 
            // 
            // AppWrapper.BottomToolStripPanel
            // 
            this.AppWrapper.BottomToolStripPanel.Controls.Add(this.statusStrip1);
            // 
            // AppWrapper.ContentPanel
            // 
            this.AppWrapper.ContentPanel.Controls.Add(this.Panel_View);
            this.AppWrapper.ContentPanel.Size = new System.Drawing.Size(800, 393);
            this.AppWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppWrapper.Location = new System.Drawing.Point(0, 0);
            this.AppWrapper.Name = "AppWrapper";
            this.AppWrapper.Size = new System.Drawing.Size(800, 450);
            this.AppWrapper.TabIndex = 1;
            this.AppWrapper.Text = "Container";
            // 
            // Panel_View
            // 
            this.Panel_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_View.Location = new System.Drawing.Point(0, 0);
            this.Panel_View.Name = "Panel_View";
            this.Panel_View.Size = new System.Drawing.Size(800, 393);
            this.Panel_View.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 32);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(179, 25);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // BibleBuddyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AppWrapper);
            this.Name = "BibleBuddyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bible Buddy";
            this.Load += new System.EventHandler(this.BibleBuddyForm_Load);
            this.AppWrapper.BottomToolStripPanel.ResumeLayout(false);
            this.AppWrapper.BottomToolStripPanel.PerformLayout();
            this.AppWrapper.ContentPanel.ResumeLayout(false);
            this.AppWrapper.ResumeLayout(false);
            this.AppWrapper.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripContainer AppWrapper;
        private System.Windows.Forms.Panel Panel_View;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

