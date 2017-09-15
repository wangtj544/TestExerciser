namespace TestExerciser.Tools.CaseManagement
{
    partial class ToolCaseCommit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolCaseCommit));
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMainManager = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMainEditor = new System.Windows.Forms.TableLayoutPanel();
            this.tlpSort = new System.Windows.Forms.TableLayoutPanel();
            this.labProject = new CCWin.SkinControl.SkinLabel();
            this.labAuthor = new CCWin.SkinControl.SkinLabel();
            this.labSubModule = new CCWin.SkinControl.SkinLabel();
            this.tb_SubModule = new CCWin.SkinControl.SkinTextBox();
            this.labTestDate = new CCWin.SkinControl.SkinLabel();
            this.labReqNO = new CCWin.SkinControl.SkinLabel();
            this.labParentModule = new CCWin.SkinControl.SkinLabel();
            this.labTester = new CCWin.SkinControl.SkinLabel();
            this.dtpTestDate = new CCWin.SkinControl.SkinDateTimePicker();
            this.tb_Project = new CCWin.SkinControl.SkinTextBox();
            this.labTSNO = new CCWin.SkinControl.SkinLabel();
            this.labTSName = new CCWin.SkinControl.SkinLabel();
            this.labTCNO = new CCWin.SkinControl.SkinLabel();
            this.tb_TSNO = new CCWin.SkinControl.SkinTextBox();
            this.tb_TSName = new CCWin.SkinControl.SkinTextBox();
            this.tb_TCNO = new CCWin.SkinControl.SkinTextBox();
            this.tb_ParentModule = new CCWin.SkinControl.SkinTextBox();
            this.cb_Author = new CCWin.SkinControl.SkinComboBox();
            this.cb_IfAuto = new CCWin.SkinControl.SkinComboBox();
            this.btnAuthor = new System.Windows.Forms.Button();
            this.labTCName = new CCWin.SkinControl.SkinLabel();
            this.tb_TCName = new CCWin.SkinControl.SkinTextBox();
            this.labStruct = new CCWin.SkinControl.SkinLabel();
            this.labIfAuto = new CCWin.SkinControl.SkinLabel();
            this.labCaseLevel = new CCWin.SkinControl.SkinLabel();
            this.cb_Struct = new CCWin.SkinControl.SkinComboBox();
            this.cb_Tester = new CCWin.SkinControl.SkinComboBox();
            this.cb_CaseLevel = new CCWin.SkinControl.SkinComboBox();
            this.tb_ReqNO = new CCWin.SkinControl.SkinTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labPrecondition = new CCWin.SkinControl.SkinLabel();
            this.labSteps = new CCWin.SkinControl.SkinLabel();
            this.labSamples = new CCWin.SkinControl.SkinLabel();
            this.labExcept = new CCWin.SkinControl.SkinLabel();
            this.labActually = new CCWin.SkinControl.SkinLabel();
            this.rtb_Precondition = new CCWin.SkinControl.SkinChatRichTextBox();
            this.rtb_Steps = new CCWin.SkinControl.SkinChatRichTextBox();
            this.rtb_Samples = new CCWin.SkinControl.SkinChatRichTextBox();
            this.rtb_Except = new CCWin.SkinControl.SkinChatRichTextBox();
            this.cb_Actually = new CCWin.SkinControl.SkinComboBox();
            this.stsManager = new CCWin.SkinControl.SkinToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbSaveAndNew = new System.Windows.Forms.ToolStripButton();
            this.tsbCommit = new System.Windows.Forms.ToolStripButton();
            this.tsbCommitAndNew = new System.Windows.Forms.ToolStripButton();
            this.tsbQuite = new System.Windows.Forms.ToolStripButton();
            this.tlpMain.SuspendLayout();
            this.tlpMainManager.SuspendLayout();
            this.tlpMainEditor.SuspendLayout();
            this.tlpSort.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.tlpMain.Size = new System.Drawing.Size(1432, 789);
            this.tlpMain.TabIndex = 2;
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
            this.tlpMainManager.Size = new System.Drawing.Size(1426, 783);
            this.tlpMainManager.TabIndex = 1;
            // 
            // tlpMainEditor
            // 
            this.tlpMainEditor.ColumnCount = 1;
            this.tlpMainEditor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainEditor.Controls.Add(this.tlpSort, 0, 0);
            this.tlpMainEditor.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tlpMainEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainEditor.Location = new System.Drawing.Point(3, 33);
            this.tlpMainEditor.Name = "tlpMainEditor";
            this.tlpMainEditor.RowCount = 2;
            this.tlpMainEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.tlpMainEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainEditor.Size = new System.Drawing.Size(1420, 747);
            this.tlpMainEditor.TabIndex = 2;
            // 
            // tlpSort
            // 
            this.tlpSort.ColumnCount = 5;
            this.tlpSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tlpSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tlpSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSort.Controls.Add(this.labProject, 0, 0);
            this.tlpSort.Controls.Add(this.labAuthor, 0, 5);
            this.tlpSort.Controls.Add(this.labSubModule, 3, 4);
            this.tlpSort.Controls.Add(this.tb_SubModule, 4, 4);
            this.tlpSort.Controls.Add(this.labTestDate, 3, 6);
            this.tlpSort.Controls.Add(this.labReqNO, 0, 3);
            this.tlpSort.Controls.Add(this.labParentModule, 0, 4);
            this.tlpSort.Controls.Add(this.labTester, 0, 6);
            this.tlpSort.Controls.Add(this.dtpTestDate, 4, 6);
            this.tlpSort.Controls.Add(this.tb_Project, 1, 0);
            this.tlpSort.Controls.Add(this.labTSNO, 0, 1);
            this.tlpSort.Controls.Add(this.labTSName, 3, 1);
            this.tlpSort.Controls.Add(this.labTCNO, 0, 2);
            this.tlpSort.Controls.Add(this.tb_TSNO, 1, 1);
            this.tlpSort.Controls.Add(this.tb_TSName, 4, 1);
            this.tlpSort.Controls.Add(this.tb_TCNO, 1, 2);
            this.tlpSort.Controls.Add(this.tb_ParentModule, 1, 4);
            this.tlpSort.Controls.Add(this.cb_Author, 1, 5);
            this.tlpSort.Controls.Add(this.cb_IfAuto, 4, 5);
            this.tlpSort.Controls.Add(this.btnAuthor, 2, 0);
            this.tlpSort.Controls.Add(this.labTCName, 3, 2);
            this.tlpSort.Controls.Add(this.tb_TCName, 4, 2);
            this.tlpSort.Controls.Add(this.labStruct, 3, 0);
            this.tlpSort.Controls.Add(this.labIfAuto, 3, 5);
            this.tlpSort.Controls.Add(this.labCaseLevel, 3, 3);
            this.tlpSort.Controls.Add(this.cb_Struct, 4, 0);
            this.tlpSort.Controls.Add(this.cb_Tester, 1, 6);
            this.tlpSort.Controls.Add(this.cb_CaseLevel, 4, 3);
            this.tlpSort.Controls.Add(this.tb_ReqNO, 1, 3);
            this.tlpSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSort.Location = new System.Drawing.Point(3, 3);
            this.tlpSort.Name = "tlpSort";
            this.tlpSort.RowCount = 7;
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlpSort.Size = new System.Drawing.Size(1414, 198);
            this.tlpSort.TabIndex = 2;
            // 
            // labProject
            // 
            this.labProject.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labProject.AutoSize = true;
            this.labProject.BackColor = System.Drawing.Color.White;
            this.labProject.BorderColor = System.Drawing.Color.White;
            this.labProject.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labProject.Location = new System.Drawing.Point(3, 5);
            this.labProject.Name = "labProject";
            this.labProject.Size = new System.Drawing.Size(68, 17);
            this.labProject.TabIndex = 4;
            this.labProject.Text = "所属项目：";
            // 
            // labAuthor
            // 
            this.labAuthor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labAuthor.AutoSize = true;
            this.labAuthor.BackColor = System.Drawing.Color.Transparent;
            this.labAuthor.BorderColor = System.Drawing.Color.White;
            this.labAuthor.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labAuthor.Location = new System.Drawing.Point(3, 145);
            this.labAuthor.Name = "labAuthor";
            this.labAuthor.Size = new System.Drawing.Size(68, 17);
            this.labAuthor.TabIndex = 45;
            this.labAuthor.Text = "用例作者：";
            // 
            // labSubModule
            // 
            this.labSubModule.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labSubModule.AutoSize = true;
            this.labSubModule.BackColor = System.Drawing.Color.White;
            this.labSubModule.BorderColor = System.Drawing.Color.White;
            this.labSubModule.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labSubModule.Location = new System.Drawing.Point(716, 117);
            this.labSubModule.Name = "labSubModule";
            this.labSubModule.Size = new System.Drawing.Size(56, 17);
            this.labSubModule.TabIndex = 16;
            this.labSubModule.Text = "子模块：";
            // 
            // tb_SubModule
            // 
            this.tb_SubModule.BackColor = System.Drawing.Color.Transparent;
            this.tb_SubModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_SubModule.DownBack = null;
            this.tb_SubModule.Icon = null;
            this.tb_SubModule.IconIsButton = false;
            this.tb_SubModule.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_SubModule.IsPasswordChat = '\0';
            this.tb_SubModule.IsSystemPasswordChar = false;
            this.tb_SubModule.Lines = new string[0];
            this.tb_SubModule.Location = new System.Drawing.Point(822, 112);
            this.tb_SubModule.Margin = new System.Windows.Forms.Padding(0);
            this.tb_SubModule.MaxLength = 32767;
            this.tb_SubModule.MinimumSize = new System.Drawing.Size(28, 28);
            this.tb_SubModule.MouseBack = null;
            this.tb_SubModule.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_SubModule.Multiline = false;
            this.tb_SubModule.Name = "tb_SubModule";
            this.tb_SubModule.NormlBack = null;
            this.tb_SubModule.Padding = new System.Windows.Forms.Padding(5);
            this.tb_SubModule.ReadOnly = false;
            this.tb_SubModule.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_SubModule.Size = new System.Drawing.Size(592, 28);
            // 
            // 
            // 
            this.tb_SubModule.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_SubModule.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_SubModule.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tb_SubModule.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tb_SubModule.SkinTxt.Name = "BaseText";
            this.tb_SubModule.SkinTxt.Size = new System.Drawing.Size(582, 18);
            this.tb_SubModule.SkinTxt.TabIndex = 0;
            this.tb_SubModule.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_SubModule.SkinTxt.WaterText = "必填...";
            this.tb_SubModule.TabIndex = 5;
            this.tb_SubModule.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_SubModule.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_SubModule.WaterText = "必填...";
            this.tb_SubModule.WordWrap = true;
            // 
            // labTestDate
            // 
            this.labTestDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labTestDate.AutoSize = true;
            this.labTestDate.BackColor = System.Drawing.Color.White;
            this.labTestDate.BorderColor = System.Drawing.Color.White;
            this.labTestDate.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTestDate.Location = new System.Drawing.Point(716, 174);
            this.labTestDate.Name = "labTestDate";
            this.labTestDate.Size = new System.Drawing.Size(68, 17);
            this.labTestDate.TabIndex = 18;
            this.labTestDate.Text = "测试日期：";
            // 
            // labReqNO
            // 
            this.labReqNO.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labReqNO.AutoSize = true;
            this.labReqNO.BackColor = System.Drawing.Color.White;
            this.labReqNO.BorderColor = System.Drawing.Color.White;
            this.labReqNO.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labReqNO.Location = new System.Drawing.Point(3, 89);
            this.labReqNO.Name = "labReqNO";
            this.labReqNO.Size = new System.Drawing.Size(68, 17);
            this.labReqNO.TabIndex = 10;
            this.labReqNO.Text = "需求编号：";
            // 
            // labParentModule
            // 
            this.labParentModule.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labParentModule.AutoSize = true;
            this.labParentModule.BackColor = System.Drawing.Color.White;
            this.labParentModule.BorderColor = System.Drawing.Color.White;
            this.labParentModule.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labParentModule.Location = new System.Drawing.Point(3, 117);
            this.labParentModule.Name = "labParentModule";
            this.labParentModule.Size = new System.Drawing.Size(56, 17);
            this.labParentModule.TabIndex = 30;
            this.labParentModule.Text = "父模块：";
            // 
            // labTester
            // 
            this.labTester.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labTester.AutoSize = true;
            this.labTester.BackColor = System.Drawing.Color.White;
            this.labTester.BorderColor = System.Drawing.Color.White;
            this.labTester.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTester.Location = new System.Drawing.Point(3, 174);
            this.labTester.Name = "labTester";
            this.labTester.Size = new System.Drawing.Size(68, 17);
            this.labTester.TabIndex = 13;
            this.labTester.Text = "测试人员：";
            // 
            // dtpTestDate
            // 
            this.dtpTestDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpTestDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpTestDate.DropDownHeight = 180;
            this.dtpTestDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.dtpTestDate.DropDownWidth = 120;
            this.dtpTestDate.font = new System.Drawing.Font("微软雅黑", 9F);
            this.dtpTestDate.Items = null;
            this.dtpTestDate.Location = new System.Drawing.Point(825, 171);
            this.dtpTestDate.Name = "dtpTestDate";
            this.dtpTestDate.Size = new System.Drawing.Size(586, 24);
            this.dtpTestDate.TabIndex = 31;
            this.dtpTestDate.text = "";
            // 
            // tb_Project
            // 
            this.tb_Project.BackColor = System.Drawing.Color.Transparent;
            this.tb_Project.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Project.DownBack = null;
            this.tb_Project.Icon = null;
            this.tb_Project.IconIsButton = false;
            this.tb_Project.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_Project.IsPasswordChat = '\0';
            this.tb_Project.IsSystemPasswordChar = false;
            this.tb_Project.Lines = new string[0];
            this.tb_Project.Location = new System.Drawing.Point(91, 0);
            this.tb_Project.Margin = new System.Windows.Forms.Padding(0);
            this.tb_Project.MaxLength = 32767;
            this.tb_Project.MinimumSize = new System.Drawing.Size(28, 28);
            this.tb_Project.MouseBack = null;
            this.tb_Project.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_Project.Multiline = false;
            this.tb_Project.Name = "tb_Project";
            this.tb_Project.NormlBack = null;
            this.tb_Project.Padding = new System.Windows.Forms.Padding(5);
            this.tb_Project.ReadOnly = true;
            this.tb_Project.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Project.Size = new System.Drawing.Size(592, 28);
            // 
            // 
            // 
            this.tb_Project.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Project.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Project.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tb_Project.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tb_Project.SkinTxt.Name = "BaseText";
            this.tb_Project.SkinTxt.ReadOnly = true;
            this.tb_Project.SkinTxt.Size = new System.Drawing.Size(582, 18);
            this.tb_Project.SkinTxt.TabIndex = 0;
            this.tb_Project.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_Project.SkinTxt.WaterText = "必选...";
            this.tb_Project.TabIndex = 32;
            this.tb_Project.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_Project.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_Project.WaterText = "必选...";
            this.tb_Project.WordWrap = true;
            // 
            // labTSNO
            // 
            this.labTSNO.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labTSNO.AutoSize = true;
            this.labTSNO.BackColor = System.Drawing.Color.White;
            this.labTSNO.BorderColor = System.Drawing.Color.White;
            this.labTSNO.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTSNO.Location = new System.Drawing.Point(3, 33);
            this.labTSNO.Name = "labTSNO";
            this.labTSNO.Size = new System.Drawing.Size(80, 17);
            this.labTSNO.TabIndex = 33;
            this.labTSNO.Text = "测试套编号：";
            // 
            // labTSName
            // 
            this.labTSName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labTSName.AutoSize = true;
            this.labTSName.BackColor = System.Drawing.Color.White;
            this.labTSName.BorderColor = System.Drawing.Color.White;
            this.labTSName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTSName.Location = new System.Drawing.Point(716, 33);
            this.labTSName.Name = "labTSName";
            this.labTSName.Size = new System.Drawing.Size(80, 17);
            this.labTSName.TabIndex = 34;
            this.labTSName.Text = "测试套名称：";
            // 
            // labTCNO
            // 
            this.labTCNO.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labTCNO.AutoSize = true;
            this.labTCNO.BackColor = System.Drawing.Color.Transparent;
            this.labTCNO.BorderColor = System.Drawing.Color.White;
            this.labTCNO.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTCNO.Location = new System.Drawing.Point(3, 61);
            this.labTCNO.Name = "labTCNO";
            this.labTCNO.Size = new System.Drawing.Size(68, 17);
            this.labTCNO.TabIndex = 37;
            this.labTCNO.Text = "用例编号：";
            // 
            // tb_TSNO
            // 
            this.tb_TSNO.BackColor = System.Drawing.Color.Transparent;
            this.tb_TSNO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_TSNO.DownBack = null;
            this.tb_TSNO.Icon = null;
            this.tb_TSNO.IconIsButton = false;
            this.tb_TSNO.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_TSNO.IsPasswordChat = '\0';
            this.tb_TSNO.IsSystemPasswordChar = false;
            this.tb_TSNO.Lines = new string[0];
            this.tb_TSNO.Location = new System.Drawing.Point(91, 28);
            this.tb_TSNO.Margin = new System.Windows.Forms.Padding(0);
            this.tb_TSNO.MaxLength = 32767;
            this.tb_TSNO.MinimumSize = new System.Drawing.Size(28, 28);
            this.tb_TSNO.MouseBack = null;
            this.tb_TSNO.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_TSNO.Multiline = false;
            this.tb_TSNO.Name = "tb_TSNO";
            this.tb_TSNO.NormlBack = null;
            this.tb_TSNO.Padding = new System.Windows.Forms.Padding(5);
            this.tb_TSNO.ReadOnly = false;
            this.tb_TSNO.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_TSNO.Size = new System.Drawing.Size(592, 28);
            // 
            // 
            // 
            this.tb_TSNO.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_TSNO.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_TSNO.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tb_TSNO.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tb_TSNO.SkinTxt.Name = "BaseText";
            this.tb_TSNO.SkinTxt.Size = new System.Drawing.Size(582, 18);
            this.tb_TSNO.SkinTxt.TabIndex = 0;
            this.tb_TSNO.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_TSNO.SkinTxt.WaterText = "必填...";
            this.tb_TSNO.TabIndex = 38;
            this.tb_TSNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_TSNO.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_TSNO.WaterText = "（产品_子系统_父模块_子模块_测试套记号）";
            this.tb_TSNO.WordWrap = true;
            // 
            // tb_TSName
            // 
            this.tb_TSName.BackColor = System.Drawing.Color.Transparent;
            this.tb_TSName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_TSName.DownBack = null;
            this.tb_TSName.Icon = null;
            this.tb_TSName.IconIsButton = false;
            this.tb_TSName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_TSName.IsPasswordChat = '\0';
            this.tb_TSName.IsSystemPasswordChar = false;
            this.tb_TSName.Lines = new string[0];
            this.tb_TSName.Location = new System.Drawing.Point(822, 28);
            this.tb_TSName.Margin = new System.Windows.Forms.Padding(0);
            this.tb_TSName.MaxLength = 32767;
            this.tb_TSName.MinimumSize = new System.Drawing.Size(28, 28);
            this.tb_TSName.MouseBack = null;
            this.tb_TSName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_TSName.Multiline = false;
            this.tb_TSName.Name = "tb_TSName";
            this.tb_TSName.NormlBack = null;
            this.tb_TSName.Padding = new System.Windows.Forms.Padding(5);
            this.tb_TSName.ReadOnly = false;
            this.tb_TSName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_TSName.Size = new System.Drawing.Size(592, 28);
            // 
            // 
            // 
            this.tb_TSName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_TSName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_TSName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tb_TSName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tb_TSName.SkinTxt.Name = "BaseText";
            this.tb_TSName.SkinTxt.Size = new System.Drawing.Size(582, 18);
            this.tb_TSName.SkinTxt.TabIndex = 0;
            this.tb_TSName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_TSName.SkinTxt.WaterText = "必填...";
            this.tb_TSName.TabIndex = 39;
            this.tb_TSName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_TSName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_TSName.WaterText = "必填...";
            this.tb_TSName.WordWrap = true;
            // 
            // tb_TCNO
            // 
            this.tb_TCNO.BackColor = System.Drawing.Color.Transparent;
            this.tb_TCNO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_TCNO.DownBack = null;
            this.tb_TCNO.Icon = null;
            this.tb_TCNO.IconIsButton = false;
            this.tb_TCNO.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_TCNO.IsPasswordChat = '\0';
            this.tb_TCNO.IsSystemPasswordChar = false;
            this.tb_TCNO.Lines = new string[0];
            this.tb_TCNO.Location = new System.Drawing.Point(91, 56);
            this.tb_TCNO.Margin = new System.Windows.Forms.Padding(0);
            this.tb_TCNO.MaxLength = 32767;
            this.tb_TCNO.MinimumSize = new System.Drawing.Size(28, 28);
            this.tb_TCNO.MouseBack = null;
            this.tb_TCNO.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_TCNO.Multiline = false;
            this.tb_TCNO.Name = "tb_TCNO";
            this.tb_TCNO.NormlBack = null;
            this.tb_TCNO.Padding = new System.Windows.Forms.Padding(5);
            this.tb_TCNO.ReadOnly = false;
            this.tb_TCNO.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_TCNO.Size = new System.Drawing.Size(592, 28);
            // 
            // 
            // 
            this.tb_TCNO.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_TCNO.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_TCNO.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tb_TCNO.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tb_TCNO.SkinTxt.Name = "BaseText";
            this.tb_TCNO.SkinTxt.Size = new System.Drawing.Size(582, 18);
            this.tb_TCNO.SkinTxt.TabIndex = 0;
            this.tb_TCNO.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_TCNO.SkinTxt.WaterText = "必填...";
            this.tb_TCNO.TabIndex = 40;
            this.tb_TCNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_TCNO.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_TCNO.WaterText = "（产品_子系统_父模块_子模块_测试套记号_用例记号）";
            this.tb_TCNO.WordWrap = true;
            // 
            // tb_ParentModule
            // 
            this.tb_ParentModule.BackColor = System.Drawing.Color.Transparent;
            this.tb_ParentModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_ParentModule.DownBack = null;
            this.tb_ParentModule.Icon = null;
            this.tb_ParentModule.IconIsButton = false;
            this.tb_ParentModule.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_ParentModule.IsPasswordChat = '\0';
            this.tb_ParentModule.IsSystemPasswordChar = false;
            this.tb_ParentModule.Lines = new string[0];
            this.tb_ParentModule.Location = new System.Drawing.Point(91, 112);
            this.tb_ParentModule.Margin = new System.Windows.Forms.Padding(0);
            this.tb_ParentModule.MaxLength = 32767;
            this.tb_ParentModule.MinimumSize = new System.Drawing.Size(28, 28);
            this.tb_ParentModule.MouseBack = null;
            this.tb_ParentModule.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_ParentModule.Multiline = false;
            this.tb_ParentModule.Name = "tb_ParentModule";
            this.tb_ParentModule.NormlBack = null;
            this.tb_ParentModule.Padding = new System.Windows.Forms.Padding(5);
            this.tb_ParentModule.ReadOnly = false;
            this.tb_ParentModule.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_ParentModule.Size = new System.Drawing.Size(592, 28);
            // 
            // 
            // 
            this.tb_ParentModule.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ParentModule.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_ParentModule.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tb_ParentModule.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tb_ParentModule.SkinTxt.Name = "BaseText";
            this.tb_ParentModule.SkinTxt.Size = new System.Drawing.Size(582, 18);
            this.tb_ParentModule.SkinTxt.TabIndex = 0;
            this.tb_ParentModule.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_ParentModule.SkinTxt.WaterText = "必填...";
            this.tb_ParentModule.TabIndex = 41;
            this.tb_ParentModule.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_ParentModule.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_ParentModule.WaterText = "必填...";
            this.tb_ParentModule.WordWrap = true;
            // 
            // cb_Author
            // 
            this.cb_Author.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_Author.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Author.FormattingEnabled = true;
            this.cb_Author.Location = new System.Drawing.Point(94, 143);
            this.cb_Author.Name = "cb_Author";
            this.cb_Author.Size = new System.Drawing.Size(586, 22);
            this.cb_Author.TabIndex = 42;
            this.cb_Author.WaterText = "必填...";
            // 
            // cb_IfAuto
            // 
            this.cb_IfAuto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_IfAuto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_IfAuto.FormattingEnabled = true;
            this.cb_IfAuto.Location = new System.Drawing.Point(825, 143);
            this.cb_IfAuto.Name = "cb_IfAuto";
            this.cb_IfAuto.Size = new System.Drawing.Size(586, 22);
            this.cb_IfAuto.TabIndex = 43;
            this.cb_IfAuto.WaterText = "必填...";
            // 
            // btnAuthor
            // 
            this.btnAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(195)))), ((int)(((byte)(245)))));
            this.btnAuthor.Image = ((System.Drawing.Image)(resources.GetObject("btnAuthor.Image")));
            this.btnAuthor.Location = new System.Drawing.Point(686, 3);
            this.btnAuthor.Name = "btnAuthor";
            this.btnAuthor.Size = new System.Drawing.Size(24, 21);
            this.btnAuthor.TabIndex = 28;
            this.btnAuthor.UseVisualStyleBackColor = false;
            // 
            // labTCName
            // 
            this.labTCName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labTCName.AutoSize = true;
            this.labTCName.BackColor = System.Drawing.Color.White;
            this.labTCName.BorderColor = System.Drawing.Color.White;
            this.labTCName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTCName.Location = new System.Drawing.Point(716, 61);
            this.labTCName.Name = "labTCName";
            this.labTCName.Size = new System.Drawing.Size(68, 17);
            this.labTCName.TabIndex = 14;
            this.labTCName.Text = "用例名称：";
            // 
            // tb_TCName
            // 
            this.tb_TCName.BackColor = System.Drawing.Color.Transparent;
            this.tb_TCName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_TCName.DownBack = null;
            this.tb_TCName.Icon = null;
            this.tb_TCName.IconIsButton = false;
            this.tb_TCName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_TCName.IsPasswordChat = '\0';
            this.tb_TCName.IsSystemPasswordChar = false;
            this.tb_TCName.Lines = new string[0];
            this.tb_TCName.Location = new System.Drawing.Point(822, 56);
            this.tb_TCName.Margin = new System.Windows.Forms.Padding(0);
            this.tb_TCName.MaxLength = 32767;
            this.tb_TCName.MinimumSize = new System.Drawing.Size(28, 28);
            this.tb_TCName.MouseBack = null;
            this.tb_TCName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_TCName.Multiline = false;
            this.tb_TCName.Name = "tb_TCName";
            this.tb_TCName.NormlBack = null;
            this.tb_TCName.Padding = new System.Windows.Forms.Padding(5);
            this.tb_TCName.ReadOnly = false;
            this.tb_TCName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_TCName.Size = new System.Drawing.Size(592, 28);
            // 
            // 
            // 
            this.tb_TCName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_TCName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_TCName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tb_TCName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tb_TCName.SkinTxt.Name = "BaseText";
            this.tb_TCName.SkinTxt.Size = new System.Drawing.Size(582, 18);
            this.tb_TCName.SkinTxt.TabIndex = 0;
            this.tb_TCName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_TCName.SkinTxt.WaterText = "必填...";
            this.tb_TCName.TabIndex = 46;
            this.tb_TCName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_TCName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_TCName.WaterText = "必填...";
            this.tb_TCName.WordWrap = true;
            // 
            // labStruct
            // 
            this.labStruct.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labStruct.AutoSize = true;
            this.labStruct.BackColor = System.Drawing.Color.White;
            this.labStruct.BorderColor = System.Drawing.Color.White;
            this.labStruct.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labStruct.Location = new System.Drawing.Point(716, 5);
            this.labStruct.Name = "labStruct";
            this.labStruct.Size = new System.Drawing.Size(68, 17);
            this.labStruct.TabIndex = 15;
            this.labStruct.Text = "产品构建：";
            // 
            // labIfAuto
            // 
            this.labIfAuto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labIfAuto.AutoSize = true;
            this.labIfAuto.BackColor = System.Drawing.Color.White;
            this.labIfAuto.BorderColor = System.Drawing.Color.White;
            this.labIfAuto.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labIfAuto.Location = new System.Drawing.Point(716, 145);
            this.labIfAuto.Name = "labIfAuto";
            this.labIfAuto.Size = new System.Drawing.Size(92, 17);
            this.labIfAuto.TabIndex = 36;
            this.labIfAuto.Text = "是否可自动化：";
            // 
            // labCaseLevel
            // 
            this.labCaseLevel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labCaseLevel.AutoSize = true;
            this.labCaseLevel.BackColor = System.Drawing.Color.White;
            this.labCaseLevel.BorderColor = System.Drawing.Color.White;
            this.labCaseLevel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCaseLevel.Location = new System.Drawing.Point(716, 89);
            this.labCaseLevel.Name = "labCaseLevel";
            this.labCaseLevel.Size = new System.Drawing.Size(68, 17);
            this.labCaseLevel.TabIndex = 35;
            this.labCaseLevel.Text = "用例级别：";
            // 
            // cb_Struct
            // 
            this.cb_Struct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_Struct.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Struct.FormattingEnabled = true;
            this.cb_Struct.Location = new System.Drawing.Point(825, 3);
            this.cb_Struct.Name = "cb_Struct";
            this.cb_Struct.Size = new System.Drawing.Size(586, 22);
            this.cb_Struct.TabIndex = 21;
            this.cb_Struct.WaterText = "必选...";
            // 
            // cb_Tester
            // 
            this.cb_Tester.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_Tester.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Tester.FormattingEnabled = true;
            this.cb_Tester.Location = new System.Drawing.Point(94, 171);
            this.cb_Tester.Name = "cb_Tester";
            this.cb_Tester.Size = new System.Drawing.Size(586, 22);
            this.cb_Tester.TabIndex = 47;
            this.cb_Tester.WaterText = "可选...";
            // 
            // cb_CaseLevel
            // 
            this.cb_CaseLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_CaseLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_CaseLevel.FormattingEnabled = true;
            this.cb_CaseLevel.Items.AddRange(new object[] {
            "级别1",
            "级别2",
            "级别3"});
            this.cb_CaseLevel.Location = new System.Drawing.Point(825, 87);
            this.cb_CaseLevel.Name = "cb_CaseLevel";
            this.cb_CaseLevel.Size = new System.Drawing.Size(586, 22);
            this.cb_CaseLevel.TabIndex = 48;
            this.cb_CaseLevel.WaterText = "";
            // 
            // tb_ReqNO
            // 
            this.tb_ReqNO.BackColor = System.Drawing.Color.Transparent;
            this.tb_ReqNO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_ReqNO.DownBack = null;
            this.tb_ReqNO.Icon = null;
            this.tb_ReqNO.IconIsButton = false;
            this.tb_ReqNO.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_ReqNO.IsPasswordChat = '\0';
            this.tb_ReqNO.IsSystemPasswordChar = false;
            this.tb_ReqNO.Lines = new string[0];
            this.tb_ReqNO.Location = new System.Drawing.Point(91, 84);
            this.tb_ReqNO.Margin = new System.Windows.Forms.Padding(0);
            this.tb_ReqNO.MaxLength = 32767;
            this.tb_ReqNO.MinimumSize = new System.Drawing.Size(28, 28);
            this.tb_ReqNO.MouseBack = null;
            this.tb_ReqNO.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_ReqNO.Multiline = false;
            this.tb_ReqNO.Name = "tb_ReqNO";
            this.tb_ReqNO.NormlBack = null;
            this.tb_ReqNO.Padding = new System.Windows.Forms.Padding(5);
            this.tb_ReqNO.ReadOnly = false;
            this.tb_ReqNO.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_ReqNO.Size = new System.Drawing.Size(592, 28);
            // 
            // 
            // 
            this.tb_ReqNO.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ReqNO.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_ReqNO.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tb_ReqNO.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tb_ReqNO.SkinTxt.Name = "BaseText";
            this.tb_ReqNO.SkinTxt.Size = new System.Drawing.Size(582, 18);
            this.tb_ReqNO.SkinTxt.TabIndex = 0;
            this.tb_ReqNO.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_ReqNO.SkinTxt.WaterText = "必填...";
            this.tb_ReqNO.TabIndex = 49;
            this.tb_ReqNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_ReqNO.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_ReqNO.WaterText = "必填...";
            this.tb_ReqNO.WordWrap = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.labPrecondition, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labSteps, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labSamples, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labExcept, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labActually, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.rtb_Precondition, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.rtb_Steps, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.rtb_Samples, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.rtb_Except, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cb_Actually, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 207);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1414, 537);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // labPrecondition
            // 
            this.labPrecondition.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labPrecondition.AutoSize = true;
            this.labPrecondition.BackColor = System.Drawing.Color.Transparent;
            this.labPrecondition.BorderColor = System.Drawing.Color.White;
            this.labPrecondition.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labPrecondition.Location = new System.Drawing.Point(3, 42);
            this.labPrecondition.Name = "labPrecondition";
            this.labPrecondition.Size = new System.Drawing.Size(68, 17);
            this.labPrecondition.TabIndex = 0;
            this.labPrecondition.Text = "预置条件：";
            // 
            // labSteps
            // 
            this.labSteps.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labSteps.AutoSize = true;
            this.labSteps.BackColor = System.Drawing.Color.Transparent;
            this.labSteps.BorderColor = System.Drawing.Color.White;
            this.labSteps.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labSteps.Location = new System.Drawing.Point(3, 194);
            this.labSteps.Name = "labSteps";
            this.labSteps.Size = new System.Drawing.Size(68, 17);
            this.labSteps.TabIndex = 1;
            this.labSteps.Text = "用例步骤：";
            // 
            // labSamples
            // 
            this.labSamples.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labSamples.AutoSize = true;
            this.labSamples.BackColor = System.Drawing.Color.Transparent;
            this.labSamples.BorderColor = System.Drawing.Color.White;
            this.labSamples.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labSamples.Location = new System.Drawing.Point(3, 346);
            this.labSamples.Name = "labSamples";
            this.labSamples.Size = new System.Drawing.Size(56, 17);
            this.labSamples.TabIndex = 2;
            this.labSamples.Text = "样本点：";
            // 
            // labExcept
            // 
            this.labExcept.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labExcept.AutoSize = true;
            this.labExcept.BackColor = System.Drawing.Color.Transparent;
            this.labExcept.BorderColor = System.Drawing.Color.White;
            this.labExcept.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labExcept.Location = new System.Drawing.Point(3, 447);
            this.labExcept.Name = "labExcept";
            this.labExcept.Size = new System.Drawing.Size(68, 17);
            this.labExcept.TabIndex = 3;
            this.labExcept.Text = "预期结果：";
            // 
            // labActually
            // 
            this.labActually.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labActually.AutoSize = true;
            this.labActually.BackColor = System.Drawing.Color.Transparent;
            this.labActually.BorderColor = System.Drawing.Color.White;
            this.labActually.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labActually.Location = new System.Drawing.Point(3, 513);
            this.labActually.Name = "labActually";
            this.labActually.Size = new System.Drawing.Size(68, 17);
            this.labActually.TabIndex = 4;
            this.labActually.Text = "实际结果：";
            // 
            // rtb_Precondition
            // 
            this.rtb_Precondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Precondition.Location = new System.Drawing.Point(93, 3);
            this.rtb_Precondition.Name = "rtb_Precondition";
            this.rtb_Precondition.SelectControl = null;
            this.rtb_Precondition.SelectControlIndex = 0;
            this.rtb_Precondition.SelectControlPoint = new System.Drawing.Point(0, 0);
            this.rtb_Precondition.Size = new System.Drawing.Size(1318, 95);
            this.rtb_Precondition.TabIndex = 5;
            this.rtb_Precondition.Text = "";
            // 
            // rtb_Steps
            // 
            this.rtb_Steps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Steps.Location = new System.Drawing.Point(93, 104);
            this.rtb_Steps.Name = "rtb_Steps";
            this.rtb_Steps.SelectControl = null;
            this.rtb_Steps.SelectControlIndex = 0;
            this.rtb_Steps.SelectControlPoint = new System.Drawing.Point(0, 0);
            this.rtb_Steps.Size = new System.Drawing.Size(1318, 197);
            this.rtb_Steps.TabIndex = 6;
            this.rtb_Steps.Text = "";
            // 
            // rtb_Samples
            // 
            this.rtb_Samples.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Samples.Location = new System.Drawing.Point(93, 307);
            this.rtb_Samples.Name = "rtb_Samples";
            this.rtb_Samples.SelectControl = null;
            this.rtb_Samples.SelectControlIndex = 0;
            this.rtb_Samples.SelectControlPoint = new System.Drawing.Point(0, 0);
            this.rtb_Samples.Size = new System.Drawing.Size(1318, 95);
            this.rtb_Samples.TabIndex = 7;
            this.rtb_Samples.Text = "";
            // 
            // rtb_Except
            // 
            this.rtb_Except.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Except.Location = new System.Drawing.Point(93, 408);
            this.rtb_Except.Name = "rtb_Except";
            this.rtb_Except.SelectControl = null;
            this.rtb_Except.SelectControlIndex = 0;
            this.rtb_Except.SelectControlPoint = new System.Drawing.Point(0, 0);
            this.rtb_Except.Size = new System.Drawing.Size(1318, 95);
            this.rtb_Except.TabIndex = 8;
            this.rtb_Except.Text = "";
            // 
            // cb_Actually
            // 
            this.cb_Actually.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_Actually.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Actually.FormattingEnabled = true;
            this.cb_Actually.Items.AddRange(new object[] {
            "PASS",
            "FAIL"});
            this.cb_Actually.Location = new System.Drawing.Point(93, 509);
            this.cb_Actually.Name = "cb_Actually";
            this.cb_Actually.Size = new System.Drawing.Size(1318, 22);
            this.cb_Actually.TabIndex = 9;
            this.cb_Actually.WaterText = "必填...";
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
            this.stsManager.Size = new System.Drawing.Size(1426, 25);
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
            // 
            // tsbSaveAndNew
            // 
            this.tsbSaveAndNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSaveAndNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbSaveAndNew.Image")));
            this.tsbSaveAndNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveAndNew.Name = "tsbSaveAndNew";
            this.tsbSaveAndNew.Size = new System.Drawing.Size(72, 22);
            this.tsbSaveAndNew.Text = "保存并新建";
            // 
            // tsbCommit
            // 
            this.tsbCommit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCommit.Image = ((System.Drawing.Image)(resources.GetObject("tsbCommit.Image")));
            this.tsbCommit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCommit.Name = "tsbCommit";
            this.tsbCommit.Size = new System.Drawing.Size(36, 22);
            this.tsbCommit.Text = "提交";
            // 
            // tsbCommitAndNew
            // 
            this.tsbCommitAndNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCommitAndNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbCommitAndNew.Image")));
            this.tsbCommitAndNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCommitAndNew.Name = "tsbCommitAndNew";
            this.tsbCommitAndNew.Size = new System.Drawing.Size(72, 22);
            this.tsbCommitAndNew.Text = "提交并新建";
            // 
            // tsbQuite
            // 
            this.tsbQuite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbQuite.Image = ((System.Drawing.Image)(resources.GetObject("tsbQuite.Image")));
            this.tsbQuite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbQuite.Name = "tsbQuite";
            this.tsbQuite.Size = new System.Drawing.Size(36, 22);
            this.tsbQuite.Text = "取消";
            // 
            // ToolCaseCommit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 825);
            this.Controls.Add(this.tlpMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ToolCaseCommit";
            this.Text = "新建用例";
            this.TitleCenter = false;
            this.tlpMain.ResumeLayout(false);
            this.tlpMainManager.ResumeLayout(false);
            this.tlpMainManager.PerformLayout();
            this.tlpMainEditor.ResumeLayout(false);
            this.tlpSort.ResumeLayout(false);
            this.tlpSort.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.stsManager.ResumeLayout(false);
            this.stsManager.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpMainManager;
        private CCWin.SkinControl.SkinToolStrip stsManager;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbSaveAndNew;
        private System.Windows.Forms.ToolStripButton tsbCommit;
        private System.Windows.Forms.ToolStripButton tsbCommitAndNew;
        private System.Windows.Forms.ToolStripButton tsbQuite;
        private System.Windows.Forms.TableLayoutPanel tlpMainEditor;
        private System.Windows.Forms.TableLayoutPanel tlpSort;
        private CCWin.SkinControl.SkinLabel labProject;
        private CCWin.SkinControl.SkinLabel labTCName;
        private CCWin.SkinControl.SkinLabel labStruct;
        private CCWin.SkinControl.SkinLabel labSubModule;
        private CCWin.SkinControl.SkinComboBox cb_Struct;
        private CCWin.SkinControl.SkinLabel labTestDate;
        private System.Windows.Forms.Button btnAuthor;
        private CCWin.SkinControl.SkinLabel labReqNO;
        private CCWin.SkinControl.SkinLabel labParentModule;
        private CCWin.SkinControl.SkinLabel labTester;
        private CCWin.SkinControl.SkinDateTimePicker dtpTestDate;
        private CCWin.SkinControl.SkinTextBox tb_Project;
        private CCWin.SkinControl.SkinLabel labTSNO;
        private CCWin.SkinControl.SkinLabel labTSName;
        private CCWin.SkinControl.SkinLabel labCaseLevel;
        private CCWin.SkinControl.SkinLabel labIfAuto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CCWin.SkinControl.SkinLabel labPrecondition;
        private CCWin.SkinControl.SkinLabel labSteps;
        private CCWin.SkinControl.SkinLabel labSamples;
        private CCWin.SkinControl.SkinLabel labExcept;
        private CCWin.SkinControl.SkinLabel labActually;
        private CCWin.SkinControl.SkinTextBox tb_SubModule;
        private CCWin.SkinControl.SkinLabel labTCNO;
        private CCWin.SkinControl.SkinTextBox tb_TSNO;
        private CCWin.SkinControl.SkinTextBox tb_TSName;
        private CCWin.SkinControl.SkinTextBox tb_TCNO;
        private CCWin.SkinControl.SkinTextBox tb_ParentModule;
        private CCWin.SkinControl.SkinComboBox cb_Author;
        private CCWin.SkinControl.SkinComboBox cb_IfAuto;
        private CCWin.SkinControl.SkinLabel labAuthor;
        private CCWin.SkinControl.SkinTextBox tb_TCName;
        private CCWin.SkinControl.SkinChatRichTextBox rtb_Precondition;
        private CCWin.SkinControl.SkinChatRichTextBox rtb_Steps;
        private CCWin.SkinControl.SkinChatRichTextBox rtb_Samples;
        private CCWin.SkinControl.SkinChatRichTextBox rtb_Except;
        private CCWin.SkinControl.SkinComboBox cb_Actually;
        private CCWin.SkinControl.SkinComboBox cb_Tester;
        private CCWin.SkinControl.SkinComboBox cb_CaseLevel;
        private CCWin.SkinControl.SkinTextBox tb_ReqNO;
    }
}