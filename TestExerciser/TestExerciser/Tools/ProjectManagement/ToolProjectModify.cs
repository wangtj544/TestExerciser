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
        string proNO = MainProjectManager.myCurrentProNo;

        public ToolProjectModify()
        {
            InitializeComponent();
        }

        private void ToolProjectModify_Load(object sender, EventArgs e)
        {
            try
            {
                this.tb_ProjectName.Text = myManageDB.getDataFromCell("proName", "ProjectManager", "proNO", proNO);
                this.tb_ShortName.Text = myManageDB.getDataFromCell("proShortName", "ProjectManager", "proNO", proNO);
                this.tb_ProjectNO.Text = myManageDB.getDataFromCell("proNO", "ProjectManager", "proNO", proNO);
                this.cb_Type.Text = myManageDB.getDataFromCell("proType", "ProjectManager", "proNO", proNO);
                this.cb_Priority.Text = myManageDB.getDataFromCell("proPriority", "ProjectManager", "proNO", proNO);
                this.tb_Department.Text = myManageDB.getDataFromCell("proDepartment", "ProjectManager", "proNO", proNO);
                this.tb_Manager.Text = myManageDB.getDataFromCell("proManager", "ProjectManager", "proNO", proNO);
                this.tb_Assistant.Text = myManageDB.getDataFromCell("proAssistant", "ProjectManager", "proNO", proNO);
                this.dtp_SetUpTime.Text = myManageDB.getDataFromCell("proSetUpTime", "ProjectManager", "proNO", proNO).Split(' ')[0];
                this.dtp_ClosedTime.Text = myManageDB.getDataFromCell("proClosedTime", "ProjectManager", "proNO", proNO).Split(' ')[0];
                this.tb_Customer.Text = myManageDB.getDataFromCell("proCustomer", "ProjectManager", "proNO", proNO);
                this.tb_DevelopmentSite.Text = myManageDB.getDataFromCell("proDevelopmentSite", "ProjectManager", "proNO", proNO);

                this.tb_Author.Text = myManageDB.getDataFromCell("proAuthor", "ProjectManager", "proNO", proNO);
                this.dtp_BuildTime.Text = myManageDB.getDataFromCell("proBuildTime", "ProjectManager", "proNO", proNO).Split(' ')[0];
                this.tb_Modifier.Text = myManageDB.getDataFromCell("proModifier", "ProjectManager", "proNO", proNO);
                this.dtp_ModifyTime.Text = myManageDB.getDataFromCell("proModifyTime", "ProjectManager", "proNO", proNO).Split(' ')[0];
                this.rtb_Describe.Text = myManageDB.getDataFromCell("proDescribe", "ProjectManager", "proNO", proNO);
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
                myManageDB.UpdateDB("ProjectManager", "proName", this.tb_ProjectName.Text, "proNO", proNO);
                myManageDB.UpdateDB("ProjectManager", "proShortName", this.tb_ShortName.Text, "proNO", proNO);
                myManageDB.UpdateDB("ProjectManager", "proNO", this.tb_ProjectNO.Text, "proNO", proNO);
                myManageDB.UpdateDB("ProjectManager", "proType", this.cb_Type.Text, "proNO", proNO);
                myManageDB.UpdateDB("ProjectManager", "proPriority", this.cb_Priority.Text, "proNO", proNO);
                myManageDB.UpdateDB("ProjectManager", "proDepartment", this.tb_Department.Text, "proNO", proNO);
                myManageDB.UpdateDB("ProjectManager", "proManager", this.tb_Manager.Text, "proNO", proNO);
                myManageDB.UpdateDB("ProjectManager", "proAssistant", this.tb_Assistant.Text, "proNO", proNO);
                myManageDB.UpdateDB("ProjectManager", "proSetUpTime", this.dtp_SetUpTime.Text, "proNO", proNO);
                myManageDB.UpdateDB("ProjectManager", "proClosedTime", this.dtp_ClosedTime.Text, "proNO", proNO);
                myManageDB.UpdateDB("ProjectManager", "proCustomer", this.tb_Customer.Text, "proNO", proNO);
                myManageDB.UpdateDB("ProjectManager", "proDevelopmentSite", this.tb_DevelopmentSite.Text, "proNO", proNO);
                myManageDB.UpdateDB("ProjectManager", "proAuthor", this.tb_Author.Text, "proNO", proNO);
                myManageDB.UpdateDB("ProjectManager", "proBuildTime", this.dtp_BuildTime.Text, "proNO", proNO);
                myManageDB.UpdateDB("ProjectManager", "proModifier", this.tb_Modifier.Text, "proNO", proNO);
                myManageDB.UpdateDB("ProjectManager", "proModifyTime", this.dtp_ModifyTime.Text, "proNO", proNO);
                myManageDB.UpdateDB("ProjectManager", "proDescribe", this.rtb_Describe.Text, "proNO", proNO);
     
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
