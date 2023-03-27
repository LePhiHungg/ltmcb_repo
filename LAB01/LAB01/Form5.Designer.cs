
namespace LAB01
{
    partial class Form5
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
            this.label4 = new System.Windows.Forms.Label();
            this.tb_money = new System.Windows.Forms.TextBox();
            this.cb_currency = new System.Windows.Forms.ComboBox();
            this.bt_convert = new System.Windows.Forms.Button();
            this.lb_converted_money = new System.Windows.Forms.Label();
            this.tb_converted_money = new System.Windows.Forms.TextBox();
            this.lb_exchange_rate = new System.Windows.Forms.Label();
            this.tb_exchange_rate = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Currency Conversion";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Money to convert:";
            // 
            // tb_money
            // 
            this.tb_money.Location = new System.Drawing.Point(177, 63);
            this.tb_money.Name = "tb_money";
            this.tb_money.Size = new System.Drawing.Size(162, 22);
            this.tb_money.TabIndex = 4;
            this.tb_money.TextChanged += new System.EventHandler(this.tb_money_TextChanged);
            this.tb_money.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_money_KeyPress);
            // 
            // cb_currency
            // 
            this.cb_currency.FormattingEnabled = true;
            this.cb_currency.Location = new System.Drawing.Point(366, 61);
            this.cb_currency.Name = "cb_currency";
            this.cb_currency.Size = new System.Drawing.Size(175, 24);
            this.cb_currency.TabIndex = 5;
            this.cb_currency.SelectedIndexChanged += new System.EventHandler(this.cb_currency_SelectedIndexChanged);
            // 
            // bt_convert
            // 
            this.bt_convert.Location = new System.Drawing.Point(53, 119);
            this.bt_convert.Name = "bt_convert";
            this.bt_convert.Size = new System.Drawing.Size(488, 35);
            this.bt_convert.TabIndex = 6;
            this.bt_convert.Text = "Convert";
            this.bt_convert.UseVisualStyleBackColor = true;
            this.bt_convert.Click += new System.EventHandler(this.bt_convert_Click);
            // 
            // lb_converted_money
            // 
            this.lb_converted_money.AutoSize = true;
            this.lb_converted_money.Location = new System.Drawing.Point(50, 188);
            this.lb_converted_money.Name = "lb_converted_money";
            this.lb_converted_money.Size = new System.Drawing.Size(123, 17);
            this.lb_converted_money.TabIndex = 7;
            this.lb_converted_money.Text = "Converted money:";
            // 
            // tb_converted_money
            // 
            this.tb_converted_money.Location = new System.Drawing.Point(177, 185);
            this.tb_converted_money.Name = "tb_converted_money";
            this.tb_converted_money.Size = new System.Drawing.Size(364, 22);
            this.tb_converted_money.TabIndex = 8;
            // 
            // lb_exchange_rate
            // 
            this.lb_exchange_rate.AutoSize = true;
            this.lb_exchange_rate.Location = new System.Drawing.Point(50, 231);
            this.lb_exchange_rate.Name = "lb_exchange_rate";
            this.lb_exchange_rate.Size = new System.Drawing.Size(103, 17);
            this.lb_exchange_rate.TabIndex = 9;
            this.lb_exchange_rate.Text = "Exchange rate:";
            // 
            // tb_exchange_rate
            // 
            this.tb_exchange_rate.Location = new System.Drawing.Point(177, 231);
            this.tb_exchange_rate.Name = "tb_exchange_rate";
            this.tb_exchange_rate.ReadOnly = true;
            this.tb_exchange_rate.Size = new System.Drawing.Size(364, 22);
            this.tb_exchange_rate.TabIndex = 10;
            this.tb_exchange_rate.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 26);
            this.button1.TabIndex = 11;
            this.button1.Text = "ERASE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(324, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "QUIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 336);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_exchange_rate);
            this.Controls.Add(this.lb_exchange_rate);
            this.Controls.Add(this.tb_converted_money);
            this.Controls.Add(this.lb_converted_money);
            this.Controls.Add(this.bt_convert);
            this.Controls.Add(this.cb_currency);
            this.Controls.Add(this.tb_money);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_money;
        private System.Windows.Forms.ComboBox cb_currency;
        private System.Windows.Forms.Button bt_convert;
        private System.Windows.Forms.Label lb_converted_money;
        private System.Windows.Forms.TextBox tb_converted_money;
        private System.Windows.Forms.Label lb_exchange_rate;
        private System.Windows.Forms.TextBox tb_exchange_rate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}