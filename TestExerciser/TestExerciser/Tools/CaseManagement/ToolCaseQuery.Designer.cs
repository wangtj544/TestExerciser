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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.labTitle = new System.Windows.Forms.Label();
            this.labProject = new System.Windows.Forms.Label();
            this.labNO = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtProject = new System.Windows.Forms.TextBox();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.tlpButton = new System.Windows.Forms.TableLayoutPanel();
            this.stbQuit = new CCWin.SkinControl.SkinButton();
            this.stbQuery = new CCWin.SkinControl.SkinButton();
            this.scobHistory = new CCWin.SkinControl.SkinComboBox();
            this.tlpMain.SuspendLayout();
            this.tlpButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 5;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.labTitle, 0, 0);
            this.tlpMain.Controls.Add(this.labProject, 0, 1);
            this.tlpMain.Controls.Add(this.labNO, 3, 0);
            this.tlpMain.Controls.Add(this.txtTitle, 1, 0);
            this.tlpMain.Controls.Add(this.txtProject, 1, 1);
            this.tlpMain.Controls.Add(this.txtNo, 4, 0);
            this.tlpMain.Controls.Add(this.tlpButton, 4, 2);
            this.tlpMain.Controls.Add(this.scobHistory, 1, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(4, 32);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpMain.Size = new System.Drawing.Size(705, 157);
            this.tlpMain.TabIndex = 1;
            // 
            // labTitle
            // 
            this.labTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labTitle.AutoSize = true;
            this.labTitle.Location = new System.Drawing.Point(3, 11);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(41, 12);
            this.labTitle.TabIndex = 0;
            this.labTitle.Text = "标题：";
            // 
            // labProject
            // 
            this.labProject.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labProject.AutoSize = true;
            this.labProject.Location = new System.Drawing.Point(3, 46);
            this.labProject.Name = "labProject";
            this.labProject.Size = new System.Drawing.Size(65, 12);
            this.labProject.TabIndex = 2;
            this.labProject.Text = "所属项目：";
            // 
            // labNO
            // 
            this.labNO.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labNO.AutoSize = true;
            this.labNO.Location = new System.Drawing.Point(381, 11);
            this.labNO.Name = "labNO";
            this.labNO.Size = new System.Drawing.Size(41, 12);
            this.labNO.TabIndex = 1;
            this.labNO.Text = "编号：";
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.Location = new System.Drawing.Point(76, 7);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(269, 21);
            this.txtTitle.TabIndex = 4;
            // 
            // txtProject
            // 
            this.txtProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProject.Location = new System.Drawing.Point(76, 42);
            this.txtProject.Name = "txtProject";
            this.txtProject.Size = new System.Drawing.Size(269, 21);
            this.txtProject.TabIndex = 5;
            // 
            // txtNo
            // 
            this.txtNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNo.Location = new System.Drawing.Point(432, 7);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(270, 21);
            this.txtNo.TabIndex = 6;
            // 
            // tlpButton
            // 
            this.tlpButton.ColumnCount = 2;
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButton.Controls.Add(this.stbQuit, 0, 0);
            this.tlpButton.Controls.Add(this.stbQuery, 0, 0);
            this.tlpButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButton.Location = new System.Drawing.Point(432, 73);
            this.tlpButton.Name = "tlpButton";
            this.tlpButton.RowCount = 1;
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tlpButton.Size = new System.Drawing.Size(270, 81);
            this.tlpButton.TabIndex = 7;
            // 
            // stbQuit
            // 
            this.stbQuit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.stbQuit.BackColor = System.Drawing.Color.Transparent;
            this.stbQuit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.stbQuit.DownBack = null;
            this.stbQuit.Location = new System.Drawing.Point(165, 55);
            this.stbQuit.MouseBack = null;
            this.stbQuit.Name = "stbQuit";
            this.stbQuit.NormlBack = null;
            this.stbQuit.Size = new System.Drawing.Size(75, 23);
            this.stbQuit.TabIndex = 1;
            this.stbQuit.Text = "退出";
            this.stbQuit.UseVisualStyleBackColor = false;
            // 
            // stbQuery
            // 
            this.stbQuery.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.stbQuery.BackColor = System.Drawing.Color.Transparent;
            this.stbQuery.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.stbQuery.DownBack = null;
            this.stbQuery.Location = new System.Drawing.Point(30, 55);
            this.stbQuery.MouseBack = null;
            this.stbQuery.Name = "stbQuery";
            this.stbQuery.NormlBack = null;
            this.stbQuery.Size = new System.Drawing.Size(75, 23);
            this.stbQuery.TabIndex = 0;
            this.stbQuery.Text = "查询";
            this.stbQuery.UseVisualStyleBackColor = false;
            // 
            // scobHistory
            // 
            this.scobHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scobHistory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.scobHistory.FormattingEnabled = true;
            this.scobHistory.Location = new System.Drawing.Point(76, 73);
            this.scobHistory.Name = "scobHistory";
            this.scobHistory.Size = new System.Drawing.Size(269, 22);
            this.scobHistory.TabIndex = 8;
            this.scobHistory.WaterText = "历史查询数据...";
            // 
            // ToolCaseQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 193);
            this.Controls.Add(this.tlpMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ToolCaseQuery";
            this.Text = "查询用例";
            this.TitleCenter = false;
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlpButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.Label labProject;
        private System.Windows.Forms.Label labNO;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtProject;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.TableLayoutPanel tlpButton;
        private CCWin.SkinControl.SkinButton stbQuit;
        private CCWin.SkinControl.SkinButton stbQuery;
        private CCWin.SkinControl.SkinComboBox scobHistory;
    }
}