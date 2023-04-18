
namespace LAB2_LTM
{
    partial class Form2
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
            this.read_bt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.exit_bt = new System.Windows.Forms.Button();
            this.rich_tb = new System.Windows.Forms.RichTextBox();
            this.filename_tb = new System.Windows.Forms.TextBox();
            this.size_tb = new System.Windows.Forms.TextBox();
            this.url_tb = new System.Windows.Forms.TextBox();
            this.linecount_tb = new System.Windows.Forms.TextBox();
            this.wordcount_tb = new System.Windows.Forms.TextBox();
            this.charcount_tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // read_bt
            // 
            this.read_bt.Location = new System.Drawing.Point(41, 36);
            this.read_bt.Name = "read_bt";
            this.read_bt.Size = new System.Drawing.Size(287, 49);
            this.read_bt.TabIndex = 0;
            this.read_bt.Text = "READ FROM FILE";
            this.read_bt.UseVisualStyleBackColor = true;
            this.read_bt.Click += new System.EventHandler(this.read_bt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "File name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Size:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "URL:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Line count:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Words count:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Character count:";
            // 
            // exit_bt
            // 
            this.exit_bt.Location = new System.Drawing.Point(41, 390);
            this.exit_bt.Name = "exit_bt";
            this.exit_bt.Size = new System.Drawing.Size(287, 49);
            this.exit_bt.TabIndex = 7;
            this.exit_bt.Text = "EXIT";
            this.exit_bt.UseVisualStyleBackColor = true;
            this.exit_bt.Click += new System.EventHandler(this.exit_bt_Click);
            // 
            // rich_tb
            // 
            this.rich_tb.Location = new System.Drawing.Point(372, 36);
            this.rich_tb.Name = "rich_tb";
            this.rich_tb.Size = new System.Drawing.Size(368, 403);
            this.rich_tb.TabIndex = 8;
            this.rich_tb.Text = "";
            // 
            // filename_tb
            // 
            this.filename_tb.Location = new System.Drawing.Point(154, 117);
            this.filename_tb.Name = "filename_tb";
            this.filename_tb.Size = new System.Drawing.Size(174, 22);
            this.filename_tb.TabIndex = 9;
            // 
            // size_tb
            // 
            this.size_tb.Location = new System.Drawing.Point(154, 156);
            this.size_tb.Name = "size_tb";
            this.size_tb.Size = new System.Drawing.Size(174, 22);
            this.size_tb.TabIndex = 10;
            // 
            // url_tb
            // 
            this.url_tb.Location = new System.Drawing.Point(154, 199);
            this.url_tb.Name = "url_tb";
            this.url_tb.Size = new System.Drawing.Size(174, 22);
            this.url_tb.TabIndex = 11;
            // 
            // linecount_tb
            // 
            this.linecount_tb.Location = new System.Drawing.Point(154, 245);
            this.linecount_tb.Name = "linecount_tb";
            this.linecount_tb.Size = new System.Drawing.Size(174, 22);
            this.linecount_tb.TabIndex = 12;
            // 
            // wordcount_tb
            // 
            this.wordcount_tb.Location = new System.Drawing.Point(154, 292);
            this.wordcount_tb.Name = "wordcount_tb";
            this.wordcount_tb.Size = new System.Drawing.Size(174, 22);
            this.wordcount_tb.TabIndex = 13;
            // 
            // charcount_tb
            // 
            this.charcount_tb.Location = new System.Drawing.Point(154, 338);
            this.charcount_tb.Name = "charcount_tb";
            this.charcount_tb.Size = new System.Drawing.Size(174, 22);
            this.charcount_tb.TabIndex = 14;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 475);
            this.Controls.Add(this.charcount_tb);
            this.Controls.Add(this.wordcount_tb);
            this.Controls.Add(this.linecount_tb);
            this.Controls.Add(this.url_tb);
            this.Controls.Add(this.size_tb);
            this.Controls.Add(this.filename_tb);
            this.Controls.Add(this.rich_tb);
            this.Controls.Add(this.exit_bt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.read_bt);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button read_bt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button exit_bt;
        private System.Windows.Forms.RichTextBox rich_tb;
        private System.Windows.Forms.TextBox filename_tb;
        private System.Windows.Forms.TextBox size_tb;
        private System.Windows.Forms.TextBox url_tb;
        private System.Windows.Forms.TextBox linecount_tb;
        private System.Windows.Forms.TextBox wordcount_tb;
        private System.Windows.Forms.TextBox charcount_tb;
    }
}