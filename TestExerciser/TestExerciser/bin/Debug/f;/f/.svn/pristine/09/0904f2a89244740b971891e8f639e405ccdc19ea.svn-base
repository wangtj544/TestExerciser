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

namespace TestExerciser.User
{
    public partial class UserInfo : Skin_Mac
    {
        public UserInfo()
        {
            InitializeComponent();
        }

        private void MainUserInfo_Load(object sender, EventArgs e)
        {
            ManageDB myManageDB = new ManageDB();
            myManageDB.queryEmailAddress(UserLogin.pubUserName,UserLogin.pubPasswd);
            myManageDB.queryUserFullName(UserLogin.pubUserName,UserLogin.pubPasswd);
            this.labUserName.Text = UserLogin.pubUserName;
            this.labFullName.Text = ManageDB.userFullName;
            this.labEmailAddress.Text = ManageDB.userEmailAddress;
        }

        private void linkChangeFullName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserChangeUserFullName myChangeUserFullName = new UserChangeUserFullName();
            myChangeUserFullName.Show();
        }

        private void linkChangeMail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserChangeUserEmail myChangeUserEmail = new UserChangeUserEmail();
            myChangeUserEmail.Show();
        }
    }
}
