namespace TestExerciser
{
    partial class MainExcelReader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainExcelReader));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tstbText = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tstbCreateDB = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tstbCreateScript = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tstbCreateScriptProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tstbScriptStatus = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.tstbTestCaseName = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tstbAddToProj = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvReadDB = new System.Windows.Forms.DataGridView();
            this.openExcelFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.selectWorkspaceBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReadDB)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tstbText,
            this.toolStripSeparator1,
            this.tstbCreateDB,
            this.toolStripSeparator7,
            this.tstbCreateScript,
            this.toolStripSeparator6,
            this.toolStripLabel2,
            this.tstbCreateScriptProgress,
            this.toolStripSeparator2,
            this.toolStripLabel3,
            this.tstbScriptStatus,
            this.toolStripSeparator3,
            this.toolStripLabel4,
            this.tstbTestCaseName,
            this.toolStripSeparator5,
            this.tstbAddToProj,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(4, 32);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1722, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(107, 22);
            this.toolStripLabel1.Text = "WorkBook名称：";
            // 
            // tstbText
            // 
            this.tstbText.Name = "tstbText";
            this.tstbText.Size = new System.Drawing.Size(200, 25);
            this.tstbText.Text = "在这里填写工作簿名称...";
            this.tstbText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tstbText_KeyDown);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tstbCreateDB
            // 
            this.tstbCreateDB.CheckOnClick = true;
            this.tstbCreateDB.Image = ((System.Drawing.Image)(resources.GetObject("tstbCreateDB.Image")));
            this.tstbCreateDB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstbCreateDB.Name = "tstbCreateDB";
            this.tstbCreateDB.Size = new System.Drawing.Size(76, 22);
            this.tstbCreateDB.Text = "获取数据";
            this.tstbCreateDB.ToolTipText = "点击获取数据";
            this.tstbCreateDB.Click += new System.EventHandler(this.tstbCreateDB_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // tstbCreateScript
            // 
            this.tstbCreateScript.Image = ((System.Drawing.Image)(resources.GetObject("tstbCreateScript.Image")));
            this.tstbCreateScript.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstbCreateScript.Name = "tstbCreateScript";
            this.tstbCreateScript.Size = new System.Drawing.Size(76, 22);
            this.tstbCreateScript.Text = "生成脚本";
            this.tstbCreateScript.ToolTipText = "点击生成脚本";
            this.tstbCreateScript.Click += new System.EventHandler(this.tstbCreateScript_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(92, 22);
            this.toolStripLabel2.Text = "生成脚本进度：";
            // 
            // tstbCreateScriptProgress
            // 
            this.tstbCreateScriptProgress.Name = "tstbCreateScriptProgress";
            this.tstbCreateScriptProgress.Size = new System.Drawing.Size(450, 22);
            this.tstbCreateScriptProgress.Step = 20;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(92, 22);
            this.toolStripLabel3.Text = "生成脚本状态：";
            // 
            // tstbScriptStatus
            // 
            this.tstbScriptStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstbScriptStatus.Image = global::TestExerciser.Properties.Resources.progress_cancel;
            this.tstbScriptStatus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstbScriptStatus.Name = "tstbScriptStatus";
            this.tstbScriptStatus.Size = new System.Drawing.Size(23, 22);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(68, 22);
            this.toolStripLabel4.Text = "用例名称：";
            // 
            // tstbTestCaseName
            // 
            this.tstbTestCaseName.Name = "tstbTestCaseName";
            this.tstbTestCaseName.ReadOnly = true;
            this.tstbTestCaseName.Size = new System.Drawing.Size(381, 25);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tstbAddToProj
            // 
            this.tstbAddToProj.Image = ((System.Drawing.Image)(resources.GetObject("tstbAddToProj.Image")));
            this.tstbAddToProj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstbAddToProj.Name = "tstbAddToProj";
            this.tstbAddToProj.Size = new System.Drawing.Size(88, 22);
            this.tstbAddToProj.Text = "添加到工程";
            this.tstbAddToProj.Click += new System.EventHandler(this.tstbAddToProj_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(4, 57);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1722, 764);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvReadDB);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1714, 738);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "生成自动化脚本对应用例如下：";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvReadDB
            // 
            this.dgvReadDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReadDB.Location = new System.Drawing.Point(3, 3);
            this.dgvReadDB.Name = "dgvReadDB";
            this.dgvReadDB.RowTemplate.Height = 23;
            this.dgvReadDB.Size = new System.Drawing.Size(1708, 732);
            this.dgvReadDB.TabIndex = 0;
            // 
            // openExcelFileDialog
            // 
            this.openExcelFileDialog.Filter = "Excel(*.xlsx)|*.xlsx|Excel(*.xls)|*.xls";
            this.openExcelFileDialog.InitialDirectory = "Environment.GetFolderPath(Environment.SpecialFolder.Desktop";
            // 
            // MainExcelReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackPalace = ((System.Drawing.Image)(resources.GetObject("$this.BackPalace")));
            this.ClientSize = new System.Drawing.Size(1730, 825);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainExcelReader";
            this.Text = "脚本智能生成";
            this.TitleCenter = false;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReadDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tstbText;
        private System.Windows.Forms.ToolStripButton tstbCreateDB;
        private System.Windows.Forms.ToolStripButton tstbCreateScript;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripProgressBar tstbCreateScriptProgress;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvReadDB;
        private System.Windows.Forms.OpenFileDialog openExcelFileDialog;
        private System.Windows.Forms.FolderBrowserDialog selectWorkspaceBrowserDialog;
        private System.Windows.Forms.ToolStripButton tstbAddToProj;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton tstbScriptStatus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripTextBox tstbTestCaseName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}