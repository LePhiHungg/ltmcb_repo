
namespace LAB2_LTM
{
    partial class Form1
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
            this.rich_tb = new System.Windows.Forms.RichTextBox();
            this.read_bt = new System.Windows.Forms.Button();
            this.write_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rich_tb
            // 
            this.rich_tb.Location = new System.Drawing.Point(247, 37);
            this.rich_tb.Name = "rich_tb";
            this.rich_tb.Size = new System.Drawing.Size(398, 187);
            this.rich_tb.TabIndex = 0;
            this.rich_tb.Text = "";
            // 
            // read_bt
            // 
            this.read_bt.Location = new System.Drawing.Point(38, 37);
            this.read_bt.Name = "read_bt";
            this.read_bt.Size = new System.Drawing.Size(187, 65);
            this.read_bt.TabIndex = 1;
            this.read_bt.Text = "READ FILE";
            this.read_bt.UseVisualStyleBackColor = true;
            this.read_bt.Click += new System.EventHandler(this.read_bt_Click);
            // 
            // write_bt
            // 
            this.write_bt.Location = new System.Drawing.Point(38, 153);
            this.write_bt.Name = "write_bt";
            this.write_bt.Size = new System.Drawing.Size(187, 65);
            this.write_bt.TabIndex = 2;
            this.write_bt.Text = "WRITE FILE";
            this.write_bt.UseVisualStyleBackColor = true;
            this.write_bt.Click += new System.EventHandler(this.write_bt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 266);
            this.Controls.Add(this.write_bt);
            this.Controls.Add(this.read_bt);
            this.Controls.Add(this.rich_tb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rich_tb;
        private System.Windows.Forms.Button read_bt;
        private System.Windows.Forms.Button write_bt;
    }
}

