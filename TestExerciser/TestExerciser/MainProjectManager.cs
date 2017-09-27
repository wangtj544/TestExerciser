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

namespace TestExerciser
{
    public partial class MainProjectManager : Skin_Mac
    {
        ManageDB myManageDB = new ManageDB();
        public static string myProNO;
        public static string currentProNo;
        
        public MainProjectManager()
        {
            InitializeComponent();
            fillToDataGridViewControl();
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

        private void fillToDataGridViewControl()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
                {
                    new DataColumn("项目"),
                    new DataColumn("所属部门"),
                    new DataColumn("项目经理"),
                    new DataColumn("创建人"),
                    new DataColumn("创建时间"),
                    new DataColumn("项目名称")
                });

            string[] myRows = myManageDB.getDataFromCell("proNO", "项目管理");

            if (myRows != null)
            {
                foreach (string myRow in myRows)
                {
                    DataRow row = dt.NewRow();
                    row[0] = myRow;
                    row[1] = myManageDB.getDataFromCell("proDepartment", "项目管理", "proNO", myRow);
                    row[2] = myManageDB.getDataFromCell("proManager", "项目管理", "proNO", myRow);
                    row[3] = myManageDB.getDataFromCell("proAuthor", "项目管理", "proNO", myRow);
                    row[4] = myManageDB.getDataFromCell("proBuildTime", "项目管理", "proNO", myRow).Split(' ')[0];
                    row[5] = myManageDB.getDataFromCell("proName", "项目管理", "proNO", myRow);
                    dt.Rows.Add(row);
                }
                dgvProjectManager.ColumnCount = 5;
                for (int i = 0; i < dgvProjectManager.ColumnCount; i++)
                {
                    dgvProjectManager.Columns[i].Name = dt.Columns[i].ColumnName;
                    dgvProjectManager.Columns[i].DataPropertyName = dt.Columns[i].ColumnName;
                    dgvProjectManager.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    if (i != 0)
                        dgvProjectManager.Columns[i].Width = 120;
                    else
                        dgvProjectManager.Columns[i].Width = 150;
                }
                dgvProjectManager.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvProjectManager.DataSource = dt;

                //只需要把需要绘制的DataGridView传入DataGridViewRenderer即可，
                //这里的隐藏列即为需要重新绘制的内容
                DataGridViewRenderer render = new DataGridViewRenderer(dgvProjectManager,
                    dgvProjectManager.Columns[dgvProjectManager.ColumnCount - 1]);
            }
        }

        private class DataGridViewRenderer
        {
            //行高
            private const int ROW_HEIGHT = 70;
            //目标DataGridView
            private CCWin.SkinControl.SkinDataGridView dataGridView;
            //需要自定义绘制的列
            private DataGridViewColumn hiddenColumn;
            //记录上一次选择的行，用于行索引改变时重绘该行而不是重绘整个控件画面
            private int preRowIndex = 0;
            //小图标
            private Bitmap icon1;
            //private Bitmap icon2;

