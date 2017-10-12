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
using System.Diagnostics;



namespace TestExerciser.User
{
    //定义委托
    public delegate void SetMainForm();

    public partial class UserLogin : Skin_Mac
    {
        public static string strDataSource = "Data Source=";

        public static string pubUserName = null;
        public static string pubPasswd = null;

        //定义委托事件
        public event SetMainForm SetMainFormActivate;
        public event SetMainForm SetMainFormVisable;
        public event SetMainForm SetMainFormClosed;

        public UserLogin()
        {
            InitializeComponent();
            InitDataBase();
            this.myNotifyIcon.Visible = false;
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
                this.txtStatus.Text = "登录信息：登录失败，无法连接到服务器！";
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
                            d_ShowMainFrom();
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
            this.Visible = false;
            UserSelectDB myToolSelectDB = new UserSelectDB();
            myToolSelectDB.Show();

        }

        private void myNotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            SetMainFormActivate();
        }

        private void toolStripMenuItem_ShowMainWindow_Click(object sender, EventArgs e)
        {
            myNotifyIcon_DoubleClick(sender, e);
        }

        private void toolStripMenuItem_Paint_Click(object sender, EventArgs e)
        {
            this.SetMainFormVisable();
            runCmd("mspaint");
        }

        private void toolStripMenuItem_Setting_Click(object sender, EventArgs e)
        {
            ToolManager myToolManager = new ToolManager();
            myToolManager.Show();
        }

        private void toolStripMenuItem_LoginOut_Click(object sender, EventArgs e)
        {
            SetMainFormClosed();
            this.txtStatus.ForeColor = Color.Red;
            this.txtStatus.Text = "登录信息：已退出，请重新登录！";
            this.txtPasswd.Text = "";
            this.Visible = true;
        }

        private void toolStripMenuItem_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void d_SetUserLoginFormVisableTrue(bool vis)
        {
            this.Visible = true;
        }


        public void d_ShowMainFrom()
        {
            MainForm myMainForm = new MainForm();
            myMainForm.Show();
            MainForm.isMainFormClosed = false;
            this.myNotifyIcon.Visible = true;
            this.SetMainFormActivate += new SetMainForm(myMainForm.d_SetMainWindowActive);
            this.SetMainFormVisable += new SetMainForm(myMainForm.d_SetMainWindowVisableFalse);
            this.SetMainFormClosed += new SetMainForm(myMainForm.d_SetMainWindowClosed);
            myMainForm.ShowMainFormWhenClosed += new ShowMainForm(this.d_ShowMainFrom);
        }

        private void InitDataBase()
        {
            Properties.Settings.Default.dataSource = strDataSource + Properties.Settings.Default.ServerIP;
            Properties.Settings.Default.ConnectionString = Properties.Settings.Default.dataSource + Properties.Settings.Default.ConnectionParas;
            Properties.Settings.Default.Save();
        }


        private void runCmd(string cmdExe)
        {
            try
            {
                System.Diagnostics.Process p = new System.Diagnostics.Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.CreateNoWindow = true;
                p.Start();
                p.StandardInput.WriteLine(cmdExe);
                p.StandardInput.WriteLine("exit");
                p.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
