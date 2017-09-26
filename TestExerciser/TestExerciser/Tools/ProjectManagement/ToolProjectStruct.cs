using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CCWin;

namespace TestExerciser.Tools.ProjectManagement
{
    public partial class ToolProjectStruct : Skin_Mac
    {
        public ToolProjectStruct()
        {
            InitializeComponent();
        }

        private void tb_AddRoot_Click(object sender, EventArgs e)
        {
            TreeNode myRoot = new TreeNode();
            myRoot.Text = "根节点";
            myRoot.ImageIndex = 0;
            myRoot.SelectedImageIndex =0;
            this.tv_Struct.Nodes.Add(myRoot);
        }

        private void tb_AddSubNode_Click(object sender, EventArgs e)
        {
            if(this.tv_Struct.SelectedNode!=null)
            {
                TreeNode mySubNode = new TreeNode();
                mySubNode.Text = "子级节点";
                this.tv_Struct.SelectedNode.Nodes.Add(mySubNode);
                this.tv_Struct.SelectedNode.ExpandAll();
            }
            else
            {
                MessageBox.Show("请先选中响应节点！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }

        private void tb_Save_Click(object sender, EventArgs e)
        {

        }
    }
}