            public DataGridViewRenderer(CCWin.SkinControl.SkinDataGridView dataGridView, DataGridViewColumn hiddenColumn = null)
            {
                this.dataGridView = dataGridView;
                this.hiddenColumn = hiddenColumn;
                SetupControl();
            }
            /// <summary>
            /// 设置控件属性
            /// </summary>
            private void SetupControl()
            {
                if (dataGridView == null) return;
                if (hiddenColumn != null)
                {
                    hiddenColumn.Visible = false;
                }

                //用户不能调整列标题高度
                dataGridView.ColumnHeadersHeightSizeMode =
                    DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                //隐藏行标题
                dataGridView.RowHeadersVisible = false;
                //设置行高
                dataGridView.RowTemplate.Height = ROW_HEIGHT;
                //设置内边距大小
                Padding newPadding = new Padding(0, 1, 0, ROW_HEIGHT - 35);
                dataGridView.RowTemplate.DefaultCellStyle.Padding = newPadding;
                dataGridView.AllowUserToAddRows = false;
                //设置无单元格边框
                dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
                //单元格选择模式为全选
                dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView.MultiSelect = false;
                dataGridView.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
                //设置字体样式
                dataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;
                dataGridView.DefaultCellStyle.ForeColor = Color.Black;
                //设置选中行背景色，需要绘制自定义背景应该在RowPrePaint处理，并设置该属性为Color.Transparent;
                //dataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
                //绑定一些事件实现自定义行绘制
                dataGridView.ColumnWidthChanged += new
                    DataGridViewColumnEventHandler(dgvCaseManager_ColumnWidthChanged);
                dataGridView.RowHeightChanged += new
                    DataGridViewRowEventHandler(dgvCaseManager_RowHeightChanged);
                dataGridView.CurrentCellChanged += new
                    EventHandler(dgvCaseManager_CurrentCellChanged);
                dataGridView.RowPostPaint += new
                    DataGridViewRowPostPaintEventHandler(dgvCaseManager_RowPostPaint);

                //初始化小图标，这里在资源列表获取
                icon1 = Properties.Resources._2;
                //icon2 = Properties.Resources._0;
            }

            /// <summary>
            /// 列宽度改变时使控件整个画面无效并导致重绘
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void dgvCaseManager_ColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
            {
                dataGridView.Invalidate();
            }

            /// <summary>
            /// 列高度改变时调整行内边距大小
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void dgvCaseManager_RowHeightChanged(object sender, DataGridViewRowEventArgs e)
            {
                int preHeight = e.Row.GetPreferredHeight(
                    e.Row.Index, DataGridViewAutoSizeRowMode.AllCellsExceptHeader, true) -
                    e.Row.DefaultCellStyle.Padding.Bottom;
                Padding newPadding = e.Row.DefaultCellStyle.Padding;
                newPadding.Bottom = e.Row.Height - preHeight;
                e.Row.DefaultCellStyle.Padding = newPadding;
            }

            /// <summary>
            /// 重绘前一个选择的行
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void dgvCaseManager_CurrentCellChanged(object sender, EventArgs e)
            {
                if (preRowIndex != -1)
                {
                    dataGridView.InvalidateRow(preRowIndex);
                }
                preRowIndex = dataGridView.CurrentCellAddress.Y;
            }

            /// <summary>
            /// 处理绘制行内容
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void dgvCaseManager_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
            {
                Rectangle rowBounds = new Rectangle(0, e.RowBounds.Top,
                   dataGridView.Columns.GetColumnsWidth(DataGridViewElementStates.Visible) -
                   dataGridView.HorizontalScrollingOffset + 1, e.RowBounds.Height);

                SolidBrush brush = null;
                try
                {
                    if ((e.State & DataGridViewElementStates.Selected) == DataGridViewElementStates.Selected)
                        brush = new SolidBrush(e.InheritedRowStyle.SelectionForeColor);
                    else
                        brush = new SolidBrush(e.InheritedRowStyle.ForeColor);

                    //获取隐藏列的值
                    object hiddenObj = dataGridView.Rows[e.RowIndex].Cells[hiddenColumn.Name].Value;
                    if (hiddenObj != null)
                    {
                        String text = hiddenObj.ToString();
                        //设定内容边界
                        Rectangle textBounds = rowBounds;
                        textBounds.X -= dataGridView.HorizontalScrollingOffset;
                        textBounds.Width += dataGridView.HorizontalScrollingOffset;

                        textBounds.Y += rowBounds.Height - e.InheritedRowStyle.Padding.Bottom;
                        textBounds.Height -= rowBounds.Height - e.InheritedRowStyle.Padding.Bottom;
                        textBounds.Height = (textBounds.Height / e.InheritedRowStyle.Font.Height) *
                            e.InheritedRowStyle.Font.Height;



                        RectangleF oldClip = e.Graphics.ClipBounds;
                        e.Graphics.SetClip(textBounds);
                        //画图标
                        e.Graphics.DrawImage(icon1, new Rectangle(textBounds.X + 5, textBounds.Y, icon1.Width, icon1.Height));
                        //e.Graphics.DrawImage(icon2, new Rectangle(textBounds.X + icon1.Width + 10, textBounds.Y, icon2.Width, icon2.Height));
                        textBounds.X += icon1.Width * 1 + 15;
                        textBounds.Y += 2;
                        //画文字
                        e.Graphics.DrawString(
                            text, e.InheritedRowStyle.Font, brush, textBounds);

                        e.Graphics.SetClip(oldClip);
                    }
                }
                finally
                {
                    brush.Dispose();
                }
            }
        }

