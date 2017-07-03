namespace TestExerciser.Tools
{
    partial class ToolSelectDB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolSelectDB));
            this.btnOK = new CCWin.SkinControl.SkinButton();
            this.btnCancel = new CCWin.SkinControl.SkinButton();
            this.labSelectDB = new CCWin.SkinControl.SkinLabel();
            this.txtStatus = new System.Windows.Forms.Label();
            this.srbLocalDB = new CCWin.SkinControl.SkinRadioButton();
            this.srbServerDB = new CCWin.SkinControl.SkinRadioButton();
            this.txtServerDBPath = new CCWin.SkinControl.SkinTextBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.DownBack = null;
            this.btnOK.Location = new System.Drawing.Point(45, 205);
            this.btnOK.MouseBack = null;
            this.btnOK.Name = "btnOK";
            this.btnOK.NormlBack = null;
            this.btnOK.Size = new System.Drawing.Size(98, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "重新登录";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.DownBack = null;
            this.btnCancel.Location = new System.Drawing.Point(194, 205);
            this.btnCancel.MouseBack = null;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NormlBack = null;
            this.btnCancel.Size = new System.Drawing.Size(111, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消登录";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labSelectDB
            // 
            this.labSelectDB.AutoSize = true;
            this.labSelectDB.BackColor = System.Drawing.Color.Transparent;
            this.labSelectDB.BorderColor = System.Drawing.Color.White;
            this.labSelectDB.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labSelectDB.Location = new System.Drawing.Point(29, 44);
            this.labSelectDB.Name = "labSelectDB";
            this.labSelectDB.Size = new System.Drawing.Size(128, 17);
            this.labSelectDB.TabIndex = 7;
            this.labSelectDB.Text = "您需要初始化数据库：";
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.Location = new System.Drawing.Point(20, 172);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(0, 12);
            this.txtStatus.TabIndex = 8;
            // 
            // srbLocalDB
            // 
            this.srbLocalDB.AutoSize = true;
            this.srbLocalDB.BackColor = System.Drawing.Color.Transparent;
            this.srbLocalDB.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.srbLocalDB.DownBack = null;
            this.srbLocalDB.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.srbLocalDB.Location = new System.Drawing.Point(121, 76);
            this.srbLocalDB.MouseBack = null;
            this.srbLocalDB.Name = "srbLocalDB";
            this.srbLocalDB.NormlBack = null;
            this.srbLocalDB.SelectedDownBack = null;
            this.srbLocalDB.SelectedMouseBack = null;
            this.srbLocalDB.SelectedNormlBack = null;
            this.srbLocalDB.Size = new System.Drawing.Size(86, 21);
            this.srbLocalDB.TabIndex = 9;
            this.srbLocalDB.TabStop = true;
            this.srbLocalDB.Text = "本地数据库";
            this.srbLocalDB.UseVisualStyleBackColor = false;
            // 
            // srbServerDB
            // 
            this.srbServerDB.AutoSize = true;
            this.srbServerDB.BackColor = System.Drawing.Color.Transparent;
            this.srbServerDB.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.srbServerDB.DownBack = null;
            this.srbServerDB.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.srbServerDB.Location = new System.Drawing.Point(121, 106);
            this.srbServerDB.MouseBack = null;
            this.srbServerDB.Name = "srbServerDB";
            this.srbServerDB.NormlBack = null;
            this.srbServerDB.SelectedDownBack = null;
            this.srbServerDB.SelectedMouseBack = null;
            this.srbServerDB.SelectedNormlBack = null;
            this.srbServerDB.Size = new System.Drawing.Size(86, 21);
            this.srbServerDB.TabIndex = 10;
            this.srbServerDB.TabStop = true;
            this.srbServerDB.Text = "远程数据库";
            this.srbServerDB.UseVisualStyleBackColor = false;
            this.srbServerDB.CheckedChanged += new System.EventHandler(this.srbServerDB_CheckedChanged);
            // 
            // txtServerDBPath
            // 
            this.txtServerDBPath.BackColor = System.Drawing.Color.Transparent;
            this.txtServerDBPath.DownBack = null;
            this.txtServerDBPath.Icon = null;
            this.txtServerDBPath.IconIsButton = false;
            this.txtServerDBPath.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtServerDBPath.IsPasswordChat = '\0';
            this.txtServerDBPath.IsSystemPasswordChar = false;
            this.txtServerDBPath.Lines = new string[0];
            this.txtServerDBPath.Location = new System.Drawing.Point(55, 136);
            this.txtServerDBPath.Margin = new System.Windows.Forms.Padding(0);
            this.txtServerDBPath.MaxLength = 32767;
            this.txtServerDBPath.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtServerDBPath.MouseBack = null;
            this.txtServerDBPath.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtServerDBPath.Multiline = false;
            this.txtServerDBPath.Name = "txtServerDBPath";
            this.txtServerDBPath.NormlBack = null;
            this.txtServerDBPath.Padding = new System.Windows.Forms.Padding(5);
            this.txtServerDBPath.ReadOnly = false;
            this.txtServerDBPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtServerDBPath.Size = new System.Drawing.Size(236, 28);
            // 
            // 
            // 
            this.txtServerDBPath.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServerDBPath.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtServerDBPath.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtServerDBPath.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtServerDBPath.SkinTxt.Name = "BaseText";
            this.txtServerDBPath.SkinTxt.Size = new System.Drawing.Size(226, 18);
            this.txtServerDBPath.SkinTxt.TabIndex = 0;
            this.txtServerDBPath.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtServerDBPath.SkinTxt.WaterText = "请填写数据库路径...";
            this.txtServerDBPath.TabIndex = 11;
            this.txtServerDBPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtServerDBPath.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtServerDBPath.WaterText = "请填写数据库路径...";
            this.txtServerDBPath.WordWrap = true;
            // 
            // ToolSelectDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackPalace = ((System.Drawing.Image)(resources.GetObject("$this.BackPalace")));
            this.ClientSize = new System.Drawing.Size(345, 254);
            this.Controls.Add(this.srbServerDB);
            this.Controls.Add(this.srbLocalDB);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.labSelectDB);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ToolSelectDB";
            this.Text = "初始化数据库";
            this.TitleSuitColor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton btnOK;
        private CCWin.SkinControl.SkinButton btnCancel;
        private CCWin.SkinControl.SkinLabel labSelectDB;
        private System.Windows.Forms.Label txtStatus;
        public CCWin.SkinControl.SkinTextBox txtServerDBPath;
        public CCWin.SkinControl.SkinRadioButton srbLocalDB;
        public CCWin.SkinControl.SkinRadioButton srbServerDB;
    }
}