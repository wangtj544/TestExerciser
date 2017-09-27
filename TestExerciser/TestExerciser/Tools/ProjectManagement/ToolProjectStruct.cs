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

        private void tb_Save_Click(object sender, EventArgs e)
        {

        }

        private void ToolProjectStruct_Load(object sender, EventArgs e)
        {
            TreeNode myRoot = new TreeNode();
            myRoot.Text = "根节点";
            myRoot.ImageIndex = 1;
            myRoot.SelectedImageIndex =1;
            this.tv_Struct.Nodes.Add(myRoot);
        }

        private void tb_AddSubNode_Click(object sender, EventArgs e)
        {
            TreeNode mySubNode = new TreeNode();
            mySubNode.Text = "子级节点";
            mySubNode.ImageIndex = 0;
            mySubNode.SelectedImageIndex = 0;
            this.tv_Struct.SelectedNode.Nodes.Add(mySubNode);
            this.tv_Struct.SelectedNode.ExpandAll();
            this.tv_Struct.SelectedNode = mySubNode;
            this.tv_Struct.SelectedNode.BeginEdit();
        }
    }
}
