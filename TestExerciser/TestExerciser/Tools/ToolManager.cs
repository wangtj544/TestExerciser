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
using TestExerciser.User;

namespace TestExerciser.Tools
{
    public partial class ToolManager : Skin_Mac
    {
        public static string strcon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\TestExerciser.accdb;Jet OLEDB:Database Password=admin@123";

        string operate = null;

        public ToolManager()
        {
            InitializeComponent();
            this.gbSelectDB.Visible = false;
        }

        private void tvItems_Click(object sender, EventArgs e)
        {
            if (this.tvItems.SelectedNode != null)
            {
                if (this.tvItems.SelectedNode.Text == "数据库")
                {
                    this.gbSelectDB.Visible = true;
                    this.radbLocal.Checked = true;
                    this.operate = "DB";
                }
            }            
        }

        private void ToolManager_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            switch(this.operate)
            {
                case "DB":
                     if (this.radbServer.Checked == true)
                        {
                            //配置为远程服务器上的数据库       
                            strcon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + @"\\172.20.32.147\data\TestExerciser.accdb;Jet OLEDB:Database Password=admin@123";
                            this.txtStatus.ForeColor = Color.Green;
                            this.txtStatus.Text = "确认信息：确认成功，更改为远程服务器数据库连接！即将重启！";
                        }
                        
                    break;
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
        }
    }
}
