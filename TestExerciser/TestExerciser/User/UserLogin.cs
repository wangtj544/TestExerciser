﻿using System;
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
            //string strcon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\TestExerciser.accdb;Jet OLEDB:Database Password=admin@123";
            //Properties.Settings.Default.ConnectionString = strcon;
            //Properties.Settings.Default.Save();
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
            this.txtStatus.ForeColor = Color.Blue;
            this.txtStatus.Text = "登录信息：登录中...";
            Application.DoEvents();
            ManageDB myManageDB = new ManageDB();
            if (this.txtUserName.Text != "" && this.txtPasswd.Text != "")
            {
                if (myManageDB.checkUserName(this.txtUserName.Text))
                {
                    if (myManageDB.queryUserFullName(this.txtUserName.Text, this.txtPasswd.Text))
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
                    if (ToolSelectDB.selectDBStatus)
                    {
                        this.txtStatus.ForeColor = Color.Blue;
                        this.txtStatus.Text = "登录信息：您需要重新登录！";
                    }
                    else
                    {
                        this.txtStatus.ForeColor = Color.Red;
                        this.txtStatus.Text = "登录信息：登录失败，用户名不存在，请注册！";
                    }                   
                }                
            }
            else
            {
                this.txtStatus.ForeColor = Color.Red;
                this.txtStatus.Text = "登录信息：登录失败，用户名和密码不能为空！";
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
    }
}
