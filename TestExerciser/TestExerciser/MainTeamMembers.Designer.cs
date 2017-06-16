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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainTeamMembers));
            this.treeTeamMembers = new CCWin.SkinControl.SkinTreeView();
            this.SuspendLayout();
            // 
            // treeTeamMembers
            // 
            this.treeTeamMembers.Location = new System.Drawing.Point(4, 376);
            this.treeTeamMembers.Name = "treeTeamMembers";
            this.treeTeamMembers.Size = new System.Drawing.Size(276, 207);
            this.treeTeamMembers.TabIndex = 0;
            // 
            // TeamMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackPalace = ((System.Drawing.Image)(resources.GetObject("$this.BackPalace")));
            this.ClientSize = new System.Drawing.Size(284, 587);
            this.Controls.Add(this.treeTeamMembers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TeamMembers";
            this.Text = "团队成员";
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinTreeView treeTeamMembers;
    }
}