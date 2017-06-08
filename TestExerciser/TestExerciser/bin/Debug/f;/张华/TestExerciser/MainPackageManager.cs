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
    public partial class MainPackageManager : Skin_Mac
    {

        Object cellTempValue = new object {};
        bool needUpdate = false;
        


        public MainPackageManager()
        {
            InitializeComponent();
        }

        private void MainPackageManager_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“packageManagerDataSet.方法封装”中。您可以根据需要移动或删除它。
            this.方法封装TableAdapter.Fill(this.packageManagerDataSet.方法封装);

        }

        private void dgvPackageManager_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            cellTempValue = this.dgvPackageManager.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }

        private void dgvPackageManager_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if(!Object.Equals(cellTempValue,this.dgvPackageManager.Rows[e.RowIndex].Cells[e.ColumnIndex].Value))
            {
                needUpdate = true;
                
                if (MessageBox.Show("确定要修改该单元格内容吗？", "消息提示：", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                             
                }
                else
                {
                    this.dgvPackageManager.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = cellTempValue;
                }
            }
        }

        private void MainPackageManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (needUpdate)
            {
                OleDbConnection mycon = null;
                if (MessageBox.Show("确定修改并将修改内容保存到数据库吗？", "消息提示：", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    try
                    {
                        mycon = new OleDbConnection(ManageDB.strcon);
                        mycon.Open();
                        DataTable myDataTable = this.packageManagerDataSet.方法封装;
                        OleDbDataAdapter myDataAdapter = this.方法封装TableAdapter.Adapter;
                        OleDbCommandBuilder myOleDbCommandBuilder = new OleDbCommandBuilder(myDataAdapter);
                        myDataAdapter.Update(myDataTable);
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
                else
                {
                    e.Cancel = true;
                }
            }
        }

    }
}
