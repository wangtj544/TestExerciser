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
using TestExerciser.Tools.CaseManagement;
using TestExerciser.Logic;

namespace TestExerciser
{ 

    public partial class MainCaseManager : Skin_Mac
    {
        
        ManageDB myManageDB = new ManageDB();
        public static string myCaseNo;
        DataTable myDTCase = new DataTable();

        public MainCaseManager()
        {
            InitializeComponent();
            this.setDataGridViewColumnHeaders();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            ToolCaseCommit myToolCaseCommit = new ToolCaseCommit();
            myToolCaseCommit.Show();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            ToolCaseQuery myToolCaseQuery = new ToolCaseQuery();
            myToolCaseQuery.Show();
            myToolCaseQuery.UpdateAfterQuery += new SetMainCaseManager(this.d_UpdateAfterQuery);
            myToolCaseQuery.DataGridViewSeletedItem += new SetMainCaseManager(this.d_DataGridViewSeletedItem);

        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            ToolSelectModeForCaseReview myToolSelectModeForCaseReview = new ToolSelectModeForCaseReview();
            myToolSelectModeForCaseReview.Show();
        }

        private const int ROW_HEIGHT = 70;

        private void setDataGridViewColumnHeaders()
        {           
            myDTCase.Columns.AddRange(new DataColumn[]
                {
                    new DataColumn("用例"),
                    new DataColumn("作者"),
                    new DataColumn("执行结果"),
                    new DataColumn("创建日期"),
                    new DataColumn("修改日期"),
                    new DataColumn("测试日期"),
                    new DataColumn("用例名称")
                });
            dgvCaseManager.ColumnCount = 6;
            for (int i = 0; i < dgvCaseManager.ColumnCount; i++)
            {
                dgvCaseManager.Columns[i].Name = myDTCase.Columns[i].ColumnName;
                dgvCaseManager.Columns[i].DataPropertyName = myDTCase.Columns[i].ColumnName;
                dgvCaseManager.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                if (i != 0)
                    dgvCaseManager.Columns[i].Width = 120;
                else
                    dgvCaseManager.Columns[i].Width = 150;
            }
        }

        private void setDataGridViewControl(string [] myRows)
        {          
            if (myRows != null)
            {
                foreach (string myRow in myRows)
                {
                    DataRow row = myDTCase.NewRow();
                    row[0] = myRow;                   
                    row[1] = myManageDB.getDataFromCell("ceAuthor", "CaseManager", "ceCaseNO", myRow);
                    row[2] = myManageDB.getDataFromCell("ceActually", "CaseManager", "ceCaseNO", myRow);
                    row[3] = myManageDB.getDataFromCell("ceEditDate", "CaseManager", "ceCaseNO", myRow).Split(' ')[0];
                    row[4] = myManageDB.getDataFromCell("ceModifyDate", "CaseManager", "ceCaseNO", myRow).Split(' ')[0];
                    row[5] = myManageDB.getDataFromCell("ceTestDate", "CaseManager", "ceCaseNO", myRow).Split(' ')[0];
                    row[6] = myManageDB.getDataFromCell("ceCaseName", "CaseManager", "ceCaseNO", myRow);
                    myDTCase.Rows.Add(row);
                }
                
                //用户不能调整列标题高度
                dgvCaseManager.ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                //隐藏行标题
                dgvCaseManager.RowHeadersVisible = false;
                //设置行高
                dgvCaseManager.RowTemplate.Height = ROW_HEIGHT;
                //设置内边距大小
                Padding newPadding = new Padding(0, 1, 0, ROW_HEIGHT - 35);
                dgvCaseManager.RowTemplate.DefaultCellStyle.Padding = newPadding;
                dgvCaseManager.AllowUserToAddRows = false;
                dgvCaseManager.AllowUserToDeleteRows = false;
                dgvCaseManager.AllowUserToResizeColumns = false;
                //设置无单元格边框
                dgvCaseManager.CellBorderStyle = DataGridViewCellBorderStyle.None;
                //单元格选择模式为全选
                dgvCaseManager.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvCaseManager.MultiSelect = false;
                dgvCaseManager.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
                //设置字体样式
                dgvCaseManager.DefaultCellStyle.SelectionForeColor = Color.Black;
                dgvCaseManager.DefaultCellStyle.ForeColor = Color.Black;
                //设置选中行背景色，需要绘制自定义背景应该在RowPrePaint处理，并设置该属性为Color.Transparent;
                //dataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;

                dgvCaseManager.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCaseManager.DataSource = myDTCase;

                //只需要把需要绘制的DataGridView传入DataGridViewRenderer即可，
                //这里的隐藏列即为需要重新绘制的内容
                DataGridViewRender render = new DataGridViewRender(dgvCaseManager,
                    dgvCaseManager.Columns[dgvCaseManager.ColumnCount - 1]);
            }          
        }

