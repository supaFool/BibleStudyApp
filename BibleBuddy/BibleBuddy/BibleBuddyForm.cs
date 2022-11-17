using BibleBuddy.Core;
using System;
using System.Windows.Forms;

namespace BibleBuddy
{
    public partial class BibleBuddyForm : Form
    {
        private Logic _logic;

        public BibleBuddyForm()
        {
            InitializeComponent();
            _logic = new Logic();
        }

        private void BibleBuddyForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
