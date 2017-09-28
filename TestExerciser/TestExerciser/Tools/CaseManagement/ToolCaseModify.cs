using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CCWin;
using TestExerciser.Logic;

namespace TestExerciser.Tools.CaseManagement
{
    public partial class ToolCaseModify : Skin_Mac
    {
        ManageDB myManageDB = new ManageDB();
        string tcNO = MainCaseManager.myCaseNo;

        public ToolCaseModify()
        {
            InitializeComponent();
        }

        private void ToolCaseModify_Load(object sender, EventArgs e)
        {
            try
            {
                this.tb_Project.Text = myManageDB.getDataFromCell("ceProject", "TestCaseEditor", "ceCaseNO", tcNO);
                this.cb_Struct.Text = myManageDB.getDataFromCell("ceStruct", "TestCaseEditor", "ceCaseNO", tcNO);
                this.tb_SuiteNO.Text = myManageDB.getDataFromCell("ceSuiteNO", "TestCaseEditor", "ceCaseNO", tcNO);
                this.tb_SuiteName.Text = myManageDB.getDataFromCell("ceSuiteName", "TestCaseEditor", "ceCaseNO", tcNO);
                this.tb_CaseNO.Text = myManageDB.getDataFromCell("ceCaseNO", "TestCaseEditor", "ceCaseNO", tcNO);
                this.tb_CaseName.Text = myManageDB.getDataFromCell("ceCaseName", "TestCaseEditor", "ceCaseNO", tcNO);
                this.tb_ReqNO.Text = myManageDB.getDataFromCell("ceReqNO", "TestCaseEditor", "ceCaseNO", tcNO);
                this.cb_CaseLevel.Text = myManageDB.getDataFromCell("ceCaseLevel", "TestCaseEditor", "ceCaseNO", tcNO);
                this.tb_FatherModule.Text = myManageDB.getDataFromCell("ceFatherModule", "TestCaseEditor", "ceCaseNO", tcNO);
                this.tb_SubModule.Text = myManageDB.getDataFromCell("ceSubModule", "TestCaseEditor", "ceCaseNO", tcNO);
                this.tb_Author.Text = myManageDB.getDataFromCell("ceAuthor", "TestCaseEditor", "ceCaseNO", tcNO);
                this.tb_EditDate.Text = myManageDB.getDataFromCell("ceEditDate", "TestCaseEditor", "ceCaseNO", tcNO).Split(' ')[0];               

                this.dtpModifyDate.Text = myManageDB.getDataFromCell("ceModifyDate", "TestCaseEditor", "ceCaseNO", tcNO).Split(' ')[0];
                this.cb_Tester.Text = myManageDB.getDataFromCell("ceTester", "TestCaseEditor", "ceCaseNO", tcNO);
                this.dtpTestDate.Text = myManageDB.getDataFromCell("ceTestDate", "TestCaseEditor", "ceCaseNO", tcNO).Split(' ')[0];
                this.rtb_Precondition.Text = myManageDB.getDataFromCell("cePrecondition", "TestCaseEditor", "ceCaseNO", tcNO);
                this.rtb_Steps.Text = myManageDB.getDataFromCell("ceSteps", "TestCaseEditor", "ceCaseNO", tcNO);
                this.rtb_Samples.Text = myManageDB.getDataFromCell("ceSamples", "TestCaseEditor", "ceCaseNO", tcNO);
                this.rtb_Except.Text = myManageDB.getDataFromCell("ceExcept", "TestCaseEditor", "ceCaseNO", tcNO);
                this.cb_Actually.Text = myManageDB.getDataFromCell("ceActually", "TestCaseEditor", "ceCaseNO", tcNO);
                this.cb_IfAuto.Text = myManageDB.getDataFromCell("ceIfAuto", "TestCaseEditor", "ceCaseNO", tcNO);
                this.dtpModifyDate.text = DateTime.Today.ToShortDateString();
                this.tb_Modifier.Text = ManageDB.userFullName;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            try
            {
                myManageDB.UpdateDB("TestCaseEditor", "ceProject", this.tb_Project.Text, "ceCaseNO", tcNO);
                myManageDB.UpdateDB("TestCaseEditor", "ceStruct", this.cb_Struct.Text, "ceCaseNO", tcNO);
                myManageDB.UpdateDB("TestCaseEditor", "ceSuiteNO", this.tb_SuiteNO.Text, "ceCaseNO", tcNO);
                myManageDB.UpdateDB("TestCaseEditor", "ceSuiteName", this.tb_SuiteName.Text, "ceCaseNO", tcNO);
                myManageDB.UpdateDB("TestCaseEditor", "ceCaseNO", this.tb_CaseNO.Text, "ceCaseNO", tcNO);
                myManageDB.UpdateDB("TestCaseEditor", "ceCaseName", this.tb_CaseName.Text, "ceCaseNO", tcNO);
                myManageDB.UpdateDB("TestCaseEditor", "ceReqNO", this.tb_ReqNO.Text, "ceCaseNO", tcNO);
                myManageDB.UpdateDB("TestCaseEditor", "ceCaseLevel", this.cb_CaseLevel.Text, "ceCaseNO", tcNO);
                myManageDB.UpdateDB("TestCaseEditor", "ceFatherModule", this.tb_FatherModule.Text, "ceCaseNO", tcNO);
                myManageDB.UpdateDB("TestCaseEditor", "ceSubModule", this.tb_SubModule.Text, "ceCaseNO", tcNO);
                myManageDB.UpdateDB("TestCaseEditor", "ceAuthor", this.tb_Author.Text, "ceCaseNO", tcNO);
                myManageDB.UpdateDB("TestCaseEditor", "ceEditDate", this.tb_EditDate.Text, "ceCaseNO", tcNO);
                myManageDB.UpdateDB("TestCaseEditor", "ceModifier", this.tb_Modifier.Text, "ceCaseNO", tcNO);
                myManageDB.UpdateDB("TestCaseEditor", "ceModifyDate", this.dtpModifyDate.Text, "ceCaseNO", tcNO);
                myManageDB.UpdateDB("TestCaseEditor", "ceTester", this.cb_Tester.Text, "ceCaseNO", tcNO);
                myManageDB.UpdateDB("TestCaseEditor", "ceTestDate", this.dtpTestDate.Text, "ceCaseNO", tcNO);
                myManageDB.UpdateDB("TestCaseEditor", "cePrecondition", this.rtb_Precondition.Text, "ceCaseNO", tcNO);
                myManageDB.UpdateDB("TestCaseEditor", "ceSteps", this.rtb_Steps.Text, "ceCaseNO", tcNO);
                myManageDB.UpdateDB("TestCaseEditor", "ceSamples", this.rtb_Samples.Text, "ceCaseNO", tcNO);
                myManageDB.UpdateDB("TestCaseEditor", "ceExcept", this.rtb_Except.Text, "ceCaseNO", tcNO);
                myManageDB.UpdateDB("TestCaseEditor", "ceActually", this.cb_Actually.Text, "ceCaseNO", tcNO);
                myManageDB.UpdateDB("TestCaseEditor", "ceIfAuto", this.cb_IfAuto.Text, "ceCaseNO", tcNO);
                this.Visible = false;
                this.Close();
            } 
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbQuite_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
        }

        private void tb_CaseNO_Leave(object sender, EventArgs e)
        {
            if (this.tb_CaseNO.Text != "")
            {
                if (myManageDB.checkItem("ceCaseName", "TestCaseEditor", this.tb_CaseNO.Text))
                {
                    MessageBox.Show("测试用例编号：" + this.tb_CaseNO.Text + "已存在，请尝试设置其他编号！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.tb_CaseNO.Text = "";
                }
            }
        }

        private void tb_CaseName_Leave(object sender, EventArgs e)
        {
            if (this.tb_CaseName.Text != "")
            {
                if (myManageDB.checkItem("ceCaseName", "TestCaseEditor", this.tb_CaseName.Text))
                {
                    MessageBox.Show("测试用例编号：" + this.tb_CaseName.Text + "已存在，请尝试设置其他编号！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.tb_CaseName.Text = "";
                }
            }
        }

        private void ToolCaseModify_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainCaseManager myMainCaseManager = new MainCaseManager();
            myMainCaseManager.Show();
        }
    }
}
