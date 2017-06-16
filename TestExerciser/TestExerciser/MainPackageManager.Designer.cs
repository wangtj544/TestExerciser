namespace TestExerciser
{
    partial class MainPackageManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPackageManager));
            this.dgvPackageManager = new CCWin.SkinControl.SkinDataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.方法IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.模块名称DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.类名称DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.类描述DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.方法名称DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.方法参数DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.方法返回值DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.正则匹配结果DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.方法描述DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.方法使用示例DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.作者DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.编写时间DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.修改人DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.修改说明DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.修改时间DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.方法封装BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.packageManagerDataSet = new TestExerciser.DataSetPackageManager();
            this.方法封装TableAdapter = new TestExerciser.PackageManagerDataSetTableAdapters.方法封装TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackageManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.方法封装BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageManagerDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPackageManager
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.dgvPackageManager.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPackageManager.AutoGenerateColumns = false;
            this.dgvPackageManager.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPackageManager.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPackageManager.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPackageManager.ColumnFont = null;
            this.dgvPackageManager.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPackageManager.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPackageManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPackageManager.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.方法IDDataGridViewTextBoxColumn,
            this.模块名称DataGridViewTextBoxColumn,
            this.类名称DataGridViewTextBoxColumn,
            this.类描述DataGridViewTextBoxColumn,
            this.方法名称DataGridViewTextBoxColumn,
            this.方法参数DataGridViewTextBoxColumn,
            this.方法返回值DataGridViewTextBoxColumn,
            this.正则匹配结果DataGridViewTextBoxColumn,
            this.方法描述DataGridViewTextBoxColumn,
            this.方法使用示例DataGridViewTextBoxColumn,
            this.作者DataGridViewTextBoxColumn,
            this.编写时间DataGridViewTextBoxColumn,
            this.修改人DataGridViewTextBoxColumn,
            this.修改说明DataGridViewTextBoxColumn,
            this.修改时间DataGridViewTextBoxColumn});
            this.dgvPackageManager.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvPackageManager.DataSource = this.方法封装BindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPackageManager.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPackageManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPackageManager.EnableHeadersVisualStyles = false;
            this.dgvPackageManager.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvPackageManager.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvPackageManager.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvPackageManager.Location = new System.Drawing.Point(4, 32);
            this.dgvPackageManager.Name = "dgvPackageManager";
            this.dgvPackageManager.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPackageManager.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvPackageManager.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPackageManager.RowTemplate.Height = 23;
            this.dgvPackageManager.Size = new System.Drawing.Size(1722, 789);
            this.dgvPackageManager.TabIndex = 0;
            this.dgvPackageManager.TitleBack = null;
            this.dgvPackageManager.TitleBackColorBegin = System.Drawing.Color.White;
            this.dgvPackageManager.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            this.dgvPackageManager.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvPackageManager_CellBeginEdit);
            this.dgvPackageManager.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPackageManager_CellEndEdit);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // 方法IDDataGridViewTextBoxColumn
            // 
            this.方法IDDataGridViewTextBoxColumn.DataPropertyName = "方法ID";
            this.方法IDDataGridViewTextBoxColumn.HeaderText = "方法ID";
            this.方法IDDataGridViewTextBoxColumn.Name = "方法IDDataGridViewTextBoxColumn";
            // 
            // 模块名称DataGridViewTextBoxColumn
            // 
            this.模块名称DataGridViewTextBoxColumn.DataPropertyName = "模块名称";
            this.模块名称DataGridViewTextBoxColumn.HeaderText = "模块名称";
            this.模块名称DataGridViewTextBoxColumn.Name = "模块名称DataGridViewTextBoxColumn";
            // 
            // 类名称DataGridViewTextBoxColumn
            // 
            this.类名称DataGridViewTextBoxColumn.DataPropertyName = "类名称";
            this.类名称DataGridViewTextBoxColumn.HeaderText = "类名称";
            this.类名称DataGridViewTextBoxColumn.Name = "类名称DataGridViewTextBoxColumn";
            // 
            // 类描述DataGridViewTextBoxColumn
            // 
            this.类描述DataGridViewTextBoxColumn.DataPropertyName = "类描述";
            this.类描述DataGridViewTextBoxColumn.HeaderText = "类描述";
            this.类描述DataGridViewTextBoxColumn.Name = "类描述DataGridViewTextBoxColumn";
            // 
            // 方法名称DataGridViewTextBoxColumn
            // 
            this.方法名称DataGridViewTextBoxColumn.DataPropertyName = "方法名称";
            this.方法名称DataGridViewTextBoxColumn.HeaderText = "方法名称";
            this.方法名称DataGridViewTextBoxColumn.Name = "方法名称DataGridViewTextBoxColumn";
            // 
            // 方法参数DataGridViewTextBoxColumn
            // 
            this.方法参数DataGridViewTextBoxColumn.DataPropertyName = "方法参数";
            this.方法参数DataGridViewTextBoxColumn.HeaderText = "方法参数";
            this.方法参数DataGridViewTextBoxColumn.Name = "方法参数DataGridViewTextBoxColumn";
            // 
            // 方法返回值DataGridViewTextBoxColumn
            // 
            this.方法返回值DataGridViewTextBoxColumn.DataPropertyName = "方法返回值";
            this.方法返回值DataGridViewTextBoxColumn.HeaderText = "方法返回值";
            this.方法返回值DataGridViewTextBoxColumn.Name = "方法返回值DataGridViewTextBoxColumn";
            // 
            // 正则匹配结果DataGridViewTextBoxColumn
            // 
            this.正则匹配结果DataGridViewTextBoxColumn.DataPropertyName = "正则匹配结果";
            this.正则匹配结果DataGridViewTextBoxColumn.HeaderText = "正则匹配结果";
            this.正则匹配结果DataGridViewTextBoxColumn.Name = "正则匹配结果DataGridViewTextBoxColumn";
            // 
            // 方法描述DataGridViewTextBoxColumn
            // 
            this.方法描述DataGridViewTextBoxColumn.DataPropertyName = "方法描述";
            this.方法描述DataGridViewTextBoxColumn.HeaderText = "方法描述";
            this.方法描述DataGridViewTextBoxColumn.Name = "方法描述DataGridViewTextBoxColumn";
            // 
            // 方法使用示例DataGridViewTextBoxColumn
            // 
            this.方法使用示例DataGridViewTextBoxColumn.DataPropertyName = "方法使用示例";
            this.方法使用示例DataGridViewTextBoxColumn.HeaderText = "方法使用示例";
            this.方法使用示例DataGridViewTextBoxColumn.Name = "方法使用示例DataGridViewTextBoxColumn";
            // 
            // 作者DataGridViewTextBoxColumn
            // 
            this.作者DataGridViewTextBoxColumn.DataPropertyName = "作者";
            this.作者DataGridViewTextBoxColumn.HeaderText = "作者";
            this.作者DataGridViewTextBoxColumn.Name = "作者DataGridViewTextBoxColumn";
            // 
            // 编写时间DataGridViewTextBoxColumn
            // 
            this.编写时间DataGridViewTextBoxColumn.DataPropertyName = "编写时间";
            this.编写时间DataGridViewTextBoxColumn.HeaderText = "编写时间";
            this.编写时间DataGridViewTextBoxColumn.Name = "编写时间DataGridViewTextBoxColumn";
            // 
            // 修改人DataGridViewTextBoxColumn
            // 
            this.修改人DataGridViewTextBoxColumn.DataPropertyName = "修改人";
            this.修改人DataGridViewTextBoxColumn.HeaderText = "修改人";
            this.修改人DataGridViewTextBoxColumn.Name = "修改人DataGridViewTextBoxColumn";
            // 
            // 修改说明DataGridViewTextBoxColumn
            // 
            this.修改说明DataGridViewTextBoxColumn.DataPropertyName = "修改说明";
            this.修改说明DataGridViewTextBoxColumn.HeaderText = "修改说明";
            this.修改说明DataGridViewTextBoxColumn.Name = "修改说明DataGridViewTextBoxColumn";
            // 
            // 修改时间DataGridViewTextBoxColumn
            // 
            this.修改时间DataGridViewTextBoxColumn.DataPropertyName = "修改时间";
            this.修改时间DataGridViewTextBoxColumn.HeaderText = "修改时间";
            this.修改时间DataGridViewTextBoxColumn.Name = "修改时间DataGridViewTextBoxColumn";
            // 
            // 方法封装BindingSource
            // 
            this.方法封装BindingSource.DataMember = "方法封装";
            this.方法封装BindingSource.DataSource = this.packageManagerDataSet;
            // 
            // packageManagerDataSet
            // 
            this.packageManagerDataSet.DataSetName = "PackageManagerDataSet";
            this.packageManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 方法封装TableAdapter
            // 
            this.方法封装TableAdapter.ClearBeforeFill = true;
            // 
            // MainPackageManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.BackPalace = ((System.Drawing.Image)(resources.GetObject("$this.BackPalace")));
            this.ClientSize = new System.Drawing.Size(1730, 825);
            this.Controls.Add(this.dgvPackageManager);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPackageManager";
            this.Text = "封装管理工具";
            this.TitleCenter = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainPackageManager_FormClosing);
            this.Load += new System.EventHandler(this.MainPackageManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackageManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.方法封装BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageManagerDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinDataGridView dgvPackageManager;
        private DataSetPackageManager packageManagerDataSet;
        private System.Windows.Forms.BindingSource 方法封装BindingSource;
        private PackageManagerDataSetTableAdapters.方法封装TableAdapter 方法封装TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 方法IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 模块名称DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 类名称DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 类描述DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 方法名称DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 方法参数DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 方法返回值DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 正则匹配结果DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 方法描述DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 方法使用示例DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 作者DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 编写时间DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 修改人DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 修改说明DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 修改时间DataGridViewTextBoxColumn;


    }
}