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
using System.Data.OleDb;



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


        int readColumnNo = 200;//读取Excel行数
        public bool addToProj = false;
        string excelFileName = null;


        Object cellTempValue = new object { };
        bool needUpdate = false;
        
      

        public MainCaseReview()
        {
            InitializeComponent();
        }

        private void MainCaseReview_Load(object sender, EventArgs e)
        {
            try
            {
            // TODO:  这行代码将数据加载到表“dataSetCasesForReview.评审用例”中。您可以根据需要移动或删除它。
            //this.评审用例TableAdapter.Fill(this.dataSetCasesForReview.评审用例);
            this.btnSelectFile.Enabled = false;
            this.cbIfAuto.Enabled = false;
            this.cbIfCover.Enabled = false;
            this.cbIfMatch.Enabled = false;
            this.cbIfOrder.Enabled = false;
            this.cbSelectExcel.Enabled = false;
            this.btnLaunch.Enabled = false;
            this.btnStart.Enabled = false;
            this.rtbCommit.Enabled = false;
            this.btnCommit.Enabled = false;

            if (myManageDB.checkCoverReviewTo() || myManageDB.checkAutoReviewTo())            
            {
                this.sbStep1.BaseColor = Color.Lime;
                this.sbStep1.BorderColor = Color.Lime;
                this.sbStep2.BaseColor = Color.Lime;
                this.sbStep2.BorderColor = Color.Lime;
                this.sbStep3.BaseColor = Color.Lime;
                this.sbStep3.BorderColor = Color.Lime;
                this.cbSelectExcel.Enabled = true;
                string[] files = Directory.GetFiles(serverTestCaseReviewExcelPool);
                foreach (string file in files)
                {
                    addExcelToTlpSelectTestCase(Path.GetFileName(file));
                }     
            }
            else if (myManageDB.checkReviewFrom())
            {
                
            }
            else
            {
                this.btnSelectFile.Enabled = true;
            }           
            myManageDB.selectItems(cbIfAuto);
            myManageDB.selectItems(cbIfCover);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
           DialogResult myLabel_DoubleClick = MessageBox.Show("确定要删除该评审人吗？","消息提示：", MessageBoxButtons.OKCancel,MessageBoxIcon.Asterisk);
           if (myLabel_DoubleClick == DialogResult.OK)
           {
               var myLabel = sender as Label;
               tlpCoverFullNameList.Controls.Remove((myLabel));
               selectedItemList.Remove(myLabel.Text.Split('；')[0]);
               selectedItem = selectedItemList.ToArray();
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

            string mailAddressStr = null;
            try
            {
                mailAddressStr = Regex.Match(cbIfCover.SelectedItem.ToString(), @"(?<=\()[\s\S]*@sit.com.cn(?=\))").Value;
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            myLabel.Text = cbIfCover.SelectedItem.ToString() + "；";
            tlpCoverFullNameList.Controls.Add(myLabel);
            
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
            if (myManageDB.checkUserName("用例评审", "revFullName", ManageDB.userFullName, "revEmail", ManageDB.userEmailAddress))
            {
                MessageBox.Show("您已经发起了评审流程！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                myManageDB.InsertInto("insert into 用例评审(revFullName,revEmail) values('" + ManageDB.userFullName + "'," + "'" + ManageDB.userEmailAddress + "')");
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
                foreach (string autoReviewTo in autoReviewer)
                {
                    myManageDB.UpdateDB("用户管理", "autoReviewTo", "True", "email", autoReviewTo);
                }
                foreach (string coverReviewTo in ifCoverReviewer)
                {
                    myManageDB.UpdateDB("用户管理", "coverReviewTo", "True", "email", coverReviewTo);
                }
                myManageDB.UpdateDB("用户管理", "reviewFrom", "True", "email", ManageDB.userEmailAddress);
            }                       
        }

        private void sendMail(string mailSubject, string [] mailTo)
        {
            try
            {
                SendMail mail = new SendMail();
                mail.mailFrom = "TestExerciser@163.com";
                mail.mailPwd = "admin123";
                mail.mailSubject = mailSubject;
                mail.mailBody = "有以下用例需要您审批：\r\n\r\n\r\n" + mailBody + "\r\n\r\n\r\n注：该邮件由自动化测试测试工具自动发送\r\n（自动化测试工具TestExerciser）";
                mail.isbodyHtml = false;
                mail.host = "smtp.163.com";
                mail.mailToArray = mailTo;
                mail.mailCcArray = new string[] { };
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if ((this.cbSelectExcel.Text != null) && (this.cbSelectExcel.Text != ""))
            {
                dgvCommit.DataSource = GetDataFromExcelToDT();
                this.sbStep5.BaseColor = Color.Lime;
                this.sbStep5.BorderColor = Color.Lime;
                this.btnStart.Enabled = true;
                this.rtbCommit.Enabled = true;
            }
            else
            {
                MessageBox.Show("请填写需要导入的Excel工作簿名称！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 从Excel获取数据
        /// </summary>
        /// <param name="sheetName"></param>
        /// <returns></returns>
        DataSet ds = new DataSet();
        private DataTable GetDataFromExcelToDT()
        {
            bool hasTitle = true;
            if (cbSelectExcel.Text!="")
            {
                var filePath = serverTestCaseReviewExcelPool + this.cbSelectExcel.Text;
                excelFileName = Path.GetFileName(filePath);
                string fileType = System.IO.Path.GetExtension(filePath);
                if (string.IsNullOrEmpty(fileType)) return null;

                try
                {
                    string strCon = string.Format("Provider=Microsoft.ACE.OLEDB.{0}.0;" +
                                                  "Extended Properties=\"Excel {1}.0;HDR={2};IMEX=1;\";" +
                                                  "data source={3};",
                                                  (fileType == ".xls" ? 4 : 12), (fileType == ".xls" ? 8 : 12), (hasTitle ? "Yes" : "NO"), filePath);                                       
                    using (OleDbConnection myConn = new OleDbConnection(strCon))
                    {
                        myConn.Open();
                        DataTable sheetsName = myConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "Table" }); //得到所有sheet的名字
                        string firstSheetName = sheetsName.Rows[0][2].ToString(); //得到第一个sheet的名字
                        string strCom = string.Format(" SELECT * FROM [{0}A3:P{1}]", (firstSheetName), readColumnNo);
                        OleDbDataAdapter myCommand = new OleDbDataAdapter(strCom, myConn);
                        myCommand.Fill(ds, firstSheetName);
                    }
                    if (ds == null || ds.Tables.Count <= 0) return null;
                    return ds.Tables[0];
                }
                catch (Exception ex)
                {

                    MessageBox.Show("数据绑定Excel失败！ 失败原因：" + ex.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return null;

                }
            }
            return null;
        }

        private void dgvCommit_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            cellTempValue = this.dgvCommit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }

        private void dgvCommit_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (!Object.Equals(cellTempValue, this.dgvCommit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value))
            {
                needUpdate = true;

                if (MessageBox.Show("确定要修改该单元格内容吗？", "消息提示：", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                }
                else
                {
                    this.dgvCommit.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = cellTempValue;
                }
            }
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (needUpdate)
            {
                SqlConnection mycon = null;
                if (MessageBox.Show("确定修改并保存修改内容吗？", "消息提示：", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    try
                    {                        
                        mycon = new SqlConnection(ManageDB.strcon);
                        mycon.Open();
                        DataTable myDataTable = this.dataSetCasesForReview.评审用例;
                        SqlDataAdapter myDataAdapter = this.评审用例TableAdapter.Adapter;
                        SqlCommandBuilder myOleDbCommandBuilder = new SqlCommandBuilder(myDataAdapter);
                        myDataAdapter.Update(myDataTable);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        mycon.Close();
                    }
                }
                else
                {

                }
            }
        }

        private void rtbCommit_TextChanged(object sender, EventArgs e)
        {
            if (this.rtbCommit.Text != "")
            {
                this.btnCommit.Enabled = true;
            }
        }


    }
}
