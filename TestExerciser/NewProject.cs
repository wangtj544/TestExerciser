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

namespace TestExerciser
{
    public partial class NewProject : Form
    {
        

        public NewProject()
        {
            InitializeComponent();
        }

        private void openProjectLocation_Click(object sender, EventArgs e)
        {
            if (selectNewFolder.ShowDialog() == DialogResult.OK)
            {
                txtProjectLocation.Text = selectNewFolder.SelectedPath;
            }
        }

        public void btn_newProjectOK_Click(object sender, EventArgs e)
        {
            
            try
            {

                if (("" == txtProjectName.Text)||(null == txtProjectName.Text))
                {
                    MessageBox.Show("项目名称不能为空！");
                }
                else if (txtProjectName.Text.Contains("~") || txtProjectName.Text.Contains("!") || txtProjectName.Text.Contains("@") || txtProjectName.Text.Contains("#") || txtProjectName.Text.Contains("$") || txtProjectName.Text.Contains("%") || txtProjectName.Text.Contains("^") || txtProjectName.Text.Contains("&") || txtProjectName.Text.Contains("*") || txtProjectName.Text.Contains("+") || txtProjectName.Text.Contains("-") || txtProjectName.Text.Contains(" ") || txtProjectName.Text.Contains(",") || txtProjectName.Text.Contains(".") || txtProjectName.Text.Contains("，") || txtProjectName.Text.Contains("。"))
                {
                    MessageBox.Show("项目名称不能包含“~，！，@，#，￥，%，^，&，*，（，），-，+，”");
                }
                else if (("" == txtProjectLocation.Text) || (null == txtProjectLocation.Text))
                {
                    MessageBox.Show("路径名称不能为空！");
                }               
                else if (txtProjectLocation.Text.Contains("~") || txtProjectLocation.Text.Contains("!") || txtProjectLocation.Text.Contains("@") || txtProjectLocation.Text.Contains("#") || txtProjectLocation.Text.Contains("$") || txtProjectLocation.Text.Contains("%") || txtProjectLocation.Text.Contains("^") || txtProjectLocation.Text.Contains("&") || txtProjectLocation.Text.Contains("*") || txtProjectLocation.Text.Contains("+") || txtProjectLocation.Text.Contains("-") || txtProjectLocation.Text.Contains(" ") || txtProjectLocation.Text.Contains(",") || txtProjectLocation.Text.Contains(".") || txtProjectLocation.Text.Contains("，") || txtProjectLocation.Text.Contains("。"))
                {
                    MessageBox.Show("路径名称不能包含“~，！，@，#，￥，%，^，&，*，（，），-，+，”");
                }
                else 
                {
                    bool folderExists = Directory.Exists(txtProjectLocation.Text);
                    if (folderExists == false)
                    {
                        MessageBox.Show("请填写正确的路径！");
                    }
                    else
                    {
                        MainForm main_Form = new MainForm();
                        this.Visible = false;
                        MessageBox.Show(txtProjectName.Text.ToString());

                    }
                  
                }            
                
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.ToString(),"异常消息提示：");
            }
            
        }

        private void btn_newProjectCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Visible = false; 
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), "异常消息提示：");
            }
        }
       
    }
}
