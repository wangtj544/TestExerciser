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
    public partial class UserChangeUserFullName : Skin_Mac
    {
        public UserChangeUserFullName()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            changeFunc(); 
        }

        private void changeFunc()
        {
            this.txtStatus.ForeColor = Color.Blue;
            this.txtStatus.Text = "修改信息：正在修改...";
            Application.DoEvents();
            LoginInfo myLoginInfo = new LoginInfo();
            if (this.txtChangeTo.Text != "")
            {
                if (myLoginInfo.isChineseChar(this.txtChangeTo.Text))
                {
                    ManageDB myManageDB = new ManageDB();
                    myManageDB.UpdateDB("fullName", this.txtChangeTo);
                    TimeDelay myTimeDelay = new TimeDelay();
                    this.btnOK.Enabled = false;
                    this.btnCancel.Enabled = false;
                    myTimeDelay.closingCurrentWindowDelay(3, this.txtStatus, this, "修改信息：用户姓名修改成功！", "");                   
                }
                else
                {
                    this.txtStatus.ForeColor = Color.Red;
                    this.txtStatus.Text = "修改信息：修改失败！请输入中文姓名（1-10个字）！";
                }
            }
            else
            {
                this.txtStatus.ForeColor = Color.Red;
                this.txtStatus.Text = "修改信息：修改失败，所有项不能为空！";
            }
        }

        private void UserChangeUserFullName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                changeFunc(); 
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
        }
    }
}
