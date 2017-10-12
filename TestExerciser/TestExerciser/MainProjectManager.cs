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
using TestExerciser.Tools.ProjectManagement;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace TestExerciser
{
    public partial class MainProjectManager : Skin_Mac
    {
        ManageDB myManageDB = new ManageDB();
        public static string myCurrentProNo;
        public static bool isModify = false;

        DataTable myDTProject = new DataTable();
        
        public MainProjectManager()
        {
            InitializeComponent();
            this.setDataGridViewColumnHeaders();
        }

        private void btnNewProject_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            ToolProjectCommit myToolProjectCommit = new ToolProjectCommit();
            myToolProjectCommit.Show();
        }

        private void btnNewStruct_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            ToolProjectStruct myToolProjectStruct = new ToolProjectStruct();
            myToolProjectStruct.Show();
        }

        private void setDataGridViewColumnHeaders()
        {
            myDTProject.Columns.AddRange(new DataColumn[]
                {
                    new DataColumn("项目"),
                    new DataColumn("所属部门"),
                    new DataColumn("项目经理"),
                    new DataColumn("创建人"),
                    new DataColumn("创建时间"),
                    new DataColumn("项目名称")
                });
            dgvProjectManager.ColumnCount = 5;
            for (int i = 0; i < dgvProjectManager.ColumnCount; i++)
            {
                dgvProjectManager.Columns[i].Name = myDTProject.Columns[i].ColumnName;
                dgvProjectManager.Columns[i].DataPropertyName = myDTProject.Columns[i].ColumnName;
                dgvProjectManager.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                if (i != 0)
                    dgvProjectManager.Columns[i].Width = 120;
                else
                    dgvProjectManager.Columns[i].Width = 150;
            }           
        }

        private const int ROW_HEIGHT = 70;
        private void setDataGridViewControl(string [] myRows)
        {
            if (myRows != null)
            {
                foreach (string myRow in myRows)
                {
                    DataRow row = myDTProject.NewRow();
                    row[0] = myRow;
                    row[1] = myManageDB.getDataFromCell("proDepartment", "ProjectManager", "proNO", myRow);
                    row[2] = myManageDB.getDataFromCell("proManager", "ProjectManager", "proNO", myRow);
                    row[3] = myManageDB.getDataFromCell("proAuthor", "ProjectManager", "proNO", myRow);
                    row[4] = myManageDB.getDataFromCell("proBuildTime", "ProjectManager", "proNO", myRow).Split(' ')[0];
                    row[5] = myManageDB.getDataFromCell("proName", "ProjectManager", "proNO", myRow);
                    myDTProject.Rows.Add(row);
                }

                //用户不能调整列标题高度
                dgvProjectManager.ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                //隐藏行标题
                dgvProjectManager.RowHeadersVisible = false;
                //设置行高
                dgvProjectManager.RowTemplate.Height = ROW_HEIGHT;
                //设置内边距大小
                Padding newPadding = new Padding(0, 1, 0, ROW_HEIGHT - 35);
                dgvProjectManager.RowTemplate.DefaultCellStyle.Padding = newPadding;
                dgvProjectManager.AllowUserToAddRows = false;
                dgvProjectManager.AllowUserToDeleteRows = false;
                dgvProjectManager.AllowUserToResizeColumns = false;
                //设置无单元格边框
                dgvProjectManager.CellBorderStyle = DataGridViewCellBorderStyle.None;
                //单元格选择模式为全选
                dgvProjectManager.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvProjectManager.MultiSelect = false;
                dgvProjectManager.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
                //设置字体样式
                dgvProjectManager.DefaultCellStyle.SelectionForeColor = Color.Black;
                dgvProjectManager.DefaultCellStyle.ForeColor = Color.Black;
                //设置选中行背景色，需要绘制自定义背景应该在RowPrePaint处理，并设置该属性为Color.Transparent;
                //dataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;

                dgvProjectManager.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvProjectManager.DataSource = myDTProject;

                //只需要把需要绘制的DataGridView传入DataGridViewRenderer即可，
                //这里的隐藏列即为需要重新绘制的内容
                DataGridViewRender render = new DataGridViewRender(dgvProjectManager,
                    dgvProjectManager.Columns[dgvProjectManager.ColumnCount - 1]);
            }
        }

        private void showProjectDetails(string prNO)
        {
            try
            {
                this.labProNameValue.Text = myManageDB.getDataFromCell("proName", "ProjectManager", "proNO", prNO) + "  ";
                this.txtProjectName.Text = myManageDB.getDataFromCell("proName", "ProjectManager", "proNO", prNO);
                this.txtShortName.Text = myManageDB.getDataFromCell("proShortName", "ProjectManager", "proNO", prNO);
                this.txtProNO.Text = myManageDB.getDataFromCell("proNO", "ProjectManager", "proNO", prNO);
                this.txtType.Text = myManageDB.getDataFromCell("proType", "ProjectManager", "proNO", prNO);
                this.txtPriority.Text = myManageDB.getDataFromCell("proPriority", "ProjectManager", "proNO", prNO);
                this.txtDepartment.Text = myManageDB.getDataFromCell("proDepartment", "ProjectManager", "proNO", prNO);
                this.txtManager.Text = myManageDB.getDataFromCell("proManager", "ProjectManager", "proNO", prNO);
                this.txtAssistant.Text = myManageDB.getDataFromCell("proAssistant", "ProjectManager", "proNO", prNO);
                this.txtSetUpTime.Text = myManageDB.getDataFromCell("proSetUpTime", "ProjectManager", "proNO", prNO).Split(' ')[0];
                this.txtClosedTime.Text = myManageDB.getDataFromCell("proClosedTime", "ProjectManager", "proNO", prNO).Split(' ')[0];
                this.txtCustomer.Text = myManageDB.getDataFromCell("proCustomer", "ProjectManager", "proNO", prNO);
                this.txtDevelopmentSite.Text = myManageDB.getDataFromCell("proDevelopmentSite", "ProjectManager", "proNO", prNO);
                this.txtAuthor.Text = myManageDB.getDataFromCell("proAuthor", "ProjectManager", "proNO", prNO);
                this.txtBuildTime.Text = myManageDB.getDataFromCell("proBuildTime", "ProjectManager", "proNO", prNO).Split(' ')[0];
                this.txtModifier.Text = myManageDB.getDataFromCell("proModifier", "ProjectManager", "proNO", prNO);
                this.txtModifyTime.Text = myManageDB.getDataFromCell("proModifyTime", "ProjectManager", "proNO", prNO).Split(' ')[0];
                this.rtbDescribe.Text = myManageDB.getDataFromCell("proDescribe", "ProjectManager", "proNO", prNO);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void dgvProjectManager_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    DataGridViewCell cell = (DataGridViewCell)dgvProjectManager.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    myCurrentProNo = dgvProjectManager.Rows[cell.RowIndex].Cells[0].Value.ToString();
                    showProjectDetails(myCurrentProNo);
                    this.btnNewStruct.Enabled = true;
                    this.tv_Struct.Nodes.Clear();
                    loadXMLToTreeViewControl();
                    this.tv_Struct.ExpandAll(); 
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void linkModify_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            this.Close();
            ToolProjectModify myToolProjectModify = new ToolProjectModify();
            myToolProjectModify.Show();
        }

        private void MainProjectManager_Load(object sender, EventArgs e)
        {
            this.btnNewStruct.Enabled = false;
            this.tbProjectDesign.SelectedIndex = 0;
            string[] myRows = myManageDB.getDataFromCells("proNO", "ProjectManager");
            this.setDataGridViewControl(myRows);
        }

        private void loadXMLToTreeViewControl()
        {
            string str = myManageDB.getDataFromCell("proStructs", "ProjectManager", "proNO", myCurrentProNo);
            if (str != null && str != "")
            {
                this.btnNewStruct.Text = "修改架构";
                isModify = true;
                StringReader myReader = new StringReader(str);
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(myReader);
                ProjectStruct myProjectStruct = new ProjectStruct();
                myProjectStruct.loadXml(xmlDoc.DocumentElement, this.tv_Struct.Nodes);
            }
            else
            {
                this.btnNewStruct.Text = "新建架构";
                isModify = false;
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            if (this.dgvProjectManager.DataSource != null)
            {
                this.dgvProjectManager.DataSource = null;
            }
            myDTProject.Rows.Clear();
            MainProjectManager_Load(sender, e);
        }

        private void btnMine_Click(object sender, EventArgs e)
        {
            if (this.dgvProjectManager.DataSource != null)
            {
                this.dgvProjectManager.DataSource = null;
            }
            myDTProject.Rows.Clear();
            string[] myRows = myManageDB.getDataFromCells("proNO", "ProjectManager", "proAuthor", ManageDB.userFullName);
            setDataGridViewControl(myRows);
        }
    }
}
