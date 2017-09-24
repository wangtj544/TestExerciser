namespace TestExerciser.Tools.ProjectManagement
{
    partial class ToolProjectStructTopNodesEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolProjectStructTopNodesEditor));
            this.btnCancel = new CCWin.SkinControl.SkinButton();
            this.btnOK = new CCWin.SkinControl.SkinButton();
            this.stbFolderName = new CCWin.SkinControl.SkinTextBox();
            this.labTopNodeName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCancel.DownBack = null;
            this.btnCancel.Location = new System.Drawing.Point(282, 149);
            this.btnCancel.MouseBack = null;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NormlBack = null;
            this.btnCancel.Size = new System.Drawing.Size(111, 23);
            this.btnCancel.TabIndex = 57;
            this.btnCancel.Text = "取消新建";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnOK.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnOK.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnOK.DownBack = null;
            this.btnOK.Location = new System.Drawing.Point(133, 149);
            this.btnOK.MouseBack = null;
            this.btnOK.Name = "btnOK";
            this.btnOK.NormlBack = null;
            this.btnOK.Size = new System.Drawing.Size(98, 23);
            this.btnOK.TabIndex = 56;
            this.btnOK.Text = "确定新建";
            this.btnOK.UseVisualStyleBackColor = false;
            // 
            // stbFolderName
            // 
            this.stbFolderName.BackColor = System.Drawing.Color.Transparent;
            this.stbFolderName.DownBack = null;
            this.stbFolderName.Icon = null;
            this.stbFolderName.IconIsButton = false;
            this.stbFolderName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.stbFolderName.IsPasswordChat = '\0';
            this.stbFolderName.IsSystemPasswordChar = false;
            this.stbFolderName.Lines = new string[0];
            this.stbFolderName.Location = new System.Drawing.Point(129, 67);
            this.stbFolderName.Margin = new System.Windows.Forms.Padding(0);
            this.stbFolderName.MaxLength = 32767;
            this.stbFolderName.MinimumSize = new System.Drawing.Size(24, 24);
            this.stbFolderName.MouseBack = null;
            this.stbFolderName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.stbFolderName.Multiline = false;
            this.stbFolderName.Name = "stbFolderName";
            this.stbFolderName.NormlBack = null;
            this.stbFolderName.Padding = new System.Windows.Forms.Padding(4);
            this.stbFolderName.ReadOnly = false;
            this.stbFolderName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.stbFolderName.Size = new System.Drawing.Size(334, 24);
            // 
            // 
            // 
            this.stbFolderName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stbFolderName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stbFolderName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.stbFolderName.SkinTxt.Location = new System.Drawing.Point(4, 4);
            this.stbFolderName.SkinTxt.Name = "BaseText";
            this.stbFolderName.SkinTxt.Size = new System.Drawing.Size(326, 18);
            this.stbFolderName.SkinTxt.TabIndex = 0;
            this.stbFolderName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.stbFolderName.SkinTxt.WaterText = "不得超过7个汉字，或14个字节(数字，字母和下划线)";
            this.stbFolderName.TabIndex = 55;
            this.stbFolderName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.stbFolderName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.stbFolderName.WaterText = "不得超过7个汉字，或14个字节(数字，字母和下划线)";
            this.stbFolderName.WordWrap = true;
            // 
            // labTopNodeName
            // 
            this.labTopNodeName.AutoSize = true;
            this.labTopNodeName.Location = new System.Drawing.Point(49, 72);
            this.labTopNodeName.Name = "labTopNodeName";
            this.labTopNodeName.Size = new System.Drawing.Size(77, 12);
            this.labTopNodeName.TabIndex = 54;
            this.labTopNodeName.Text = "根节点名称：";
            // 
            // ToolProjectStructTopNodesEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 204);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.stbFolderName);
            this.Controls.Add(this.labTopNodeName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ToolProjectStructTopNodesEditor";
            this.Text = "编辑根";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton btnCancel;
        private CCWin.SkinControl.SkinButton btnOK;
        public CCWin.SkinControl.SkinTextBox stbFolderName;
        private System.Windows.Forms.Label labTopNodeName;
    }
}