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
            this.tabControlCaseReview = new System.Windows.Forms.TabControl();
            this.tabPageFlow = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControlReview = new System.Windows.Forms.TabControl();
            this.tabPagePreRev = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOK = new CCWin.SkinControl.SkinButton();
            this.gbSubmit = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCommit = new CCWin.SkinControl.SkinButton();
            this.tabPageStartRev = new System.Windows.Forms.TabPage();
            this.gbAddReviewer = new System.Windows.Forms.GroupBox();
            this.gbselectCases = new System.Windows.Forms.GroupBox();
            this.tabControlCaseReview.SuspendLayout();
            this.tabPageFlow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControlReview.SuspendLayout();
            this.tabPagePreRev.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlCaseReview
            // 
            this.tabControlCaseReview.Controls.Add(this.tabPageFlow);
            this.tabControlCaseReview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlCaseReview.Location = new System.Drawing.Point(4, 32);
            this.tabControlCaseReview.Name = "tabControlCaseReview";
            this.tabControlCaseReview.SelectedIndex = 0;
            this.tabControlCaseReview.Size = new System.Drawing.Size(1432, 789);
            this.tabControlCaseReview.TabIndex = 0;
            // 
            // tabPageFlow
            // 
            this.tabPageFlow.Controls.Add(this.splitContainer1);
            this.tabPageFlow.Location = new System.Drawing.Point(4, 22);
            this.tabPageFlow.Name = "tabPageFlow";
            this.tabPageFlow.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFlow.Size = new System.Drawing.Size(1424, 763);
            this.tabPageFlow.TabIndex = 0;
            this.tabPageFlow.Text = "评审流程";
            this.tabPageFlow.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControlReview);
            this.splitContainer1.Size = new System.Drawing.Size(1418, 757);
            this.splitContainer1.SplitterDistance = 1154;
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
            this.tabControlReview.Size = new System.Drawing.Size(1154, 757);
            this.tabControlReview.TabIndex = 1;
            // 
            // tabPagePreRev
            // 
            this.tabPagePreRev.Controls.Add(this.splitContainer2);
            this.tabPagePreRev.Location = new System.Drawing.Point(4, 22);
            this.tabPagePreRev.Name = "tabPagePreRev";
            this.tabPagePreRev.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePreRev.Size = new System.Drawing.Size(1146, 731);
            this.tabPagePreRev.TabIndex = 0;
            this.tabPagePreRev.Text = "发起评审";
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
            this.splitContainer2.Size = new System.Drawing.Size(1140, 725);
            this.splitContainer2.SplitterDistance = 485;
            this.splitContainer2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnOK, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbselectCases, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(485, 725);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.DownBack = null;
            this.btnOK.Location = new System.Drawing.Point(193, 698);
            this.btnOK.MouseBack = null;
            this.btnOK.Name = "btnOK";
            this.btnOK.NormlBack = null;
            this.btnOK.Size = new System.Drawing.Size(98, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "开始评审";
            this.btnOK.UseVisualStyleBackColor = false;
            // 
            // gbSubmit
            // 
            this.gbSubmit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSubmit.Location = new System.Drawing.Point(3, 3);
            this.gbSubmit.Name = "gbSubmit";
            this.gbSubmit.Size = new System.Drawing.Size(473, 149);
            this.gbSubmit.TabIndex = 5;
            this.gbSubmit.TabStop = false;
            this.gbSubmit.Text = "第一步：提交用例";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnCommit, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.gbSubmit, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.gbAddReviewer, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(479, 341);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // btnCommit
            // 
            this.btnCommit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCommit.BackColor = System.Drawing.Color.Transparent;
            this.btnCommit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCommit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCommit.DownBack = null;
            this.btnCommit.Location = new System.Drawing.Point(190, 314);
            this.btnCommit.MouseBack = null;
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.NormlBack = null;
            this.btnCommit.Size = new System.Drawing.Size(98, 23);
            this.btnCommit.TabIndex = 5;
            this.btnCommit.Text = "提交评审";
            this.btnCommit.UseVisualStyleBackColor = false;
            // 
            // tabPageStartRev
            // 
            this.tabPageStartRev.Location = new System.Drawing.Point(4, 22);
            this.tabPageStartRev.Name = "tabPageStartRev";
            this.tabPageStartRev.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStartRev.Size = new System.Drawing.Size(1146, 731);
            this.tabPageStartRev.TabIndex = 1;
            this.tabPageStartRev.Text = "开始评审";
            this.tabPageStartRev.UseVisualStyleBackColor = true;
            // 
            // gbAddReviewer
            // 
            this.gbAddReviewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAddReviewer.Location = new System.Drawing.Point(3, 158);
            this.gbAddReviewer.Name = "gbAddReviewer";
            this.gbAddReviewer.Size = new System.Drawing.Size(473, 149);
            this.gbAddReviewer.TabIndex = 6;
            this.gbAddReviewer.TabStop = false;
            this.gbAddReviewer.Text = "第二步：添加评审人";
            // 
            // gbselectCases
            // 
            this.gbselectCases.Location = new System.Drawing.Point(3, 350);
            this.gbselectCases.Name = "gbselectCases";
            this.gbselectCases.Size = new System.Drawing.Size(200, 100);
            this.gbselectCases.TabIndex = 7;
            this.gbselectCases.TabStop = false;
            this.gbselectCases.Text = "选择用例";
            // 
            // MainCaseReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackPalace = ((System.Drawing.Image)(resources.GetObject("$this.BackPalace")));
            this.ClientSize = new System.Drawing.Size(1440, 825);
            this.Controls.Add(this.tabControlCaseReview);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainCaseReview";
            this.ShadowColor = System.Drawing.Color.Blue;
            this.Text = "用例评审";
            this.TitleCenter = false;
            this.tabControlCaseReview.ResumeLayout(false);
            this.tabPageFlow.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControlReview.ResumeLayout(false);
            this.tabPagePreRev.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlCaseReview;
        private System.Windows.Forms.TabPage tabPageFlow;
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
    }
}