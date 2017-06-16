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
            this.packProductNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packClassNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packClassDescribeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packMethodIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packMethodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packMethodParaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packMethodReturnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packRegularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packMethodDescribeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packMethodExampleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packAuthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packModifierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packModifyStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packModifyTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.方法封装BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPackageManager = new TestExerciser.DataSetPackageManager();
            this.方法封装TableAdapter = new TestExerciser.DataSetPackageManagerTableAdapters.方法封装TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackageManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.方法封装BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPackageManager)).BeginInit();
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
            this.packProductNameDataGridViewTextBoxColumn,
            this.packClassNameDataGridViewTextBoxColumn,
            this.packClassDescribeDataGridViewTextBoxColumn,
            this.packMethodIDDataGridViewTextBoxColumn,
            this.packMethodNameDataGridViewTextBoxColumn,
            this.packMethodParaDataGridViewTextBoxColumn,
            this.packMethodReturnDataGridViewTextBoxColumn,
            this.packRegularDataGridViewTextBoxColumn,
            this.packMethodDescribeDataGridViewTextBoxColumn,
            this.packMethodExampleDataGridViewTextBoxColumn,
            this.packAuthorDataGridViewTextBoxColumn,
            this.packTimeDataGridViewTextBoxColumn,
            this.packModifierDataGridViewTextBoxColumn,
            this.packModifyStateDataGridViewTextBoxColumn,
            this.packModifyTimeDataGridViewTextBoxColumn});
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
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // packProductNameDataGridViewTextBoxColumn
            // 
            this.packProductNameDataGridViewTextBoxColumn.DataPropertyName = "packProductName";
            this.packProductNameDataGridViewTextBoxColumn.HeaderText = "模块名称";
            this.packProductNameDataGridViewTextBoxColumn.Name = "packProductNameDataGridViewTextBoxColumn";
            // 
            // packClassNameDataGridViewTextBoxColumn
            // 
            this.packClassNameDataGridViewTextBoxColumn.DataPropertyName = "packClassName";
            this.packClassNameDataGridViewTextBoxColumn.HeaderText = "类名称";
            this.packClassNameDataGridViewTextBoxColumn.Name = "packClassNameDataGridViewTextBoxColumn";
            // 
            // packClassDescribeDataGridViewTextBoxColumn
            // 
            this.packClassDescribeDataGridViewTextBoxColumn.DataPropertyName = "packClassDescribe";
            this.packClassDescribeDataGridViewTextBoxColumn.HeaderText = "类描述";
            this.packClassDescribeDataGridViewTextBoxColumn.Name = "packClassDescribeDataGridViewTextBoxColumn";
            // 
            // packMethodIDDataGridViewTextBoxColumn
            // 
            this.packMethodIDDataGridViewTextBoxColumn.DataPropertyName = "packMethodID";
            this.packMethodIDDataGridViewTextBoxColumn.HeaderText = "方法ID";
            this.packMethodIDDataGridViewTextBoxColumn.Name = "packMethodIDDataGridViewTextBoxColumn";
            // 
            // packMethodNameDataGridViewTextBoxColumn
            // 
            this.packMethodNameDataGridViewTextBoxColumn.DataPropertyName = "packMethodName";
            this.packMethodNameDataGridViewTextBoxColumn.HeaderText = "方法名称";
            this.packMethodNameDataGridViewTextBoxColumn.Name = "packMethodNameDataGridViewTextBoxColumn";
            // 
            // packMethodParaDataGridViewTextBoxColumn
            // 
            this.packMethodParaDataGridViewTextBoxColumn.DataPropertyName = "packMethodPara";
            this.packMethodParaDataGridViewTextBoxColumn.HeaderText = "方法参数";
            this.packMethodParaDataGridViewTextBoxColumn.Name = "packMethodParaDataGridViewTextBoxColumn";
            // 
            // packMethodReturnDataGridViewTextBoxColumn
            // 
            this.packMethodReturnDataGridViewTextBoxColumn.DataPropertyName = "packMethodReturn";
            this.packMethodReturnDataGridViewTextBoxColumn.HeaderText = "方法返回值";
            this.packMethodReturnDataGridViewTextBoxColumn.Name = "packMethodReturnDataGridViewTextBoxColumn";
            // 
            // packRegularDataGridViewTextBoxColumn
            // 
            this.packRegularDataGridViewTextBoxColumn.DataPropertyName = "packRegular";
            this.packRegularDataGridViewTextBoxColumn.HeaderText = "正则匹配结果";
            this.packRegularDataGridViewTextBoxColumn.Name = "packRegularDataGridViewTextBoxColumn";
            // 
            // packMethodDescribeDataGridViewTextBoxColumn
            // 
            this.packMethodDescribeDataGridViewTextBoxColumn.DataPropertyName = "packMethodDescribe";
            this.packMethodDescribeDataGridViewTextBoxColumn.HeaderText = "方法描述";
            this.packMethodDescribeDataGridViewTextBoxColumn.Name = "packMethodDescribeDataGridViewTextBoxColumn";
            // 
            // packMethodExampleDataGridViewTextBoxColumn
            // 
            this.packMethodExampleDataGridViewTextBoxColumn.DataPropertyName = "packMethodExample";
            this.packMethodExampleDataGridViewTextBoxColumn.HeaderText = "方法使用示例";
            this.packMethodExampleDataGridViewTextBoxColumn.Name = "packMethodExampleDataGridViewTextBoxColumn";
            // 
            // packAuthorDataGridViewTextBoxColumn
            // 
            this.packAuthorDataGridViewTextBoxColumn.DataPropertyName = "packAuthor";
            this.packAuthorDataGridViewTextBoxColumn.HeaderText = "作者";
            this.packAuthorDataGridViewTextBoxColumn.Name = "packAuthorDataGridViewTextBoxColumn";
            // 
            // packTimeDataGridViewTextBoxColumn
            // 
            this.packTimeDataGridViewTextBoxColumn.DataPropertyName = "packTime";
            this.packTimeDataGridViewTextBoxColumn.HeaderText = "编写时间";
            this.packTimeDataGridViewTextBoxColumn.Name = "packTimeDataGridViewTextBoxColumn";
            // 
            // packModifierDataGridViewTextBoxColumn
            // 
            this.packModifierDataGridViewTextBoxColumn.DataPropertyName = "packModifier";
            this.packModifierDataGridViewTextBoxColumn.HeaderText = "修改人";
            this.packModifierDataGridViewTextBoxColumn.Name = "packModifierDataGridViewTextBoxColumn";
            // 
            // packModifyStateDataGridViewTextBoxColumn
            // 
            this.packModifyStateDataGridViewTextBoxColumn.DataPropertyName = "packModifyState";
            this.packModifyStateDataGridViewTextBoxColumn.HeaderText = "修改说明";
            this.packModifyStateDataGridViewTextBoxColumn.Name = "packModifyStateDataGridViewTextBoxColumn";
            // 
            // packModifyTimeDataGridViewTextBoxColumn
            // 
            this.packModifyTimeDataGridViewTextBoxColumn.DataPropertyName = "packModifyTime";
            this.packModifyTimeDataGridViewTextBoxColumn.HeaderText = "修改时间";
            this.packModifyTimeDataGridViewTextBoxColumn.Name = "packModifyTimeDataGridViewTextBoxColumn";
            // 
            // 方法封装BindingSource
            // 
            this.方法封装BindingSource.DataMember = "方法封装";
            this.方法封装BindingSource.DataSource = this.dataSetPackageManager;
            // 
            // dataSetPackageManager
            // 
            this.dataSetPackageManager.DataSetName = "DataSetPackageManager";
            this.dataSetPackageManager.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 方法封装TableAdapter
            // 
            this.方法封装TableAdapter.ClearBeforeFill = true;
            // 
            // MainPackageManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(1730, 825);
            this.Controls.Add(this.dgvPackageManager);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPackageManager";
            this.Text = "封装管理工具";
            this.Load += new System.EventHandler(this.MainPackageManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPackageManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.方法封装BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPackageManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CCWin.SkinControl.SkinDataGridView dgvPackageManager;
        private DataSetPackageManager dataSetPackageManager;
        private System.Windows.Forms.BindingSource 方法封装BindingSource;
        private DataSetPackageManagerTableAdapters.方法封装TableAdapter 方法封装TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packProductNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packClassNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packClassDescribeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packMethodIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packMethodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packMethodParaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packMethodReturnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packRegularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packMethodDescribeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packMethodExampleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packAuthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packModifierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packModifyStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn packModifyTimeDataGridViewTextBoxColumn;
    }
}