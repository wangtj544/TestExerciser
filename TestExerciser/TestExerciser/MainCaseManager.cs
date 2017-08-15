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
using TestExerciser.Tools.CaseManagement;

namespace TestExerciser
{
    public partial class MainCaseManager : Skin_Mac
    {
        public MainCaseManager()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ToolCaseCommit myToolCaseCommit = new ToolCaseCommit();
            myToolCaseCommit.Show();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            ToolCaseQuery myToolCaseQuery = new ToolCaseQuery();
            myToolCaseQuery.Show();
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            ToolSelectModeForCaseReview myToolSelectModeForCaseReview = new ToolSelectModeForCaseReview();
            myToolSelectModeForCaseReview.Show();
        }
    }
}
