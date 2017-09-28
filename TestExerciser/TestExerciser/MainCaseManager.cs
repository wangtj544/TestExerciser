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

        public MainCaseManager()
        {
            InitializeComponent();
            fillToDataGridViewControl();
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
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            ToolSelectModeForCaseReview myToolSelectModeForCaseReview = new ToolSelectModeForCaseReview();
            myToolSelectModeForCaseReview.Show();
        }

        private void fillToDataGridViewControl()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
                {
                    new DataColumn("用例"),
                    new DataColumn("作者"),
                    new DataColumn("执行结果"),
                    new DataColumn("创建日期"),
                    new DataColumn("修改日期"),
                    new DataColumn("测试日期"),
                    new DataColumn("用例名称")
                });

            string [] myRows = myManageDB.getDataFromCell("ceCaseNO", "TestCaseEditor");

            if (myRows != null)
            {
                foreach (string myRow in myRows)
                {
                    DataRow row = dt.NewRow();
                    row[0] = myRow;                   
                    row[1] = myManageDB.getDataFromCell("ceAuthor", "TestCaseEditor", "ceCaseNO", myRow);
                    row[2] = myManageDB.getDataFromCell("ceActually", "TestCaseEditor", "ceCaseNO", myRow);
                    row[3] = myManageDB.getDataFromCell("ceEditDate", "TestCaseEditor", "ceCaseNO", myRow).Split(' ')[0];
                    row[4] = myManageDB.getDataFromCell("ceModifyDate", "TestCaseEditor", "ceCaseNO", myRow).Split(' ')[0];
                    row[5] = myManageDB.getDataFromCell("ceTestDate", "TestCaseEditor", "ceCaseNO", myRow).Split(' ')[0];
                    row[6] = myManageDB.getDataFromCell("ceCaseName", "TestCaseEditor", "ceCaseNO", myRow);
                    dt.Rows.Add(row);
                }
                dgvCaseManager.ColumnCount = 6;
                for (int i = 0; i < dgvCaseManager.ColumnCount; i++)
                {
                    dgvCaseManager.Columns[i].Name = dt.Columns[i].ColumnName;
                    dgvCaseManager.Columns[i].DataPropertyName = dt.Columns[i].ColumnName;
                    dgvCaseManager.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    if (i != 0)
                        dgvCaseManager.Columns[i].Width = 120;
                    else
                        dgvCaseManager.Columns[i].Width = 150;
                }
                dgvCaseManager.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCaseManager.DataSource = dt;

                //只需要把需要绘制的DataGridView传入DataGridViewRenderer即可，
                //这里的隐藏列即为需要重新绘制的内容
                DataGridViewRenderer render = new DataGridViewRenderer(dgvCaseManager,
                    dgvCaseManager.Columns[dgvCaseManager.ColumnCount - 1]);
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

        private void showTestCaseDetails(string tcNO)
        {
            try
            {
                this.labTCNOValue.Text = myManageDB.getDataFromCell("ceCaseNO", "TestCaseEditor", "ceCaseNO", tcNO) + "  ";
                this.txtProject.Text = myManageDB.getDataFromCell("ceProject", "TestCaseEditor", "ceCaseNO", tcNO);
                this.txtIfAuto.Text = myManageDB.getDataFromCell("ceIfAuto", "TestCaseEditor", "ceCaseNO", tcNO);
                this.txtSuiteNO.Text = myManageDB.getDataFromCell("ceSuiteNO", "TestCaseEditor", "ceCaseNO", tcNO);
                this.txtSuiteName.Text = myManageDB.getDataFromCell("ceSuiteName", "TestCaseEditor", "ceCaseNO", tcNO);
                this.txtCaseNO.Text = myManageDB.getDataFromCell("ceCaseNO", "TestCaseEditor", "ceCaseNO", tcNO);
                this.txtCaseName.Text = myManageDB.getDataFromCell("ceCaseName", "TestCaseEditor", "ceCaseNO", tcNO);
                this.txtReqNO.Text = myManageDB.getDataFromCell("ceReqNO", "TestCaseEditor", "ceCaseNO", tcNO);
                this.txtCaseLevel.Text = myManageDB.getDataFromCell("ceCaseLevel", "TestCaseEditor", "ceCaseNO", tcNO);
                this.txtFatherModule.Text = myManageDB.getDataFromCell("ceFatherModule", "TestCaseEditor", "ceCaseNO", tcNO);
                this.txtSubModule.Text = myManageDB.getDataFromCell("ceSubModule", "TestCaseEditor", "ceCaseNO", tcNO);
                this.txtAuthor.Text = myManageDB.getDataFromCell("ceAuthor", "TestCaseEditor", "ceCaseNO", tcNO);
                this.txtEditTime.Text = myManageDB.getDataFromCell("ceEditDate", "TestCaseEditor", "ceCaseNO", tcNO).Split(' ')[0];
                this.txtModifier.Text = myManageDB.getDataFromCell("ceModifier", "TestCaseEditor", "ceCaseNO", tcNO);
                this.txtModifyTime.Text = myManageDB.getDataFromCell("ceModifyDate", "TestCaseEditor", "ceCaseNO", tcNO).Split(' ')[0];
                this.txtTester.Text = myManageDB.getDataFromCell("ceTester", "TestCaseEditor", "ceCaseNO", tcNO);
                this.txtTestTime.Text = myManageDB.getDataFromCell("ceTestDate", "TestCaseEditor", "ceCaseNO", tcNO).Split(' ')[0];
                this.rtbPrecondition.Text = myManageDB.getDataFromCell("cePrecondition", "TestCaseEditor", "ceCaseNO", tcNO);
                this.rtbSteps.Text = myManageDB.getDataFromCell("ceSteps", "TestCaseEditor", "ceCaseNO", tcNO);
                this.rtbSamples.Text = myManageDB.getDataFromCell("ceSamples", "TestCaseEditor", "ceCaseNO", tcNO);
                this.rtbExcept.Text = myManageDB.getDataFromCell("ceExcept", "TestCaseEditor", "ceCaseNO", tcNO);
                this.txtActually.Text = myManageDB.getDataFromCell("ceActually", "TestCaseEditor", "ceCaseNO", tcNO);
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
        }
    }
}
