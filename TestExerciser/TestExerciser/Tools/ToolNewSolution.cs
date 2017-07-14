using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using CCWin;
using TestExerciser.Logic;
using System.IO;

namespace TestExerciser.Tools
{
    public partial class ToolNewSolution : Skin_Mac
    {
        public static string projectLocation = null;

        public ToolNewSolution()
        {
            InitializeComponent();
        }

        private void ToolNewSolution_Load(object sender, EventArgs e)
        {

        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            DialogResult selectLocation = this.selectLocationFolderBrowser.ShowDialog();
            if (selectLocation == DialogResult.OK)
            {
                this.stbLocation.Text = this.selectLocationFolderBrowser.SelectedPath;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }       
    }
}