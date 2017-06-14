namespace TestExerciser
{
    partial class MainUpdateHis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUpdateHis));
            this.rtbUpdateList = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbUpdateList
            // 
            this.rtbUpdateList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbUpdateList.Location = new System.Drawing.Point(4, 32);
            this.rtbUpdateList.Name = "rtbUpdateList";
            this.rtbUpdateList.ReadOnly = true;
            this.rtbUpdateList.Size = new System.Drawing.Size(669, 507);
            this.rtbUpdateList.TabIndex = 0;
            this.rtbUpdateList.Text = "";
            // 
            // MainUpdateHis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 543);
            this.Controls.Add(this.rtbUpdateList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainUpdateHis";
            this.Text = "版本更新说明";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbUpdateList;
    }
}