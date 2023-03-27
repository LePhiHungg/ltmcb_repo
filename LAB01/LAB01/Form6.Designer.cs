
namespace LAB01
{
    partial class Form6
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tb_a = new System.Windows.Forms.TextBox();
            this.tb_b = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tb_answerA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_answerB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_S1 = new System.Windows.Forms.TextBox();
            this.tb_S2 = new System.Windows.Forms.TextBox();
            this.tb_S3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter A: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter B: ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(399, 40);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 17);
            this.linkLabel1.TabIndex = 2;
            // 
            // tb_a
            // 
            this.tb_a.Location = new System.Drawing.Point(126, 67);
            this.tb_a.Name = "tb_a";
            this.tb_a.Size = new System.Drawing.Size(182, 22);
            this.tb_a.TabIndex = 3;
            this.tb_a.TextChanged += new System.EventHandler(this.tb_a_TextChanged);
            // 
            // tb_b
            // 
            this.tb_b.Location = new System.Drawing.Point(444, 65);
            this.tb_b.Name = "tb_b";
            this.tb_b.Size = new System.Drawing.Size(210, 22);
            this.tb_b.TabIndex = 4;
            this.tb_b.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "CALCULATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(402, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "ERASE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(544, 118);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 37);
            this.button3.TabIndex = 7;
            this.button3.Text = "QUIT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tb_answerA
            // 
            this.tb_answerA.Location = new System.Drawing.Point(99, 208);
            this.tb_answerA.Name = "tb_answerA";
            this.tb_answerA.ReadOnly = true;
            this.tb_answerA.Size = new System.Drawing.Size(240, 22);
            this.tb_answerA.TabIndex = 8;
            this.tb_answerA.TextChanged += new System.EventHandler(this.tb_answer_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "A! = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "B! = ";
            // 
            // tb_answerB
            // 
            this.tb_answerB.Location = new System.Drawing.Point(405, 206);
            this.tb_answerB.Name = "tb_answerB";
            this.tb_answerB.ReadOnly = true;
            this.tb_answerB.Size = new System.Drawing.Size(249, 22);
            this.tb_answerB.TabIndex = 11;
            this.tb_answerB.TextChanged += new System.EventHandler(this.tb_answerB_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "S1:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "S2:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "S3:";
            // 
            // tb_S1
            // 
            this.tb_S1.Location = new System.Drawing.Point(99, 257);
            this.tb_S1.Name = "tb_S1";
            this.tb_S1.ReadOnly = true;
            this.tb_S1.Size = new System.Drawing.Size(555, 22);
            this.tb_S1.TabIndex = 15;
            this.tb_S1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tb_S2
            // 
            this.tb_S2.Location = new System.Drawing.Point(99, 308);
            this.tb_S2.Name = "tb_S2";
            this.tb_S2.ReadOnly = true;
            this.tb_S2.Size = new System.Drawing.Size(555, 22);
            this.tb_S2.TabIndex = 16;
            this.tb_S2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // tb_S3
            // 
            this.tb_S3.Location = new System.Drawing.Point(99, 352);
            this.tb_S3.Name = "tb_S3";
            this.tb_S3.ReadOnly = true;
            this.tb_S3.Size = new System.Drawing.Size(555, 22);
            this.tb_S3.TabIndex = 17;
            this.tb_S3.TextChanged += new System.EventHandler(this.tb_S3_TextChanged);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 386);
            this.Controls.Add(this.tb_S3);
            this.Controls.Add(this.tb_S2);
            this.Controls.Add(this.tb_S1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_answerB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_answerA);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_b);
            this.Controls.Add(this.tb_a);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox tb_a;
        private System.Windows.Forms.TextBox tb_b;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tb_answerA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_answerB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_S1;
        private System.Windows.Forms.TextBox tb_S2;
        private System.Windows.Forms.TextBox tb_S3;
    }
}