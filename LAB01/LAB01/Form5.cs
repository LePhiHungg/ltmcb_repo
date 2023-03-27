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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cb_currency_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            cb_currency.Items.Add("USD");
            cb_currency.Items.Add("EUR");
            cb_currency.Items.Add("GBP");
            cb_currency.Items.Add("SGD");
            cb_currency.Items.Add("JPY");
        }

        private void tb_money_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_money_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is a number, a period, or a hyphen at the beginning
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Invalid input. Please enter numbers, a period (.) between numbers");
            }

            // Allow only one period
            if ((e.KeyChar == '.') && (sender as TextBox).Text.IndexOf('.') > -1 && ((sender as TextBox).Text.IndexOf('.') != (sender as TextBox).Text.Length - 3))
            {
                e.Handled = true;
                MessageBox.Show("Invalid input. Only one period (.) is allowed between numbers.");
            }
        }

        private void bt_convert_Click(object sender, EventArgs e)
        {
            double converted_money;
            double money = double.Parse(tb_money.Text);
            switch (cb_currency.Text)
            {
                case "USD":
                    converted_money = 22.772 * money;
                    tb_converted_money.Text = converted_money.ToString();
                    tb_exchange_rate.Text = "1 USD = 22.77 VND";
                    break;
                case "SGD":
                    converted_money = 17.286 * money;
                    tb_converted_money.Text = converted_money.ToString();
                    tb_exchange_rate.Text = "1 SGD = 17.186 VND";
                    break;
                case "EUR":
                    converted_money = 28.132 * money;
                    tb_converted_money.Text = converted_money.ToString();
                    tb_exchange_rate.Text = "1 EUR = 28.132 VND";
                    break;
                case "JPY":
                    converted_money = 214 * money;
                    tb_converted_money.Text = converted_money.ToString();
                    tb_exchange_rate.Text = "1 JPY = 214 VND";
                    break;
                case "GBP":
                    converted_money = 31.538 * money;
                    tb_converted_money.Text = converted_money.ToString();
                    tb_exchange_rate.Text = "1 GBP = 31.538 VND";
                    break;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_money.Text = "";
            tb_exchange_rate.Text = "";
            tb_converted_money.Text = "";
            cb_currency.SelectedIndex = -1;
        }
    }
}
