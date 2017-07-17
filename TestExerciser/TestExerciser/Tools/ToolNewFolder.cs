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
using System.IO;


namespace TestExerciser.Tools
{
    public partial class ToolNewFolder : Skin_Mac
    {
        public static string folderLocation = null;
        public static bool isCreateFolder = false;
        private string [] folders ;

        public ToolNewFolder()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.stbFolderName.Text != "")
            {
                LoginInfo myLoginInfo = new LoginInfo();
                if (myLoginInfo.isProjectName(this.stbFolderName.Text))
                {
                    if (MainForm.selectedNodePath != "")
                    {
                        MainForm myMainForm = new MainForm();
                        folderLocation = MainForm.selectedNodePath + "\\" + this.stbFolderName.Text;
                        if (Array.IndexOf<string>(newFolderName, folderLocation) != -1)
                        {
                            MessageBox.Show("文件夹名称冲突，请修改工程名称！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            this.IsCreateFolder = true;
                            createFolder(folderLocation);
                            this.txtStatus.ForeColor = Color.Green;
                            this.txtStatus.Text = "创建信息：创建成功！";
                            this.Close();
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                    else
                    {
                        this.txtStatus.ForeColor = Color.Red;
                        this.txtStatus.Text = "创建信息：创建失败，所选项目为空！";
                    }
                }
                else
                {
                    this.txtStatus.ForeColor = Color.Red;
                    this.txtStatus.Text = "创建信息：创建失败，请正确填写文件夹名称！";
                }
            }
            else
            {
                this.txtStatus.ForeColor = Color.Red;
                this.txtStatus.Text = "创建信息：创建失败，文件夹名称不能为空！";
            }
        }

        private void createFolder(string projectLocation)
        {
            if (!Directory.Exists(projectLocation))
            {
                Directory.CreateDirectory(projectLocation);
            }
        }

        public bool IsCreateFolder
        {
            get { return isCreateFolder; }
            set { isCreateFolder = value; }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
        }

        private void btnOK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK_Click(sender, e);
            }
        }

        private void ToolNewFolder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK_KeyDown(sender, e);
            }
        }


        string[] newFolderName;
        List<string> newFolderNameList = new List<string>(); 
    }
}
