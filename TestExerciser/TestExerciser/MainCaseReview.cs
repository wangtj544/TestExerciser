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
using System.Data.SqlClient;
using TestExerciser.Tools.Control;



namespace TestExerciser
{
    public partial class MainCaseReview : Skin_Mac
    {
        string [] caseToReview = null;
        ManageDB myManageDB = new Logic.ManageDB();       
        string strNotice = null;
       

        public MainCaseReview()
        {
            InitializeComponent();
        }

        private void MainCaseReview_Load(object sender, EventArgs e)
        {
            this.cbIfAuto.Enabled = false;
            this.cbIfCover.Enabled = false;
            this.cbIfMatch.Enabled = false;
            this.cbIfOrder.Enabled = false;
            this.cbSelectExcel.Enabled = false;
            this.btnStart.Enabled = false;
            this.btnLaunch.Enabled = false;
            this.btnCommit.Enabled = false;
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            DialogResult myDialogResult = this.selectFileDialog.ShowDialog();
            if (myDialogResult == DialogResult.OK)
            {
                string strSub = null;
                caseToReview = this.selectFileDialog.FileNames;
                foreach (string str in caseToReview)
                {
                    strSub = strSub + str + ";";
                    this.tbFilePath.Text = strSub;
                }
                this.sbStep1.BaseColor = Color.Lime;
                this.sbStep1.BorderColor = Color.Lime;
                this.cbIfAuto.Enabled = true;
            }
        }

        private void MainCaseReview_FormClosing(object sender, FormClosingEventArgs e)
        {
            myManageDB.clearnFullNameList();
        }

        private void cbIfAuto_Click(object sender, EventArgs e)
        {
            List<string> fullNameList = ManageDB.autoFullNameList;
            myManageDB.selectAutoFullName();
            this.cbIfAuto.DataSource = fullNameList;
            this.cbIfAuto.Text = strNotice;
        }

        private void cbIfCover_Click(object sender, EventArgs e)
        {
            List<string> fullNameList = ManageDB.coverFullNameList;
            myManageDB.selectCoverFullName();
            this.cbIfCover.DataSource = fullNameList;
            this.cbIfCover.Text = strNotice;
        }

        private void cbIfAuto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if ((cbIfAuto.Text != null)||(cbIfAuto.Text!=""))
            {
                this.cbIfCover.Enabled = true;
            }
        }

        private void myLabel_DoubleClick(object sender, EventArgs e)
        {
           DialogResult myLabel_DoubleClick = MessageBox.Show("确定要删除评审人： " + cbIfCover.SelectedItem.ToString() + " 吗？","消息提示：", MessageBoxButtons.OKCancel,MessageBoxIcon.Asterisk);
           if (myLabel_DoubleClick == DialogResult.OK)
           {
               var myLabel = sender as Label;
               tlpCoverFullNameList.Controls.Remove((myLabel));
           }
        }

        private void cbIfCover_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Label myLabel = new Label();
            if ((string)cbIfCover.SelectedItem != strNotice)
            {
                myLabel.DoubleClick += new System.EventHandler(this.myLabel_DoubleClick);
                myLabel.Text = cbIfCover.SelectedItem.ToString()+ "；";
                tlpCoverFullNameList.Controls.Add(myLabel);
                if ((cbIfAuto.Text != null) || (cbIfAuto.Text != ""))
                {
                    this.sbStep2.BaseColor = Color.Lime;
                    this.sbStep2.BorderColor = Color.Lime;
                    this.btnLaunch.Enabled = true;
                }                                 
            }
        }
    }
}
