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
    public partial class ToolProjectModify : Skin_Mac
    {
        ManageDB myManageDB = new ManageDB();
        string proNO = MainProjectManager.myProNO;

        public ToolProjectModify()
        {
            InitializeComponent();
        }

        private void ToolProjectModify_Load(object sender, EventArgs e)
        {
            try
            {
                this.tb_ProjectName.Text = myManageDB.getDataFromCell("proName", "项目管理", "proNO", proNO);
                this.tb_ShortName.Text = myManageDB.getDataFromCell("proShortName", "项目管理", "proNO", proNO);
                this.tb_ProjectNO.Text = myManageDB.getDataFromCell("proNO", "项目管理", "proNO", proNO);
                this.cb_Type.Text = myManageDB.getDataFromCell("proType", "项目管理", "proNO", proNO);
                this.cb_Priority.Text = myManageDB.getDataFromCell("proPriority", "项目管理", "proNO", proNO);
                this.tb_Department.Text = myManageDB.getDataFromCell("proDepartment", "项目管理", "proNO", proNO);
                this.tb_Manager.Text = myManageDB.getDataFromCell("proManager", "项目管理", "proNO", proNO);
                this.tb_Assistant.Text = myManageDB.getDataFromCell("proAssistant", "项目管理", "proNO", proNO);
                this.dtp_SetUpTime.Text = myManageDB.getDataFromCell("proSetUpTime", "项目管理", "proNO", proNO).Split(' ')[0];
                this.dtp_ClosedTime.Text = myManageDB.getDataFromCell("proClosedTime", "项目管理", "proNO", proNO).Split(' ')[0];
                this.tb_Customer.Text = myManageDB.getDataFromCell("proCustomer", "项目管理", "proNO", proNO);
                this.tb_DevelopmentSite.Text = myManageDB.getDataFromCell("proDevelopmentSite", "项目管理", "proNO", proNO);

                this.tb_Author.Text = myManageDB.getDataFromCell("proAuthor", "项目管理", "proNO", proNO);
                this.dtp_BuildTime.Text = myManageDB.getDataFromCell("proBuildTime", "项目管理", "proNO", proNO).Split(' ')[0];
                this.tb_Modifier.Text = myManageDB.getDataFromCell("proModifier", "项目管理", "proNO", proNO);
                this.dtp_ModifyTime.Text = myManageDB.getDataFromCell("proModifyTime", "项目管理", "proNO", proNO).Split(' ')[0];
                this.rtb_Describe.Text = myManageDB.getDataFromCell("proDescribe", "项目管理", "proNO", proNO);
                this.dtp_ModifyTime.text = DateTime.Today.ToShortDateString();
                this.tb_Modifier.Text = ManageDB.userFullName;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void ToolProjectModify_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainProjectManager myMainProjectManager = new MainProjectManager();
            myMainProjectManager.Show();
        }

        private void tsbQuite_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            try
            {
                myManageDB.UpdateDB("项目管理", "proName", this.tb_ProjectName.Text, "proNO", proNO);
                myManageDB.UpdateDB("项目管理", "proShortName", this.tb_ShortName.Text, "proNO", proNO);
                myManageDB.UpdateDB("项目管理", "proNO", this.tb_ProjectNO.Text, "proNO", proNO);
                myManageDB.UpdateDB("项目管理", "proType", this.cb_Type.Text, "proNO", proNO);
                myManageDB.UpdateDB("项目管理", "proPriority", this.cb_Priority.Text, "proNO", proNO);
                myManageDB.UpdateDB("项目管理", "proDepartment", this.tb_Department.Text, "proNO", proNO);
                myManageDB.UpdateDB("项目管理", "proManager", this.tb_Manager.Text, "proNO", proNO);
                myManageDB.UpdateDB("项目管理", "proAssistant", this.tb_Assistant.Text, "proNO", proNO);
                myManageDB.UpdateDB("项目管理", "proSetUpTime", this.dtp_SetUpTime.Text, "proNO", proNO);
                myManageDB.UpdateDB("项目管理", "proClosedTime", this.dtp_ClosedTime.Text, "proNO", proNO);
                myManageDB.UpdateDB("项目管理", "proCustomer", this.tb_Customer.Text, "proNO", proNO);
                myManageDB.UpdateDB("项目管理", "proDevelopmentSite", this.tb_DevelopmentSite.Text, "proNO", proNO);
                myManageDB.UpdateDB("项目管理", "proAuthor", this.tb_Author.Text, "proNO", proNO);
                myManageDB.UpdateDB("项目管理", "proBuildTime", this.dtp_BuildTime.Text, "proNO", proNO);
                myManageDB.UpdateDB("项目管理", "proModifier", this.tb_Modifier.Text, "proNO", proNO);
                myManageDB.UpdateDB("项目管理", "proModifyTime", this.dtp_ModifyTime.Text, "proNO", proNO);
                myManageDB.UpdateDB("项目管理", "proDescribe", this.rtb_Describe.Text, "proNO", proNO);
     
                this.Visible = false;
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
