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
using TestExerciser.Tools;
using System.Data.SqlClient;


namespace TestExerciser.User
{
    public partial class UserLogin : Skin_Mac
    {
        public static string pubUserName = null;
        public static string pubPasswd = null;

        public UserLogin()
        {
            InitializeComponent();
        }

        private void MainLogin_Load(object sender, EventArgs e)
        {           
            this.txtUserName.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {            
            myLoginFunc();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            myCancelFunc();
        }

        private void MainLogin_KeyDown(object sender, KeyEventArgs e)
        {
            myLoginKeyDown(sender, e);
        }

        private void myLoginKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                myLoginFunc();
            }   
        }

        private void myLoginFunc()
        {
            if (Properties.Settings.Default.ConnectionString == null || Properties.Settings.Default.ConnectionString == "")
            {
                this.txtStatus.ForeColor = Color.Red;
                this.txtStatus.Text = "登录信息：登录失败，请先选择服务器！";
            }
            else
            {
                this.txtStatus.ForeColor = Color.Blue;
                this.txtStatus.Text = "登录信息：登录中...";
                Application.DoEvents();
                ManageDB myManageDB = new ManageDB();
                if (this.txtUserName.Text != "" && this.txtPasswd.Text != "")
                {
                    if (myManageDB.checkUserName(this.txtUserName.Text))
                    {
                        if (myManageDB.queryUserFullName(this.txtUserName.Text, this.txtPasswd.Text) && myManageDB.queryEmailAddress(this.txtUserName.Text, this.txtPasswd.Text))
                        {

                            pubUserName = this.txtUserName.Text;
                            pubPasswd = this.txtPasswd.Text;
                            this.txtStatus.ForeColor = Color.Green;
                            this.txtStatus.Text = "登录信息：成功！";
                            Application.DoEvents();
                            this.Visible = false;
                            MainForm myMainForm = new MainForm();
                            myMainForm.Show();
                        }
                        else
                        {
                            this.txtStatus.ForeColor = Color.Red;
                            this.txtStatus.Text = "登录信息：登录失败，请确认密码是否填写正确！";
                        }
                    }
                    else
                    {
                        this.txtStatus.ForeColor = Color.Red;
                        this.txtStatus.Text = "登录信息：登录失败，用户名不存在，请注册！";
                    }
                }
                else
                {
                    this.txtStatus.ForeColor = Color.Red;
                    this.txtStatus.Text = "登录信息：登录失败，用户名和密码不能为空！";
                }
            }            
        }

        private void myCancelFunc()
        {
            this.Visible = false;
            Application.Exit();
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            UserRegister myRegister = new UserRegister();
            myRegister.Show();
        }

        private void MainLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void linkForgetPwd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            UserResetPwd myUserResetPwd = new UserResetPwd();
            myUserResetPwd.Show();
        }

        private void linkSelectDB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ToolSelectDB myToolSelectDB = new ToolSelectDB();
            myToolSelectDB.Show();
        }

    }
}
