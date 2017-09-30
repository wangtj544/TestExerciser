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
            if (MainProjectManager.isModify)
            {
                loadXMLToTreeViewControl();
                this.tv_Struct.ExpandAll();
            }
            else
            {
                TreeNode myRoot = new TreeNode();
                myRoot.Text = "根节点";
                myRoot.ImageIndex = 1;
                myRoot.SelectedImageIndex = 1;
                this.tv_Struct.Nodes.Add(myRoot);
            }
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
            string xmlContent = xml.ToString();
            string sql = "declare @xmlDoc xml;set @xmlDoc ='" + xml + "'update ProjectManager set proStructs = @xmlDoc where proNO ='" + MainProjectManager.myCurrentProNo + "'";
            myManageDB.saveXML(sql);
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

        private void loadXMLToTreeViewControl()
        {
            string str = myManageDB.getDataFromCell("proStructs", "ProjectManager", "proNO", MainProjectManager.myCurrentProNo);
            if (str != null && str != "")
            {
                StringReader myReader = new StringReader(str);
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(myReader);
                ProjectStruct myProjectStruct = new ProjectStruct();
                myProjectStruct.loadXml(xmlDoc.DocumentElement, this.tv_Struct.Nodes);
            }
        }

        private void ToolProjectStruct_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainProjectManager myMainProjectManager = new MainProjectManager();
            myMainProjectManager.Show();
        }

        private void tv_Struct_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            this.tv_Struct.SelectedNode.BeginEdit();
        }
    }
}
