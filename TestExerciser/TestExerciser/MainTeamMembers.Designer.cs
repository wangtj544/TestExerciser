namespace TestExerciser
{
    partial class MainTeamMembers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainTeamMembers));
            this.dgvTeamMembers = new CCWin.SkinControl.SkinDataGridView();
            this.用户管理BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTeamMembers = new TestExerciser.DataSetTeamMembers();
            this.用户管理BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.用户管理TableAdapter = new TestExerciser.DataSetTeamMembersTableAdapters.用户管理TableAdapter();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.用户管理BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTeamMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.用户管理BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTeamMembers
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.dgvTeamMembers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTeamMembers.AutoGenerateColumns = false;
            this.dgvTeamMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeamMembers.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTeamMembers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTeamMembers.ColumnFont = null;
            this.dgvTeamMembers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTeamMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTeamMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeamMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullNameDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn});
            this.dgvTeamMembers.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvTeamMembers.DataSource = this.用户管理BindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTeamMembers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTeamMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTeamMembers.EnableHeadersVisualStyles = false;
            this.dgvTeamMembers.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvTeamMembers.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvTeamMembers.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvTeamMembers.Location = new System.Drawing.Point(4, 32);
            this.dgvTeamMembers.Name = "dgvTeamMembers";
            this.dgvTeamMembers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTeamMembers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvTeamMembers.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTeamMembers.RowTemplate.Height = 23;
            this.dgvTeamMembers.Size = new System.Drawing.Size(276, 551);
            this.dgvTeamMembers.TabIndex = 0;
            this.dgvTeamMembers.TitleBack = null;
            this.dgvTeamMembers.TitleBackColorBegin = System.Drawing.Color.White;
            this.dgvTeamMembers.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            // 
            // 用户管理BindingSource1
            // 
            this.用户管理BindingSource1.DataMember = "用户管理";
            this.用户管理BindingSource1.DataSource = this.dataSetTeamMembers;
            // 
            // dataSetTeamMembers
            // 
            this.dataSetTeamMembers.DataSetName = "DataSetTeamMembers";
            this.dataSetTeamMembers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 用户管理BindingSource
            // 
            this.用户管理BindingSource.DataMember = "用户管理";
            this.用户管理BindingSource.DataSource = this.dataSetTeamMembers;
            // 
            // 用户管理TableAdapter
            // 
            this.用户管理TableAdapter.ClearBeforeFill = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "fullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "姓名";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "userName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "用户名";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // MainTeamMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackPalace = ((System.Drawing.Image)(resources.GetObject("$this.BackPalace")));
            this.ClientSize = new System.Drawing.Size(284, 587);
            this.Controls.Add(this.dgvTeamMembers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainTeamMembers";
            this.Text = "团队成员";
            this.Load += new System.EventHandler(this.MainTeamMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.用户管理BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTeamMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.用户管理BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinDataGridView dgvTeamMembers;
        private DataSetTeamMembers dataSetTeamMembers;
        private System.Windows.Forms.BindingSource 用户管理BindingSource;
        private DataSetTeamMembersTableAdapters.用户管理TableAdapter 用户管理TableAdapter;
        private System.Windows.Forms.BindingSource 用户管理BindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;

    }
}