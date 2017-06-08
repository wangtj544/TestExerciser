using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpSvn;


namespace TestExerciser.Tools
{
    public partial class ToolSVN : Form
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
    }
}
