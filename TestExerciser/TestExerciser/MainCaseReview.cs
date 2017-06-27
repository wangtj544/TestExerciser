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


namespace TestExerciser
{
    public partial class MainCaseReview : Skin_Mac
    {
        string [] caseToReview = null;
        

        public MainCaseReview()
        {
            InitializeComponent();
        }

        private void MainCaseReview_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            DialogResult myDialogResult = this.selectFileDialog.ShowDialog();
            if (myDialogResult == DialogResult.OK)
            {
                string strSub = null;
                caseToReview = this.selectFileDialog.FileNames;
                foreach (string str in caseToReview)
                {
                    strSub = strSub + str + ";";
                    this.tbFilePath.Text = strSub;
                }
                this.sbStep1.BaseColor = Color.Lime;
                this.sbStep1.BorderColor = Color.Lime;
            }
        } 
    }
}
