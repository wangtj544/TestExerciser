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


namespace TestExerciser.Tools
{
    public partial class ToolSelectDB : Skin_Mac
    {
        public static string strcon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\TestExerciser.accdb;Jet OLEDB:Database Password=admin@123";

        public ToolSelectDB()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.srbServerDB.Checked == true)
            {
                if (this.txtServerDBPath.Text != "")
                {
                    //配置为远程服务器上的数据库                        
                    strcon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + this.txtServerDBPath.Text.ToString() + ";Jet OLEDB:Database Password=admin@123";
                    Properties.Settings.Default.isLocalAccessDB = false;
                    this.txtStatus.ForeColor = Color.Green;
                    this.txtStatus.Text = "设置信息：设置成功，更改为远程服务器数据库连接！";

                }
                else
                {
                    this.txtStatus.ForeColor = Color.Red;
                    this.txtStatus.Text = "设置信息：设置失败，请填写远程服务器上数据库文件路径！";
                }
            }
            else if (this.srbLocalDB.Checked == true)
            {
                Properties.Settings.Default.isLocalAccessDB = true;
                this.txtStatus.ForeColor = Color.Green;
                this.txtStatus.Text = "设置信息：设置成功，更改为本地数据库连接！关闭并重启软件后生效！";
            }
            Properties.Settings.Default.ConnectionString = strcon;
            Properties.Settings.Default.Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
        }
    }
}
