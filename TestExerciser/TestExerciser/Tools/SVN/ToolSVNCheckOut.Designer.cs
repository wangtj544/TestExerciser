namespace TestExerciser.Tools.SVN
{
    partial class ToolSVNCheckOut
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolSVNCheckOut));
            this.btnCancel = new CCWin.SkinControl.SkinButton();
            this.btnOK = new CCWin.SkinControl.SkinButton();
            this.lblRepoURI = new System.Windows.Forms.Label();
            this.lblLocalPath = new System.Windows.Forms.Label();
            this.lblRevision = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.selectLocalPath = new System.Windows.Forms.FolderBrowserDialog();
            this.progCheckOut = new CCWin.SkinControl.SkinProgressBar();
            this.myTimer = new System.Windows.Forms.Timer(this.components);
            this.tbLocalPath = new CCWin.SkinControl.SkinTextBox();
            this.tbRevision = new CCWin.SkinControl.SkinTextBox();
            this.tbRepoURI = new CCWin.SkinControl.SkinTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.DownBack = null;
            this.btnCancel.Location = new System.Drawing.Point(246, 92);
            this.btnCancel.MouseBack = null;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NormlBack = null;
            this.btnCancel.Size = new System.Drawing.Size(130, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnOK.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOK.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.DownBack = null;
            this.btnOK.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnOK.Location = new System.Drawing.Point(68, 92);
            this.btnOK.MouseBack = null;
            this.btnOK.Name = "btnOK";
            this.btnOK.NormlBack = null;
            this.btnOK.Size = new System.Drawing.Size(130, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "检出";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblRepoURI
            // 
            this.lblRepoURI.AutoSize = true;
            this.lblRepoURI.Location = new System.Drawing.Point(12, 21);
            this.lblRepoURI.Name = "lblRepoURI";
            this.lblRepoURI.Size = new System.Drawing.Size(77, 12);
            this.lblRepoURI.TabIndex = 9;
            this.lblRepoURI.Text = "远程仓库URI:";
            // 
            // lblLocalPath
            // 
            this.lblLocalPath.AutoSize = true;
            this.lblLocalPath.Location = new System.Drawing.Point(13, 83);
            this.lblLocalPath.Name = "lblLocalPath";
            this.lblLocalPath.Size = new System.Drawing.Size(59, 12);
            this.lblLocalPath.TabIndex = 10;
            this.lblLocalPath.Text = "本地路径:";
            // 
            // lblRevision
            // 
            this.lblRevision.AutoSize = true;
            this.lblRevision.Location = new System.Drawing.Point(13, 141);
            this.lblRevision.Name = "lblRevision";
            this.lblRevision.Size = new System.Drawing.Size(59, 12);
            this.lblRevision.TabIndex = 11;
            this.lblRevision.Text = "版本信息:";
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.Location = new System.Drawing.Point(13, 61);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(0, 12);
            this.txtStatus.TabIndex = 15;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(9, 26);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(59, 12);
            this.lblProgress.TabIndex = 16;
            this.lblProgress.Text = "检出进度:";
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(399, 101);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(31, 28);
            this.btnSelectFolder.TabIndex = 18;
            this.btnSelectFolder.Text = "...";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // progCheckOut
            // 
            this.progCheckOut.Back = null;
            this.progCheckOut.BackColor = System.Drawing.Color.Transparent;
            this.progCheckOut.BarBack = null;
            this.progCheckOut.BarRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.progCheckOut.ForeColor = System.Drawing.Color.Red;
            this.progCheckOut.Location = new System.Drawing.Point(67, 20);
            this.progCheckOut.Name = "progCheckOut";
            this.progCheckOut.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.progCheckOut.Size = new System.Drawing.Size(359, 23);
            this.progCheckOut.TabIndex = 19;
            this.progCheckOut.TrackFore = System.Drawing.Color.Moccasin;
            // 
            // myTimer
            // 
            this.myTimer.Tick += new System.EventHandler(this.myTimer_Tick);
            // 
            // tbLocalPath
            // 
            this.tbLocalPath.BackColor = System.Drawing.Color.Transparent;
            this.tbLocalPath.DownBack = null;
            this.tbLocalPath.Icon = null;
            this.tbLocalPath.IconIsButton = false;
            this.tbLocalPath.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tbLocalPath.IsPasswordChat = '\0';
            this.tbLocalPath.IsSystemPasswordChar = false;
            this.tbLocalPath.Lines = new string[0];
            this.tbLocalPath.Location = new System.Drawing.Point(14, 101);
            this.tbLocalPath.Margin = new System.Windows.Forms.Padding(0);
            this.tbLocalPath.MaxLength = 32767;
            this.tbLocalPath.MinimumSize = new System.Drawing.Size(28, 28);
            this.tbLocalPath.MouseBack = null;
            this.tbLocalPath.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tbLocalPath.Multiline = false;
            this.tbLocalPath.Name = "tbLocalPath";
            this.tbLocalPath.NormlBack = null;
            this.tbLocalPath.Padding = new System.Windows.Forms.Padding(5);
            this.tbLocalPath.ReadOnly = false;
            this.tbLocalPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbLocalPath.Size = new System.Drawing.Size(382, 28);
            // 
            // 
            // 
            this.tbLocalPath.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLocalPath.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLocalPath.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tbLocalPath.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tbLocalPath.SkinTxt.Name = "BaseText";
            this.tbLocalPath.SkinTxt.Size = new System.Drawing.Size(372, 18);
            this.tbLocalPath.SkinTxt.TabIndex = 0;
            this.tbLocalPath.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbLocalPath.SkinTxt.WaterText = "请填写要检出的路径...";
            this.tbLocalPath.TabIndex = 21;
            this.tbLocalPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbLocalPath.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbLocalPath.WaterText = "请填写要检出的路径...";
            this.tbLocalPath.WordWrap = true;
            // 
            // tbRevision
            // 
            this.tbRevision.BackColor = System.Drawing.Color.Transparent;
            this.tbRevision.DownBack = null;
            this.tbRevision.Icon = null;
            this.tbRevision.IconIsButton = false;
            this.tbRevision.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tbRevision.IsPasswordChat = '\0';
            this.tbRevision.IsSystemPasswordChar = false;
            this.tbRevision.Lines = new string[0];
            this.tbRevision.Location = new System.Drawing.Point(14, 161);
            this.tbRevision.Margin = new System.Windows.Forms.Padding(0);
            this.tbRevision.MaxLength = 32767;
            this.tbRevision.MinimumSize = new System.Drawing.Size(28, 28);
            this.tbRevision.MouseBack = null;
            this.tbRevision.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tbRevision.Multiline = false;
            this.tbRevision.Name = "tbRevision";
            this.tbRevision.NormlBack = null;
            this.tbRevision.Padding = new System.Windows.Forms.Padding(5);
            this.tbRevision.ReadOnly = false;
            this.tbRevision.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbRevision.Size = new System.Drawing.Size(139, 28);
            // 
            // 
            // 
            this.tbRevision.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRevision.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRevision.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tbRevision.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tbRevision.SkinTxt.Name = "BaseText";
            this.tbRevision.SkinTxt.Size = new System.Drawing.Size(129, 18);
            this.tbRevision.SkinTxt.TabIndex = 0;
            this.tbRevision.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbRevision.SkinTxt.WaterText = "请填写需要检出的版本...";
            this.tbRevision.TabIndex = 22;
            this.tbRevision.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbRevision.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbRevision.WaterText = "请填写需要检出的版本...";
            this.tbRevision.WordWrap = true;
            // 
            // tbRepoURI
            // 
            this.tbRepoURI.BackColor = System.Drawing.Color.Transparent;
            this.tbRepoURI.DownBack = null;
            this.tbRepoURI.Icon = null;
            this.tbRepoURI.IconIsButton = false;
            this.tbRepoURI.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tbRepoURI.IsPasswordChat = '\0';
            this.tbRepoURI.IsSystemPasswordChar = false;
            this.tbRepoURI.Lines = new string[0];
            this.tbRepoURI.Location = new System.Drawing.Point(14, 43);
            this.tbRepoURI.Margin = new System.Windows.Forms.Padding(0);
            this.tbRepoURI.MaxLength = 32767;
            this.tbRepoURI.MinimumSize = new System.Drawing.Size(28, 28);
            this.tbRepoURI.MouseBack = null;
            this.tbRepoURI.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tbRepoURI.Multiline = false;
            this.tbRepoURI.Name = "tbRepoURI";
            this.tbRepoURI.NormlBack = null;
            this.tbRepoURI.Padding = new System.Windows.Forms.Padding(5);
            this.tbRepoURI.ReadOnly = false;
            this.tbRepoURI.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbRepoURI.Size = new System.Drawing.Size(414, 28);
            // 
            // 
            // 
            this.tbRepoURI.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbRepoURI.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRepoURI.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tbRepoURI.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tbRepoURI.SkinTxt.Name = "BaseText";
            this.tbRepoURI.SkinTxt.Size = new System.Drawing.Size(404, 18);
            this.tbRepoURI.SkinTxt.TabIndex = 0;
            this.tbRepoURI.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbRepoURI.SkinTxt.WaterText = "请填写要检出的路径...";
            this.tbRepoURI.TabIndex = 24;
            this.tbRepoURI.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbRepoURI.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbRepoURI.WaterText = "请填写要检出的路径...";
            this.tbRepoURI.WordWrap = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbRepoURI);
            this.groupBox1.Controls.Add(this.tbRevision);
            this.groupBox1.Controls.Add(this.lblRepoURI);
            this.groupBox1.Controls.Add(this.tbLocalPath);
            this.groupBox1.Controls.Add(this.btnSelectFolder);
            this.groupBox1.Controls.Add(this.lblRevision);
            this.groupBox1.Controls.Add(this.lblLocalPath);
            this.groupBox1.Location = new System.Drawing.Point(16, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 197);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "检出设置";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(18, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 226);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "检出过程";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.progCheckOut);
            this.groupBox3.Controls.Add(this.btnOK);
            this.groupBox3.Controls.Add(this.btnCancel);
            this.groupBox3.Controls.Add(this.lblProgress);
            this.groupBox3.Controls.Add(this.txtStatus);
            this.groupBox3.Location = new System.Drawing.Point(18, 487);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(446, 131);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "检出结果";
            // 
            // ToolSVNCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackPalace = ((System.Drawing.Image)(resources.GetObject("$this.BackPalace")));
            this.ClientSize = new System.Drawing.Size(479, 650);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ToolSVNCheckOut";
            this.Text = "SVN 检出";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinButton btnCancel;
        private CCWin.SkinControl.SkinButton btnOK;
        private System.Windows.Forms.Label lblRepoURI;
        private System.Windows.Forms.Label lblLocalPath;
        private System.Windows.Forms.Label lblRevision;
        private System.Windows.Forms.Label txtStatus;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.FolderBrowserDialog selectLocalPath;
        private CCWin.SkinControl.SkinProgressBar progCheckOut;
        private System.Windows.Forms.Timer myTimer;
        private CCWin.SkinControl.SkinTextBox tbLocalPath;
        private CCWin.SkinControl.SkinTextBox tbRevision;
        private CCWin.SkinControl.SkinTextBox tbRepoURI;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}