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
using TestExerciser.Logic;
using System.Data.OleDb;



namespace TestExerciser
{
    public partial class MainCaseReview : Skin_Mac
    {
        string [] caseToReview = null;
        DataSetCaseReview dataSetCaseReview = new DataSetCaseReview();
        DataSetTeamMembers dataSetTeamMembers = new DataSetTeamMembers();
        

        public MainCaseReview()
        {
            InitializeComponent();
        }

        private void MainCaseReview_Load(object sender, EventArgs e)
        {
            OleDbConnection mycon = null;
            try
                    {
                        mycon = new OleDbConnection(ManageDB.strcon);
                        mycon.Open();
                        DataColumn myDataColumn = this.dataSetTeamMembers.用户信息.fullNameColumn;                      
                        
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        mycon.Close();
                    }         
            
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
