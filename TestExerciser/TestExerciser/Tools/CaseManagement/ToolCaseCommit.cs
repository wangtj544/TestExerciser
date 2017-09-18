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
            this.dtpTestDate.text = DateTime.Today.ToShortDateString();
            this.tb_Author.Text = ManageDB.userFullName;
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            
            if (tb_CaseNO.Text!=null && tb_CaseNO.Text != "")
            {
                myManageDB.InsertInto("insert into 用例编写(ceProject,ceStruct,ceSuiteNO,ceSuiteName,ceCaseNO,ceCaseName,ceReqNO,ceCaseLevel,ceParentModule,ceSubModule,ceAuthor,ceIfAuto,ceTester,ceTestDate,cePrecondition,ceSteps,ceSamples,ceExcept,ceActually) values('" + this.tb_Project.Text + "','" + this.cb_Struct.Text + "','" + this.tb_SuiteNO.Text + "','" + this.tb_SuiteName.Text + "','" + this.tb_CaseNO.Text + "','" + this.tb_CaseName.Text + "','" + this.tb_ReqNO.Text + "','" + this.cb_CaseLevel.Text + "','" + this.tb_ParentModule.Text + "','" + this.tb_SubModule.Text + "','" + this.tb_Author.Text + "','" + this.cb_IfAuto.Text + "','" + this.cb_Tester.Text + "','" + this.dtpTestDate.Text + "','" + this.rtb_Precondition.Text + "','" + this.rtb_Steps.Text + "','" + this.rtb_Samples.Text + "','" + this.rtb_Except.Text + "','" + this.cb_Actually.Text + "')");
                this.Visible = false;
                this.Close();
            }
            else
            {
                MessageBox.Show("请将必填项填写完整！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }

        private void tb_CaseNO_Leave(object sender, EventArgs e)
        {
            if (myManageDB.checkItem("ceCaseNO", "用例编写", this.tb_CaseNO.Text))
            {
                MessageBox.Show("测试用例编号：" + this.tb_CaseNO.Text + "已存在，请尝试设置其他编号！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tb_CaseNO.Text = "";
            }
        }

        private void tb_SuiteNO_Leave(object sender, EventArgs e)
        {
            if (myManageDB.checkItem("ceSuiteNO", "用例编写", this.tb_SuiteNO.Text))
            {
                MessageBox.Show("测试套编号：" + this.tb_SuiteNO.Text + "已存在，请尝试设置其他编号！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tb_SuiteNO.Text = "";
            }
        }

        private void tb_SuiteName_Leave(object sender, EventArgs e)
        {
            if (myManageDB.checkItem("ceSuiteName", "用例编写", this.tb_SuiteName.Text))
            {
                MessageBox.Show("测试用例编号：" + this.tb_SuiteName.Text + "已存在，请尝试设置其他编号！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tb_SuiteName.Text = "";
            }
        }

        private void tb_CaseName_Leave(object sender, EventArgs e)
        {
            if (myManageDB.checkItem("ceCaseName", "用例编写", this.tb_CaseName.Text))
            {
                MessageBox.Show("测试用例编号：" + this.tb_CaseName.Text + "已存在，请尝试设置其他编号！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.tb_CaseName.Text = "";
            }
        }
    }
}
