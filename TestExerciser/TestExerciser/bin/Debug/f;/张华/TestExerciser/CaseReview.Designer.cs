namespace TestExerciser
{
    partial class CaseReview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaseReview));
            this.tabControlCaseReview = new System.Windows.Forms.TabControl();
            this.tabPageFlow = new System.Windows.Forms.TabPage();
            this.tabPageReview = new System.Windows.Forms.TabPage();
            this.pictureBoxFlow = new System.Windows.Forms.PictureBox();
            this.tabControlCaseReview.SuspendLayout();
            this.tabPageFlow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlow)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlCaseReview
            // 
            this.tabControlCaseReview.Controls.Add(this.tabPageFlow);
            this.tabControlCaseReview.Controls.Add(this.tabPageReview);
            this.tabControlCaseReview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlCaseReview.Location = new System.Drawing.Point(4, 32);
            this.tabControlCaseReview.Name = "tabControlCaseReview";
            this.tabControlCaseReview.SelectedIndex = 0;
            this.tabControlCaseReview.Size = new System.Drawing.Size(1147, 534);
            this.tabControlCaseReview.TabIndex = 0;
            // 
            // tabPageFlow
            // 
            this.tabPageFlow.Controls.Add(this.pictureBoxFlow);
            this.tabPageFlow.Location = new System.Drawing.Point(4, 22);
            this.tabPageFlow.Name = "tabPageFlow";
            this.tabPageFlow.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFlow.Size = new System.Drawing.Size(1139, 508);
            this.tabPageFlow.TabIndex = 0;
            this.tabPageFlow.Text = "评审流程";
            this.tabPageFlow.UseVisualStyleBackColor = true;
            // 
            // tabPageReview
            // 
            this.tabPageReview.Location = new System.Drawing.Point(4, 22);
            this.tabPageReview.Name = "tabPageReview";
            this.tabPageReview.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReview.Size = new System.Drawing.Size(1139, 508);
            this.tabPageReview.TabIndex = 1;
            this.tabPageReview.Text = "发起评审";
            this.tabPageReview.UseVisualStyleBackColor = true;
            // 
            // pictureBoxFlow
            // 
            this.pictureBoxFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxFlow.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxFlow.Name = "pictureBoxFlow";
            this.pictureBoxFlow.Size = new System.Drawing.Size(1133, 502);
            this.pictureBoxFlow.TabIndex = 0;
            this.pictureBoxFlow.TabStop = false;
            // 
            // CaseReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackPalace = ((System.Drawing.Image)(resources.GetObject("$this.BackPalace")));
            this.ClientSize = new System.Drawing.Size(1155, 570);
            this.Controls.Add(this.tabControlCaseReview);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CaseReview";
            this.Text = "用例评审";
            this.TitleCenter = false;
            this.tabControlCaseReview.ResumeLayout(false);
            this.tabPageFlow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlCaseReview;
        private System.Windows.Forms.TabPage tabPageFlow;
        private System.Windows.Forms.TabPage tabPageReview;
        private System.Windows.Forms.PictureBox pictureBoxFlow;
    }
}