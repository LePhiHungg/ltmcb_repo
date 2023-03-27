using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB01
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (tb_numb.Text)
            {
                case "1":
                    tb_answer.Text = "One";
                    break;
                case "2":
                    tb_answer.Text = "Two";
                    break;
                case "3":
                    tb_answer.Text = "Three";
                    break;
                case "4":
                    tb_answer.Text = "Four";
                    break;
                case "5":
                    tb_answer.Text = "Five";
                    break;
                case "6":
                    tb_answer.Text = "Six";
                    break;
                case "7":
                    tb_answer.Text = "Seven";
                    break;
                case "8":
                    tb_answer.Text = "Eight";
                    break;
                case "9":
                    tb_answer.Text = "Nine";
                    break;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb_answer.Text = "";
            tb_numb.Text = "";
        }

        private void tb_numb_TextChanged(object sender, EventArgs e)
        {
            int value;
            bool isNotInterger = !int.TryParse(tb_numb.Text, out value);
            if (isNotInterger)
            {
                MessageBox.Show("Error: Please enter an integer value.");
                tb_numb.Text = "";
            }
        }
        private void tb_answer_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tb_numb_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Prevent typing more than one digit
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Length >= 1 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Enter a single number from 0 to 9");
            }
        }
    }
}
