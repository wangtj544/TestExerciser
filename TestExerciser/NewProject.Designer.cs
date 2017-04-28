namespace TestExerciser
{
    partial class NewProject
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
        public void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.txtProjectLocation = new System.Windows.Forms.TextBox();
            this.openProjectLocation = new System.Windows.Forms.Button();
            this.selectNewFile = new System.Windows.Forms.OpenFileDialog();
            this.btn_newProjectOK = new System.Windows.Forms.Button();
            this.btn_newProjectCancel = new System.Windows.Forms.Button();
            this.selectNewFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "项目名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "位置：";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(99, 32);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Text = "";
            this.txtProjectName.Size = new System.Drawing.Size(375, 21);
            this.txtProjectName.TabIndex = 2;
            // 
            // txtProjectLocation
            // 
            this.txtProjectLocation.Location = new System.Drawing.Point(63, 74);
            this.txtProjectLocation.Name = "txtProjectLocation";
            this.txtProjectLocation.Text = "";
            this.txtProjectLocation.Size = new System.Drawing.Size(428, 21);
            this.txtProjectLocation.TabIndex = 3;
            // 
            // openProjectLocation
            // 
            this.openProjectLocation.Location = new System.Drawing.Point(489, 74);
            this.openProjectLocation.Name = "openProjectLocation";
            this.openProjectLocation.Size = new System.Drawing.Size(36, 23);
            this.openProjectLocation.TabIndex = 4;
            this.openProjectLocation.Text = "...";
            this.openProjectLocation.UseVisualStyleBackColor = true;
            this.openProjectLocation.Click += new System.EventHandler(this.openProjectLocation_Click);
            // 
            // selectNewFile
            // 
            this.selectNewFile.FileName = "选择新建的位置";
            // 
            // btn_newProjectOK
            // 
            this.btn_newProjectOK.Location = new System.Drawing.Point(369, 131);
            this.btn_newProjectOK.Name = "btn_newProjectOK";
            this.btn_newProjectOK.Size = new System.Drawing.Size(75, 23);
            this.btn_newProjectOK.TabIndex = 5;
            this.btn_newProjectOK.Text = "确认";
            this.btn_newProjectOK.UseVisualStyleBackColor = true;
            this.btn_newProjectOK.Click += new System.EventHandler(this.btn_newProjectOK_Click);
            this.btn_newProjectOK.Enter += new System.EventHandler(this.btn_newProjectOK_Click);
            // 
            // btn_newProjectCancel
            // 
            this.btn_newProjectCancel.Location = new System.Drawing.Point(450, 131);
            this.btn_newProjectCancel.Name = "btn_newProjectCancel";
            this.btn_newProjectCancel.Size = new System.Drawing.Size(75, 23);
            this.btn_newProjectCancel.TabIndex = 6;
            this.btn_newProjectCancel.Text = "取消";
            this.btn_newProjectCancel.UseVisualStyleBackColor = true;
            this.btn_newProjectCancel.Click += new System.EventHandler(this.btn_newProjectCancel_Click);
            // 
            // NewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 172);
            this.Controls.Add(this.btn_newProjectCancel);
            this.Controls.Add(this.btn_newProjectOK);
            this.Controls.Add(this.openProjectLocation);
            this.Controls.Add(this.txtProjectLocation);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewProject";
            this.Text = "新建工程";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtProjectName;
        public System.Windows.Forms.TextBox txtProjectLocation;
        private System.Windows.Forms.Button openProjectLocation;
        private System.Windows.Forms.OpenFileDialog selectNewFile;
        private System.Windows.Forms.Button btn_newProjectCancel;
        private System.Windows.Forms.FolderBrowserDialog selectNewFolder;
        public System.Windows.Forms.Button btn_newProjectOK;
    }
}