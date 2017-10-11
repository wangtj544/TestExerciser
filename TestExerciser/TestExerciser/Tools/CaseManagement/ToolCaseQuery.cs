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
    public delegate void SetToolCaseQuery();

    public partial class ToolCaseQuery : Skin_Mac
    {
        public static string mySelectedItem;
        ManageDB myManageDB = new ManageDB();
        MainCaseManager myMainCaseManager = new MainCaseManager();

        //定义委托事件
        public event SetToolCaseQuery SetToolCaseQuerySelected;

        public ToolCaseQuery()
        {
            InitializeComponent();
            this.SetToolCaseQuerySelected += new SetToolCaseQuery(myMainCaseManager.d_SetdgvCaseManagerSelectedItem);
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
            if (myManageDB.checkItem("ceCaseNO", "TestCaseEditor", this.tb_QueryItems.Text))
            {
                this.txtStatus.ForeColor = Color.Green;
                this.txtStatus.Text = "查询结果：查询成功！";
                mySelectedItem = this.tb_QueryItems.Text;
                this.SetToolCaseQuerySelected();
            }
            else
            {
                this.txtStatus.ForeColor = Color.Red;
                this.txtStatus.Text = "查询结果：未能查询到此用例！";
            }
        }
    }
}
