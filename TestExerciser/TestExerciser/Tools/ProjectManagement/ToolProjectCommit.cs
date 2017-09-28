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

namespace TestExerciser.Tools.ProjectManagement
{
    public partial class ToolProjectCommit : Skin_Mac
    {
        ManageDB myManageDB = new ManageDB();

        public ToolProjectCommit()
        {
            InitializeComponent();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (this.tb_ProjectNO.Text != null && this.tb_ProjectNO.Text != "")
            {
                myManageDB.InsertInto("insert into ProjectManager(proName,proShortName,proNO,proType,proPriority,proDepartment,proManager,proAssistant,proSetUpTime,proClosedTime,proCustomer,proDevelopmentSite,proAuthor,proBuildTime,proModifier,proModifyTime,proDescribe) values('" + this.tb_ProjectName.Text + "','" + this.tb_ShortName.Text + "','" + this.tb_ProjectNO.Text + "','" + this.cb_Type.Text + "','" + this.cb_Priority.Text + "','" + this.tb_Department.Text + "','" + this.tb_Manager.Text + "','" + this.tb_Assistant.Text + "','" + this.dtp_SetUpTime.Text + "','" + this.dtp_ClosedTime.Text + "','" + this.tb_Customer.Text + "','" + this.tb_DevelopmentSite.Text + "','" + this.tb_Author.Text + "','" + this.dtp_BuildTime.Text + "','" + this.tb_Modifier.Text + "','" + this.dtp_ModifyTime.Text + "','" + this.rtb_Describe.Text + "')");
                this.Visible = false;
                this.Close();
                MainProjectManager myMainProjectManager = new MainProjectManager();
                myMainProjectManager.Show();
            } 
            else
            {
                MessageBox.Show("请将必填项填写完整！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }

        private void tsbSaveAndNew_Click(object sender, EventArgs e)
        {
            if (this.tb_ProjectNO.Text != null && this.tb_ProjectNO.Text != "")
            {
                if (myManageDB.checkItem("ceSuiteNO", "TestCaseEditor", this.tb_ProjectNO.Text))
                {
                    MessageBox.Show("测试套编号：" + this.tb_ProjectNO.Text + "已存在，请尝试设置其他编号！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.tb_ProjectNO.Text = "";
                }
                else
                {
                    myManageDB.InsertInto("insert into ProjectManager(proName,proShortName,proNO,proType,proPriority,proDepartment,proManager,proAssistant,proSetUpTime,proClosedTime,proCustomer,proDevelopmentSite,proAuthor,proBuildTime,proModifier,proModifyTime,proDescribe) values('" + this.tb_ProjectName.Text + "','" + this.tb_ShortName.Text + "','" + this.tb_ProjectNO.Text + "','" + this.cb_Type.Text + "','" + this.cb_Priority.Text + "','" + this.tb_Department.Text + "','" + this.tb_Manager.Text + "','" + this.tb_Assistant.Text + "','" + this.dtp_SetUpTime.Text + "','" + this.dtp_ClosedTime.Text + "','" + this.tb_Customer.Text + "','" + this.tb_DevelopmentSite.Text + "','" + this.tb_Author.Text + "','" + this.dtp_BuildTime.Text + "','" + this.tb_Modifier.Text + "','" + this.dtp_ModifyTime.Text + "','" + this.rtb_Describe.Text + "')");
                 
                    this.tb_ProjectName.Text = "";
                    this.tb_ShortName.Text = "";
                    this.tb_Modifier.Text = "";
                    this.tb_Manager.Text = "";
                    this.tb_Customer.Text = "";
                    this.tb_Department.Text = "";
                    this.tb_DevelopmentSite.Text = "";
                }
            }
            else
            {
                MessageBox.Show("请将必填项填写完整！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }           
        }

        private void ToolProjectCommit_Load(object sender, EventArgs e)
        {
            this.tb_Author.Text = ManageDB.userFullName;
            this.dtp_BuildTime.text = DateTime.Today.ToShortDateString();
        }

        private void tsbQuite_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
        }

        private void ToolProjectCommit_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainProjectManager myMainProjectManager = new MainProjectManager();
            myMainProjectManager.Show();
        }
    }
}
