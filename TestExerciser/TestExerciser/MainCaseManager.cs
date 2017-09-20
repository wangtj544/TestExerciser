﻿using System;
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
        public MainCaseManager()
        {
            InitializeComponent();
            fillToDataGridViewControl();
        }


        ManageDB myManageDB = new ManageDB();

        private void btnNew_Click(object sender, EventArgs e)
        {
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
                    new DataColumn("更新日期"),
                    new DataColumn("隐藏信息列")
                });
            for (int i = 0; i < myManageDB.countNum("ceCaseNO", "用例编写"); i++)
            {
                DataRow row = dt.NewRow();
                row[0] = "名称" + (i + 1);
                row[1] = i % 2 == 0 ? "超级管理员" : "管理员";
                row[3] = DateTime.Now.ToString("yyyy/MM/dd");
                row[4] = DateTime.Now.AddDays(i).ToString("yyyy/MM/dd");
                row[5] = "客户已经同意与（某某" + (i + 1) + " " + (i + 1) + "小时前）";
                dt.Rows.Add(row);
            }
            dgvCaseManager.ColumnCount = 5;
            for (int i = 0; i < 5; i++)
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

        private class DataGridViewRenderer
        {
            //行高
            private const int ROW_HEIGHT = 70;
            //目标DataGridView
            private DataGridView dataGridView;
            //需要自定义绘制的列
            private DataGridViewColumn hiddenColumn;
            //记录上一次选择的行，用于行索引改变时重绘该行而不是重绘整个控件画面
            private int preRowIndex = 0;
            //小图标
            private Bitmap icon1;
            private Bitmap icon2;

            public DataGridViewRenderer(DataGridView dataGridView, DataGridViewColumn hiddenColumn = null)
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
                Padding newPadding = new Padding(0, 1, 0, ROW_HEIGHT - 30);
                dataGridView.RowTemplate.DefaultCellStyle.Padding = newPadding;
                dataGridView.AllowUserToAddRows = false;
                //设置无单元格边框
                dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
                //单元格选择模式为全选
                dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
                //设置字体样式
                dataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;
                dataGridView.DefaultCellStyle.ForeColor = Color.DimGray;
                //设置选中行背景色，需要绘制自定义背景应该在RowPrePaint处理，并设置该属性为Color.Transparent;
                dataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.Orange;
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
                icon1 = Properties.Resources._0;
                icon2 = Properties.Resources._0;
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
                        e.Graphics.DrawImage(icon2, new Rectangle(textBounds.X + icon1.Width + 10, textBounds.Y, icon2.Width, icon2.Height));
                        textBounds.X += icon1.Width * 2 + 15;
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
    }
}
