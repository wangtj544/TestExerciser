using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CCWin;

namespace TestExerciser.Tools
{
    public partial class ToolSelectDB : Skin_Mac
    {

        public static string strDataSource = "Data Source=";
        public static string sqlExpress = "SQLEXPRESS";
        public static string strconLocal = @".\SQLEXPRESS";
        public static string strcon = null;

        public ToolSelectDB()
        {
            InitializeComponent();
            this.rdbServer.Checked = true;
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            mySelectFunc();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
        }

        private void ToolSelectDB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                mySelectFunc();
            }  
        }

        private void mySelectFunc()
        {
            if (this.rdbServer.Checked == true)
            {
                if (this.stbServerDBPath.Text != "")
                {
                    //配置为远程服务器上的数据库                        
                    strcon = this.stbServerDBPath.Text.ToString();
                    this.txtStatus.ForeColor = Color.Green;
                    this.txtStatus.Text = "设置信息：设置成功，更改为远程服务器数据库连接！";

                }
                else
                {
                    this.txtStatus.ForeColor = Color.Red;
                    this.txtStatus.Text = "设置信息：设置失败，请填写远程服务器上数据库文件路径！";
                }
            }
            else if (rdbLocal.Checked == true)
            {
                strcon = strconLocal;
                this.txtStatus.ForeColor = Color.Green;
                this.txtStatus.Text = "设置信息：设置成功，更改为本地数据库连接！";
            }
            Properties.Settings.Default.dataSource = strDataSource + strcon;
            Properties.Settings.Default.ConnectionString = Properties.Settings.Default.dataSource + Properties.Settings.Default.ConnectionParas;
            Properties.Settings.Default.Save();
        }
    }
}
