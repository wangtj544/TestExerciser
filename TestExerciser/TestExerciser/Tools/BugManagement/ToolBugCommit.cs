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

using TestExerciser.Logic;
using MySql.Data.MySqlClient;

namespace TestExerciser.Tools.BugManagement
{
    public partial class ToolBugCommit : Skin_Mac
    {
        DateTime myDateTime = DateTime.Now;
        

        public ToolBugCommit()
        {
            InitializeComponent();
            showBugID();
            commitForms();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (this.txtTitle.Text != "" && this.cbOccurrence.Text != "" && this.cbGravity.Text != "" && this.txtReviewers.Text != "")
            {

            }
            else
            {
                MessageBox.Show("请将必填项填写完整！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsbSaveAndNew_Click(object sender, EventArgs e)
        {

        }

        private void tsbCommit_Click(object sender, EventArgs e)
        {

        }

        private void tsbCommitAndNew_Click(object sender, EventArgs e)
        {

        }

        private void tsbQuite_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
        }

        private string showBugID()
        {
            string myBugId = "BUG" + myDateTime.Year + myDateTime.Month + myDateTime.Day + myDateTime.TimeOfDay.Hours+myDateTime.TimeOfDay.Minutes+myDateTime.TimeOfDay.Seconds;
            return myBugId;
        }

        public void commitForms()
        {
            string sql = @"INSERT INTO 缺陷管理 ('bugID','bugTitle','bugAttribution','bugCategory','bugHowFound','bugOccurrence','bugGravity','bugPriority','bugFoundVersion','bugProductVersion','bugExceptDate','bugAuthor','bugFillDate','bugReproSteps','bugExpectValue','bugRealValue','bugSamples','bugAttachment','bugAuditor','bugAuditTeam')VALUES("+ this.showBugID() +this.txtTitle.Text +this.txtAttribution.Text +this.cbCategory.Text +this.cbHowFound.Text+this.cbOccurrence.Text+this.cbGravity.Text + this.cbPriority.Text+this.cbFoundVersion.Text+ this.cbProductVersion.Text+this.dtpExceptDate.text+this.txtAuthor.Text+this.dtpFillDate.text +")";
            List<MySqlParameter> Paramter = new List<MySqlParameter>();
            int a = MySqlDB.Ins.ExecuteNonquery(sql, Paramter.ToArray());
        }
        
    }
}
