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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void tb_operand1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a number, a period, or a hyphen at the beginning
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
                MessageBox.Show("Invalid input. Please enter numbers, a period (.) between numbers, and an optional hyphen (-) at the beginning.");
            }

            // Allow a hyphen only at the beginning
            if ((e.KeyChar == '-') && (sender as TextBox).Text.IndexOf('-') > 0)
            {
                e.Handled = true;
                MessageBox.Show("Invalid input. The hyphen (-) can only be at the beginning.");
            }

            // Allow only one period
            if ((e.KeyChar == '.') && (sender as TextBox).Text.IndexOf('.') > -1 && ((sender as TextBox).Text.IndexOf('.') != (sender as TextBox).Text.Length - 3))
            {
                e.Handled = true;
                MessageBox.Show("Invalid input. Only one period (.) is allowed between numbers.");
            }
        }

        private void tb_operand2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a number, a period, or a hyphen at the beginning
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
                MessageBox.Show("Invalid input. Please enter numbers, a period (.) between numbers, and an optional hyphen (-) at the beginning.");
            }

            // Allow a hyphen only at the beginning
            if ((e.KeyChar == '-') && (sender as TextBox).Text.IndexOf('-') > 0)
            {
                e.Handled = true;
                MessageBox.Show("Invalid input. The hyphen (-) can only be at the beginning.");
            }

            // Allow only one period
            if ((e.KeyChar == '.') && (sender as TextBox).Text.IndexOf('.') > -1 && ((sender as TextBox).Text.IndexOf('.') != (sender as TextBox).Text.Length - 3))
            {
                e.Handled = true;
                MessageBox.Show("Invalid input. Only one period (.) is allowed between numbers.");
            }
        }

        private void tb_operand3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a number, a period, or a hyphen at the beginning
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
                MessageBox.Show("Invalid input. Please enter numbers, a period (.) between numbers, and an optional hyphen (-) at the beginning.");
            }

            // Allow a hyphen only at the beginning
            if ((e.KeyChar == '-') && (sender as TextBox).Text.IndexOf('-') > 0)
            {
                e.Handled = true;
                MessageBox.Show("Invalid input. The hyphen (-) can only be at the beginning.");
            }

            // Allow only one period
            if ((e.KeyChar == '.') && (sender as TextBox).Text.IndexOf('.') > -1 && ((sender as TextBox).Text.IndexOf('.') != (sender as TextBox).Text.Length - 3))
            {
                e.Handled = true;
                MessageBox.Show("Invalid input. Only one period (.) is allowed between numbers.");
            }
        }

        private void bt_sum_Click(object sender, EventArgs e)
        {
            double operand1 = double.Parse(tb_operand1.Text);
            double operand2 = double.Parse(tb_operand2.Text);
            double operand3 = double.Parse(tb_operand3.Text);
            double[] operand_arr = { operand1, operand2, operand3 };
            double maxValue = operand1;
            double minValue = operand2;
            int numOfOperands = 3;

            for (int i = 0; i < numOfOperands; i++)
            {
                if (maxValue < operand_arr[i])
                {
                    maxValue = operand_arr[i];
                }
                if (minValue > operand_arr[i])
                {
                    minValue = operand_arr[i];
                }
            }
            tb_maxValue.Text = maxValue.ToString();
            tb_minValue.Text = minValue.ToString();
        }

        private void tb_maxValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_minValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_maxValue.Text = "";
            tb_minValue.Text = "";
            tb_operand1.Text = "";
            tb_operand2.Text = "";
            tb_operand3.Text = "";
        }

        private void bt_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_operand1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
