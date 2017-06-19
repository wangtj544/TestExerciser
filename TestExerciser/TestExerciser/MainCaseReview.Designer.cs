namespace TestExerciser
{
    partial class MainCaseReview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainCaseReview));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControlReview = new System.Windows.Forms.TabControl();
            this.tabPagePreRev = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOK = new CCWin.SkinControl.SkinButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCommit = new CCWin.SkinControl.SkinButton();
            this.gbSubmit = new System.Windows.Forms.GroupBox();
            this.gbAddReviewer = new System.Windows.Forms.GroupBox();
            this.gbselectCases = new System.Windows.Forms.GroupBox();
            this.tabPageStartRev = new System.Windows.Forms.TabPage();
            this.gbFlow = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.gbSponsor = new System.Windows.Forms.GroupBox();
            this.labExcelPath = new System.Windows.Forms.Label();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.stbFilePath = new CCWin.SkinControl.SkinTextBox();
            this.labIfAuto = new System.Windows.Forms.Label();
            this.combReviewer = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labIfMatch = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.labIfOrder = new System.Windows.Forms.Label();
            this.labIfCover = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.dgvCommit = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControlReview.SuspendLayout();
            this.tabPagePreRev.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gbSubmit.SuspendLayout();
            this.gbAddReviewer.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.gbSponsor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommit)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(4, 32);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControlReview);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gbFlow);
            this.splitContainer1.Size = new System.Drawing.Size(1432, 789);
            this.splitContainer1.SplitterDistance = 1208;
            this.splitContainer1.TabIndex = 1;
            // 
            // tabControlReview
            // 
            this.tabControlReview.Controls.Add(this.tabPagePreRev);
            this.tabControlReview.Controls.Add(this.tabPageStartRev);
            this.tabControlReview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlReview.Location = new System.Drawing.Point(0, 0);
            this.tabControlReview.Name = "tabControlReview";
            this.tabControlReview.SelectedIndex = 0;
            this.tabControlReview.Size = new System.Drawing.Size(1208, 789);
            this.tabControlReview.TabIndex = 1;
            // 
            // tabPagePreRev
            // 
            this.tabPagePreRev.Controls.Add(this.splitContainer2);
            this.tabPagePreRev.Location = new System.Drawing.Point(4, 22);
            this.tabPagePreRev.Name = "tabPagePreRev";
            this.tabPagePreRev.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePreRev.Size = new System.Drawing.Size(1200, 763);
            this.tabPagePreRev.TabIndex = 0;
            this.tabPagePreRev.Text = "评审流程";
            this.tabPagePreRev.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer2.Panel1MinSize = 210;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvCommit);
            this.splitContainer2.Size = new System.Drawing.Size(1194, 757);
            this.splitContainer2.SplitterDistance = 210;
            this.splitContainer2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnOK, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.gbSponsor, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbselectCases, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(210, 757);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.DownBack = null;
            this.btnOK.Location = new System.Drawing.Point(56, 730);
            this.btnOK.MouseBack = null;
            this.btnOK.Name = "btnOK";
            this.btnOK.NormlBack = null;
            this.btnOK.Size = new System.Drawing.Size(98, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "开始评审";
            this.btnOK.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.gbAddReviewer, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.gbSubmit, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCommit, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.77778F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(198, 337);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // btnCommit
            // 
            this.btnCommit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCommit.BackColor = System.Drawing.Color.Transparent;
            this.btnCommit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCommit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCommit.DownBack = null;
            this.btnCommit.Location = new System.Drawing.Point(50, 310);
            this.btnCommit.MouseBack = null;
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.NormlBack = null;
            this.btnCommit.Size = new System.Drawing.Size(98, 23);
            this.btnCommit.TabIndex = 5;
            this.btnCommit.Text = "提交评审";
            this.btnCommit.UseVisualStyleBackColor = false;
            // 
            // gbSubmit
            // 
            this.gbSubmit.Controls.Add(this.tableLayoutPanel3);
            this.gbSubmit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSubmit.Location = new System.Drawing.Point(3, 3);
            this.gbSubmit.Name = "gbSubmit";
            this.gbSubmit.Size = new System.Drawing.Size(192, 62);
            this.gbSubmit.TabIndex = 5;
            this.gbSubmit.TabStop = false;
            this.gbSubmit.Text = "第一步：添加用例";
            // 
            // gbAddReviewer
            // 
            this.gbAddReviewer.Controls.Add(this.tableLayoutPanel4);
            this.gbAddReviewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAddReviewer.Location = new System.Drawing.Point(3, 71);
            this.gbAddReviewer.Name = "gbAddReviewer";
            this.gbAddReviewer.Size = new System.Drawing.Size(192, 232);
            this.gbAddReviewer.TabIndex = 6;
            this.gbAddReviewer.TabStop = false;
            this.gbAddReviewer.Text = "第二步：添加评审人";
            // 
            // gbselectCases
            // 
            this.gbselectCases.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbselectCases.Location = new System.Drawing.Point(3, 366);
            this.gbselectCases.Name = "gbselectCases";
            this.gbselectCases.Size = new System.Drawing.Size(204, 357);
            this.gbselectCases.TabIndex = 7;
            this.gbselectCases.TabStop = false;
            this.gbselectCases.Text = "选择用例：";
            // 
            // tabPageStartRev
            // 
            this.tabPageStartRev.Location = new System.Drawing.Point(4, 22);
            this.tabPageStartRev.Name = "tabPageStartRev";
            this.tabPageStartRev.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStartRev.Size = new System.Drawing.Size(1200, 763);
            this.tabPageStartRev.TabIndex = 1;
            this.tabPageStartRev.Text = "开始评审";
            this.tabPageStartRev.UseVisualStyleBackColor = true;
            // 
            // gbFlow
            // 
            this.gbFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFlow.Location = new System.Drawing.Point(0, 0);
            this.gbFlow.Name = "gbFlow";
            this.gbFlow.Size = new System.Drawing.Size(220, 789);
            this.gbFlow.TabIndex = 0;
            this.gbFlow.TabStop = false;
            this.gbFlow.Text = "评审流程与结果：";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel3.Controls.Add(this.labExcelPath, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnSelectFile, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.stbFilePath, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(186, 42);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // gbSponsor
            // 
            this.gbSponsor.Controls.Add(this.tableLayoutPanel2);
            this.gbSponsor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSponsor.Location = new System.Drawing.Point(3, 3);
            this.gbSponsor.Name = "gbSponsor";
            this.gbSponsor.Size = new System.Drawing.Size(204, 357);
            this.gbSponsor.TabIndex = 8;
            this.gbSponsor.TabStop = false;
            this.gbSponsor.Text = "发起评审：";
            // 
            // labExcelPath
            // 
            this.labExcelPath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labExcelPath.AutoSize = true;
            this.labExcelPath.Location = new System.Drawing.Point(4, 15);
            this.labExcelPath.Name = "labExcelPath";
            this.labExcelPath.Size = new System.Drawing.Size(41, 12);
            this.labExcelPath.TabIndex = 0;
            this.labExcelPath.Text = "文件：";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSelectFile.Location = new System.Drawing.Point(151, 9);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(31, 23);
            this.btnSelectFile.TabIndex = 1;
            this.btnSelectFile.Text = "...";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            // 
            // stbFilePath
            // 
            this.stbFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.stbFilePath.BackColor = System.Drawing.Color.Transparent;
            this.stbFilePath.DownBack = null;
            this.stbFilePath.Icon = null;
            this.stbFilePath.IconIsButton = false;
            this.stbFilePath.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.stbFilePath.IsPasswordChat = '\0';
            this.stbFilePath.IsSystemPasswordChar = false;
            this.stbFilePath.Lines = new string[0];
            this.stbFilePath.Location = new System.Drawing.Point(50, 7);
            this.stbFilePath.Margin = new System.Windows.Forms.Padding(0);
            this.stbFilePath.MaxLength = 32767;
            this.stbFilePath.MinimumSize = new System.Drawing.Size(28, 28);
            this.stbFilePath.MouseBack = null;
            this.stbFilePath.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.stbFilePath.Multiline = false;
            this.stbFilePath.Name = "stbFilePath";
            this.stbFilePath.NormlBack = null;
            this.stbFilePath.Padding = new System.Windows.Forms.Padding(5);
            this.stbFilePath.ReadOnly = false;
            this.stbFilePath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.stbFilePath.Size = new System.Drawing.Size(98, 28);
            // 
            // 
            // 
            this.stbFilePath.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stbFilePath.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stbFilePath.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.stbFilePath.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.stbFilePath.SkinTxt.Name = "BaseText";
            this.stbFilePath.SkinTxt.Size = new System.Drawing.Size(88, 18);
            this.stbFilePath.SkinTxt.TabIndex = 0;
            this.stbFilePath.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.stbFilePath.SkinTxt.WaterText = "请填写文件路径...";
            this.stbFilePath.TabIndex = 2;
            this.stbFilePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.stbFilePath.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.stbFilePath.WaterText = "请填写文件路径...";
            this.stbFilePath.WordWrap = true;
            // 
            // labIfAuto
            // 
            this.labIfAuto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labIfAuto.AutoSize = true;
            this.labIfAuto.Location = new System.Drawing.Point(3, 7);
            this.labIfAuto.Name = "labIfAuto";
            this.labIfAuto.Size = new System.Drawing.Size(95, 12);
            this.labIfAuto.TabIndex = 0;
            this.labIfAuto.Text = "是否自动化评审:";
            // 
            // combReviewer
            // 
            this.combReviewer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.combReviewer.FormattingEnabled = true;
            this.combReviewer.Location = new System.Drawing.Point(128, 3);
            this.combReviewer.Name = "combReviewer";
            this.combReviewer.Size = new System.Drawing.Size(49, 20);
            this.combReviewer.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(128, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(49, 20);
            this.comboBox1.TabIndex = 1;
            // 
            // labIfMatch
            // 
            this.labIfMatch.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labIfMatch.AutoSize = true;
            this.labIfMatch.Location = new System.Drawing.Point(3, 59);
            this.labIfMatch.Name = "labIfMatch";
            this.labIfMatch.Size = new System.Drawing.Size(107, 12);
            this.labIfMatch.TabIndex = 0;
            this.labIfMatch.Text = "是否匹配模板评审:";
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(128, 55);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(49, 20);
            this.comboBox2.TabIndex = 1;
            // 
            // labIfOrder
            // 
            this.labIfOrder.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labIfOrder.AutoSize = true;
            this.labIfOrder.Location = new System.Drawing.Point(3, 33);
            this.labIfOrder.Name = "labIfOrder";
            this.labIfOrder.Size = new System.Drawing.Size(107, 12);
            this.labIfOrder.TabIndex = 2;
            this.labIfOrder.Text = "是否符合规范评审:";
            // 
            // labIfCover
            // 
            this.labIfCover.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labIfCover.AutoSize = true;
            this.labIfCover.Location = new System.Drawing.Point(3, 86);
            this.labIfCover.Name = "labIfCover";
            this.labIfCover.Size = new System.Drawing.Size(119, 12);
            this.labIfCover.TabIndex = 0;
            this.labIfCover.Text = "是否覆盖测试点评审:";
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(128, 82);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(49, 20);
            this.comboBox3.TabIndex = 1;
            // 
            // dgvCommit
            // 
            this.dgvCommit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCommit.Location = new System.Drawing.Point(0, 0);
            this.dgvCommit.Name = "dgvCommit";
            this.dgvCommit.RowTemplate.Height = 23;
            this.dgvCommit.Size = new System.Drawing.Size(980, 757);
            this.dgvCommit.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(186, 212);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.comboBox3, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.combReviewer, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.comboBox2, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.labIfCover, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.comboBox1, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.labIfAuto, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.labIfMatch, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.labIfOrder, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(180, 106);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // MainCaseReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackPalace = ((System.Drawing.Image)(resources.GetObject("$this.BackPalace")));
            this.ClientSize = new System.Drawing.Size(1440, 825);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainCaseReview";
            this.ShadowColor = System.Drawing.Color.Blue;
            this.Text = "用例评审";
            this.TitleCenter = false;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControlReview.ResumeLayout(false);
            this.tabPagePreRev.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.gbSubmit.ResumeLayout(false);
            this.gbAddReviewer.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.gbSponsor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommit)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControlReview;
        private System.Windows.Forms.TabPage tabPagePreRev;
        private CCWin.SkinControl.SkinButton btnOK;
        private System.Windows.Forms.TabPage tabPageStartRev;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox gbSubmit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private CCWin.SkinControl.SkinButton btnCommit;
        private System.Windows.Forms.GroupBox gbAddReviewer;
        private System.Windows.Forms.GroupBox gbselectCases;
        private System.Windows.Forms.GroupBox gbSponsor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labExcelPath;
        private System.Windows.Forms.Button btnSelectFile;
        private CCWin.SkinControl.SkinTextBox stbFilePath;
        private System.Windows.Forms.GroupBox gbFlow;
        private System.Windows.Forms.Label labIfCover;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label labIfMatch;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label labIfOrder;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labIfAuto;
        private System.Windows.Forms.ComboBox combReviewer;
        private System.Windows.Forms.DataGridView dgvCommit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    }
}