namespace TestExerciser.Tools
{
    partial class ToolManager
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("数据库");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("环境", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolManager));
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnOK = new CCWin.SkinControl.SkinButton();
            this.btnCancel = new CCWin.SkinControl.SkinButton();
            this.spCMain = new System.Windows.Forms.SplitContainer();
            this.tlpTreeView = new System.Windows.Forms.TableLayoutPanel();
            this.tvItems = new System.Windows.Forms.TreeView();
            this.ImageToolManager = new System.Windows.Forms.ImageList(this.components);
            this.gbSelectDB = new System.Windows.Forms.GroupBox();
            this.radbLocal = new System.Windows.Forms.RadioButton();
            this.radbServer = new System.Windows.Forms.RadioButton();
            this.txtStatus = new System.Windows.Forms.Label();
            this.mySearch = new TestExerciser.Tools.Control.ControlSearch();
            this.labDetails = new System.Windows.Forms.Label();
            this.tlpMain.SuspendLayout();
            this.tlpButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spCMain)).BeginInit();
            this.spCMain.Panel1.SuspendLayout();
            this.spCMain.Panel2.SuspendLayout();
            this.spCMain.SuspendLayout();
            this.tlpTreeView.SuspendLayout();
            this.gbSelectDB.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Controls.Add(this.tlpButton, 0, 1);
            this.tlpMain.Controls.Add(this.spCMain, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(4, 32);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpMain.Size = new System.Drawing.Size(672, 461);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpButton
            // 
            this.tlpButton.ColumnCount = 3;
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpButton.Controls.Add(this.txtStatus, 0, 0);
            this.tlpButton.Controls.Add(this.btnOK, 1, 0);
            this.tlpButton.Controls.Add(this.btnCancel, 2, 0);
            this.tlpButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButton.Location = new System.Drawing.Point(3, 414);
            this.tlpButton.Name = "tlpButton";
            this.tlpButton.RowCount = 1;
            this.tlpButton.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButton.Size = new System.Drawing.Size(666, 44);
            this.tlpButton.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.BaseColor = System.Drawing.Color.Silver;
            this.btnOK.BorderColor = System.Drawing.Color.Silver;
            this.btnOK.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnOK.DownBack = null;
            this.btnOK.Location = new System.Drawing.Point(478, 10);
            this.btnOK.MouseBack = null;
            this.btnOK.Name = "btnOK";
            this.btnOK.NormlBack = null;
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BaseColor = System.Drawing.Color.Silver;
            this.btnCancel.BorderColor = System.Drawing.Color.Silver;
            this.btnCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCancel.DownBack = null;
            this.btnCancel.Location = new System.Drawing.Point(578, 10);
            this.btnCancel.MouseBack = null;
            this.btnCancel.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NormlBack = null;
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // spCMain
            // 
            this.spCMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spCMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spCMain.IsSplitterFixed = true;
            this.spCMain.Location = new System.Drawing.Point(3, 3);
            this.spCMain.Name = "spCMain";
            // 
            // spCMain.Panel1
            // 
            this.spCMain.Panel1.Controls.Add(this.tlpTreeView);
            // 
            // spCMain.Panel2
            // 
            this.spCMain.Panel2.Controls.Add(this.gbSelectDB);
            this.spCMain.Size = new System.Drawing.Size(666, 405);
            this.spCMain.SplitterDistance = 214;
            this.spCMain.TabIndex = 1;
            // 
            // tlpTreeView
            // 
            this.tlpTreeView.ColumnCount = 1;
            this.tlpTreeView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTreeView.Controls.Add(this.mySearch, 0, 0);
            this.tlpTreeView.Controls.Add(this.tvItems, 0, 1);
            this.tlpTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTreeView.Location = new System.Drawing.Point(0, 0);
            this.tlpTreeView.Name = "tlpTreeView";
            this.tlpTreeView.RowCount = 2;
            this.tlpTreeView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpTreeView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTreeView.Size = new System.Drawing.Size(212, 403);
            this.tlpTreeView.TabIndex = 0;
            // 
            // tvItems
            // 
            this.tvItems.BackColor = System.Drawing.Color.White;
            this.tvItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvItems.ImageIndex = 0;
            this.tvItems.ImageList = this.ImageToolManager;
            this.tvItems.Location = new System.Drawing.Point(3, 38);
            this.tvItems.Name = "tvItems";
            treeNode1.Name = "tnDB";
            treeNode1.Text = "数据库";
            treeNode1.ToolTipText = "数据库";
            treeNode2.Name = "tnEnv";
            treeNode2.Text = "环境";
            treeNode2.ToolTipText = "环境";
            this.tvItems.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.tvItems.SelectedImageIndex = 0;
            this.tvItems.Size = new System.Drawing.Size(206, 362);
            this.tvItems.TabIndex = 1;
            this.tvItems.Click += new System.EventHandler(this.tvItems_Click);
            // 
            // ImageToolManager
            // 
            this.ImageToolManager.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageToolManager.ImageStream")));
            this.ImageToolManager.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageToolManager.Images.SetKeyName(0, "8.png");
            // 
            // gbSelectDB
            // 
            this.gbSelectDB.Controls.Add(this.labDetails);
            this.gbSelectDB.Controls.Add(this.radbLocal);
            this.gbSelectDB.Controls.Add(this.radbServer);
            this.gbSelectDB.Location = new System.Drawing.Point(17, 14);
            this.gbSelectDB.Name = "gbSelectDB";
            this.gbSelectDB.Size = new System.Drawing.Size(417, 132);
            this.gbSelectDB.TabIndex = 0;
            this.gbSelectDB.TabStop = false;
            this.gbSelectDB.Text = "选择数据库：";
            // 
            // radbLocal
            // 
            this.radbLocal.AutoSize = true;
            this.radbLocal.Location = new System.Drawing.Point(58, 38);
            this.radbLocal.Name = "radbLocal";
            this.radbLocal.Size = new System.Drawing.Size(47, 16);
            this.radbLocal.TabIndex = 16;
            this.radbLocal.Text = "本地";
            this.radbLocal.UseVisualStyleBackColor = true;
            // 
            // radbServer
            // 
            this.radbServer.AutoSize = true;
            this.radbServer.Location = new System.Drawing.Point(58, 71);
            this.radbServer.Name = "radbServer";
            this.radbServer.Size = new System.Drawing.Size(83, 16);
            this.radbServer.TabIndex = 17;
            this.radbServer.Text = "远程服务器";
            this.radbServer.UseVisualStyleBackColor = true;
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtStatus.AutoSize = true;
            this.txtStatus.Location = new System.Drawing.Point(3, 16);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(0, 12);
            this.txtStatus.TabIndex = 19;
            // 
            // mySearch
            // 
            this.mySearch.Location = new System.Drawing.Point(3, 3);
            this.mySearch.Name = "mySearch";
            this.mySearch.Size = new System.Drawing.Size(204, 29);
            this.mySearch.TabIndex = 0;
            // 
            // labDetails
            // 
            this.labDetails.AutoSize = true;
            this.labDetails.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labDetails.ForeColor = System.Drawing.Color.Red;
            this.labDetails.Location = new System.Drawing.Point(47, 103);
            this.labDetails.Name = "labDetails";
            this.labDetails.Size = new System.Drawing.Size(259, 12);
            this.labDetails.TabIndex = 18;
            this.labDetails.Text = "*提示：选择数据库后，需要重启才能生效！";
            // 
            // ToolManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackPalace = ((System.Drawing.Image)(resources.GetObject("$this.BackPalace")));
            this.ClientSize = new System.Drawing.Size(680, 497);
            this.Controls.Add(this.tlpMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "ToolManager";
            this.Text = "选项";
            this.TitleCenter = false;
            this.Load += new System.EventHandler(this.ToolManager_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpButton.ResumeLayout(false);
            this.tlpButton.PerformLayout();
            this.spCMain.Panel1.ResumeLayout(false);
            this.spCMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spCMain)).EndInit();
            this.spCMain.ResumeLayout(false);
            this.tlpTreeView.ResumeLayout(false);
            this.gbSelectDB.ResumeLayout(false);
            this.gbSelectDB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpButton;
        private CCWin.SkinControl.SkinButton btnOK;
        private CCWin.SkinControl.SkinButton btnCancel;
        private System.Windows.Forms.SplitContainer spCMain;
        private System.Windows.Forms.TableLayoutPanel tlpTreeView;
        private Control.ControlSearch mySearch;
        private System.Windows.Forms.TreeView tvItems;
        private System.Windows.Forms.ImageList ImageToolManager;
        private System.Windows.Forms.GroupBox gbSelectDB;
        private System.Windows.Forms.Label txtStatus;
        private System.Windows.Forms.RadioButton radbLocal;
        private System.Windows.Forms.RadioButton radbServer;
        private System.Windows.Forms.Label labDetails;
    }
}