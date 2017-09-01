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
using SharpSvn;



namespace TestExerciser.Tools.SVN
{
    public partial class ToolSVN : Skin_Mac
    {
        public ToolSVN()
        {
            InitializeComponent();
        }

        private void ToolSVN_Load(object sender, EventArgs e)
        {
            using (SvnClient client = new SvnClient())
            {
                SharpSvn.UI.SvnUIBindArgs uiBindArgs = new SharpSvn.UI.SvnUIBindArgs();
                SharpSvn.UI.SvnUI.Bind(client, uiBindArgs);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            object command = cbCmdList.SelectedItem;
            if (command == null) 
            {
                MessageBox.Show("请从下拉菜单中选择相应的SVN命令！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
           
            switch (command.ToString())
            {
                case "CheckOut": 
                    ToolSVNCheckOut myCheckOutFrm = new ToolSVNCheckOut();
                    myCheckOutFrm.Show();
                    break;
                default: 
                    MessageBox.Show("请从下拉菜单中选择相应的SVN命令！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
