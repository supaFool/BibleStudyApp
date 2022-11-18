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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.Panel_View = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.AppWrapper.BottomToolStripPanel.SuspendLayout();
            this.AppWrapper.ContentPanel.SuspendLayout();
            this.AppWrapper.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.Panel_View.SuspendLayout();
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
            this.AppWrapper.ContentPanel.Size = new System.Drawing.Size(800, 397);
            this.AppWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppWrapper.Location = new System.Drawing.Point(0, 0);
            this.AppWrapper.Name = "AppWrapper";
            this.AppWrapper.Size = new System.Drawing.Size(800, 450);
            this.AppWrapper.TabIndex = 1;
            this.AppWrapper.Text = "Container";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 28);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 20);
            this.toolStripProgressBar1.Click += new System.EventHandler(this.toolStripProgressBar1_Click);
            // 
            // Panel_View
            // 
            this.Panel_View.Controls.Add(this.button1);
            this.Panel_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_View.Location = new System.Drawing.Point(0, 0);
            this.Panel_View.Name = "Panel_View";
            this.Panel_View.Size = new System.Drawing.Size(800, 397);
            this.Panel_View.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(800, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Test Ser";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.Panel_View.ResumeLayout(false);
            this.Panel_View.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripContainer AppWrapper;
        private System.Windows.Forms.Panel Panel_View;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Button button1;
    }
}

