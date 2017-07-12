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


namespace TestExerciser
{
    public partial class MainTeamMembers : Skin_Mac
    {
        public MainTeamMembers()
        {
            InitializeComponent();

        }

        private void MainTeamMembers_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“dataSetTeamMembers.用户信息”中。您可以根据需要移动或删除它。
            this.用户管理TableAdapter.Fill(this.dataSetTeamMembers.用户管理);

        }
    }
}
