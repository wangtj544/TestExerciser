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
using CCWin.SkinControl;
using TestExerciser.User;

namespace TestExerciser.Tools
{
    public partial class ToolManager : Skin_Mac
    {
        GroupBox gbSelectDB = new GroupBox();
        RadioButton radbLocal = new RadioButton();
        RadioButton radbServer = new RadioButton();
        Label labDetails = new Label();
        SkinTextBox stbServerDBPath = new SkinTextBox();

        public static string strcon = ToolSelectDB.strcon;

        string operate = null;

        public ToolManager()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            switch(this.operate)
            {
                case null:
                    this.txtStatus.ForeColor = Color.Red;
                    this.txtStatus.Text = "设置信息：设置失败，请选择正确的节点！";
                    break;

                case "tnAccess":
                    if (radbServer.Checked == true)
                    {
                        if (this.stbServerDBPath.Text != "")
                        {
                            //配置为远程服务器上的数据库                        
                            strcon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+ this.stbServerDBPath.Text.ToString()+ ";Jet OLEDB:Database Password=admin@123";
                            Properties.Settings.Default.isLocalAccessDB = false;
                            this.txtStatus.ForeColor = Color.Green;
                            this.txtStatus.Text = "设置信息：设置成功，更改为远程服务器数据库连接！关闭并重启软件后生效！";

                        }
                        else
                        {
                            this.txtStatus.ForeColor = Color.Red;
                            this.txtStatus.Text = "设置信息：设置失败，请填写远程服务器上数据库文件路径！";
                        }
                    }
                    else if(radbLocal.Checked==true)
                    {
                        Properties.Settings.Default.isLocalAccessDB = true;
                        this.txtStatus.ForeColor = Color.Green;
                        this.txtStatus.Text = "设置信息：设置成功，更改为本地数据库连接！关闭并重启软件后生效！";
                    }
                    Properties.Settings.Default.ConnectionString = strcon;
                    Properties.Settings.Default.Save();
                    break;
            }            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
        }

