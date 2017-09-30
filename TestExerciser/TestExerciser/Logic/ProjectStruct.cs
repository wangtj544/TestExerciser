using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;

namespace TestExerciser.Logic
{
    class ProjectStruct
    {
        public void loadXml(XmlNode xmlNode, TreeNodeCollection nodes)
        {
            foreach (System.Xml.XmlNode node in xmlNode.ChildNodes)
            {
                TreeNode child = new TreeNode();
                child.Name = node.Attributes["Name"].Value;
                child.Text = node.Attributes["Text"].Value;
                nodes.Add(child);
                loadXml(node, child.Nodes);
            }
        }
    }
}
