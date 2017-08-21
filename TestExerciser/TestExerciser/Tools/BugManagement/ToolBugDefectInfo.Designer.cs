namespace TestExerciser.Tools.BugManagement
{
    partial class ToolBugDefectInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolBugDefectInfo));
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpRawFirst = new System.Windows.Forms.TableLayoutPanel();
            this.labMode = new CCWin.SkinControl.SkinLabel();
            this.scbMode = new CCWin.SkinControl.SkinComboBox();
            this.tlpRawLast = new System.Windows.Forms.TableLayoutPanel();
            this.sbtnOK = new CCWin.SkinControl.SkinButton();
            this.sbtnClean = new CCWin.SkinControl.SkinButton();
            this.sbtnAdd = new CCWin.SkinControl.SkinButton();
            this.sbtnHistory = new CCWin.SkinControl.SkinComboBox();
            this.skinTabControl1 = new CCWin.SkinControl.SkinTabControl();
            this.stpQuery = new CCWin.SkinControl.SkinTabPage();
            this.stpResults = new CCWin.SkinControl.SkinTabPage();
            this.tlpMain.SuspendLayout();
            this.tlpRawFirst.SuspendLayout();
            this.tlpRawLast.SuspendLayout();
            this.skinTabControl1.SuspendLayout();
            this.stpQuery.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tlpRawFirst, 0, 0);
            this.tlpMain.Controls.Add(this.tlpRawLast, 0, 2);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlpMain.Size = new System.Drawing.Size(1722, 753);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpRawFirst
            // 
            this.tlpRawFirst.ColumnCount = 2;
            this.tlpRawFirst.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tlpRawFirst.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRawFirst.Controls.Add(this.labMode, 0, 0);
            this.tlpRawFirst.Controls.Add(this.scbMode, 1, 0);
            this.tlpRawFirst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRawFirst.Location = new System.Drawing.Point(3, 3);
            this.tlpRawFirst.Name = "tlpRawFirst";
            this.tlpRawFirst.RowCount = 1;
            this.tlpRawFirst.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRawFirst.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlpRawFirst.Size = new System.Drawing.Size(1716, 29);
            this.tlpRawFirst.TabIndex = 0;
            // 
            // labMode
            // 
            this.labMode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labMode.AutoSize = true;
            this.labMode.BackColor = System.Drawing.Color.Transparent;
            this.labMode.BorderColor = System.Drawing.Color.White;
            this.labMode.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labMode.Location = new System.Drawing.Point(3, 6);
            this.labMode.Name = "labMode";
            this.labMode.Size = new System.Drawing.Size(61, 17);
            this.labMode.TabIndex = 2;
            this.labMode.Text = "统计视图*";
            // 
            // scbMode
            // 
            this.scbMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(179)))));
            this.scbMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scbMode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.scbMode.FormattingEnabled = true;
            this.scbMode.Location = new System.Drawing.Point(79, 3);
            this.scbMode.Name = "scbMode";
            this.scbMode.Size = new System.Drawing.Size(1634, 22);
            this.scbMode.TabIndex = 3;
            this.scbMode.WaterText = "";
            // 
            // tlpRawLast
            // 
            this.tlpRawLast.ColumnCount = 5;
            this.tlpRawLast.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tlpRawLast.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 181F));
            this.tlpRawLast.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRawLast.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tlpRawLast.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tlpRawLast.Controls.Add(this.sbtnOK, 3, 0);
            this.tlpRawLast.Controls.Add(this.sbtnClean, 4, 0);
            this.tlpRawLast.Controls.Add(this.sbtnAdd, 0, 0);
            this.tlpRawLast.Controls.Add(this.sbtnHistory, 1, 0);
            this.tlpRawLast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRawLast.Location = new System.Drawing.Point(3, 720);
            this.tlpRawLast.Name = "tlpRawLast";
            this.tlpRawLast.RowCount = 1;
            this.tlpRawLast.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpRawLast.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpRawLast.Size = new System.Drawing.Size(1716, 30);
            this.tlpRawLast.TabIndex = 1;
            // 
            // sbtnOK
            // 
            this.sbtnOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sbtnOK.BackColor = System.Drawing.Color.Transparent;
            this.sbtnOK.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.sbtnOK.DownBack = null;
            this.sbtnOK.Location = new System.Drawing.Point(1496, 3);
            this.sbtnOK.MouseBack = null;
            this.sbtnOK.Name = "sbtnOK";
            this.sbtnOK.NormlBack = null;
            this.sbtnOK.Size = new System.Drawing.Size(89, 23);
            this.sbtnOK.TabIndex = 0;
            this.sbtnOK.Text = "确定";
            this.sbtnOK.UseVisualStyleBackColor = false;
            // 
            // sbtnClean
            // 
            this.sbtnClean.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sbtnClean.BackColor = System.Drawing.Color.Transparent;
            this.sbtnClean.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.sbtnClean.DownBack = null;
            this.sbtnClean.Location = new System.Drawing.Point(1614, 3);
            this.sbtnClean.MouseBack = null;
            this.sbtnClean.Name = "sbtnClean";
            this.sbtnClean.NormlBack = null;
            this.sbtnClean.Size = new System.Drawing.Size(89, 23);
            this.sbtnClean.TabIndex = 1;
            this.sbtnClean.Text = "清除";
            this.sbtnClean.UseVisualStyleBackColor = false;
            // 
            // sbtnAdd
            // 
            this.sbtnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sbtnAdd.BackColor = System.Drawing.Color.Transparent;
            this.sbtnAdd.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.sbtnAdd.DownBack = null;
            this.sbtnAdd.Location = new System.Drawing.Point(9, 3);
            this.sbtnAdd.MouseBack = null;
            this.sbtnAdd.Name = "sbtnAdd";
            this.sbtnAdd.NormlBack = null;
            this.sbtnAdd.Size = new System.Drawing.Size(89, 23);
            this.sbtnAdd.TabIndex = 2;
            this.sbtnAdd.Text = "添加";
            this.sbtnAdd.UseVisualStyleBackColor = false;
            // 
            // sbtnHistory
            // 
            this.sbtnHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sbtnHistory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.sbtnHistory.FormattingEnabled = true;
            this.sbtnHistory.Location = new System.Drawing.Point(112, 4);
            this.sbtnHistory.Name = "sbtnHistory";
            this.sbtnHistory.Size = new System.Drawing.Size(170, 22);
            this.sbtnHistory.TabIndex = 3;
            this.sbtnHistory.WaterText = "历史查询条件...";
            // 
            // skinTabControl1
            // 
            this.skinTabControl1.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.skinTabControl1.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.skinTabControl1.Controls.Add(this.stpQuery);
            this.skinTabControl1.Controls.Add(this.stpResults);
            this.skinTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabControl1.HeadBack = null;
            this.skinTabControl1.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.skinTabControl1.ItemSize = new System.Drawing.Size(70, 36);
            this.skinTabControl1.Location = new System.Drawing.Point(4, 32);
            this.skinTabControl1.Name = "skinTabControl1";
            this.skinTabControl1.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageArrowDown")));
            this.skinTabControl1.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageArrowHover")));
            this.skinTabControl1.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageCloseHover")));
            this.skinTabControl1.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageCloseNormal")));
            this.skinTabControl1.PageDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageDown")));
            this.skinTabControl1.PageHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageHover")));
            this.skinTabControl1.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.skinTabControl1.PageNorml = null;
            this.skinTabControl1.SelectedIndex = 0;
            this.skinTabControl1.Size = new System.Drawing.Size(1722, 789);
            this.skinTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.skinTabControl1.TabIndex = 1;
            // 
            // stpQuery
            // 
            this.stpQuery.BackColor = System.Drawing.Color.White;
            this.stpQuery.Controls.Add(this.tlpMain);
            this.stpQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stpQuery.Location = new System.Drawing.Point(0, 36);
            this.stpQuery.Name = "stpQuery";
            this.stpQuery.Size = new System.Drawing.Size(1722, 753);
            this.stpQuery.TabIndex = 0;
            this.stpQuery.TabItemImage = null;
            this.stpQuery.Text = "统计查询";
            // 
            // stpResults
            // 
            this.stpResults.BackColor = System.Drawing.Color.White;
            this.stpResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stpResults.Location = new System.Drawing.Point(0, 36);
            this.stpResults.Name = "stpResults";
            this.stpResults.Size = new System.Drawing.Size(1722, 753);
            this.stpResults.TabIndex = 1;
            this.stpResults.TabItemImage = null;
            this.stpResults.Text = "统计结果";
            // 
            // ToolBugDefectInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1730, 825);
            this.Controls.Add(this.skinTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ToolBugDefectInfo";
            this.Text = "统计缺陷";
            this.TitleCenter = false;
            this.tlpMain.ResumeLayout(false);
            this.tlpRawFirst.ResumeLayout(false);
            this.tlpRawFirst.PerformLayout();
            this.tlpRawLast.ResumeLayout(false);
            this.skinTabControl1.ResumeLayout(false);
            this.stpQuery.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpRawFirst;
        private CCWin.SkinControl.SkinLabel labMode;
        private CCWin.SkinControl.SkinComboBox scbMode;
        private System.Windows.Forms.TableLayoutPanel tlpRawLast;
        private CCWin.SkinControl.SkinButton sbtnOK;
        private CCWin.SkinControl.SkinButton sbtnClean;
        private CCWin.SkinControl.SkinButton sbtnAdd;
        private CCWin.SkinControl.SkinComboBox sbtnHistory;
        private CCWin.SkinControl.SkinTabControl skinTabControl1;
        private CCWin.SkinControl.SkinTabPage stpQuery;
        private CCWin.SkinControl.SkinTabPage stpResults;
    }
}