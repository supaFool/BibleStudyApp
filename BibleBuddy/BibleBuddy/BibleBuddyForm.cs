using BibleBuddy.Core;
using BibleBuddy.Core.BibleVersions;
using System;
using System.Windows.Forms;

namespace BibleBuddy
{
    public partial class BibleBuddyForm : Form
    {
        private Logic _logic;

        public BibleBuddyForm()
        {
            //Forms Stuff
            InitializeComponent();

            //BibleBuddy Starts here
            _logic = new Logic(this);
        }

        private void BibleBuddyForm_Load(object sender, EventArgs e)
        {

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {
        }
    }
}
