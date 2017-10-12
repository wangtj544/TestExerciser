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


namespace TestExerciser.Tools.CaseManagement
{
    public delegate void SetMainCaseManager();

    public partial class ToolCaseQuery : Skin_Mac
    {
        public static string mySelectedItem;
        ManageDB myManageDB = new ManageDB();

        public event SetMainCaseManager UpdateAfterQuery;
        public event SetMainCaseManager DataGridViewSeletedItem;

        public ToolCaseQuery()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.searchQueryItems();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
        }

        private void searchQueryItems()
        {
            if (myManageDB.checkItem("ceCaseNO", "CaseManager", this.tb_QueryItems.Text))
            {               
                this.txtStatus.ForeColor = Color.Green;
                this.txtStatus.Text = "查询结果：查询成功！";
                mySelectedItem = this.tb_QueryItems.Text;
                this.Visible = false;
                this.Close();
                this.UpdateAfterQuery();
                this.DataGridViewSeletedItem();
            }
            else
            {
                this.txtStatus.ForeColor = Color.Red;
                this.txtStatus.Text = "查询结果：未能查询到此用例！";
            }
        }

        private void ToolCaseQuery_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.searchQueryItems();
            }
        }
    }
}
