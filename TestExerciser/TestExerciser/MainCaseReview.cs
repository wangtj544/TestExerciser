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
using System.Text.RegularExpressions;



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
        List<string> ifCoverReviewerList = new List<string>();

        string[] selectedItem = null;
        static List<string> selectedItemList = new List<string>();

        string mailBody = null;

        string currentExcelPath = null;
        string serverTestCaseReviewExcelPool = @"\\" + Properties.Settings.Default.serverPath + @"\DATA\TestCaseReviewExcelPool\";

       

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
            myManageDB.selectItems(cbIfAuto);
            myManageDB.selectItems(cbIfCover);
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
            myManageDB.clearList(cbIfAuto);
            myManageDB.clearList(cbIfCover);
        }

        private void cbIfAuto_Click(object sender, EventArgs e)
        {           
            this.cbIfAuto.Text = strNotice;
        }

        private void cbIfCover_Click(object sender, EventArgs e)
        {
            this.cbIfCover.Text = strNotice;
        }

        private void cbIfAuto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.cbIfCover.Enabled = true;
            //if ((cbIfAuto.Text != null)||(cbIfAuto.Text!=""))
            //{
            //    this.cbIfCover.Enabled = true;
            //    string mailAddressStr = null;
            //    try
            //    {
            //        mailAddressStr = Regex.Match(cbIfAuto.Text.ToString(), @"(?<=\()[\s\S]*@sit.com.cn(?=\))").Value;
            //    }
            //    catch (ArgumentException exception)
            //    {
            //        MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    autoReviewerList.Add(mailAddressStr);
            //    autoReviewer = autoReviewerList.ToArray();
            //}
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
            bool flag = false;
            if (cbIfCover.SelectedItem != null)
            {
                if (selectedItem != null)
                {
                  for (int i = 0; i < selectedItem.Length;i++ ) 
                    {
                        if (selectedItem[i] == cbIfCover.SelectedItem.ToString())
                        {
                            flag = true;
                            break;
                        }      
                    } 
                }

                if (!flag)
                {
                    addMyLabelControl();
                }
            }
        }

        private void addMyLabelControl()
        {
            Label myLabel = new Label();
            myLabel.DoubleClick += new System.EventHandler(this.myLabelIfCover_DoubleClick);
            myLabel.Text = cbIfCover.SelectedItem.ToString() + "；";
            tlpCoverFullNameList.Controls.Add(myLabel);
            string mailAddressStr = null;
            try
            {
                mailAddressStr = Regex.Match(cbIfCover.SelectedItem.ToString(), @"(?<=\()[\s\S]*@sit.com.cn(?=\))").Value;
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ifCoverReviewerList.Add(mailAddressStr);
            ifCoverReviewer = ifCoverReviewerList.ToArray();
            selectedItemList.Add(cbIfCover.SelectedItem.ToString());
            selectedItem = selectedItemList.ToArray();
            if ((cbIfAuto.Text != null) || (cbIfAuto.Text != ""))
            {
                this.sbStep2.BaseColor = Color.Lime;
                this.sbStep2.BorderColor = Color.Lime;
                this.btnLaunch.Enabled = true;
            }
        }


        private void myTextSelectTestCase_DoubleClick(object sender, EventArgs e)
        {
            DialogResult myText_DoubleClick = MessageBox.Show("确定要选择用例吗？", "消息提示：", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (myText_DoubleClick == DialogResult.OK)
            {
                var myText = sender as TextBox;
                //tlpSelectTestCase.Controls.Remove((myText));
                myText.BackColor = Color.LightGoldenrodYellow;
                cbSelectExcel.Enabled = true;
                if (!cbSelectExcel.Items.Contains(myText.Text))
                {
                    cbSelectExcel.Items.Add(myText.Text);
                    cbSelectExcel.Text = myText.Text;
                    currentExcelPath = serverTestCaseReviewExcelPool + myText.Text;
                }               
                this.sbStep4.BaseColor = Color.Lime;
                this.sbStep4.BorderColor = Color.Lime;
                btnStart.Enabled = true;
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
                        File.Copy(str, serverTestCaseReviewExcelPool + Path.GetFileName(str), true);
                        caseNameToReviewList.Add(Path.GetFileName(str) + "\r\n");
                        caseNameToReview = caseNameToReviewList.ToArray();
                        mailBody = Path.GetFileName(str) + "\r\n" + mailBody;
                        addExcelToTlpSelectTestCase(Path.GetFileName(str));
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }                
            }
            if ((cbIfAuto.Text != null) || (cbIfAuto.Text != ""))
            {
                this.cbIfCover.Enabled = true;
                string mailAddressStr = null;
                try
                {
                    mailAddressStr = Regex.Match(cbIfAuto.Text.ToString(), @"(?<=\()[\s\S]*@sit.com.cn(?=\))").Value;
                }
                catch (ArgumentException exception)
                {
                    MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                autoReviewerList.Add(mailAddressStr);
                autoReviewer = autoReviewerList.ToArray();
            }

            if (autoReviewer != null)
            {
                sendMail("测试用例自动化评审流程", autoReviewer);
            }
            if (ifCoverReviewer != null)
            {
                sendMail("测试用例测试点覆盖评审流程", ifCoverReviewer);
            }

            
        }

        private void sendMail(string mailSubject, string [] mailTo)
        {
            SendMail mail = new SendMail();
            mail.mailFrom = "TestExerciser@163.com";
            mail.mailPwd = "admin123";
            mail.mailSubject = mailSubject;
            mail.mailBody = "有以下用例需要您审批：\r\n\r\n\r\n"+ mailBody + "\r\n\r\n\r\n注：该邮件由自动化测试测试工具自动发送\r\n（自动化测试工具TestExerciser）";
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

        private void btnStart_Click(object sender, EventArgs e)
        {
            //if ((this.cbSelectExcel.Text != null) && (this.cbSelectExcel.Text != ""))
            //{
            //    dgvCommit.DataSource = GetDataFromExcelToDT(this.tstbText.Text);
            //}
            //else
            //{
            //    MessageBox.Show("请填写需要导入的Excel工作簿名称！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        //public void GetDataFromExcelToDT()
        //{
        //    MainExcelReader myMainExcelReader = new MainExcelReader();
        //    myMainExcelReader.GetDataFromExcelToDT();
        //}
    }
}
