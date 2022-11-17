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
            this.AppWrapper.ContentPanel.SuspendLayout();
            this.AppWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // AppWrapper
            // 
            // 
            // AppWrapper.ViewWrapper
            // 
            this.AppWrapper.ContentPanel.Controls.Add(this.Panel_View);
            this.AppWrapper.ContentPanel.Size = new System.Drawing.Size(800, 450);
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
            this.Panel_View.Size = new System.Drawing.Size(800, 450);
            this.Panel_View.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AppWrapper);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bible Buddy";
            this.Load += new System.EventHandler(this.BibleBuddyForm_Load);
            this.AppWrapper.ContentPanel.ResumeLayout(false);
            this.AppWrapper.ResumeLayout(false);
            this.AppWrapper.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripContainer AppWrapper;
        private System.Windows.Forms.Panel Panel_View;
    }
}

