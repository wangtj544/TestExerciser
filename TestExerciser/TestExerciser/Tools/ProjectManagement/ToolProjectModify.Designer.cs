namespace TestExerciser.Tools.ProjectManagement
{
    partial class ToolProjectModify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolProjectModify));
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMainManager = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMainEditor = new System.Windows.Forms.TableLayoutPanel();
            this.tlpSort = new System.Windows.Forms.TableLayoutPanel();
            this.labProjectName = new CCWin.SkinControl.SkinLabel();
            this.labDepartment = new CCWin.SkinControl.SkinLabel();
            this.labType = new CCWin.SkinControl.SkinLabel();
            this.labPriority = new CCWin.SkinControl.SkinLabel();
            this.tb_ProjectName = new CCWin.SkinControl.SkinTextBox();
            this.labShortName = new CCWin.SkinControl.SkinLabel();
            this.labProjectNO = new CCWin.SkinControl.SkinLabel();
            this.tb_ShortName = new CCWin.SkinControl.SkinTextBox();
            this.tb_ProjectNO = new CCWin.SkinControl.SkinTextBox();
            this.tb_Department = new CCWin.SkinControl.SkinTextBox();
            this.labManager = new CCWin.SkinControl.SkinLabel();
            this.labAssistant = new CCWin.SkinControl.SkinLabel();
            this.labSetUpTime = new CCWin.SkinControl.SkinLabel();
            this.labClosedTime = new CCWin.SkinControl.SkinLabel();
            this.labCustomer = new CCWin.SkinControl.SkinLabel();
            this.labDevelopmentSite = new CCWin.SkinControl.SkinLabel();
            this.labAuthor = new CCWin.SkinControl.SkinLabel();
            this.labBuildTime = new CCWin.SkinControl.SkinLabel();
            this.labModifier = new CCWin.SkinControl.SkinLabel();
            this.labModifyTime = new CCWin.SkinControl.SkinLabel();
            this.tb_Manager = new CCWin.SkinControl.SkinTextBox();
            this.tb_Assistant = new CCWin.SkinControl.SkinTextBox();
            this.tb_Customer = new CCWin.SkinControl.SkinTextBox();
            this.tb_DevelopmentSite = new CCWin.SkinControl.SkinTextBox();
            this.tb_Author = new CCWin.SkinControl.SkinTextBox();
            this.tb_Modifier = new CCWin.SkinControl.SkinTextBox();
            this.cb_Type = new CCWin.SkinControl.SkinComboBox();
            this.cb_Priority = new CCWin.SkinControl.SkinComboBox();
            this.dtp_SetUpTime = new CCWin.SkinControl.SkinDateTimePicker();
            this.dtp_ClosedTime = new CCWin.SkinControl.SkinDateTimePicker();
            this.dtp_BuildTime = new CCWin.SkinControl.SkinDateTimePicker();
            this.dtp_ModifyTime = new CCWin.SkinControl.SkinDateTimePicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labDescribe = new CCWin.SkinControl.SkinLabel();
            this.rtb_Describe = new CCWin.SkinControl.SkinChatRichTextBox();
            this.stsManager = new CCWin.SkinControl.SkinToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
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
            this.tlpMain.TabIndex = 4;
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
            this.tlpMainEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 487F));
            this.tlpMainEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainEditor.Size = new System.Drawing.Size(1420, 747);
            this.tlpMainEditor.TabIndex = 2;
            // 
            // tlpSort
            // 
            this.tlpSort.ColumnCount = 2;
            this.tlpSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tlpSort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSort.Controls.Add(this.labProjectName, 0, 0);
            this.tlpSort.Controls.Add(this.labDepartment, 0, 5);
            this.tlpSort.Controls.Add(this.labType, 0, 3);
            this.tlpSort.Controls.Add(this.labPriority, 0, 4);
            this.tlpSort.Controls.Add(this.tb_ProjectName, 1, 0);
            this.tlpSort.Controls.Add(this.labShortName, 0, 1);
            this.tlpSort.Controls.Add(this.labProjectNO, 0, 2);
            this.tlpSort.Controls.Add(this.tb_ShortName, 1, 1);
            this.tlpSort.Controls.Add(this.tb_ProjectNO, 1, 2);
            this.tlpSort.Controls.Add(this.tb_Department, 1, 5);
            this.tlpSort.Controls.Add(this.labManager, 0, 6);
            this.tlpSort.Controls.Add(this.labAssistant, 0, 7);
            this.tlpSort.Controls.Add(this.labSetUpTime, 0, 8);
            this.tlpSort.Controls.Add(this.labClosedTime, 0, 9);
            this.tlpSort.Controls.Add(this.labCustomer, 0, 10);
            this.tlpSort.Controls.Add(this.labDevelopmentSite, 0, 11);
            this.tlpSort.Controls.Add(this.labAuthor, 0, 12);
            this.tlpSort.Controls.Add(this.labBuildTime, 0, 13);
            this.tlpSort.Controls.Add(this.labModifier, 0, 14);
            this.tlpSort.Controls.Add(this.labModifyTime, 0, 15);
            this.tlpSort.Controls.Add(this.tb_Manager, 1, 6);
            this.tlpSort.Controls.Add(this.tb_Assistant, 1, 7);
            this.tlpSort.Controls.Add(this.tb_Customer, 1, 10);
            this.tlpSort.Controls.Add(this.tb_DevelopmentSite, 1, 11);
            this.tlpSort.Controls.Add(this.tb_Author, 1, 12);
            this.tlpSort.Controls.Add(this.tb_Modifier, 1, 14);
            this.tlpSort.Controls.Add(this.cb_Type, 1, 3);
            this.tlpSort.Controls.Add(this.cb_Priority, 1, 4);
            this.tlpSort.Controls.Add(this.dtp_SetUpTime, 1, 8);
            this.tlpSort.Controls.Add(this.dtp_ClosedTime, 1, 9);
            this.tlpSort.Controls.Add(this.dtp_BuildTime, 1, 13);
            this.tlpSort.Controls.Add(this.dtp_ModifyTime, 1, 15);
            this.tlpSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSort.Location = new System.Drawing.Point(3, 3);
            this.tlpSort.Name = "tlpSort";
            this.tlpSort.RowCount = 16;
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.652807F));
            this.tlpSort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.029106F));
            this.tlpSort.Size = new System.Drawing.Size(1414, 481);
            this.tlpSort.TabIndex = 2;
            // 
            // labProjectName
            // 
            this.labProjectName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labProjectName.AutoSize = true;
            this.labProjectName.BackColor = System.Drawing.Color.White;
            this.labProjectName.BorderColor = System.Drawing.Color.White;
            this.labProjectName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labProjectName.Location = new System.Drawing.Point(3, 6);
            this.labProjectName.Name = "labProjectName";
            this.labProjectName.Size = new System.Drawing.Size(68, 17);
            this.labProjectName.TabIndex = 1;
            this.labProjectName.Text = "项目名称：";
            // 
            // labDepartment
            // 
            this.labDepartment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labDepartment.AutoSize = true;
            this.labDepartment.BackColor = System.Drawing.Color.White;
            this.labDepartment.BorderColor = System.Drawing.Color.White;
            this.labDepartment.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labDepartment.Location = new System.Drawing.Point(3, 156);
            this.labDepartment.Name = "labDepartment";
            this.labDepartment.Size = new System.Drawing.Size(68, 17);
            this.labDepartment.TabIndex = 11;
            this.labDepartment.Text = "所属部门：";
            // 
            // labType
            // 
            this.labType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labType.AutoSize = true;
            this.labType.BackColor = System.Drawing.Color.White;
            this.labType.BorderColor = System.Drawing.Color.White;
            this.labType.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labType.Location = new System.Drawing.Point(3, 96);
            this.labType.Name = "labType";
            this.labType.Size = new System.Drawing.Size(68, 17);
            this.labType.TabIndex = 7;
            this.labType.Text = "项目类型：";
            // 
            // labPriority
            // 
            this.labPriority.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labPriority.AutoSize = true;
            this.labPriority.BackColor = System.Drawing.Color.White;
            this.labPriority.BorderColor = System.Drawing.Color.White;
            this.labPriority.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labPriority.Location = new System.Drawing.Point(3, 126);
            this.labPriority.Name = "labPriority";
            this.labPriority.Size = new System.Drawing.Size(56, 17);
            this.labPriority.TabIndex = 9;
            this.labPriority.Text = "优先级：";
            // 
            // tb_ProjectName
            // 
            this.tb_ProjectName.BackColor = System.Drawing.Color.Transparent;
            this.tb_ProjectName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_ProjectName.DownBack = null;
            this.tb_ProjectName.Icon = null;
            this.tb_ProjectName.IconIsButton = false;
            this.tb_ProjectName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_ProjectName.IsPasswordChat = '\0';
            this.tb_ProjectName.IsSystemPasswordChar = false;
            this.tb_ProjectName.Lines = new string[0];
            this.tb_ProjectName.Location = new System.Drawing.Point(104, 0);
            this.tb_ProjectName.Margin = new System.Windows.Forms.Padding(0);
            this.tb_ProjectName.MaxLength = 32767;
            this.tb_ProjectName.MinimumSize = new System.Drawing.Size(28, 28);
            this.tb_ProjectName.MouseBack = null;
            this.tb_ProjectName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_ProjectName.Multiline = true;
            this.tb_ProjectName.Name = "tb_ProjectName";
            this.tb_ProjectName.NormlBack = null;
            this.tb_ProjectName.Padding = new System.Windows.Forms.Padding(5);
            this.tb_ProjectName.ReadOnly = false;
            this.tb_ProjectName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_ProjectName.Size = new System.Drawing.Size(1310, 30);
            // 
            // 
            // 
            this.tb_ProjectName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ProjectName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_ProjectName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tb_ProjectName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tb_ProjectName.SkinTxt.Multiline = true;
            this.tb_ProjectName.SkinTxt.Name = "BaseText";
            this.tb_ProjectName.SkinTxt.Size = new System.Drawing.Size(1300, 20);
            this.tb_ProjectName.SkinTxt.TabIndex = 0;
            this.tb_ProjectName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_ProjectName.SkinTxt.WaterText = "必填...";
            this.tb_ProjectName.TabIndex = 1;
            this.tb_ProjectName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_ProjectName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_ProjectName.WaterText = "必填...";
            this.tb_ProjectName.WordWrap = true;
            // 
            // labShortName
            // 
            this.labShortName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labShortName.AutoSize = true;
            this.labShortName.BackColor = System.Drawing.Color.White;
            this.labShortName.BorderColor = System.Drawing.Color.White;
            this.labShortName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labShortName.Location = new System.Drawing.Point(3, 36);
            this.labShortName.Name = "labShortName";
            this.labShortName.Size = new System.Drawing.Size(68, 17);
            this.labShortName.TabIndex = 3;
            this.labShortName.Text = "项目简称：";
            // 
            // labProjectNO
            // 
            this.labProjectNO.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labProjectNO.AutoSize = true;
            this.labProjectNO.BackColor = System.Drawing.Color.White;
            this.labProjectNO.BorderColor = System.Drawing.Color.White;
            this.labProjectNO.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labProjectNO.Location = new System.Drawing.Point(3, 66);
            this.labProjectNO.Name = "labProjectNO";
            this.labProjectNO.Size = new System.Drawing.Size(68, 17);
            this.labProjectNO.TabIndex = 5;
            this.labProjectNO.Text = "项目编号：";
            // 
            // tb_ShortName
            // 
            this.tb_ShortName.BackColor = System.Drawing.Color.Transparent;
            this.tb_ShortName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_ShortName.DownBack = null;
            this.tb_ShortName.Icon = null;
            this.tb_ShortName.IconIsButton = false;
            this.tb_ShortName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_ShortName.IsPasswordChat = '\0';
            this.tb_ShortName.IsSystemPasswordChar = false;
            this.tb_ShortName.Lines = new string[0];
            this.tb_ShortName.Location = new System.Drawing.Point(104, 30);
            this.tb_ShortName.Margin = new System.Windows.Forms.Padding(0);
            this.tb_ShortName.MaxLength = 32767;
            this.tb_ShortName.MinimumSize = new System.Drawing.Size(28, 28);
            this.tb_ShortName.MouseBack = null;
            this.tb_ShortName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_ShortName.Multiline = true;
            this.tb_ShortName.Name = "tb_ShortName";
            this.tb_ShortName.NormlBack = null;
            this.tb_ShortName.Padding = new System.Windows.Forms.Padding(5);
            this.tb_ShortName.ReadOnly = false;
            this.tb_ShortName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_ShortName.Size = new System.Drawing.Size(1310, 30);
            // 
            // 
            // 
            this.tb_ShortName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ShortName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_ShortName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tb_ShortName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tb_ShortName.SkinTxt.Multiline = true;
            this.tb_ShortName.SkinTxt.Name = "BaseText";
            this.tb_ShortName.SkinTxt.Size = new System.Drawing.Size(1300, 20);
            this.tb_ShortName.SkinTxt.TabIndex = 0;
            this.tb_ShortName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_ShortName.SkinTxt.WaterText = "可填...";
            this.tb_ShortName.TabIndex = 3;
            this.tb_ShortName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_ShortName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_ShortName.WaterText = "可填...";
            this.tb_ShortName.WordWrap = true;
            // 
            // tb_ProjectNO
            // 
            this.tb_ProjectNO.BackColor = System.Drawing.Color.Transparent;
            this.tb_ProjectNO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_ProjectNO.DownBack = null;
            this.tb_ProjectNO.Icon = null;
            this.tb_ProjectNO.IconIsButton = false;
            this.tb_ProjectNO.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_ProjectNO.IsPasswordChat = '\0';
            this.tb_ProjectNO.IsSystemPasswordChar = false;
            this.tb_ProjectNO.Lines = new string[0];
            this.tb_ProjectNO.Location = new System.Drawing.Point(104, 60);
            this.tb_ProjectNO.Margin = new System.Windows.Forms.Padding(0);
            this.tb_ProjectNO.MaxLength = 32767;
            this.tb_ProjectNO.MinimumSize = new System.Drawing.Size(28, 28);
            this.tb_ProjectNO.MouseBack = null;
            this.tb_ProjectNO.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_ProjectNO.Multiline = true;
            this.tb_ProjectNO.Name = "tb_ProjectNO";
            this.tb_ProjectNO.NormlBack = null;
            this.tb_ProjectNO.Padding = new System.Windows.Forms.Padding(5);
            this.tb_ProjectNO.ReadOnly = false;
            this.tb_ProjectNO.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_ProjectNO.Size = new System.Drawing.Size(1310, 30);
            // 
            // 
            // 
            this.tb_ProjectNO.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ProjectNO.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_ProjectNO.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tb_ProjectNO.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tb_ProjectNO.SkinTxt.Multiline = true;
            this.tb_ProjectNO.SkinTxt.Name = "BaseText";
            this.tb_ProjectNO.SkinTxt.Size = new System.Drawing.Size(1300, 20);
            this.tb_ProjectNO.SkinTxt.TabIndex = 0;
            this.tb_ProjectNO.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_ProjectNO.SkinTxt.WaterText = "必填...";
            this.tb_ProjectNO.TabIndex = 5;
            this.tb_ProjectNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_ProjectNO.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_ProjectNO.WaterText = "必填...";
            this.tb_ProjectNO.WordWrap = true;
            // 
            // tb_Department
            // 
            this.tb_Department.BackColor = System.Drawing.Color.Transparent;
            this.tb_Department.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Department.DownBack = null;
            this.tb_Department.Icon = null;
            this.tb_Department.IconIsButton = false;
            this.tb_Department.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_Department.IsPasswordChat = '\0';
            this.tb_Department.IsSystemPasswordChar = false;
            this.tb_Department.Lines = new string[0];
            this.tb_Department.Location = new System.Drawing.Point(104, 150);
            this.tb_Department.Margin = new System.Windows.Forms.Padding(0);
            this.tb_Department.MaxLength = 32767;
            this.tb_Department.MinimumSize = new System.Drawing.Size(28, 28);
            this.tb_Department.MouseBack = null;
            this.tb_Department.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_Department.Multiline = true;
            this.tb_Department.Name = "tb_Department";
            this.tb_Department.NormlBack = null;
            this.tb_Department.Padding = new System.Windows.Forms.Padding(5);
            this.tb_Department.ReadOnly = false;
            this.tb_Department.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Department.Size = new System.Drawing.Size(1310, 30);
            // 
            // 
            // 
            this.tb_Department.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Department.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Department.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tb_Department.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tb_Department.SkinTxt.Multiline = true;
            this.tb_Department.SkinTxt.Name = "BaseText";
            this.tb_Department.SkinTxt.Size = new System.Drawing.Size(1300, 20);
            this.tb_Department.SkinTxt.TabIndex = 0;
            this.tb_Department.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_Department.SkinTxt.WaterText = "必填...";
            this.tb_Department.TabIndex = 11;
            this.tb_Department.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_Department.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_Department.WaterText = "必填...";
            this.tb_Department.WordWrap = true;
            // 
            // labManager
            // 
            this.labManager.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labManager.AutoSize = true;
            this.labManager.BackColor = System.Drawing.Color.White;
            this.labManager.BorderColor = System.Drawing.Color.White;
            this.labManager.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labManager.Location = new System.Drawing.Point(3, 186);
            this.labManager.Name = "labManager";
            this.labManager.Size = new System.Drawing.Size(68, 17);
            this.labManager.TabIndex = 13;
            this.labManager.Text = "项目经理：";
            // 
            // labAssistant
            // 
            this.labAssistant.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labAssistant.AutoSize = true;
            this.labAssistant.BackColor = System.Drawing.Color.White;
            this.labAssistant.BorderColor = System.Drawing.Color.White;
            this.labAssistant.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labAssistant.Location = new System.Drawing.Point(3, 216);
            this.labAssistant.Name = "labAssistant";
            this.labAssistant.Size = new System.Drawing.Size(68, 17);
            this.labAssistant.TabIndex = 14;
            this.labAssistant.Text = "项目助理：";
            // 
            // labSetUpTime
            // 
            this.labSetUpTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labSetUpTime.AutoSize = true;
            this.labSetUpTime.BackColor = System.Drawing.Color.White;
            this.labSetUpTime.BorderColor = System.Drawing.Color.White;
            this.labSetUpTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labSetUpTime.Location = new System.Drawing.Point(3, 246);
            this.labSetUpTime.Name = "labSetUpTime";
            this.labSetUpTime.Size = new System.Drawing.Size(92, 17);
            this.labSetUpTime.TabIndex = 15;
            this.labSetUpTime.Text = "计划启动日期：";
            // 
            // labClosedTime
            // 
            this.labClosedTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labClosedTime.AutoSize = true;
            this.labClosedTime.BackColor = System.Drawing.Color.White;
            this.labClosedTime.BorderColor = System.Drawing.Color.White;
            this.labClosedTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labClosedTime.Location = new System.Drawing.Point(3, 276);
            this.labClosedTime.Name = "labClosedTime";
            this.labClosedTime.Size = new System.Drawing.Size(92, 17);
            this.labClosedTime.TabIndex = 17;
            this.labClosedTime.Text = "计划关闭日期：";
            // 
            // labCustomer
            // 
            this.labCustomer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labCustomer.AutoSize = true;
            this.labCustomer.BackColor = System.Drawing.Color.White;
            this.labCustomer.BorderColor = System.Drawing.Color.White;
            this.labCustomer.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labCustomer.Location = new System.Drawing.Point(3, 306);
            this.labCustomer.Name = "labCustomer";
            this.labCustomer.Size = new System.Drawing.Size(68, 17);
            this.labCustomer.TabIndex = 18;
            this.labCustomer.Text = "客户名称：";
            // 
            // labDevelopmentSite
            // 
            this.labDevelopmentSite.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labDevelopmentSite.AutoSize = true;
            this.labDevelopmentSite.BackColor = System.Drawing.Color.White;
            this.labDevelopmentSite.BorderColor = System.Drawing.Color.White;
            this.labDevelopmentSite.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labDevelopmentSite.Location = new System.Drawing.Point(3, 336);
            this.labDevelopmentSite.Name = "labDevelopmentSite";
            this.labDevelopmentSite.Size = new System.Drawing.Size(68, 17);
            this.labDevelopmentSite.TabIndex = 19;
            this.labDevelopmentSite.Text = "开发地点：";
            // 
            // labAuthor
            // 
            this.labAuthor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labAuthor.AutoSize = true;
            this.labAuthor.BackColor = System.Drawing.Color.White;
            this.labAuthor.BorderColor = System.Drawing.Color.White;
            this.labAuthor.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labAuthor.Location = new System.Drawing.Point(3, 366);
            this.labAuthor.Name = "labAuthor";
            this.labAuthor.Size = new System.Drawing.Size(56, 17);
            this.labAuthor.TabIndex = 20;
            this.labAuthor.Text = "创建人：";
            // 
            // labBuildTime
            // 
            this.labBuildTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labBuildTime.AutoSize = true;
            this.labBuildTime.BackColor = System.Drawing.Color.White;
            this.labBuildTime.BorderColor = System.Drawing.Color.White;
            this.labBuildTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labBuildTime.Location = new System.Drawing.Point(3, 396);
            this.labBuildTime.Name = "labBuildTime";
            this.labBuildTime.Size = new System.Drawing.Size(68, 17);
            this.labBuildTime.TabIndex = 21;
            this.labBuildTime.Text = "创建时间：";
            // 
            // labModifier
            // 
            this.labModifier.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labModifier.AutoSize = true;
            this.labModifier.BackColor = System.Drawing.Color.White;
            this.labModifier.BorderColor = System.Drawing.Color.White;
            this.labModifier.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labModifier.Location = new System.Drawing.Point(3, 427);
            this.labModifier.Name = "labModifier";
            this.labModifier.Size = new System.Drawing.Size(56, 17);
            this.labModifier.TabIndex = 22;
            this.labModifier.Text = "修改人：";
            // 
            // labModifyTime
            // 
            this.labModifyTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labModifyTime.AutoSize = true;
            this.labModifyTime.BackColor = System.Drawing.Color.White;
            this.labModifyTime.BorderColor = System.Drawing.Color.White;
            this.labModifyTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labModifyTime.Location = new System.Drawing.Point(3, 457);
            this.labModifyTime.Name = "labModifyTime";
            this.labModifyTime.Size = new System.Drawing.Size(68, 17);
            this.labModifyTime.TabIndex = 23;
            this.labModifyTime.Text = "修改时间：";
            // 
            // tb_Manager
            // 
            this.tb_Manager.BackColor = System.Drawing.Color.Transparent;
            this.tb_Manager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Manager.DownBack = null;
            this.tb_Manager.Icon = null;
            this.tb_Manager.IconIsButton = false;
            this.tb_Manager.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_Manager.IsPasswordChat = '\0';
            this.tb_Manager.IsSystemPasswordChar = false;
            this.tb_Manager.Lines = new string[0];
            this.tb_Manager.Location = new System.Drawing.Point(104, 180);
            this.tb_Manager.Margin = new System.Windows.Forms.Padding(0);
            this.tb_Manager.MaxLength = 32767;
            this.tb_Manager.MinimumSize = new System.Drawing.Size(28, 28);
            this.tb_Manager.MouseBack = null;
            this.tb_Manager.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_Manager.Multiline = true;
            this.tb_Manager.Name = "tb_Manager";
            this.tb_Manager.NormlBack = null;
            this.tb_Manager.Padding = new System.Windows.Forms.Padding(5);
            this.tb_Manager.ReadOnly = false;
            this.tb_Manager.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Manager.Size = new System.Drawing.Size(1310, 30);
            // 
            // 
            // 
            this.tb_Manager.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Manager.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Manager.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tb_Manager.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tb_Manager.SkinTxt.Multiline = true;
            this.tb_Manager.SkinTxt.Name = "BaseText";
            this.tb_Manager.SkinTxt.Size = new System.Drawing.Size(1300, 20);
            this.tb_Manager.SkinTxt.TabIndex = 0;
            this.tb_Manager.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_Manager.SkinTxt.WaterText = "必填...";
            this.tb_Manager.TabIndex = 24;
            this.tb_Manager.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_Manager.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_Manager.WaterText = "必填...";
            this.tb_Manager.WordWrap = true;
            // 
            // tb_Assistant
            // 
            this.tb_Assistant.BackColor = System.Drawing.Color.Transparent;
            this.tb_Assistant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Assistant.DownBack = null;
            this.tb_Assistant.Icon = null;
            this.tb_Assistant.IconIsButton = false;
            this.tb_Assistant.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_Assistant.IsPasswordChat = '\0';
            this.tb_Assistant.IsSystemPasswordChar = false;
            this.tb_Assistant.Lines = new string[0];
            this.tb_Assistant.Location = new System.Drawing.Point(104, 210);
            this.tb_Assistant.Margin = new System.Windows.Forms.Padding(0);
            this.tb_Assistant.MaxLength = 32767;
            this.tb_Assistant.MinimumSize = new System.Drawing.Size(28, 28);
            this.tb_Assistant.MouseBack = null;
            this.tb_Assistant.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_Assistant.Multiline = true;
            this.tb_Assistant.Name = "tb_Assistant";
            this.tb_Assistant.NormlBack = null;
            this.tb_Assistant.Padding = new System.Windows.Forms.Padding(5);
            this.tb_Assistant.ReadOnly = false;
            this.tb_Assistant.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Assistant.Size = new System.Drawing.Size(1310, 30);
            // 
            // 
            // 
            this.tb_Assistant.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Assistant.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Assistant.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tb_Assistant.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tb_Assistant.SkinTxt.Multiline = true;
            this.tb_Assistant.SkinTxt.Name = "BaseText";
            this.tb_Assistant.SkinTxt.Size = new System.Drawing.Size(1300, 20);
            this.tb_Assistant.SkinTxt.TabIndex = 0;
            this.tb_Assistant.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_Assistant.SkinTxt.WaterText = "可填...";
            this.tb_Assistant.TabIndex = 25;
            this.tb_Assistant.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_Assistant.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_Assistant.WaterText = "可填...";
            this.tb_Assistant.WordWrap = true;
            // 
            // tb_Customer
            // 
            this.tb_Customer.BackColor = System.Drawing.Color.Transparent;
            this.tb_Customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Customer.DownBack = null;
            this.tb_Customer.Icon = null;
            this.tb_Customer.IconIsButton = false;
            this.tb_Customer.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_Customer.IsPasswordChat = '\0';
            this.tb_Customer.IsSystemPasswordChar = false;
            this.tb_Customer.Lines = new string[0];
            this.tb_Customer.Location = new System.Drawing.Point(104, 300);
            this.tb_Customer.Margin = new System.Windows.Forms.Padding(0);
            this.tb_Customer.MaxLength = 32767;
            this.tb_Customer.MinimumSize = new System.Drawing.Size(28, 28);
            this.tb_Customer.MouseBack = null;
            this.tb_Customer.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_Customer.Multiline = true;
            this.tb_Customer.Name = "tb_Customer";
            this.tb_Customer.NormlBack = null;
            this.tb_Customer.Padding = new System.Windows.Forms.Padding(5);
            this.tb_Customer.ReadOnly = false;
            this.tb_Customer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Customer.Size = new System.Drawing.Size(1310, 30);
            // 
            // 
            // 
            this.tb_Customer.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Customer.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Customer.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tb_Customer.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tb_Customer.SkinTxt.Multiline = true;
            this.tb_Customer.SkinTxt.Name = "BaseText";
            this.tb_Customer.SkinTxt.Size = new System.Drawing.Size(1300, 20);
            this.tb_Customer.SkinTxt.TabIndex = 0;
            this.tb_Customer.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_Customer.SkinTxt.WaterText = "可填...";
            this.tb_Customer.TabIndex = 28;
            this.tb_Customer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_Customer.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_Customer.WaterText = "可填...";
            this.tb_Customer.WordWrap = true;
            // 
            // tb_DevelopmentSite
            // 
            this.tb_DevelopmentSite.BackColor = System.Drawing.Color.Transparent;
            this.tb_DevelopmentSite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_DevelopmentSite.DownBack = null;
            this.tb_DevelopmentSite.Icon = null;
            this.tb_DevelopmentSite.IconIsButton = false;
            this.tb_DevelopmentSite.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_DevelopmentSite.IsPasswordChat = '\0';
            this.tb_DevelopmentSite.IsSystemPasswordChar = false;
            this.tb_DevelopmentSite.Lines = new string[0];
            this.tb_DevelopmentSite.Location = new System.Drawing.Point(104, 330);
            this.tb_DevelopmentSite.Margin = new System.Windows.Forms.Padding(0);
            this.tb_DevelopmentSite.MaxLength = 32767;
            this.tb_DevelopmentSite.MinimumSize = new System.Drawing.Size(28, 28);
            this.tb_DevelopmentSite.MouseBack = null;
            this.tb_DevelopmentSite.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_DevelopmentSite.Multiline = true;
            this.tb_DevelopmentSite.Name = "tb_DevelopmentSite";
            this.tb_DevelopmentSite.NormlBack = null;
            this.tb_DevelopmentSite.Padding = new System.Windows.Forms.Padding(5);
            this.tb_DevelopmentSite.ReadOnly = false;
            this.tb_DevelopmentSite.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_DevelopmentSite.Size = new System.Drawing.Size(1310, 30);
            // 
            // 
            // 
            this.tb_DevelopmentSite.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_DevelopmentSite.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_DevelopmentSite.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tb_DevelopmentSite.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tb_DevelopmentSite.SkinTxt.Multiline = true;
            this.tb_DevelopmentSite.SkinTxt.Name = "BaseText";
            this.tb_DevelopmentSite.SkinTxt.Size = new System.Drawing.Size(1300, 20);
            this.tb_DevelopmentSite.SkinTxt.TabIndex = 0;
            this.tb_DevelopmentSite.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_DevelopmentSite.SkinTxt.WaterText = "可填...";
            this.tb_DevelopmentSite.TabIndex = 29;
            this.tb_DevelopmentSite.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_DevelopmentSite.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_DevelopmentSite.WaterText = "可填...";
            this.tb_DevelopmentSite.WordWrap = true;
            // 
            // tb_Author
            // 
            this.tb_Author.BackColor = System.Drawing.Color.Transparent;
            this.tb_Author.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Author.DownBack = null;
            this.tb_Author.Icon = null;
            this.tb_Author.IconIsButton = false;
            this.tb_Author.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_Author.IsPasswordChat = '\0';
            this.tb_Author.IsSystemPasswordChar = false;
            this.tb_Author.Lines = new string[0];
            this.tb_Author.Location = new System.Drawing.Point(104, 360);
            this.tb_Author.Margin = new System.Windows.Forms.Padding(0);
            this.tb_Author.MaxLength = 32767;
            this.tb_Author.MinimumSize = new System.Drawing.Size(28, 28);
            this.tb_Author.MouseBack = null;
            this.tb_Author.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_Author.Multiline = true;
            this.tb_Author.Name = "tb_Author";
            this.tb_Author.NormlBack = null;
            this.tb_Author.Padding = new System.Windows.Forms.Padding(5);
            this.tb_Author.ReadOnly = true;
            this.tb_Author.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Author.Size = new System.Drawing.Size(1310, 30);
            // 
            // 
            // 
            this.tb_Author.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Author.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Author.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tb_Author.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tb_Author.SkinTxt.Multiline = true;
            this.tb_Author.SkinTxt.Name = "BaseText";
            this.tb_Author.SkinTxt.ReadOnly = true;
            this.tb_Author.SkinTxt.Size = new System.Drawing.Size(1300, 20);
            this.tb_Author.SkinTxt.TabIndex = 0;
            this.tb_Author.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_Author.SkinTxt.WaterText = "必填...";
            this.tb_Author.TabIndex = 30;
            this.tb_Author.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_Author.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_Author.WaterText = "必填...";
            this.tb_Author.WordWrap = true;
            // 
            // tb_Modifier
            // 
            this.tb_Modifier.BackColor = System.Drawing.Color.Transparent;
            this.tb_Modifier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Modifier.DownBack = null;
            this.tb_Modifier.Icon = null;
            this.tb_Modifier.IconIsButton = false;
            this.tb_Modifier.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_Modifier.IsPasswordChat = '\0';
            this.tb_Modifier.IsSystemPasswordChar = false;
            this.tb_Modifier.Lines = new string[0];
            this.tb_Modifier.Location = new System.Drawing.Point(104, 420);
            this.tb_Modifier.Margin = new System.Windows.Forms.Padding(0);
            this.tb_Modifier.MaxLength = 32767;
            this.tb_Modifier.MinimumSize = new System.Drawing.Size(28, 28);
            this.tb_Modifier.MouseBack = null;
            this.tb_Modifier.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_Modifier.Multiline = true;
            this.tb_Modifier.Name = "tb_Modifier";
            this.tb_Modifier.NormlBack = null;
            this.tb_Modifier.Padding = new System.Windows.Forms.Padding(5);
            this.tb_Modifier.ReadOnly = false;
            this.tb_Modifier.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Modifier.Size = new System.Drawing.Size(1310, 31);
            // 
            // 
            // 
            this.tb_Modifier.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Modifier.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Modifier.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tb_Modifier.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tb_Modifier.SkinTxt.Multiline = true;
            this.tb_Modifier.SkinTxt.Name = "BaseText";
            this.tb_Modifier.SkinTxt.Size = new System.Drawing.Size(1300, 21);
            this.tb_Modifier.SkinTxt.TabIndex = 0;
            this.tb_Modifier.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_Modifier.SkinTxt.WaterText = "可填...";
            this.tb_Modifier.TabIndex = 32;
            this.tb_Modifier.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_Modifier.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_Modifier.WaterText = "可填...";
            this.tb_Modifier.WordWrap = true;
            // 
            // cb_Type
            // 
            this.cb_Type.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_Type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Type.FormattingEnabled = true;
            this.cb_Type.ItemBorderColor = System.Drawing.Color.Transparent;
            this.cb_Type.Items.AddRange(new object[] {
            "软件研发瀑布模型",
            "软件研发迭代模型"});
            this.cb_Type.Location = new System.Drawing.Point(107, 93);
            this.cb_Type.Name = "cb_Type";
            this.cb_Type.Size = new System.Drawing.Size(1304, 22);
            this.cb_Type.TabIndex = 34;
            this.cb_Type.WaterText = "必填...";
            // 
            // cb_Priority
            // 
            this.cb_Priority.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_Priority.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Priority.FormattingEnabled = true;
            this.cb_Priority.Items.AddRange(new object[] {
            "高",
            "中",
            "低"});
            this.cb_Priority.Location = new System.Drawing.Point(107, 123);
            this.cb_Priority.Name = "cb_Priority";
            this.cb_Priority.Size = new System.Drawing.Size(1304, 22);
            this.cb_Priority.TabIndex = 35;
            this.cb_Priority.WaterText = "必填...";
            // 
            // dtp_SetUpTime
            // 
            this.dtp_SetUpTime.BackColor = System.Drawing.Color.Transparent;
            this.dtp_SetUpTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtp_SetUpTime.DropDownHeight = 180;
            this.dtp_SetUpTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.dtp_SetUpTime.DropDownWidth = 120;
            this.dtp_SetUpTime.font = new System.Drawing.Font("微软雅黑", 9F);
            this.dtp_SetUpTime.Items = null;
            this.dtp_SetUpTime.Location = new System.Drawing.Point(107, 243);
            this.dtp_SetUpTime.Name = "dtp_SetUpTime";
            this.dtp_SetUpTime.Size = new System.Drawing.Size(1304, 24);
            this.dtp_SetUpTime.TabIndex = 36;
            this.dtp_SetUpTime.text = "";
            // 
            // dtp_ClosedTime
            // 
            this.dtp_ClosedTime.BackColor = System.Drawing.Color.Transparent;
            this.dtp_ClosedTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtp_ClosedTime.DropDownHeight = 180;
            this.dtp_ClosedTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.dtp_ClosedTime.DropDownWidth = 120;
            this.dtp_ClosedTime.font = new System.Drawing.Font("微软雅黑", 9F);
            this.dtp_ClosedTime.Items = null;
            this.dtp_ClosedTime.Location = new System.Drawing.Point(107, 273);
            this.dtp_ClosedTime.Name = "dtp_ClosedTime";
            this.dtp_ClosedTime.Size = new System.Drawing.Size(1304, 24);
            this.dtp_ClosedTime.TabIndex = 37;
            this.dtp_ClosedTime.text = "";
            // 
            // dtp_BuildTime
            // 
            this.dtp_BuildTime.BackColor = System.Drawing.Color.Transparent;
            this.dtp_BuildTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtp_BuildTime.DropDownHeight = 180;
            this.dtp_BuildTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.dtp_BuildTime.DropDownWidth = 120;
            this.dtp_BuildTime.font = new System.Drawing.Font("微软雅黑", 9F);
            this.dtp_BuildTime.Items = null;
            this.dtp_BuildTime.Location = new System.Drawing.Point(107, 393);
            this.dtp_BuildTime.Name = "dtp_BuildTime";
            this.dtp_BuildTime.Size = new System.Drawing.Size(1304, 24);
            this.dtp_BuildTime.TabIndex = 38;
            this.dtp_BuildTime.text = "";
            // 
            // dtp_ModifyTime
            // 
            this.dtp_ModifyTime.BackColor = System.Drawing.Color.Transparent;
            this.dtp_ModifyTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtp_ModifyTime.DropDownHeight = 180;
            this.dtp_ModifyTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.dtp_ModifyTime.DropDownWidth = 120;
            this.dtp_ModifyTime.font = new System.Drawing.Font("微软雅黑", 9F);
            this.dtp_ModifyTime.Items = null;
            this.dtp_ModifyTime.Location = new System.Drawing.Point(107, 454);
            this.dtp_ModifyTime.Name = "dtp_ModifyTime";
            this.dtp_ModifyTime.Size = new System.Drawing.Size(1304, 24);
            this.dtp_ModifyTime.TabIndex = 39;
            this.dtp_ModifyTime.text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.labDescribe, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rtb_Describe, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 490);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1414, 254);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // labDescribe
            // 
            this.labDescribe.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labDescribe.AutoSize = true;
            this.labDescribe.BackColor = System.Drawing.Color.White;
            this.labDescribe.BorderColor = System.Drawing.Color.White;
            this.labDescribe.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labDescribe.Location = new System.Drawing.Point(3, 118);
            this.labDescribe.Name = "labDescribe";
            this.labDescribe.Size = new System.Drawing.Size(44, 17);
            this.labDescribe.TabIndex = 24;
            this.labDescribe.Text = "描述：";
            // 
            // rtb_Describe
            // 
            this.rtb_Describe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Describe.Location = new System.Drawing.Point(107, 3);
            this.rtb_Describe.Name = "rtb_Describe";
            this.rtb_Describe.SelectControl = null;
            this.rtb_Describe.SelectControlIndex = 0;
            this.rtb_Describe.SelectControlPoint = new System.Drawing.Point(0, 0);
            this.rtb_Describe.Size = new System.Drawing.Size(1304, 248);
            this.rtb_Describe.TabIndex = 25;
            this.rtb_Describe.Text = "";
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
            this.tsbSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(36, 22);
            this.tsbSave.Text = "保存";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbQuite
            // 
            this.tsbQuite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbQuite.Name = "tsbQuite";
            this.tsbQuite.Size = new System.Drawing.Size(36, 22);
            this.tsbQuite.Text = "取消";
            this.tsbQuite.Click += new System.EventHandler(this.tsbQuite_Click);
            // 
            // ToolProjectModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 825);
            this.Controls.Add(this.tlpMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ToolProjectModify";
            this.Text = "修改项目";
            this.TitleCenter = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ToolProjectModify_FormClosing);
            this.Load += new System.EventHandler(this.ToolProjectModify_Load);
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
        private System.Windows.Forms.TableLayoutPanel tlpMainEditor;
        private System.Windows.Forms.TableLayoutPanel tlpSort;
        private CCWin.SkinControl.SkinLabel labProjectName;
        private CCWin.SkinControl.SkinLabel labDepartment;
        private CCWin.SkinControl.SkinLabel labType;
        private CCWin.SkinControl.SkinLabel labPriority;
        private CCWin.SkinControl.SkinTextBox tb_ProjectName;
        private CCWin.SkinControl.SkinLabel labShortName;
        private CCWin.SkinControl.SkinLabel labProjectNO;
        private CCWin.SkinControl.SkinTextBox tb_ShortName;
        private CCWin.SkinControl.SkinTextBox tb_ProjectNO;
        private CCWin.SkinControl.SkinTextBox tb_Department;
        private CCWin.SkinControl.SkinLabel labManager;
        private CCWin.SkinControl.SkinLabel labAssistant;
        private CCWin.SkinControl.SkinLabel labSetUpTime;
        private CCWin.SkinControl.SkinLabel labClosedTime;
        private CCWin.SkinControl.SkinLabel labCustomer;
        private CCWin.SkinControl.SkinLabel labDevelopmentSite;
        private CCWin.SkinControl.SkinLabel labAuthor;
        private CCWin.SkinControl.SkinLabel labBuildTime;
        private CCWin.SkinControl.SkinLabel labModifier;
        private CCWin.SkinControl.SkinLabel labModifyTime;
        private CCWin.SkinControl.SkinTextBox tb_Manager;
        private CCWin.SkinControl.SkinTextBox tb_Assistant;
        private CCWin.SkinControl.SkinTextBox tb_Customer;
        private CCWin.SkinControl.SkinTextBox tb_DevelopmentSite;
        private CCWin.SkinControl.SkinTextBox tb_Author;
        private CCWin.SkinControl.SkinTextBox tb_Modifier;
        private CCWin.SkinControl.SkinComboBox cb_Type;
        private CCWin.SkinControl.SkinComboBox cb_Priority;
        private CCWin.SkinControl.SkinDateTimePicker dtp_SetUpTime;
        private CCWin.SkinControl.SkinDateTimePicker dtp_ClosedTime;
        private CCWin.SkinControl.SkinDateTimePicker dtp_BuildTime;
        private CCWin.SkinControl.SkinDateTimePicker dtp_ModifyTime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CCWin.SkinControl.SkinLabel labDescribe;
        private CCWin.SkinControl.SkinChatRichTextBox rtb_Describe;
        private CCWin.SkinControl.SkinToolStrip stsManager;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbQuite;
    }
}