        private void tvItems_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (this.tvItems.SelectedNode != null)
            {
                if (this.tvItems.SelectedNode.Name == "tnAccess")
                {                  
                    this.spCMain.Panel2.Controls.Add(this.gbSelectDB);
                    // 
                    // gbSelectDB
                    //                     
                    this.gbSelectDB.Controls.Add(labDetails);
                    this.gbSelectDB.Controls.Add(radbLocal);
                    this.gbSelectDB.Controls.Add(radbServer);
                    this.gbSelectDB.Location = new System.Drawing.Point(17, 14);
                    this.gbSelectDB.Name = "gbSelectDB";
                    this.gbSelectDB.Size = new System.Drawing.Size(405, 369);
                    this.gbSelectDB.TabIndex = 0;
                    this.gbSelectDB.TabStop = false;
                    this.gbSelectDB.Text = "选择Access数据库：";

                    // 
                    // labDetails
                    // 
                    this.labDetails.AutoSize = true;
                    this.labDetails.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    this.labDetails.ForeColor = System.Drawing.Color.Red;
                    this.labDetails.Location = new System.Drawing.Point(6, 338);
                    this.labDetails.Name = "labDetails";
                    this.labDetails.Size = new System.Drawing.Size(259, 12);
                    this.labDetails.TabIndex = 18;
                    this.labDetails.Text = "*提示：选择数据库后，需要关闭并重启软件才能生效！";
                    // 
                    // radbLocal
                    // 
                    this.radbLocal.AutoSize = true;
                    this.radbLocal.Location = new System.Drawing.Point(45, 38);
                    this.radbLocal.Name = "radbLocal";
                    this.radbLocal.Size = new System.Drawing.Size(47, 16);
                    this.radbLocal.TabIndex = 16;
                    this.radbLocal.Text = "本地";
                    this.radbLocal.UseVisualStyleBackColor = true;               
                    // 
                    // radbServer
                    // 
                    this.radbServer.AutoSize = true;
                    this.radbServer.Location = new System.Drawing.Point(45, 76);
                    this.radbServer.Name = "radbServer";
                    this.radbServer.Size = new System.Drawing.Size(83, 16);
                    this.radbServer.TabIndex = 17;
                    this.radbServer.Text = "远程服务器";
                    this.radbServer.UseVisualStyleBackColor = true;
                    this.radbServer.CheckedChanged += new System.EventHandler(this.radbServer_CheckedChanged);
                    this.operate = "tnAccess";
                    // 
                    // stbServerDBPath
                    // 
                    this.stbServerDBPath.BackColor = System.Drawing.Color.Transparent;
                    this.stbServerDBPath.DownBack = null;
                    this.stbServerDBPath.Icon = null;
                    this.stbServerDBPath.IconIsButton = false;
                    this.stbServerDBPath.IconMouseState = CCWin.SkinClass.ControlState.Normal;
                    this.stbServerDBPath.IsPasswordChat = '\0';
                    this.stbServerDBPath.IsSystemPasswordChar = false;
                    this.stbServerDBPath.Lines = new string[0];
                    this.stbServerDBPath.Location = new System.Drawing.Point(45, 105);
                    this.stbServerDBPath.Margin = new System.Windows.Forms.Padding(0);
                    this.stbServerDBPath.MaxLength = 32767;
                    this.stbServerDBPath.MinimumSize = new System.Drawing.Size(28, 28);
                    this.stbServerDBPath.MouseBack = null;
                    this.stbServerDBPath.MouseState = CCWin.SkinClass.ControlState.Normal;
                    this.stbServerDBPath.Multiline = true;
                    this.stbServerDBPath.Name = "stbServerDBPath";
                    this.stbServerDBPath.NormlBack = null;
                    this.stbServerDBPath.Padding = new System.Windows.Forms.Padding(5);
                    this.stbServerDBPath.ReadOnly = false;
                    this.stbServerDBPath.ScrollBars = System.Windows.Forms.ScrollBars.Both;
                    this.stbServerDBPath.Size = new System.Drawing.Size(321, 148);
                    // 
                    // 
                    // 
                    this.stbServerDBPath.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    this.stbServerDBPath.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
                    this.stbServerDBPath.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
                    this.stbServerDBPath.SkinTxt.Location = new System.Drawing.Point(5, 5);
                    this.stbServerDBPath.SkinTxt.Multiline = true;
                    this.stbServerDBPath.SkinTxt.Name = "BaseText";
                    this.stbServerDBPath.SkinTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
                    this.stbServerDBPath.SkinTxt.Size = new System.Drawing.Size(311, 138);
                    this.stbServerDBPath.SkinTxt.TabIndex = 0;
                    this.stbServerDBPath.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
                    this.stbServerDBPath.SkinTxt.WaterText = "\\\\172.20.32.147\\data\\TestExerciser.accdb";
                    this.stbServerDBPath.TabIndex = 20;
                    this.stbServerDBPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
                    this.stbServerDBPath.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
                    this.stbServerDBPath.WaterText = "\\\\172.20.32.147\\data\\TestExerciser.accdb";
                    this.stbServerDBPath.WordWrap = true;
                }
                else
                {
                    this.spCMain.Panel2.Controls.Remove(this.gbSelectDB);
                }
            }
        }

        private void radbServer_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radbServer.Checked == true)
            {
                this.gbSelectDB.Controls.Add(stbServerDBPath);
            }
            else
            {
                this.gbSelectDB.Controls.Remove(stbServerDBPath);
            }            
        }

        /// <summary>
        /// 仅仅适用于服务器路径选取
        /// </summary>
        /// <param name="stbText"></param>
        /// <returns></returns>
        private string realPath(SkinTextBox stbText)
        {
            string realstr = "\\";
            string str = stbText.Text.ToString();
            string[] mystr = str.Split('\\');
            foreach (string i in mystr)
            {
                if (i != "")
                {
                    if (i != mystr[mystr.Length - 1])
                    {
                        realstr = realstr + i + "\\";
                    }
                    else
                    {
                        realstr = realstr + i;
                    }
                }
            }
            return realstr;
        }

        private void ToolManager_Load(object sender, EventArgs e)
        {
            this.tvItems.ExpandAll();
            if (Properties.Settings.Default.isLocalAccessDB == true)
            {
                this.radbLocal.Checked = true;
            }
            else
            {
                this.radbServer.Checked = true;
            }
        }
    }
}
