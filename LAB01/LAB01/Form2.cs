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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tb_operand1_TextChanged(object sender, EventArgs e)
        {
            int value;
            bool isNotInterger = !int.TryParse(tb_operand1.Text, out value);
            if (isNotInterger)
            {
                MessageBox.Show("Error: Please enter an integer value.");
                tb_operand1.Text = "";
            }
        }

        private void tb_operand2_TextChanged(object sender, EventArgs e)
        {
            int value;
            bool isNotInterger = !int.TryParse(tb_operand2.Text, out value);
            if (isNotInterger)
            {
                MessageBox.Show("Error: Please enter an integer value.");
                tb_operand2.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int operand1 = int.Parse(tb_operand1.Text);
            int operand2 = int.Parse(tb_operand2.Text);
            int sum = operand1 + operand2;
            tb_result.Text = sum.ToString();
        }

        private void tb_result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
