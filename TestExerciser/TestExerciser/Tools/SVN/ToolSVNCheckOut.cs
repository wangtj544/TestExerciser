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
using SharpSvn;
using System.IO;
using System.Collections;


namespace TestExerciser.Tools.SVN
{
    public partial class ToolSVNCheckOut : Skin_Mac
    {
        public ToolSVNCheckOut()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbLocalPath.Text.Length == 0 || tbRepoURI.Text.Length == 0)
            {
                this.txtStatus.ForeColor = Color.Red;
                this.txtStatus.Text = "'远程仓库 URI' 和 '本地路径' 不能为空！";
            }
            else
            {
                if (Directory.Exists(this.tbLocalPath.Text))
                {

                    SvnUpdateResult result;
                    long revision;
                    SvnCheckOutArgs args = new SvnCheckOutArgs();
                    string path = tbLocalPath.Text;
                    if (long.TryParse(tbRevision.Text, out revision))
                    {
                        //set the revision number if the user entered a valid number
                        args.Revision = new SvnRevision(revision);
                    }
                    else
                    {
                        this.txtStatus.ForeColor = Color.Red;
                        this.txtStatus.Text = "无效的版本号，默认为HEAD！";
                    }

                    using (SvnClient client = new SvnClient())
                    {                                             
                        myTimer.Start();
                        for (int i = 0; i < 100; i++)
                        {
                            System.Threading.Thread.Sleep(100);
                            progCheckOut.Value++;
                        }
                            try
                            {
                                //SvnUriTarget is a wrapper class for SVN repository URIs
                                SvnUriTarget target = new SvnUriTarget(tbRepoURI.Text);

                                //this is the where 'svn checkout' actually happens.
                                if (client.CheckOut(target, path, args, out result))
                                {                       
                                    this.txtStatus.ForeColor = Color.Green;
                                    this.txtStatus.Text = "成功检出版本：" + result.Revision + ".";
                                }
                            }
                            catch (SvnException se)
                            {
                                MessageBox.Show("版本检出异常：" + se.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            catch (UriFormatException ufe)
                            {
                                MessageBox.Show("版本检出异常：" + ufe.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                    }
                }
                else
                {
                    this.txtStatus.ForeColor = Color.Red;
                    this.txtStatus.Text = "无效的文件路径！请确认路径是否填写正确！";
                }
            }           
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
          DialogResult mySelectLocalPath = selectLocalPath.ShowDialog();
            if (mySelectLocalPath == DialogResult.OK)
            {
                this.tbLocalPath.Text = selectLocalPath.SelectedPath;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            if (this.progCheckOut.Value < this.progCheckOut.Maximum)
            {
                this.progCheckOut.PerformStep();
            }
        }
    }
}
