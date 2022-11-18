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
            this.Menu = new System.Windows.Forms.TabControl();
            this.KJV_Tab = new System.Windows.Forms.TabPage();
            this.Profile_Tab = new System.Windows.Forms.TabPage();
            this.OnlineSearch_Tab = new System.Windows.Forms.TabPage();
            this.WebBrowser = new System.Windows.Forms.WebBrowser();
            this.BibleLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.Kjv_Label_BookTitle = new System.Windows.Forms.Label();
            this.Kjv_Label_Chapter = new System.Windows.Forms.Label();
            this.Kjv_Label_VerseText = new System.Windows.Forms.Label();
            this.Menu.SuspendLayout();
            this.KJV_Tab.SuspendLayout();
            this.OnlineSearch_Tab.SuspendLayout();
            this.BibleLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.KJV_Tab);
            this.Menu.Controls.Add(this.Profile_Tab);
            this.Menu.Controls.Add(this.OnlineSearch_Tab);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.SelectedIndex = 0;
            this.Menu.Size = new System.Drawing.Size(800, 450);
            this.Menu.TabIndex = 0;
            // 
            // KJV_Tab
            // 
            this.KJV_Tab.BackColor = System.Drawing.Color.Transparent;
            this.KJV_Tab.Controls.Add(this.BibleLayout);
            this.KJV_Tab.Location = new System.Drawing.Point(4, 29);
            this.KJV_Tab.Name = "KJV_Tab";
            this.KJV_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.KJV_Tab.Size = new System.Drawing.Size(792, 417);
            this.KJV_Tab.TabIndex = 0;
            this.KJV_Tab.Text = "KJV";
            // 
            // Profile_Tab
            // 
            this.Profile_Tab.Location = new System.Drawing.Point(4, 29);
            this.Profile_Tab.Name = "Profile_Tab";
            this.Profile_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.Profile_Tab.Size = new System.Drawing.Size(792, 417);
            this.Profile_Tab.TabIndex = 1;
            this.Profile_Tab.Text = "Profile";
            // 
            // OnlineSearch_Tab
            // 
            this.OnlineSearch_Tab.AutoScroll = true;
            this.OnlineSearch_Tab.Controls.Add(this.WebBrowser);
            this.OnlineSearch_Tab.Location = new System.Drawing.Point(4, 29);
            this.OnlineSearch_Tab.Name = "OnlineSearch_Tab";
            this.OnlineSearch_Tab.Padding = new System.Windows.Forms.Padding(3);
            this.OnlineSearch_Tab.Size = new System.Drawing.Size(792, 417);
            this.OnlineSearch_Tab.TabIndex = 2;
            this.OnlineSearch_Tab.Text = "Online Search";
            this.OnlineSearch_Tab.UseVisualStyleBackColor = true;
            // 
            // WebBrowser
            // 
            this.WebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebBrowser.Location = new System.Drawing.Point(3, 3);
            this.WebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrowser.Name = "WebBrowser";
            this.WebBrowser.ScriptErrorsSuppressed = true;
            this.WebBrowser.Size = new System.Drawing.Size(786, 411);
            this.WebBrowser.TabIndex = 0;
            this.WebBrowser.Url = new System.Uri("https://www.kingjamesbibleonline.org/", System.UriKind.Absolute);
            // 
            // BibleLayout
            // 
            this.BibleLayout.AutoScroll = true;
            this.BibleLayout.AutoSize = true;
            this.BibleLayout.Controls.Add(this.Kjv_Label_BookTitle);
            this.BibleLayout.Controls.Add(this.Kjv_Label_Chapter);
            this.BibleLayout.Controls.Add(this.Kjv_Label_VerseText);
            this.BibleLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BibleLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.BibleLayout.Location = new System.Drawing.Point(3, 3);
            this.BibleLayout.Name = "BibleLayout";
            this.BibleLayout.Size = new System.Drawing.Size(786, 411);
            this.BibleLayout.TabIndex = 0;
            // 
            // Kjv_Label_BookTitle
            // 
            this.Kjv_Label_BookTitle.AutoSize = true;
            this.Kjv_Label_BookTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.Kjv_Label_BookTitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kjv_Label_BookTitle.Location = new System.Drawing.Point(3, 0);
            this.Kjv_Label_BookTitle.Name = "Kjv_Label_BookTitle";
            this.Kjv_Label_BookTitle.Size = new System.Drawing.Size(119, 26);
            this.Kjv_Label_BookTitle.TabIndex = 0;
            this.Kjv_Label_BookTitle.Text = "Book Title";
            // 
            // Kjv_Label_Chapter
            // 
            this.Kjv_Label_Chapter.AutoSize = true;
            this.Kjv_Label_Chapter.Dock = System.Windows.Forms.DockStyle.Top;
            this.Kjv_Label_Chapter.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kjv_Label_Chapter.Location = new System.Drawing.Point(3, 26);
            this.Kjv_Label_Chapter.Name = "Kjv_Label_Chapter";
            this.Kjv_Label_Chapter.Size = new System.Drawing.Size(119, 20);
            this.Kjv_Label_Chapter.TabIndex = 1;
            this.Kjv_Label_Chapter.Text = "Chapter";
            // 
            // Kjv_Label_VerseText
            // 
            this.Kjv_Label_VerseText.AutoSize = true;
            this.Kjv_Label_VerseText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Kjv_Label_VerseText.Location = new System.Drawing.Point(3, 46);
            this.Kjv_Label_VerseText.Name = "Kjv_Label_VerseText";
            this.Kjv_Label_VerseText.Padding = new System.Windows.Forms.Padding(0, 35, 0, 0);
            this.Kjv_Label_VerseText.Size = new System.Drawing.Size(119, 55);
            this.Kjv_Label_VerseText.TabIndex = 2;
            this.Kjv_Label_VerseText.Text = "Verse Text";
            // 
            // BibleBuddyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Menu);
            this.HelpButton = true;
            this.Name = "BibleBuddyForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bible Buddy";
            this.Load += new System.EventHandler(this.BibleBuddyForm_Load);
            this.Menu.ResumeLayout(false);
            this.KJV_Tab.ResumeLayout(false);
            this.KJV_Tab.PerformLayout();
            this.OnlineSearch_Tab.ResumeLayout(false);
            this.BibleLayout.ResumeLayout(false);
            this.BibleLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl Menu;
        private System.Windows.Forms.TabPage KJV_Tab;
        private System.Windows.Forms.TabPage Profile_Tab;
        private System.Windows.Forms.TabPage OnlineSearch_Tab;
        protected internal System.Windows.Forms.WebBrowser WebBrowser;
        protected internal System.Windows.Forms.Label Kjv_Label_BookTitle;
        protected internal System.Windows.Forms.Label Kjv_Label_Chapter;
        protected internal System.Windows.Forms.Label Kjv_Label_VerseText;
        protected internal System.Windows.Forms.FlowLayoutPanel BibleLayout;
    }
}

