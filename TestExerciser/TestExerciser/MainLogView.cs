using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CCWin;

namespace TestExerciser
{
    public partial class MainLogView : Skin_Mac
    {
        public MainLogView()
        {
            InitializeComponent();
        }

        private void MainLogView_Load(object sender, EventArgs e)
        {            
            if (Directory.Exists(MainForm.rootFolder + @"\.log"))
            {
                string[] logFileName = Directory.GetFiles(MainForm.rootFolder + @"\.log", "*.html");
                logView.Navigate(logFileName[0]);
            }
            else
            {
                MessageBox.Show("请确认log文件是否生成！", "消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
