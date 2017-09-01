using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;
using TestExerciser.Tools.BugManagement;

namespace TestExerciser
{
    public partial class MainBugManager : Skin_Mac
    {
        public MainBugManager()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ToolBugCommit myToolBugCommit = new ToolBugCommit();
            myToolBugCommit.Show();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            ToolBugQuery myToolBugQuery = new ToolBugQuery();
            myToolBugQuery.Show();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            ToolBugDefectInfo myToolBugDefectInfo = new ToolBugDefectInfo();
            myToolBugDefectInfo.Show();
        }
    }
}
