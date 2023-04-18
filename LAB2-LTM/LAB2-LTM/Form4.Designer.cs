
namespace LAB2_LTM
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.dir_tree = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.rich_tb = new System.Windows.Forms.RichTextBox();
            this.pic_box = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box)).BeginInit();
            this.SuspendLayout();
            // 
            // dir_tree
            // 
            this.dir_tree.ImageIndex = 1;
            this.dir_tree.ImageList = this.imageList1;
            this.dir_tree.Location = new System.Drawing.Point(36, 86);
            this.dir_tree.Name = "dir_tree";
            this.dir_tree.SelectedImageIndex = 0;
            this.dir_tree.Size = new System.Drawing.Size(213, 377);
            this.dir_tree.StateImageList = this.imageList1;
            this.dir_tree.TabIndex = 0;
            this.dir_tree.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.dir_tree_BeforeCollapse);
            this.dir_tree.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.dir_tree_BeforeExpand);
            this.dir_tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.dir_tree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.dir_tree_NodeMouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "png-transparent-progress-bar-preloader-dotted-lines-angle-user-interface-design-t" +
        "ext.png");
            this.imageList1.Images.SetKeyName(1, "images.png");
            this.imageList1.Images.SetKeyName(2, "pngtree-vector-folder-icon-png-image_555493.jpg");
            this.imageList1.Images.SetKeyName(3, "png-transparent-progress-bar-preloader-dotted-lines-angle-user-interface-design-t" +
        "ext.png");
            // 
            // rich_tb
            // 
            this.rich_tb.Location = new System.Drawing.Point(273, 86);
            this.rich_tb.Name = "rich_tb";
            this.rich_tb.Size = new System.Drawing.Size(450, 96);
            this.rich_tb.TabIndex = 1;
            this.rich_tb.Text = "";
            this.rich_tb.TextChanged += new System.EventHandler(this.rich_tb_TextChanged);
            // 
            // pic_box
            // 
            this.pic_box.Location = new System.Drawing.Point(273, 266);
            this.pic_box.Name = "pic_box";
            this.pic_box.Size = new System.Drawing.Size(450, 197);
            this.pic_box.TabIndex = 2;
            this.pic_box.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "TEXT VIEW";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "IMAGE VIEW";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "TREE VIEW";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_box);
            this.Controls.Add(this.rich_tb);
            this.Controls.Add(this.dir_tree);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView dir_tree;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.RichTextBox rich_tb;
        private System.Windows.Forms.PictureBox pic_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}