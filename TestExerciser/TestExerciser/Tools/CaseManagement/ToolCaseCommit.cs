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

namespace TestExerciser.Tools.CaseManagement
{
    public partial class ToolCaseCommit : Skin_Mac
    {
        public ToolCaseCommit()
        {
            InitializeComponent();
        }

        ManageDB myManageDB = new ManageDB();

        private void ToolCaseCommit_Load(object sender, EventArgs e)
        {
            this.dtpEditDate.text = DateTime.Today.ToShortDateString();
            this.tb_Author.Text = ManageDB.userFullName;
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (tb_CaseNO.Text != null && tb_CaseNO.Text != "")
            {
                if (myManageDB.checkItem("ceCaseNO", "TestCaseEditor", this.tb_CaseNO.Text))
                {
                    MessageBox.Show("测试用例编号：" + this.tb_CaseNO.Text + "已存在，请重新填写！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.tb_CaseNO.Text = "";
                }
                else
                {
                    myManageDB.InsertInto("insert into TestCaseEditor(ceProject,ceStruct,ceSuiteNO,ceSuiteName,ceCaseNO,ceCaseName,ceReqNO,ceCaseLevel,ceFatherModule,ceSubModule,ceAuthor,ceEditDate,ceIfAuto,cePrecondition,ceSteps,ceSamples,ceExcept,ceActually) values('" + this.tb_Project.Text + "','" + this.cb_Struct.Text + "','" + this.tb_SuiteNO.Text + "','" + this.tb_SuiteName.Text + "','" + this.tb_CaseNO.Text + "','" + this.tb_CaseName.Text + "','" + this.tb_ReqNO.Text + "','" + this.cb_CaseLevel.Text + "','" + this.tb_ParentModule.Text + "','" + this.tb_SubModule.Text + "','" + this.tb_Author.Text + "','" + this.dtpEditDate.Text + "','" + this.cb_IfAuto.Text + "','" + this.rtb_Precondition.Text + "','" + this.rtb_Steps.Text + "','" + this.rtb_Samples.Text + "','" + this.rtb_Except.Text + "','" + this.cb_Actually.Text + "')");


                    this.Visible = false;
                    this.Close();
                }               
            }
            else
            {
                MessageBox.Show("请将必填项填写完整！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }

        private void tb_CaseNO_Leave(object sender, EventArgs e)
        {
            if (this.tb_CaseNO.Text != "")
            {
                if (myManageDB.checkItem("ceCaseNO", "TestCaseEditor", this.tb_CaseNO.Text))
                {
                    MessageBox.Show("测试用例编号：" + this.tb_CaseNO.Text + "已存在，请重新填写！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show("测试用例名称： '" + this.tb_CaseName.Text + "' 已存在，请重新填写！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.tb_CaseName.Text = "";
                }
            }
        }

        private void tsbQuite_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
        }

        private void tsbSaveAndNew_Click(object sender, EventArgs e)
        {
            if (tb_CaseNO.Text != null && tb_CaseNO.Text != "")
            {
                if (myManageDB.checkItem("ceCaseNO", "TestCaseEditor", this.tb_CaseNO.Text))
                {
                    MessageBox.Show("测试用例编号：" + this.tb_CaseNO.Text + "已存在，请重新填写！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.tb_CaseNO.Text = "";
                }
                else
                {
                    myManageDB.InsertInto("insert into TestCaseEditor(ceProject,ceStruct,ceSuiteNO,ceSuiteName,ceCaseNO,ceCaseName,ceReqNO,ceCaseLevel,ceFatherModule,ceSubModule,ceAuthor,ceEditDate,ceIfAuto,cePrecondition,ceSteps,ceSamples,ceExcept,ceActually) values('" + this.tb_Project.Text + "','" + this.cb_Struct.Text + "','" + this.tb_SuiteNO.Text + "','" + this.tb_SuiteName.Text + "','" + this.tb_CaseNO.Text + "','" + this.tb_CaseName.Text + "','" + this.tb_ReqNO.Text + "','" + this.cb_CaseLevel.Text + "','" + this.tb_ParentModule.Text + "','" + this.tb_SubModule.Text + "','" + this.tb_Author.Text + "','" + this.dtpEditDate.Text + "','" + this.cb_IfAuto.Text + "','" + this.rtb_Precondition.Text + "','" + this.rtb_Steps.Text + "','" + this.rtb_Samples.Text + "','" + this.rtb_Except.Text + "','" + this.cb_Actually.Text + "')");
                    string[] caseNo = this.tb_CaseNO.Text.Split('_');

                    try
                    {
                        this.tb_CaseNO.Text = (Convert.ToInt32(caseNo[caseNo.Length - 1]) + 1).ToString();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    this.tb_CaseName.Text = "";
                    this.rtb_Precondition.Text = "";
                    this.rtb_Steps.Text = "";
                    this.rtb_Samples.Text = "";
                }              
            }
            else
            {
                MessageBox.Show("请将必填项填写完整！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }                                     
        }

        private void ToolCaseCommit_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainCaseManager myMainCaseManager = new MainCaseManager();
            myMainCaseManager.Show();
        }
    }
}
