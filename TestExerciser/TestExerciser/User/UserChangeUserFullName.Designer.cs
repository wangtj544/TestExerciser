namespace TestExerciser.User
{
    partial class UserChangeUserFullName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserChangeUserFullName));
            this.txtStatus = new System.Windows.Forms.Label();
            this.btnCancel = new CCWin.SkinControl.SkinButton();
            this.btnOK = new CCWin.SkinControl.SkinButton();
            this.txtChangeTo = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.Location = new System.Drawing.Point(20, 98);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(0, 12);
            this.txtStatus.TabIndex = 27;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.DownBack = null;
            this.btnCancel.Location = new System.Drawing.Point(181, 124);
            this.btnCancel.MouseBack = null;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NormlBack = null;
            this.btnCancel.Size = new System.Drawing.Size(111, 23);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "取消修改";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.DownBack = null;
            this.btnOK.Location = new System.Drawing.Point(35, 124);
            this.btnOK.MouseBack = null;
            this.btnOK.Name = "btnOK";
            this.btnOK.NormlBack = null;
            this.btnOK.Size = new System.Drawing.Size(98, 23);
            this.btnOK.TabIndex = 30;
            this.btnOK.Text = "确定修改";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtChangeTo
            // 
            this.txtChangeTo.BackColor = System.Drawing.Color.Transparent;
            this.txtChangeTo.DownBack = null;
            this.txtChangeTo.Icon = null;
            this.txtChangeTo.IconIsButton = false;
            this.txtChangeTo.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtChangeTo.IsPasswordChat = '\0';
            this.txtChangeTo.IsSystemPasswordChar = false;
            this.txtChangeTo.Lines = new string[0];
            this.txtChangeTo.Location = new System.Drawing.Point(105, 57);
            this.txtChangeTo.Margin = new System.Windows.Forms.Padding(0);
            this.txtChangeTo.MaxLength = 32767;
            this.txtChangeTo.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtChangeTo.MouseBack = null;
            this.txtChangeTo.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtChangeTo.Multiline = false;
            this.txtChangeTo.Name = "txtChangeTo";
            this.txtChangeTo.NormlBack = null;
            this.txtChangeTo.Padding = new System.Windows.Forms.Padding(5);
            this.txtChangeTo.ReadOnly = false;
            this.txtChangeTo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtChangeTo.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.txtChangeTo.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChangeTo.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtChangeTo.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtChangeTo.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtChangeTo.SkinTxt.Name = "BaseText";
            this.txtChangeTo.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.txtChangeTo.SkinTxt.TabIndex = 0;
            this.txtChangeTo.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtChangeTo.SkinTxt.WaterText = "3-20位中文字符";
            this.txtChangeTo.TabIndex = 28;
            this.txtChangeTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtChangeTo.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtChangeTo.WaterText = "3-20位中文字符";
            this.txtChangeTo.WordWrap = true;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(31, 63);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(80, 17);
            this.skinLabel1.TabIndex = 29;
            this.skinLabel1.Text = "新用户姓名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 32;
            // 
            // UserChangeUserFullName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackPalace = ((System.Drawing.Image)(resources.GetObject("$this.BackPalace")));
            this.ClientSize = new System.Drawing.Size(345, 178);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtChangeTo);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.txtStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "UserChangeUserFullName";
            this.Text = "修改用户姓名";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserChangeUserFullName_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtStatus;
        private CCWin.SkinControl.SkinButton btnCancel;
        private CCWin.SkinControl.SkinButton btnOK;
        private CCWin.SkinControl.SkinTextBox txtChangeTo;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private System.Windows.Forms.Label label1;
    }
}