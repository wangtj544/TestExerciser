namespace TestExerciser.Tools.ProjectManagement
{
    partial class ToolProjectStruct
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolProjectStruct));
            this.ts_Top = new CCWin.SkinControl.SkinToolStrip();
            this.tb_AddSubNode = new System.Windows.Forms.ToolStripButton();
            this.tb_Save = new System.Windows.Forms.ToolStripButton();
            this.tv_Struct = new CCWin.SkinControl.SkinTreeView();
            this.myPrStrImageList = new System.Windows.Forms.ImageList(this.components);
            this.ts_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // ts_Top
            // 
            this.ts_Top.Arrow = System.Drawing.Color.Black;
            this.ts_Top.Back = System.Drawing.Color.White;
            this.ts_Top.BackRadius = 4;
            this.ts_Top.BackRectangle = new System.Drawing.Rectangle(10, 10, 10, 10);
            this.ts_Top.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.ts_Top.BaseFore = System.Drawing.Color.Black;
            this.ts_Top.BaseForeAnamorphosis = false;
            this.ts_Top.BaseForeAnamorphosisBorder = 4;
            this.ts_Top.BaseForeAnamorphosisColor = System.Drawing.Color.White;
            this.ts_Top.BaseForeOffset = new System.Drawing.Point(0, 0);
            this.ts_Top.BaseHoverFore = System.Drawing.Color.White;
            this.ts_Top.BaseItemAnamorphosis = true;
            this.ts_Top.BaseItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.ts_Top.BaseItemBorderShow = true;
            this.ts_Top.BaseItemDown = ((System.Drawing.Image)(resources.GetObject("ts_Top.BaseItemDown")));
            this.ts_Top.BaseItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.ts_Top.BaseItemMouse = ((System.Drawing.Image)(resources.GetObject("ts_Top.BaseItemMouse")));
            this.ts_Top.BaseItemNorml = null;
            this.ts_Top.BaseItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.ts_Top.BaseItemRadius = 4;
            this.ts_Top.BaseItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.ts_Top.BaseItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.ts_Top.BindTabControl = null;
            this.ts_Top.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.ts_Top.Fore = System.Drawing.Color.Black;
            this.ts_Top.GripMargin = new System.Windows.Forms.Padding(2, 2, 4, 2);
            this.ts_Top.HoverFore = System.Drawing.Color.White;
            this.ts_Top.ItemAnamorphosis = true;
            this.ts_Top.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.ts_Top.ItemBorderShow = true;
            this.ts_Top.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.ts_Top.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.ts_Top.ItemRadius = 4;
            this.ts_Top.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.ts_Top.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tb_AddSubNode,
            this.tb_Save});
            this.ts_Top.Location = new System.Drawing.Point(4, 32);
            this.ts_Top.Name = "ts_Top";
            this.ts_Top.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.ts_Top.Size = new System.Drawing.Size(1432, 25);
            this.ts_Top.SkinAllColor = true;
            this.ts_Top.TabIndex = 0;
            this.ts_Top.TitleAnamorphosis = true;
            this.ts_Top.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.ts_Top.TitleRadius = 4;
            this.ts_Top.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // tb_AddSubNode
            // 
            this.tb_AddSubNode.Image = ((System.Drawing.Image)(resources.GetObject("tb_AddSubNode.Image")));
            this.tb_AddSubNode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_AddSubNode.Name = "tb_AddSubNode";
            this.tb_AddSubNode.Size = new System.Drawing.Size(100, 22);
            this.tb_AddSubNode.Text = "添加子级节点";
            this.tb_AddSubNode.Click += new System.EventHandler(this.tb_AddSubNode_Click);
            // 
            // tb_Save
            // 
            this.tb_Save.Image = ((System.Drawing.Image)(resources.GetObject("tb_Save.Image")));
            this.tb_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_Save.Name = "tb_Save";
            this.tb_Save.Size = new System.Drawing.Size(52, 22);
            this.tb_Save.Text = "保存";
            this.tb_Save.Click += new System.EventHandler(this.tb_Save_Click);
            // 
            // tv_Struct
            // 
            this.tv_Struct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_Struct.ImageIndex = 0;
            this.tv_Struct.ImageList = this.myPrStrImageList;
            this.tv_Struct.LabelEdit = true;
            this.tv_Struct.Location = new System.Drawing.Point(4, 57);
            this.tv_Struct.Name = "tv_Struct";
            this.tv_Struct.SelectedImageIndex = 0;
            this.tv_Struct.Size = new System.Drawing.Size(1432, 764);
            this.tv_Struct.TabIndex = 1;
            // 
            // myPrStrImageList
            // 
            this.myPrStrImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("myPrStrImageList.ImageStream")));
            this.myPrStrImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.myPrStrImageList.Images.SetKeyName(0, "afchgorg.gif");
            this.myPrStrImageList.Images.SetKeyName(1, "3.png");
            // 
            // ToolProjectStruct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 825);
            this.Controls.Add(this.tv_Struct);
            this.Controls.Add(this.ts_Top);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ToolProjectStruct";
            this.Text = "项目结构";
            this.TitleCenter = false;
            this.Load += new System.EventHandler(this.ToolProjectStruct_Load);
            this.ts_Top.ResumeLayout(false);
            this.ts_Top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private CCWin.SkinControl.SkinToolStrip ts_Top;
        private System.Windows.Forms.ToolStripButton tb_AddSubNode;
        private System.Windows.Forms.ToolStripButton tb_Save;
        private CCWin.SkinControl.SkinTreeView tv_Struct;
        private System.Windows.Forms.ImageList myPrStrImageList;
    }
}