        private void showTestCaseDetails(string tcNO)
        {
            try
            {
                this.labTCNOValue.Text = myManageDB.getDataFromCell("ceCaseNO", "CaseManager", "ceCaseNO", tcNO) + "  ";
                this.txtProject.Text = myManageDB.getDataFromCell("ceProject", "CaseManager", "ceCaseNO", tcNO);
                this.txtIfAuto.Text = myManageDB.getDataFromCell("ceIfAuto", "CaseManager", "ceCaseNO", tcNO);
                this.txtSuiteNO.Text = myManageDB.getDataFromCell("ceSuiteNO", "CaseManager", "ceCaseNO", tcNO);
                this.txtSuiteName.Text = myManageDB.getDataFromCell("ceSuiteName", "CaseManager", "ceCaseNO", tcNO);
                this.txtCaseNO.Text = myManageDB.getDataFromCell("ceCaseNO", "CaseManager", "ceCaseNO", tcNO);
                this.txtCaseName.Text = myManageDB.getDataFromCell("ceCaseName", "CaseManager", "ceCaseNO", tcNO);
                this.txtReqNO.Text = myManageDB.getDataFromCell("ceReqNO", "CaseManager", "ceCaseNO", tcNO);
                this.txtCaseLevel.Text = myManageDB.getDataFromCell("ceCaseLevel", "CaseManager", "ceCaseNO", tcNO);
                this.txtFatherModule.Text = myManageDB.getDataFromCell("ceFatherModule", "CaseManager", "ceCaseNO", tcNO);
                this.txtSubModule.Text = myManageDB.getDataFromCell("ceSubModule", "CaseManager", "ceCaseNO", tcNO);
                this.txtAuthor.Text = myManageDB.getDataFromCell("ceAuthor", "CaseManager", "ceCaseNO", tcNO);
                this.txtEditTime.Text = myManageDB.getDataFromCell("ceEditDate", "CaseManager", "ceCaseNO", tcNO).Split(' ')[0];
                this.txtModifier.Text = myManageDB.getDataFromCell("ceModifier", "CaseManager", "ceCaseNO", tcNO);
                this.txtModifyTime.Text = myManageDB.getDataFromCell("ceModifyDate", "CaseManager", "ceCaseNO", tcNO).Split(' ')[0];
                this.txtTester.Text = myManageDB.getDataFromCell("ceTester", "CaseManager", "ceCaseNO", tcNO);
                this.txtTestTime.Text = myManageDB.getDataFromCell("ceTestDate", "CaseManager", "ceCaseNO", tcNO).Split(' ')[0];
                this.rtbPrecondition.Text = myManageDB.getDataFromCell("cePrecondition", "CaseManager", "ceCaseNO", tcNO);
                this.rtbSteps.Text = myManageDB.getDataFromCell("ceSteps", "CaseManager", "ceCaseNO", tcNO);
                this.rtbSamples.Text = myManageDB.getDataFromCell("ceSamples", "CaseManager", "ceCaseNO", tcNO);
                this.rtbExcept.Text = myManageDB.getDataFromCell("ceExcept", "CaseManager", "ceCaseNO", tcNO);
                this.txtActually.Text = myManageDB.getDataFromCell("ceActually", "CaseManager", "ceCaseNO", tcNO);
            }            
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void dgvCaseManager_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    DataGridViewCell cell = (DataGridViewCell)dgvCaseManager.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    string tcNO = dgvCaseManager.Rows[cell.RowIndex].Cells[0].Value.ToString();
                    showTestCaseDetails(tcNO);
                }  
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void linkModify_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            myCaseNo = this.txtCaseNO.Text;
            this.Visible = false;
            this.Close();
            ToolCaseModify myToolCaseModify = new ToolCaseModify();
            myToolCaseModify.Show();
            
        }

        private void MainCaseManager_Load(object sender, EventArgs e)
        {
            this.tbcCaseDesign.SelectedIndex = 0;
            string[] myRows = myManageDB.getDataFromCells("ceCaseNO", "CaseManager");
            setDataGridViewControl(myRows);
        }

        private int queryItemRowIndex()
        {
            int index = 0;
            for (int i=0; i < this.dgvCaseManager.Rows.Count; i++)
            {
                if (this.dgvCaseManager.Rows[i].Cells[0].Value.ToString() == ToolCaseQuery.mySelectedItem)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public void d_UpdateAfterQuery()
        {
            this.dgvCaseManager_CellClick(this.dgvCaseManager, new DataGridViewCellEventArgs(0, queryItemRowIndex()));
        }

        public void d_DataGridViewSeletedItem()
        {
            this.dgvCaseManager.CurrentCell = this.dgvCaseManager.Rows[queryItemRowIndex()].Cells[0];
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            if (this.dgvCaseManager.DataSource != null)
            {
                this.dgvCaseManager.DataSource = null;
            }
            myDTCase.Rows.Clear();
            MainCaseManager_Load(sender,e);
        }

        private void btnMine_Click(object sender, EventArgs e)
        {
            if (this.dgvCaseManager.DataSource != null)
            {
                this.dgvCaseManager.DataSource = null;
            }
            myDTCase.Rows.Clear();
            string[] myRows = myManageDB.getDataFromCells("ceCaseNO", "CaseManager", "ceAuthor", ManageDB.userFullName);
            setDataGridViewControl(myRows);
        }

        private void btnInto_Click(object sender, EventArgs e)
        {

        }

        private void btnOut_Click(object sender, EventArgs e)
        {

        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {

        }

    }
}