        private void showProjectDetails(string prNO)
        {
            try
            {
                this.labProNameValue.Text = myManageDB.getDataFromCell("proName", "项目管理", "proNO", prNO) + "  ";
                this.txtProjectName.Text = myManageDB.getDataFromCell("proName", "项目管理", "proNO", prNO);
                this.txtShortName.Text = myManageDB.getDataFromCell("proShortName", "项目管理", "proNO", prNO);
                this.txtProNO.Text = myManageDB.getDataFromCell("proNO", "项目管理", "proNO", prNO);
                this.txtType.Text = myManageDB.getDataFromCell("proType", "项目管理", "proNO", prNO);
                this.txtPriority.Text = myManageDB.getDataFromCell("proPriority", "项目管理", "proNO", prNO);
                this.txtDepartment.Text = myManageDB.getDataFromCell("proDepartment", "项目管理", "proNO", prNO);
                this.txtManager.Text = myManageDB.getDataFromCell("proManager", "项目管理", "proNO", prNO);
                this.txtAssistant.Text = myManageDB.getDataFromCell("proAssistant", "项目管理", "proNO", prNO);
                this.txtSetUpTime.Text = myManageDB.getDataFromCell("proSetUpTime", "项目管理", "proNO", prNO).Split(' ')[0];
                this.txtClosedTime.Text = myManageDB.getDataFromCell("proClosedTime", "项目管理", "proNO", prNO).Split(' ')[0];
                this.txtCustomer.Text = myManageDB.getDataFromCell("proCustomer", "项目管理", "proNO", prNO);
                this.txtDevelopmentSite.Text = myManageDB.getDataFromCell("proDevelopmentSite", "项目管理", "proNO", prNO);
                this.txtAuthor.Text = myManageDB.getDataFromCell("proAuthor", "项目管理", "proNO", prNO);
                this.txtBuildTime.Text = myManageDB.getDataFromCell("proBuildTime", "项目管理", "proNO", prNO).Split(' ')[0];
                this.txtModifier.Text = myManageDB.getDataFromCell("proModifier", "项目管理", "proNO", prNO);
                this.txtModifyTime.Text = myManageDB.getDataFromCell("proModifyTime", "项目管理", "proNO", prNO).Split(' ')[0];
                this.rtbDescribe.Text = myManageDB.getDataFromCell("proDescribe", "项目管理", "proNO", prNO);
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
                    string proNO = dgvProjectManager.Rows[cell.RowIndex].Cells[0].Value.ToString();
                    showProjectDetails(proNO);
                    this.btnNewStruct.Enabled = true;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void linkModify_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            myProNO = this.txtProNO.Text;
            this.Visible = false;
            this.Close();
            ToolProjectModify myToolProjectModify = new ToolProjectModify();
             myToolProjectModify.Show();
        }

        private void tbProjectDesign_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tbProjectDesign.SelectedIndex == 1)
            { 
            }
        }

        private void MainProjectManager_Load(object sender, EventArgs e)
        {
            this.btnNewStruct.Enabled = false;
        }
    }
}
