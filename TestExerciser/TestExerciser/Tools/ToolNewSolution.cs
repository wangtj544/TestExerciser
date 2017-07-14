using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TestExerciser.Logic;

namespace TestExerciser.Tools
{
    public partial class ToolNewSolution : DevExpress.XtraEditors.XtraForm
    {
        public static string projectLocation = null;

        public ToolNewSolution()
        {
            InitializeComponent();
        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            DialogResult selectLocation = this.selectLocationFolderBrowser.ShowDialog();
            if (selectLocation == DialogResult.OK)
            {
                this.stbLocation.Text = this.selectLocationFolderBrowser.SelectedPath;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.stbProName.Text != null)
            {
                LoginInfo myLoginInfo =new LoginInfo();
                if (myLoginInfo.isProjectName(this.stbProName.Text))
                {
                    if (myLoginInfo.isProjectLocation(this.stbLocation.Text))
                    {
                        projectLocation = this.stbLocation.Text + "\\" + this.stbProName.Text;
                        this.txtStatus.ForeColor = Color.Green;
                        this.txtStatus.Text = "创建信息：创建成功！";
                    }
                    else
                    {
                        this.txtStatus.ForeColor = Color.Red;
                        this.txtStatus.Text = "创建信息：创建失败，请正确填写项目路径！";
                    }                    
                }
                else
                {
                    this.txtStatus.ForeColor = Color.Red;
                    this.txtStatus.Text = "创建信息：创建失败，请正确填写项目名称！";
                }
            }
            else
            {
                this.txtStatus.ForeColor = Color.Red;
                this.txtStatus.Text = "创建信息：创建失败，项目名称不能为空！";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}