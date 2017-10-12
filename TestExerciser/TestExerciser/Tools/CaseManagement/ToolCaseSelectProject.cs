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


namespace TestExerciser.Tools.CaseManagement
{
    public delegate void SetToolCaseCommit();

    public partial class ToolCaseSelectProject : Skin_Mac
    {
        DataTable myDTSelectProject = new DataTable();
        ManageDB myManageDB = new ManageDB();
        public static string seletedProjectNO = "";
        public static string seletedProjectName = "";

        public event SetToolCaseCommit SetToolCaseCommitProjectName;
        public event SetToolCaseCommit SetToolCaseCommitProjectStruct;

        public ToolCaseSelectProject()
        {
            InitializeComponent();
            this.setSelectDataGridViewColumnHeaders();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string[] myRows = null;
            if (this.dgvSelectProject.DataSource != null)
            {
                this.dgvSelectProject.DataSource = null;
            }
            myDTSelectProject.Rows.Clear();
            if (this.txtProjectName.Text != "")
            {
                myRows = myManageDB.getDataFromCells("proNO", "ProjectManager", "proName", this.txtProjectName.Text);
            }
            else
            {
                myRows = myManageDB.getDataFromCells("proNO", "ProjectManager", "proNO", this.txtProjectNO.Text);
            }
            if (myRows != null)
            {
                setDataGridViewControl(myRows);
            }            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (seletedProjectName != "")
            {
                this.SetToolCaseCommitProjectName();
                this.SetToolCaseCommitProjectStruct();
                this.btnCancel_Click(sender, e);
            }
            else
            {
                this.txtStatus.ForeColor = Color.Red;
                this.txtStatus.Text = "选择信息：选择失败，请使用鼠标点击并选中工程！";
            }
        }

        private void btnFlush_Click(object sender, EventArgs e)
        {
            if (this.dgvSelectProject.DataSource != null)
            {
                this.dgvSelectProject.DataSource = null;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
        }

        private void txtProjectName_TextChanged(object sender, EventArgs e)
        {
            if (this.txtProjectName.Text != "")
            {
                this.txtProjectNO.Enabled = false;
            }
            else
            {
                this.txtProjectNO.Enabled = true;
            }
        }

        private void txtProjectNO_TextChanged(object sender, EventArgs e)
        {
            if (this.txtProjectNO.Text != "")
            {
                this.txtProjectName.Enabled = false;
            }
            else
            {
                this.txtProjectName.Enabled = true;
            }
        }

        private void setSelectDataGridViewColumnHeaders()
        {
            myDTSelectProject.Columns.AddRange(new DataColumn[]
                {
                    new DataColumn("项目"),
                    new DataColumn("项目名称"),
                    new DataColumn("项目经理"),
                    new DataColumn("所属部门"),
                });
            dgvSelectProject.ColumnCount = 4;
            for (int i = 0; i < dgvSelectProject.ColumnCount; i++)
            {
                dgvSelectProject.Columns[i].Name = myDTSelectProject.Columns[i].ColumnName;
                dgvSelectProject.Columns[i].DataPropertyName = myDTSelectProject.Columns[i].ColumnName;
                dgvSelectProject.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                if (i != 0)
                    dgvSelectProject.Columns[i].Width = 120;
                else
                    dgvSelectProject.Columns[i].Width = 150;
            }
        }

        private const int ROW_HEIGHT = 30;

        private void setDataGridViewControl(string[] myRows)
        {
            if (myRows != null)
            {
                foreach (string myRow in myRows)
                {
                    DataRow row = myDTSelectProject.NewRow();
                    row[0] = myRow;
                    row[1] = myManageDB.getDataFromCell("proName", "ProjectManager", "proNO", myRow);
                    row[2] = myManageDB.getDataFromCell("proManager", "ProjectManager", "proNO", myRow);        
                    row[3] = myManageDB.getDataFromCell("proDepartment", "ProjectManager", "proNO", myRow);                                         
                    myDTSelectProject.Rows.Add(row);
                }

                //用户不能调整列标题高度
                dgvSelectProject.ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

                //设置行高
                dgvSelectProject.RowTemplate.Height = ROW_HEIGHT;
                //设置内边距大小
                //Padding newPadding = new Padding(0, 1, 0, ROW_HEIGHT - 35);
                //dgvSelectProject.RowTemplate.DefaultCellStyle.Padding = newPadding;
                dgvSelectProject.AllowUserToAddRows = false;
                dgvSelectProject.AllowUserToDeleteRows = false;
                dgvSelectProject.AllowUserToResizeColumns = false;
                //设置无单元格边框
                dgvSelectProject.CellBorderStyle = DataGridViewCellBorderStyle.None;
                //单元格选择模式为全选
                dgvSelectProject.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvSelectProject.MultiSelect = false;
                dgvSelectProject.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
                //设置字体样式
                dgvSelectProject.DefaultCellStyle.SelectionForeColor = Color.Black;
                dgvSelectProject.DefaultCellStyle.ForeColor = Color.Black;
                //设置选中行背景色，需要绘制自定义背景应该在RowPrePaint处理，并设置该属性为Color.Transparent;
                //dataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;

                dgvSelectProject.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvSelectProject.DataSource = myDTSelectProject;
            }
        }

        private void dgvSelectProject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    DataGridViewCell cell = (DataGridViewCell)dgvSelectProject.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    seletedProjectNO = dgvSelectProject.Rows[cell.RowIndex].Cells[0].Value.ToString();
                    seletedProjectName = dgvSelectProject.Rows[cell.RowIndex].Cells[1].Value.ToString();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }      
        }

        private void setToolCaseCommitStructFromXML()
        { 
        
        }   
    }
}
