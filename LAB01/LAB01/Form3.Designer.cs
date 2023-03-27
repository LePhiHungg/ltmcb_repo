
namespace LAB01
{
    partial class Form3
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
            this.label3 = new System.Windows.Forms.Label();
            this.tb_operand1 = new System.Windows.Forms.TextBox();
            this.tb_operand2 = new System.Windows.Forms.TextBox();
            this.tb_operand3 = new System.Windows.Forms.TextBox();
            this.bt_search = new System.Windows.Forms.Button();
            this.tb_maxValue = new System.Windows.Forms.TextBox();
            this.tb_minValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_erase = new System.Windows.Forms.Button();
            this.bt_quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operand 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Operand 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(556, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Operand 3";
            // 
            // tb_operand1
            // 
            this.tb_operand1.Location = new System.Drawing.Point(128, 36);
            this.tb_operand1.Name = "tb_operand1";
            this.tb_operand1.Size = new System.Drawing.Size(100, 22);
            this.tb_operand1.TabIndex = 3;
            this.tb_operand1.TextChanged += new System.EventHandler(this.tb_operand1_TextChanged);
            this.tb_operand1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_operand1_KeyPress);
            // 
            // tb_operand2
            // 
            this.tb_operand2.Location = new System.Drawing.Point(373, 36);
            this.tb_operand2.Name = "tb_operand2";
            this.tb_operand2.Size = new System.Drawing.Size(100, 22);
            this.tb_operand2.TabIndex = 4;
            this.tb_operand2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_operand2_KeyPress);
            // 
            // tb_operand3
            // 
            this.tb_operand3.Location = new System.Drawing.Point(638, 36);
            this.tb_operand3.Name = "tb_operand3";
            this.tb_operand3.Size = new System.Drawing.Size(100, 22);
            this.tb_operand3.TabIndex = 5;
            this.tb_operand3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_operand3_KeyPress);
            // 
            // bt_search
            // 
            this.bt_search.Location = new System.Drawing.Point(161, 98);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(138, 33);
            this.bt_search.TabIndex = 6;
            this.bt_search.Text = "SEARCH";
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.bt_sum_Click);
            // 
            // tb_maxValue
            // 
            this.tb_maxValue.Location = new System.Drawing.Point(156, 193);
            this.tb_maxValue.Name = "tb_maxValue";
            this.tb_maxValue.Size = new System.Drawing.Size(162, 22);
            this.tb_maxValue.TabIndex = 8;
            this.tb_maxValue.TextChanged += new System.EventHandler(this.tb_maxValue_TextChanged);
            // 
            // tb_minValue
            // 
            this.tb_minValue.Location = new System.Drawing.Point(468, 193);
            this.tb_minValue.Name = "tb_minValue";
            this.tb_minValue.Size = new System.Drawing.Size(162, 22);
            this.tb_minValue.TabIndex = 9;
            this.tb_minValue.TextChanged += new System.EventHandler(this.tb_minValue_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Max value:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(465, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Min value:";
            // 
            // bt_erase
            // 
            this.bt_erase.Location = new System.Drawing.Point(364, 98);
            this.bt_erase.Name = "bt_erase";
            this.bt_erase.Size = new System.Drawing.Size(138, 33);
            this.bt_erase.TabIndex = 12;
            this.bt_erase.Text = "ERASE";
            this.bt_erase.UseVisualStyleBackColor = true;
            this.bt_erase.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_quit
            // 
            this.bt_quit.Location = new System.Drawing.Point(568, 98);
            this.bt_quit.Name = "bt_quit";
            this.bt_quit.Size = new System.Drawing.Size(138, 33);
            this.bt_quit.TabIndex = 13;
            this.bt_quit.Text = "QUIT";
            this.bt_quit.UseVisualStyleBackColor = true;
            this.bt_quit.Click += new System.EventHandler(this.bt_quit_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 272);
            this.Controls.Add(this.bt_quit);
            this.Controls.Add(this.bt_erase);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_minValue);
            this.Controls.Add(this.tb_maxValue);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.tb_operand3);
            this.Controls.Add(this.tb_operand2);
            this.Controls.Add(this.tb_operand1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_operand1;
        private System.Windows.Forms.TextBox tb_operand2;
        private System.Windows.Forms.TextBox tb_operand3;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.TextBox tb_maxValue;
        private System.Windows.Forms.TextBox tb_minValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_erase;
        private System.Windows.Forms.Button bt_quit;
    }
}