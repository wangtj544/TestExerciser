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
            this.rtbUpdateList.Text = "\n下阶段迭代内容：\n\n1、优化执行流程（优化测试套执行），程序自动检测当前测试套下的测试用例个数，并从每个测试用例脚本中找到可以匹配的数据项并执行n（用例个数）次" +
    "，每次执行使用对应的用例的数据；\n2、优化结果显示，动态显示，执行一步显示一步；\n3、优化视图，动态显示当前执行结果以及执行过程；\n4、执行过程控制，一些较小的" +
    "功能，用以辅助执行过程控制和结果展示；";
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