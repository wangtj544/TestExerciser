using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CCWin;
using TestExerciser.Logic;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace TestExerciser.Tools.ProjectManagement
{
    public partial class ToolProjectStruct : Skin_Mac
    {

        ManageDB myManageDB = new ManageDB();

        public ToolProjectStruct()
        {
            InitializeComponent();
        }

        private void tb_Save_Click(object sender, EventArgs e)
        {
            SaveToXml(MainProjectManager.myCurrentProNo);
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

        private void SaveToXml(string xmlFileName)
        {
            XDeclaration dec = new XDeclaration("1.0", "utf-8", "yes");
            XDocument xml = new XDocument(dec);

            XElement root = new XElement("Tree");

            foreach (TreeNode node in this.tv_Struct.Nodes)
            {
                XElement e = CreateElements(node);
                root.Add(e);
            }
            xml.Add(root);
            string projectStructPool = "";
            if (Properties.Settings.Default.ServerIP == "")
            {
                projectStructPool = @"C:\DATA\ProjectStructPool\";
            }
            else
            {
                projectStructPool = @"\\" + Properties.Settings.Default.ServerIP + @"\DATA\ProjectStructPool\";
            }
            try
            {
                if (!Directory.Exists(projectStructPool))
                {
                    Directory.CreateDirectory(projectStructPool);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("读取Excel数据失败！ 失败原因：" + ex.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string savePath = projectStructPool + xmlFileName + ".xml";
            xml.Save(savePath);
            string xmlContent = xml.Declaration.ToString() + "r\n" + xml.ToString();
            myManageDB.UpdateDB("ProjectManager", "proStructs", savePath, "proNO", MainProjectManager.myCurrentProNo);
        }

        private XElement CreateElements(TreeNode node)
        {
            XElement root = CreateElement(node);

            foreach (TreeNode n in node.Nodes)
            {
                XElement e = CreateElements(n);
                root.Add(e);
            }
            return root;
        }

        private XElement CreateElement(TreeNode node)
        {
            return new XElement("Node",
                new XAttribute("Name", node.Name),
                new XAttribute("Text", node.Text)
                );
        }

    }
}
