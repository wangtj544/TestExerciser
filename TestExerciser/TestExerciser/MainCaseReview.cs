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
using System.IO;



namespace TestExerciser
{
    public partial class MainCaseReview : Skin_Mac
    {
        string [] caseToReview = null;
        
        ManageDB myManageDB = new Logic.ManageDB();       
        string strNotice = null;

        string[] caseNameToReview = null;
        List<string> caseNameToReviewList = new List<string>();

        string[] autoReviewer = null;
        List<string> autoReviewerList = new List<string>();

        string[] ifCoverReviewer = null;
        List<string> ifCoverReviewList = new List<string>();
       

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
                    addExcelToTlpSelectTestCase(strSub);
                }
                this.sbStep1.BaseColor = Color.Lime;
                this.sbStep1.BorderColor = Color.Lime;
                this.cbIfAuto.Enabled = true;
                
            }
        }

        private void MainCaseReview_FormClosing(object sender, FormClosingEventArgs e)
        {
            myManageDB.clearFullNameList();
        }

        private void cbIfAuto_Click(object sender, EventArgs e)
        {
            List<ListItem> autoListItem = ManageDB.autoList;
            myManageDB.selectAuto();
            this.cbIfAuto.DataSource = autoListItem;
            this.cbIfAuto.Text = strNotice;
        }

        private void cbIfCover_Click(object sender, EventArgs e)
        {
            List<ListItem> coverListItem = ManageDB.coverList;
            myManageDB.selectCover();
            this.cbIfCover.DataSource = coverListItem;
            this.cbIfCover.Text = strNotice;
        }

        private void cbIfAuto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if ((cbIfAuto.Text != null)||(cbIfAuto.Text!=""))
            {
                this.cbIfCover.Enabled = true;
                ifCoverReviewList.Add(cbIfAuto.Text);
                ifCoverReviewer = ifCoverReviewList.ToArray();
            }
        }

        private void myLabelIfCover_DoubleClick(object sender, EventArgs e)
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
                myLabel.DoubleClick += new System.EventHandler(this.myLabelIfCover_DoubleClick);
                myLabel.Text = cbIfCover.SelectedItem.ToString()+ "；";
                tlpCoverFullNameList.Controls.Add(myLabel);
                autoReviewerList.Add(myLabel.Text);
                autoReviewer = autoReviewerList.ToArray();
                if ((cbIfAuto.Text != null) || (cbIfAuto.Text != ""))
                {
                    this.sbStep2.BaseColor = Color.Lime;
                    this.sbStep2.BorderColor = Color.Lime;
                    this.btnLaunch.Enabled = true;
                }                                 
            }
        }

        private void myTextSelectTestCase_DoubleClick(object sender, EventArgs e)
        {
            DialogResult myText_DoubleClick = MessageBox.Show("确定要选择用例吗？", "消息提示：", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (myText_DoubleClick == DialogResult.OK)
            {
                var myText = sender as TextBox;
                tlpSelectTestCase.Controls.Remove((myText));
            }
        }

        private void addExcelToTlpSelectTestCase(string labelText)
        {
            TextBox myText = new TextBox();
            myText.Dock = DockStyle.Fill;
            myText.ReadOnly = true;
            myText.DoubleClick += new System.EventHandler(this.myTextSelectTestCase_DoubleClick);           
            myText.Text = labelText;
            tlpSelectTestCase.Controls.Add(myText);
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            string FilesPath = this.tbFilePath.Text;
            string[] excelFilesPath = FilesPath.Split(';');
            foreach (string str in excelFilesPath)
            {
                if (str != "")
                {
                    try
                    {
                        File.Copy(str, Properties.Settings.Default.serverPath + Path.GetFileName(str), true);
                        caseNameToReviewList.Add(Path.GetFileName(str) + "\r\n");
                        caseNameToReview = caseNameToReviewList.ToArray();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }                
            }
            if (autoReviewer != null)
            {
                sendMail("测试用例自动化评审流程", autoReviewer, caseNameToReview.ToString());
            }
            if (ifCoverReviewer != null)
            {
                sendMail("测试用例覆盖评审流程", ifCoverReviewer, caseNameToReview.ToString());
            }            
        }

        private void sendMail(string mailSubject, string [] mailTo,string mailBody)
        {
            SendMail mail = new SendMail();
            mail.mailFrom = "TestExerciser@163.com";
            mail.mailPwd = "admin123";
            mail.mailSubject = mailSubject;
            mail.mailBody = "有以下用例需要您审批：\r\n\r\n\r\n"+ mailBody;
            mail.isbodyHtml = false;
            mail.host = "smtp.163.com";
            mail.mailToArray = mailTo;
            mail.mailCcArray = new string[] { };
            if (mail.Send())
            {
                this.sbStep3.BaseColor = Color.Lime;
                this.sbStep3.BorderColor = Color.Lime;
                this.btnLaunch.Enabled = true;
            }
            else
            {
              
            }
        }
    }
}
