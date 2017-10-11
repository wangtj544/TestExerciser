namespace TestExerciser.Tools.CaseManagement
{
    partial class ToolCaseQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolCaseQuery));
            this.labQuery = new System.Windows.Forms.Label();
            this.tb_QueryItems = new CCWin.SkinControl.SkinTextBox();
            this.btnCancel = new CCWin.SkinControl.SkinButton();
            this.btnOK = new CCWin.SkinControl.SkinButton();
            this.txtStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labQuery
            // 
            this.labQuery.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labQuery.AutoSize = true;
            this.labQuery.Location = new System.Drawing.Point(68, 82);
            this.labQuery.Name = "labQuery";
            this.labQuery.Size = new System.Drawing.Size(65, 12);
            this.labQuery.TabIndex = 0;
            this.labQuery.Text = "用例编号：";
            // 
            // tb_QueryItems
            // 
            this.tb_QueryItems.BackColor = System.Drawing.Color.Transparent;
            this.tb_QueryItems.DownBack = null;
            this.tb_QueryItems.Icon = null;
            this.tb_QueryItems.IconIsButton = false;
            this.tb_QueryItems.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_QueryItems.IsPasswordChat = '\0';
            this.tb_QueryItems.IsSystemPasswordChar = false;
            this.tb_QueryItems.Lines = new string[0];
            this.tb_QueryItems.Location = new System.Drawing.Point(131, 75);
            this.tb_QueryItems.Margin = new System.Windows.Forms.Padding(0);
            this.tb_QueryItems.MaxLength = 32767;
            this.tb_QueryItems.MinimumSize = new System.Drawing.Size(28, 28);
            this.tb_QueryItems.MouseBack = null;
            this.tb_QueryItems.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_QueryItems.Multiline = false;
            this.tb_QueryItems.Name = "tb_QueryItems";
            this.tb_QueryItems.NormlBack = null;
            this.tb_QueryItems.Padding = new System.Windows.Forms.Padding(5);
            this.tb_QueryItems.ReadOnly = false;
            this.tb_QueryItems.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_QueryItems.Size = new System.Drawing.Size(320, 28);
            // 
            // 
            // 
            this.tb_QueryItems.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_QueryItems.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_QueryItems.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tb_QueryItems.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tb_QueryItems.SkinTxt.Name = "BaseText";
            this.tb_QueryItems.SkinTxt.Size = new System.Drawing.Size(310, 18);
            this.tb_QueryItems.SkinTxt.TabIndex = 0;
            this.tb_QueryItems.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_QueryItems.SkinTxt.WaterText = "请输入用例编号...";
            this.tb_QueryItems.TabIndex = 2;
            this.tb_QueryItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_QueryItems.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_QueryItems.WaterText = "请输入用例编号...";
            this.tb_QueryItems.WordWrap = true;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCancel.DownBack = null;
            this.btnCancel.Location = new System.Drawing.Point(280, 149);
            this.btnCancel.MouseBack = null;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NormlBack = null;
            this.btnCancel.Size = new System.Drawing.Size(111, 23);
            this.btnCancel.TabIndex = 51;
            this.btnCancel.Text = "取消查询";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnOK.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.btnOK.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnOK.DownBack = null;
            this.btnOK.Location = new System.Drawing.Point(131, 149);
            this.btnOK.MouseBack = null;
            this.btnOK.Name = "btnOK";
            this.btnOK.NormlBack = null;
            this.btnOK.Size = new System.Drawing.Size(111, 23);
            this.btnOK.TabIndex = 50;
            this.btnOK.Text = "确定查询";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = true;
            this.txtStatus.Location = new System.Drawing.Point(43, 122);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(0, 12);
            this.txtStatus.TabIndex = 49;
            // 
            // ToolCaseQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 201);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.tb_QueryItems);
            this.Controls.Add(this.labQuery);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ToolCaseQuery";
            this.Text = "查询用例";
            this.TitleCenter = false;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ToolCaseQuery_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labQuery;
        private CCWin.SkinControl.SkinTextBox tb_QueryItems;
        private CCWin.SkinControl.SkinButton btnCancel;
        private CCWin.SkinControl.SkinButton btnOK;
        public System.Windows.Forms.Label txtStatus;
    }
}