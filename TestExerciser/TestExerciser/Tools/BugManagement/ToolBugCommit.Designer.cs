namespace TestExerciser.Tools.BugManagement
{
    partial class ToolBugCommit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolBugCommit));
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMainManager = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMainEditor = new System.Windows.Forms.TableLayoutPanel();
            this.tlpReviewer = new System.Windows.Forms.TableLayoutPanel();
            this.labAuditor = new CCWin.SkinControl.SkinLabel();
            this.btnAuditor = new System.Windows.Forms.Button();
            this.txtAuditor = new System.Windows.Forms.TextBox();
            this.tlpAttachment = new System.Windows.Forms.TableLayoutPanel();
            this.labAttachement = new CCWin.SkinControl.SkinLabel();
            this.btnAttachment = new System.Windows.Forms.Button();
            this.txtAttachment = new System.Windows.Forms.TextBox();
            this.tlpTitle = new System.Windows.Forms.TableLayoutPanel();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.labTitle = new CCWin.SkinControl.SkinLabel();
            this.tlpSort = new System.Windows.Forms.TableLayoutPanel();
            this.dtpExceptDate = new CCWin.SkinControl.SkinDateTimePicker();
            this.labAuthor = new CCWin.SkinControl.SkinLabel();
            this.labCategory = new CCWin.SkinControl.SkinLabel();
            this.cbOccurrence = new CCWin.SkinControl.SkinComboBox();
            this.labPriority = new CCWin.SkinControl.SkinLabel();
            this.cbPriority = new CCWin.SkinControl.SkinComboBox();
            this.labHowFound = new CCWin.SkinControl.SkinLabel();
            this.labGravity = new CCWin.SkinControl.SkinLabel();
            this.labFoundVersion = new CCWin.SkinControl.SkinLabel();
            this.labExceptDate = new CCWin.SkinControl.SkinLabel();
            this.labFillDate = new CCWin.SkinControl.SkinLabel();
            this.cbProductVersion = new CCWin.SkinControl.SkinComboBox();
            this.cbCategory = new CCWin.SkinControl.SkinComboBox();
            this.cbHowFound = new CCWin.SkinControl.SkinComboBox();
            this.cbGravity = new CCWin.SkinControl.SkinComboBox();
            this.cbFoundVersion = new CCWin.SkinControl.SkinComboBox();
            this.dtpFillDate = new CCWin.SkinControl.SkinDateTimePicker();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.btnAuthor = new System.Windows.Forms.Button();
            this.labOccurrence = new CCWin.SkinControl.SkinLabel();
            this.labProductVersion = new CCWin.SkinControl.SkinLabel();
            this.tlpProject = new System.Windows.Forms.TableLayoutPanel();
            this.labAttribution = new CCWin.SkinControl.SkinLabel();
            this.txtAttribution = new System.Windows.Forms.TextBox();
            this.btnProject = new System.Windows.Forms.Button();
            this.tlpEditor = new System.Windows.Forms.TableLayoutPanel();
            this.labDetails = new CCWin.SkinControl.SkinLabel();
            this.tlpStsEditor = new System.Windows.Forms.TableLayoutPanel();
            this.stsEditor = new CCWin.SkinControl.SkinToolStrip();
            this.剪切UToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.复制CToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.粘贴PToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tssSeparatorOne = new System.Windows.Forms.ToolStripSeparator();
            this.帮助LToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.srtbDescription = new CCWin.SkinControl.SkinChatRichTextBox();
            this.stsManager = new CCWin.SkinControl.SkinToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbSaveAndNew = new System.Windows.Forms.ToolStripButton();
            this.tsbCommit = new System.Windows.Forms.ToolStripButton();
            this.tsbCommitAndNew = new System.Windows.Forms.ToolStripButton();
            this.tsbQuite = new System.Windows.Forms.ToolStripButton();
            this.tlpMain.SuspendLayout();
            this.tlpMainManager.SuspendLayout();
            this.tlpMainEditor.SuspendLayout();
            this.tlpReviewer.SuspendLayout();
            this.tlpAttachment.SuspendLayout();
            this.tlpTitle.SuspendLayout();
            this.tlpSort.SuspendLayout();
            this.tlpProject.SuspendLayout();
            this.tlpEditor.SuspendLayout();
            this.tlpStsEditor.SuspendLayout();
            this.stsEditor.SuspendLayout();
            this.stsManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tlpMainManager, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(4, 32);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(1722, 789);
            this.tlpMain.TabIndex = 1;
            // 
            // tlpMainManager
            // 
            this.tlpMainManager.ColumnCount = 1;
            this.tlpMainManager.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainManager.Controls.Add(this.tlpMainEditor, 0, 1);
            this.tlpMainManager.Controls.Add(this.stsManager, 0, 0);
            this.tlpMainManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainManager.Location = new System.Drawing.Point(3, 3);
            this.tlpMainManager.Name = "tlpMainManager";
            this.tlpMainManager.RowCount = 2;
            this.tlpMainManager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpMainManager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainManager.Size = new System.Drawing.Size(1716, 783);
            this.tlpMainManager.TabIndex = 1;
            // 
            // tlpMainEditor
            // 
            this.tlpMainEditor.ColumnCount = 1;
            this.tlpMainEditor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainEditor.Controls.Add(this.tlpReviewer, 0, 5);
            this.tlpMainEditor.Controls.Add(this.tlpAttachment, 0, 4);
            this.tlpMainEditor.Controls.Add(this.tlpTitle, 0, 0);
            this.tlpMainEditor.Controls.Add(this.tlpSort, 0, 2);
            this.tlpMainEditor.Controls.Add(this.tlpProject, 0, 1);
            this.tlpMainEditor.Controls.Add(this.tlpEditor, 0, 3);
            this.tlpMainEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainEditor.Location = new System.Drawing.Point(3, 33);
            this.tlpMainEditor.Name = "tlpMainEditor";
            this.tlpMainEditor.RowCount = 6;
            this.tlpMainEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpMainEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpMainEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tlpMainEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpMainEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tlpMainEditor.Size = new System.Drawing.Size(1710, 747);
            this.tlpMainEditor.TabIndex = 2;
            // 
            // tlpReviewer
            // 
            this.tlpReviewer.ColumnCount = 3;
            this.tlpReviewer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpReviewer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpReviewer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpReviewer.Controls.Add(this.labAuditor, 0, 0);
            this.tlpReviewer.Controls.Add(this.btnAuditor, 2, 0);
            this.tlpReviewer.Controls.Add(this.txtAuditor, 1, 0);
            this.tlpReviewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpReviewer.Location = new System.Drawing.Point(3, 718);
            this.tlpReviewer.Name = "tlpReviewer";
            this.tlpReviewer.RowCount = 1;
            this.tlpReviewer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpReviewer.Size = new System.Drawing.Size(1704, 26);
            this.tlpReviewer.TabIndex = 11;
            // 
            // labAuditor
            // 
            this.labAuditor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labAuditor.AutoSize = true;
            this.labAuditor.BackColor = System.Drawing.Color.Transparent;
            this.labAuditor.BorderColor = System.Drawing.Color.White;
            this.labAuditor.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labAuditor.Location = new System.Drawing.Point(3, 4);
            this.labAuditor.Name = "labAuditor";
            this.labAuditor.Size = new System.Drawing.Size(49, 17);
            this.labAuditor.TabIndex = 1;
            this.labAuditor.Text = "审核人*";
            // 
            // btnAuditor
            // 
            this.btnAuditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.btnAuditor.Image = ((System.Drawing.Image)(resources.GetObject("btnAuditor.Image")));
            this.btnAuditor.Location = new System.Drawing.Point(1677, 3);
            this.btnAuditor.Name = "btnAuditor";
            this.btnAuditor.Size = new System.Drawing.Size(24, 18);
            this.btnAuditor.TabIndex = 3;
            this.btnAuditor.UseVisualStyleBackColor = false;
            // 
            // txtAuditor
            // 
            this.txtAuditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(179)))));
            this.txtAuditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAuditor.Location = new System.Drawing.Point(83, 3);
            this.txtAuditor.Name = "txtAuditor";
            this.txtAuditor.ReadOnly = true;
            this.txtAuditor.Size = new System.Drawing.Size(1588, 21);
            this.txtAuditor.TabIndex = 2;
            // 
            // tlpAttachment
            // 
            this.tlpAttachment.ColumnCount = 3;
            this.tlpAttachment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpAttachment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAttachment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpAttachment.Controls.Add(this.labAttachement, 0, 0);
            this.tlpAttachment.Controls.Add(this.btnAttachment, 2, 0);
            this.tlpAttachment.Controls.Add(this.txtAttachment, 1, 0);
            this.tlpAttachment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAttachment.Location = new System.Drawing.Point(3, 686);
            this.tlpAttachment.Name = "tlpAttachment";
            this.tlpAttachment.RowCount = 1;
            this.tlpAttachment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAttachment.Size = new System.Drawing.Size(1704, 26);
            this.tlpAttachment.TabIndex = 10;
            // 
            // labAttachement
            // 
            this.labAttachement.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labAttachement.AutoSize = true;
            this.labAttachement.BackColor = System.Drawing.Color.Transparent;
            this.labAttachement.BorderColor = System.Drawing.Color.White;
            this.labAttachement.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labAttachement.Location = new System.Drawing.Point(3, 4);
            this.labAttachement.Name = "labAttachement";
            this.labAttachement.Size = new System.Drawing.Size(56, 17);
            this.labAttachement.TabIndex = 1;
            this.labAttachement.Text = "添加附件";
            // 
            // btnAttachment
            // 
            this.btnAttachment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.btnAttachment.Image = ((System.Drawing.Image)(resources.GetObject("btnAttachment.Image")));
            this.btnAttachment.Location = new System.Drawing.Point(1677, 3);
            this.btnAttachment.Name = "btnAttachment";
            this.btnAttachment.Size = new System.Drawing.Size(24, 18);
            this.btnAttachment.TabIndex = 3;
            this.btnAttachment.UseVisualStyleBackColor = false;
            // 
            // txtAttachment
            // 
            this.txtAttachment.BackColor = System.Drawing.Color.White;
            this.txtAttachment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAttachment.Location = new System.Drawing.Point(83, 3);
            this.txtAttachment.Name = "txtAttachment";
            this.txtAttachment.ReadOnly = true;
            this.txtAttachment.Size = new System.Drawing.Size(1588, 21);
            this.txtAttachment.TabIndex = 2;
            // 
            // tlpTitle
            // 
            this.tlpTitle.ColumnCount = 2;
            this.tlpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTitle.Controls.Add(this.txtTitle, 0, 0);
            this.tlpTitle.Controls.Add(this.labTitle, 0, 0);
            this.tlpTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTitle.Location = new System.Drawing.Point(3, 3);
            this.tlpTitle.Name = "tlpTitle";
            this.tlpTitle.RowCount = 1;
            this.tlpTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTitle.Size = new System.Drawing.Size(1704, 26);
            this.tlpTitle.TabIndex = 4;
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(179)))));
            this.txtTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTitle.Location = new System.Drawing.Point(83, 3);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(1618, 21);
            this.txtTitle.TabIndex = 3;
            // 
            // labTitle
            // 
            this.labTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labTitle.AutoSize = true;
            this.labTitle.BackColor = System.Drawing.Color.Transparent;
            this.labTitle.BorderColor = System.Drawing.Color.White;
            this.labTitle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTitle.Location = new System.Drawing.Point(3, 4);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(37, 17);
            this.labTitle.TabIndex = 1;
            this.labTitle.Text = "标题*";
            // 
            // tlpSort
            // 
            this.tlpSort.ColumnCount = 5;
            this.tlpSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSort.Controls.Add(this.dtpExceptDate, 4, 3);
            this.tlpSort.Controls.Add(this.labAuthor, 0, 4);
            this.tlpSort.Controls.Add(this.labCategory, 0, 0);
            this.tlpSort.Controls.Add(this.cbOccurrence, 1, 1);
            this.tlpSort.Controls.Add(this.labPriority, 0, 2);
            this.tlpSort.Controls.Add(this.cbPriority, 1, 2);
            this.tlpSort.Controls.Add(this.labHowFound, 3, 0);
            this.tlpSort.Controls.Add(this.labGravity, 3, 1);
            this.tlpSort.Controls.Add(this.labFoundVersion, 3, 2);
            this.tlpSort.Controls.Add(this.labExceptDate, 3, 3);
            this.tlpSort.Controls.Add(this.labFillDate, 3, 4);
            this.tlpSort.Controls.Add(this.cbProductVersion, 1, 3);
            this.tlpSort.Controls.Add(this.cbCategory, 1, 0);
            this.tlpSort.Controls.Add(this.cbHowFound, 4, 0);
            this.tlpSort.Controls.Add(this.cbGravity, 4, 1);
            this.tlpSort.Controls.Add(this.cbFoundVersion, 4, 2);
            this.tlpSort.Controls.Add(this.dtpFillDate, 4, 4);
            this.tlpSort.Controls.Add(this.txtAuthor, 1, 4);
            this.tlpSort.Controls.Add(this.btnAuthor, 2, 4);
            this.tlpSort.Controls.Add(this.labOccurrence, 0, 1);
            this.tlpSort.Controls.Add(this.labProductVersion, 0, 3);
            this.tlpSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSort.Location = new System.Drawing.Point(3, 67);
            this.tlpSort.Name = "tlpSort";
            this.tlpSort.RowCount = 5;
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpSort.Size = new System.Drawing.Size(1704, 139);
            this.tlpSort.TabIndex = 2;
            // 
            // dtpExceptDate
            // 
            this.dtpExceptDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpExceptDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpExceptDate.DropDownHeight = 180;
            this.dtpExceptDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.dtpExceptDate.DropDownWidth = 120;
            this.dtpExceptDate.font = new System.Drawing.Font("微软雅黑", 9F);
            this.dtpExceptDate.Items = null;
            this.dtpExceptDate.Location = new System.Drawing.Point(950, 84);
            this.dtpExceptDate.Name = "dtpExceptDate";
            this.dtpExceptDate.Size = new System.Drawing.Size(751, 21);
            this.dtpExceptDate.TabIndex = 9;
            this.dtpExceptDate.text = "";
            // 
            // labAuthor
            // 
            this.labAuthor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labAuthor.AutoSize = true;
            this.labAuthor.BackColor = System.Drawing.Color.Transparent;
            this.labAuthor.BorderColor = System.Drawing.Color.White;
            this.labAuthor.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labAuthor.Location = new System.Drawing.Point(3, 115);
            this.labAuthor.Name = "labAuthor";
            this.labAuthor.Size = new System.Drawing.Size(44, 17);
            this.labAuthor.TabIndex = 13;
            this.labAuthor.Text = "提出人";
            // 
            // labCategory
            // 
            this.labCategory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labCategory.AutoSize = true;
            this.labCategory.BackColor = System.Drawing.Color.White;
            this.labCategory.BorderColor = System.Drawing.Color.White;
            this.labCategory.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCategory.Location = new System.Drawing.Point(3, 5);
            this.labCategory.Name = "labCategory";
            this.labCategory.Size = new System.Drawing.Size(32, 17);
            this.labCategory.TabIndex = 4;
            this.labCategory.Text = "类别";
            // 
            // cbOccurrence
            // 
            this.cbOccurrence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbOccurrence.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbOccurrence.FormattingEnabled = true;
            this.cbOccurrence.Items.AddRange(new object[] {
            "稳定复现",
            "概率复现"});
            this.cbOccurrence.Location = new System.Drawing.Point(83, 30);
            this.cbOccurrence.Name = "cbOccurrence";
            this.cbOccurrence.Size = new System.Drawing.Size(751, 22);
            this.cbOccurrence.TabIndex = 9;
            this.cbOccurrence.WaterText = "";
            // 
            // labPriority
            // 
            this.labPriority.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labPriority.AutoSize = true;
            this.labPriority.BackColor = System.Drawing.Color.Transparent;
            this.labPriority.BorderColor = System.Drawing.Color.White;
            this.labPriority.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labPriority.Location = new System.Drawing.Point(3, 59);
            this.labPriority.Name = "labPriority";
            this.labPriority.Size = new System.Drawing.Size(44, 17);
            this.labPriority.TabIndex = 10;
            this.labPriority.Text = "优先级";
            // 
            // cbPriority
            // 
            this.cbPriority.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPriority.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Items.AddRange(new object[] {
            "高",
            "中",
            "低"});
            this.cbPriority.Location = new System.Drawing.Point(83, 57);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(751, 22);
            this.cbPriority.TabIndex = 11;
            this.cbPriority.WaterText = "";
            // 
            // labHowFound
            // 
            this.labHowFound.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labHowFound.AutoSize = true;
            this.labHowFound.BackColor = System.Drawing.Color.White;
            this.labHowFound.BorderColor = System.Drawing.Color.White;
            this.labHowFound.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labHowFound.Location = new System.Drawing.Point(870, 5);
            this.labHowFound.Name = "labHowFound";
            this.labHowFound.Size = new System.Drawing.Size(56, 17);
            this.labHowFound.TabIndex = 14;
            this.labHowFound.Text = "发现方法";
            // 
            // labGravity
            // 
            this.labGravity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labGravity.AutoSize = true;
            this.labGravity.BackColor = System.Drawing.Color.White;
            this.labGravity.BorderColor = System.Drawing.Color.White;
            this.labGravity.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labGravity.Location = new System.Drawing.Point(870, 32);
            this.labGravity.Name = "labGravity";
            this.labGravity.Size = new System.Drawing.Size(49, 17);
            this.labGravity.TabIndex = 15;
            this.labGravity.Text = "严重性*";
            // 
            // labFoundVersion
            // 
            this.labFoundVersion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labFoundVersion.AutoSize = true;
            this.labFoundVersion.BackColor = System.Drawing.Color.White;
            this.labFoundVersion.BorderColor = System.Drawing.Color.White;
            this.labFoundVersion.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labFoundVersion.Location = new System.Drawing.Point(870, 59);
            this.labFoundVersion.Name = "labFoundVersion";
            this.labFoundVersion.Size = new System.Drawing.Size(56, 17);
            this.labFoundVersion.TabIndex = 16;
            this.labFoundVersion.Text = "发现构建";
            // 
            // labExceptDate
            // 
            this.labExceptDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labExceptDate.AutoSize = true;
            this.labExceptDate.BackColor = System.Drawing.Color.White;
            this.labExceptDate.BorderColor = System.Drawing.Color.White;
            this.labExceptDate.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labExceptDate.Location = new System.Drawing.Point(870, 86);
            this.labExceptDate.Name = "labExceptDate";
            this.labExceptDate.Size = new System.Drawing.Size(56, 17);
            this.labExceptDate.TabIndex = 17;
            this.labExceptDate.Text = "解决日期";
            // 
            // labFillDate
            // 
            this.labFillDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labFillDate.AutoSize = true;
            this.labFillDate.BackColor = System.Drawing.Color.White;
            this.labFillDate.BorderColor = System.Drawing.Color.White;
            this.labFillDate.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labFillDate.Location = new System.Drawing.Point(870, 115);
            this.labFillDate.Name = "labFillDate";
            this.labFillDate.Size = new System.Drawing.Size(56, 17);
            this.labFillDate.TabIndex = 18;
            this.labFillDate.Text = "提出日期";
            // 
            // cbProductVersion
            // 
            this.cbProductVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbProductVersion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbProductVersion.FormattingEnabled = true;
            this.cbProductVersion.Items.AddRange(new object[] {
            "功能类",
            "接口类",
            "逻辑类",
            "数据类",
            "UI类",
            "其他"});
            this.cbProductVersion.Location = new System.Drawing.Point(83, 84);
            this.cbProductVersion.Name = "cbProductVersion";
            this.cbProductVersion.Size = new System.Drawing.Size(751, 22);
            this.cbProductVersion.TabIndex = 19;
            this.cbProductVersion.WaterText = "";
            // 
            // cbCategory
            // 
            this.cbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Items.AddRange(new object[] {
            "功能类",
            "接口类",
            "逻辑类",
            "数据类",
            "UI类",
            "其他"});
            this.cbCategory.Location = new System.Drawing.Point(83, 3);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(751, 22);
            this.cbCategory.TabIndex = 8;
            this.cbCategory.WaterText = "";
            // 
            // cbHowFound
            // 
            this.cbHowFound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbHowFound.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbHowFound.FormattingEnabled = true;
            this.cbHowFound.Items.AddRange(new object[] {
            "技术评审",
            "功能测试",
            "性能测试",
            "验收测试",
            "可靠性测试",
            "单元测试",
            "集成测试",
            "代码检查",
            "客户反馈"});
            this.cbHowFound.Location = new System.Drawing.Point(950, 3);
            this.cbHowFound.Name = "cbHowFound";
            this.cbHowFound.Size = new System.Drawing.Size(751, 22);
            this.cbHowFound.TabIndex = 20;
            this.cbHowFound.WaterText = "";
            // 
            // cbGravity
            // 
            this.cbGravity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbGravity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGravity.FormattingEnabled = true;
            this.cbGravity.Items.AddRange(new object[] {
            "致命",
            "严重",
            "一般",
            "提示"});
            this.cbGravity.Location = new System.Drawing.Point(950, 30);
            this.cbGravity.Name = "cbGravity";
            this.cbGravity.Size = new System.Drawing.Size(751, 22);
            this.cbGravity.TabIndex = 21;
            this.cbGravity.WaterText = "";
            // 
            // cbFoundVersion
            // 
            this.cbFoundVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbFoundVersion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFoundVersion.FormattingEnabled = true;
            this.cbFoundVersion.Location = new System.Drawing.Point(950, 57);
            this.cbFoundVersion.Name = "cbFoundVersion";
            this.cbFoundVersion.Size = new System.Drawing.Size(751, 22);
            this.cbFoundVersion.TabIndex = 22;
            this.cbFoundVersion.WaterText = "";
            // 
            // dtpFillDate
            // 
            this.dtpFillDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpFillDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFillDate.DropDownHeight = 180;
            this.dtpFillDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.dtpFillDate.DropDownWidth = 120;
            this.dtpFillDate.font = new System.Drawing.Font("微软雅黑", 9F);
            this.dtpFillDate.Items = null;
            this.dtpFillDate.Location = new System.Drawing.Point(950, 111);
            this.dtpFillDate.Name = "dtpFillDate";
            this.dtpFillDate.Size = new System.Drawing.Size(751, 25);
            this.dtpFillDate.TabIndex = 26;
            this.dtpFillDate.text = "";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAuthor.Location = new System.Drawing.Point(83, 111);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(751, 21);
            this.txtAuthor.TabIndex = 27;
            // 
            // btnAuthor
            // 
            this.btnAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.btnAuthor.Image = ((System.Drawing.Image)(resources.GetObject("btnAuthor.Image")));
            this.btnAuthor.Location = new System.Drawing.Point(840, 111);
            this.btnAuthor.Name = "btnAuthor";
            this.btnAuthor.Size = new System.Drawing.Size(24, 23);
            this.btnAuthor.TabIndex = 28;
            this.btnAuthor.UseVisualStyleBackColor = false;
            // 
            // labOccurrence
            // 
            this.labOccurrence.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labOccurrence.AutoSize = true;
            this.labOccurrence.BackColor = System.Drawing.Color.White;
            this.labOccurrence.BorderColor = System.Drawing.Color.White;
            this.labOccurrence.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labOccurrence.Location = new System.Drawing.Point(3, 32);
            this.labOccurrence.Name = "labOccurrence";
            this.labOccurrence.Size = new System.Drawing.Size(61, 17);
            this.labOccurrence.TabIndex = 29;
            this.labOccurrence.Text = "发生概率*";
            // 
            // labProductVersion
            // 
            this.labProductVersion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labProductVersion.AutoSize = true;
            this.labProductVersion.BackColor = System.Drawing.Color.Transparent;
            this.labProductVersion.BorderColor = System.Drawing.Color.White;
            this.labProductVersion.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labProductVersion.Location = new System.Drawing.Point(3, 86);
            this.labProductVersion.Name = "labProductVersion";
            this.labProductVersion.Size = new System.Drawing.Size(56, 17);
            this.labProductVersion.TabIndex = 30;
            this.labProductVersion.Text = "产品构建";
            // 
            // tlpProject
            // 
            this.tlpProject.ColumnCount = 3;
            this.tlpProject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpProject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProject.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpProject.Controls.Add(this.labAttribution, 0, 0);
            this.tlpProject.Controls.Add(this.txtAttribution, 1, 0);
            this.tlpProject.Controls.Add(this.btnProject, 2, 0);
            this.tlpProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpProject.Location = new System.Drawing.Point(3, 35);
            this.tlpProject.Name = "tlpProject";
            this.tlpProject.RowCount = 1;
            this.tlpProject.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProject.Size = new System.Drawing.Size(1704, 26);
            this.tlpProject.TabIndex = 3;
            // 
            // labAttribution
            // 
            this.labAttribution.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labAttribution.AutoSize = true;
            this.labAttribution.BackColor = System.Drawing.Color.Transparent;
            this.labAttribution.BorderColor = System.Drawing.Color.White;
            this.labAttribution.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labAttribution.Location = new System.Drawing.Point(3, 4);
            this.labAttribution.Name = "labAttribution";
            this.labAttribution.Size = new System.Drawing.Size(56, 17);
            this.labAttribution.TabIndex = 1;
            this.labAttribution.Text = "所属项目";
            // 
            // txtAttribution
            // 
            this.txtAttribution.BackColor = System.Drawing.Color.White;
            this.txtAttribution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAttribution.Location = new System.Drawing.Point(83, 3);
            this.txtAttribution.Name = "txtAttribution";
            this.txtAttribution.ReadOnly = true;
            this.txtAttribution.Size = new System.Drawing.Size(1588, 21);
            this.txtAttribution.TabIndex = 2;
            // 
            // btnProject
            // 
            this.btnProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.btnProject.Image = ((System.Drawing.Image)(resources.GetObject("btnProject.Image")));
            this.btnProject.Location = new System.Drawing.Point(1677, 3);
            this.btnProject.Name = "btnProject";
            this.btnProject.Size = new System.Drawing.Size(24, 20);
            this.btnProject.TabIndex = 3;
            this.btnProject.UseVisualStyleBackColor = false;
            // 
            // tlpEditor
            // 
            this.tlpEditor.ColumnCount = 2;
            this.tlpEditor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpEditor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEditor.Controls.Add(this.labDetails, 0, 0);
            this.tlpEditor.Controls.Add(this.tlpStsEditor, 1, 0);
            this.tlpEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEditor.Location = new System.Drawing.Point(3, 212);
            this.tlpEditor.Name = "tlpEditor";
            this.tlpEditor.RowCount = 1;
            this.tlpEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpEditor.Size = new System.Drawing.Size(1704, 468);
            this.tlpEditor.TabIndex = 5;
            // 
            // labDetails
            // 
            this.labDetails.AutoSize = true;
            this.labDetails.BackColor = System.Drawing.Color.Transparent;
            this.labDetails.BorderColor = System.Drawing.Color.White;
            this.labDetails.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labDetails.Location = new System.Drawing.Point(3, 0);
            this.labDetails.Name = "labDetails";
            this.labDetails.Size = new System.Drawing.Size(68, 17);
            this.labDetails.TabIndex = 14;
            this.labDetails.Text = "描述和建议";
            // 
            // tlpStsEditor
            // 
            this.tlpStsEditor.ColumnCount = 1;
            this.tlpStsEditor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStsEditor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpStsEditor.Controls.Add(this.stsEditor, 0, 0);
            this.tlpStsEditor.Controls.Add(this.srtbDescription, 0, 1);
            this.tlpStsEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpStsEditor.Location = new System.Drawing.Point(83, 3);
            this.tlpStsEditor.Name = "tlpStsEditor";
            this.tlpStsEditor.RowCount = 2;
            this.tlpStsEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpStsEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStsEditor.Size = new System.Drawing.Size(1618, 462);
            this.tlpStsEditor.TabIndex = 15;
            // 
            // stsEditor
            // 
            this.stsEditor.Arrow = System.Drawing.Color.Black;
            this.stsEditor.Back = System.Drawing.Color.White;
            this.stsEditor.BackRadius = 4;
            this.stsEditor.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.stsEditor.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.stsEditor.BaseFore = System.Drawing.Color.Black;
            this.stsEditor.BaseForeAnamorphosis = false;
            this.stsEditor.BaseForeAnamorphosisBorder = 4;
            this.stsEditor.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.stsEditor.BaseForeOffset = new System.Drawing.Point(0, 0);
            this.stsEditor.BaseHoverFore = System.Drawing.Color.White;
            this.stsEditor.BaseItemAnamorphosis = true;
            this.stsEditor.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.stsEditor.BaseItemBorderShow = true;
            this.stsEditor.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("stsEditor.BaseItemDown")));
            this.stsEditor.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.stsEditor.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("stsEditor.BaseItemMouse")));
            this.stsEditor.BaseItemNorml = null;
            this.stsEditor.BaseItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.stsEditor.BaseItemRadius = 4;
            this.stsEditor.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.stsEditor.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.stsEditor.BindTabControl = null;
            this.stsEditor.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.stsEditor.Fore = System.Drawing.Color.Black;
            this.stsEditor.GripMargin = new System.Windows.Forms.Padding(2, 2, 4, 2);
            this.stsEditor.HoverFore = System.Drawing.Color.White;
            this.stsEditor.ItemAnamorphosis = true;
            this.stsEditor.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.stsEditor.ItemBorderShow = true;
            this.stsEditor.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.stsEditor.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.stsEditor.ItemRadius = 4;
            this.stsEditor.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.stsEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.剪切UToolStripButton,
            this.复制CToolStripButton,
            this.粘贴PToolStripButton,
            this.tssSeparatorOne,
            this.帮助LToolStripButton});
            this.stsEditor.Location = new System.Drawing.Point(0, 0);
            this.stsEditor.Name = "stsEditor";
            this.stsEditor.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.stsEditor.Size = new System.Drawing.Size(1618, 25);
            this.stsEditor.SkinAllColor = true;
            this.stsEditor.TabIndex = 2;
            this.stsEditor.Text = "skinToolStrip2";
            this.stsEditor.TitleAnamorphosis = true;
            this.stsEditor.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.stsEditor.TitleRadius = 4;
            this.stsEditor.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // 剪切UToolStripButton
            // 
            this.剪切UToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.剪切UToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("剪切UToolStripButton.Image")));
            this.剪切UToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.剪切UToolStripButton.Name = "剪切UToolStripButton";
            this.剪切UToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.剪切UToolStripButton.Text = "剪切(&U)";
            // 
            // 复制CToolStripButton
            // 
            this.复制CToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.复制CToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("复制CToolStripButton.Image")));
            this.复制CToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.复制CToolStripButton.Name = "复制CToolStripButton";
            this.复制CToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.复制CToolStripButton.Text = "复制(&C)";
            // 
            // 粘贴PToolStripButton
            // 
            this.粘贴PToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.粘贴PToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("粘贴PToolStripButton.Image")));
            this.粘贴PToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.粘贴PToolStripButton.Name = "粘贴PToolStripButton";
            this.粘贴PToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.粘贴PToolStripButton.Text = "粘贴(&P)";
            // 
            // tssSeparatorOne
            // 
            this.tssSeparatorOne.Name = "tssSeparatorOne";
            this.tssSeparatorOne.Size = new System.Drawing.Size(6, 25);
            // 
            // 帮助LToolStripButton
            // 
            this.帮助LToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.帮助LToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("帮助LToolStripButton.Image")));
            this.帮助LToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.帮助LToolStripButton.Name = "帮助LToolStripButton";
            this.帮助LToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.帮助LToolStripButton.Text = "帮助(&L)";
            // 
            // srtbDescription
            // 
            this.srtbDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.srtbDescription.Location = new System.Drawing.Point(3, 33);
            this.srtbDescription.Name = "srtbDescription";
            this.srtbDescription.SelectControl = null;
            this.srtbDescription.SelectControlIndex = 0;
            this.srtbDescription.SelectControlPoint = new System.Drawing.Point(0, 0);
            this.srtbDescription.Size = new System.Drawing.Size(1612, 426);
            this.srtbDescription.TabIndex = 3;
            this.srtbDescription.Text = "";
            // 
            // stsManager
            // 
            this.stsManager.Arrow = System.Drawing.Color.Black;
            this.stsManager.Back = System.Drawing.Color.White;
            this.stsManager.BackRadius = 4;
            this.stsManager.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.stsManager.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.stsManager.BaseFore = System.Drawing.Color.Black;
            this.stsManager.BaseForeAnamorphosis = false;
            this.stsManager.BaseForeAnamorphosisBorder = 4;
            this.stsManager.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.stsManager.BaseForeOffset = new System.Drawing.Point(0, 0);
            this.stsManager.BaseHoverFore = System.Drawing.Color.White;
            this.stsManager.BaseItemAnamorphosis = true;
            this.stsManager.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.stsManager.BaseItemBorderShow = true;
            this.stsManager.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("stsManager.BaseItemDown")));
            this.stsManager.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.stsManager.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("stsManager.BaseItemMouse")));
            this.stsManager.BaseItemNorml = null;
            this.stsManager.BaseItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.stsManager.BaseItemRadius = 4;
            this.stsManager.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.stsManager.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.stsManager.BindTabControl = null;
            this.stsManager.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.stsManager.Fore = System.Drawing.Color.Black;
            this.stsManager.GripMargin = new System.Windows.Forms.Padding(2, 2, 4, 2);
            this.stsManager.HoverFore = System.Drawing.Color.White;
            this.stsManager.ItemAnamorphosis = true;
            this.stsManager.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.stsManager.ItemBorderShow = true;
            this.stsManager.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.stsManager.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.stsManager.ItemRadius = 4;
            this.stsManager.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.stsManager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.tsbSaveAndNew,
            this.tsbCommit,
            this.tsbCommitAndNew,
            this.tsbQuite});
            this.stsManager.Location = new System.Drawing.Point(0, 0);
            this.stsManager.Name = "stsManager";
            this.stsManager.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.stsManager.Size = new System.Drawing.Size(1716, 25);
            this.stsManager.SkinAllColor = true;
            this.stsManager.TabIndex = 3;
            this.stsManager.Text = "skinToolStrip1";
            this.stsManager.TitleAnamorphosis = true;
            this.stsManager.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.stsManager.TitleRadius = 4;
            this.stsManager.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(36, 22);
            this.tsbSave.Text = "保存";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbSaveAndNew
            // 
            this.tsbSaveAndNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSaveAndNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbSaveAndNew.Image")));
            this.tsbSaveAndNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveAndNew.Name = "tsbSaveAndNew";
            this.tsbSaveAndNew.Size = new System.Drawing.Size(72, 22);
            this.tsbSaveAndNew.Text = "保存并新建";
            this.tsbSaveAndNew.Click += new System.EventHandler(this.tsbSaveAndNew_Click);
            // 
            // tsbCommit
            // 
            this.tsbCommit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCommit.Image = ((System.Drawing.Image)(resources.GetObject("tsbCommit.Image")));
            this.tsbCommit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCommit.Name = "tsbCommit";
            this.tsbCommit.Size = new System.Drawing.Size(36, 22);
            this.tsbCommit.Text = "提交";
            this.tsbCommit.Click += new System.EventHandler(this.tsbCommit_Click);
            // 
            // tsbCommitAndNew
            // 
            this.tsbCommitAndNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCommitAndNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbCommitAndNew.Image")));
            this.tsbCommitAndNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCommitAndNew.Name = "tsbCommitAndNew";
            this.tsbCommitAndNew.Size = new System.Drawing.Size(72, 22);
            this.tsbCommitAndNew.Text = "提交并新建";
            this.tsbCommitAndNew.Click += new System.EventHandler(this.tsbCommitAndNew_Click);
            // 
            // tsbQuite
            // 
            this.tsbQuite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbQuite.Image = ((System.Drawing.Image)(resources.GetObject("tsbQuite.Image")));
            this.tsbQuite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbQuite.Name = "tsbQuite";
            this.tsbQuite.Size = new System.Drawing.Size(36, 22);
            this.tsbQuite.Text = "取消";
            this.tsbQuite.Click += new System.EventHandler(this.tsbQuite_Click);
            // 
            // ToolBugCommit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackPalace = ((System.Drawing.Image)(resources.GetObject("$this.BackPalace")));
            this.ClientSize = new System.Drawing.Size(1730, 825);
            this.Controls.Add(this.tlpMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ToolBugCommit";
            this.Text = "新建缺陷";
            this.TitleCenter = false;
            this.tlpMain.ResumeLayout(false);
            this.tlpMainManager.ResumeLayout(false);
            this.tlpMainManager.PerformLayout();
            this.tlpMainEditor.ResumeLayout(false);
            this.tlpReviewer.ResumeLayout(false);
            this.tlpReviewer.PerformLayout();
            this.tlpAttachment.ResumeLayout(false);
            this.tlpAttachment.PerformLayout();
            this.tlpTitle.ResumeLayout(false);
            this.tlpTitle.PerformLayout();
            this.tlpSort.ResumeLayout(false);
            this.tlpSort.PerformLayout();
            this.tlpProject.ResumeLayout(false);
            this.tlpProject.PerformLayout();
            this.tlpEditor.ResumeLayout(false);
            this.tlpEditor.PerformLayout();
            this.tlpStsEditor.ResumeLayout(false);
            this.tlpStsEditor.PerformLayout();
            this.stsEditor.ResumeLayout(false);
            this.stsEditor.PerformLayout();
            this.stsManager.ResumeLayout(false);
            this.stsManager.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpMainManager;
        private System.Windows.Forms.TableLayoutPanel tlpMainEditor;
        private System.Windows.Forms.TableLayoutPanel tlpReviewer;
        private CCWin.SkinControl.SkinLabel labAuditor;
        private System.Windows.Forms.Button btnAuditor;
        private System.Windows.Forms.TextBox txtAuditor;
        private System.Windows.Forms.TableLayoutPanel tlpAttachment;
        private CCWin.SkinControl.SkinLabel labAttachement;
        private System.Windows.Forms.Button btnAttachment;
        private System.Windows.Forms.TextBox txtAttachment;
        private System.Windows.Forms.TableLayoutPanel tlpTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private CCWin.SkinControl.SkinLabel labTitle;
        private System.Windows.Forms.TableLayoutPanel tlpSort;
        private CCWin.SkinControl.SkinLabel labAuthor;
        private CCWin.SkinControl.SkinLabel labCategory;
        private CCWin.SkinControl.SkinComboBox cbOccurrence;
        private CCWin.SkinControl.SkinLabel labPriority;
        private CCWin.SkinControl.SkinComboBox cbPriority;
        private CCWin.SkinControl.SkinLabel labHowFound;
        private CCWin.SkinControl.SkinLabel labGravity;
        private CCWin.SkinControl.SkinLabel labFoundVersion;
        private CCWin.SkinControl.SkinLabel labExceptDate;
        private CCWin.SkinControl.SkinLabel labFillDate;
        private CCWin.SkinControl.SkinComboBox cbProductVersion;
        private CCWin.SkinControl.SkinComboBox cbCategory;
        private CCWin.SkinControl.SkinComboBox cbHowFound;
        private CCWin.SkinControl.SkinComboBox cbGravity;
        private CCWin.SkinControl.SkinComboBox cbFoundVersion;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Button btnAuthor;
        private CCWin.SkinControl.SkinLabel labOccurrence;
        private CCWin.SkinControl.SkinLabel labProductVersion;
        private System.Windows.Forms.TableLayoutPanel tlpProject;
        private CCWin.SkinControl.SkinLabel labAttribution;
        private System.Windows.Forms.TextBox txtAttribution;
        private System.Windows.Forms.Button btnProject;
        private System.Windows.Forms.TableLayoutPanel tlpEditor;
        private CCWin.SkinControl.SkinLabel labDetails;
        private System.Windows.Forms.TableLayoutPanel tlpStsEditor;
        private CCWin.SkinControl.SkinDateTimePicker dtpExceptDate;
        private CCWin.SkinControl.SkinDateTimePicker dtpFillDate;
        private CCWin.SkinControl.SkinToolStrip stsEditor;
        private System.Windows.Forms.ToolStripButton 剪切UToolStripButton;
        private System.Windows.Forms.ToolStripButton 复制CToolStripButton;
        private System.Windows.Forms.ToolStripButton 粘贴PToolStripButton;
        private System.Windows.Forms.ToolStripSeparator tssSeparatorOne;
        private System.Windows.Forms.ToolStripButton 帮助LToolStripButton;
        private CCWin.SkinControl.SkinToolStrip stsManager;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbSaveAndNew;
        private System.Windows.Forms.ToolStripButton tsbCommit;
        private System.Windows.Forms.ToolStripButton tsbCommitAndNew;
        private System.Windows.Forms.ToolStripButton tsbQuite;
        private CCWin.SkinControl.SkinChatRichTextBox srtbDescription;
    }
}