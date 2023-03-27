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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void tb_a_TextChanged(object sender, EventArgs e)
        {
            int value;
            bool isNotInterger = !int.TryParse(tb_a.Text, out value);
            if (isNotInterger)
            {
                MessageBox.Show("Error: Please enter an integer value.");
                tb_a.Text = "";
            }
        }
        private void tb_answer_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int value;
            bool isNotInterger = !int.TryParse(tb_b.Text, out value);
            if (isNotInterger)
            {
                MessageBox.Show("Error: Please enter an integer value.");
                tb_b.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb_a.Text = "";
            tb_b.Text = "";

        }

        private void tb_answerB_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int A = int.Parse(tb_a.Text);
            string a = "";
            int a_answer = 0;
            for (int i = 1; i <= A; i++)
            {

                if (i == A)
                {
                    a += "+ ... + A";
                }
                else
                {
                    if (i == 1)
                    {
                        a += i.ToString();
                    }
                    else
                    {
                        a += '+';
                        a += i.ToString();
                    }
                }
                a_answer += i;

            }
            tb_answerA.Text = a_answer.ToString();
            tb_S1.Text =  a + " = " + a_answer.ToString();
            
            int B = int.Parse(tb_b.Text);
            string b = "";
            int b_answer = 0;
            for (int i = 1; i <= B; i++)
            {
                if (i == B)
                {
                    b += "+ ... + A";
                }
                else
                {
                    if (i == 1)
                    {
                        b += i.ToString();
                    }
                    else
                    {
                        b += '+';
                        b += i.ToString();
                    }
                }
                b_answer += i;
            }
            tb_answerB.Text = b_answer.ToString();
            tb_S2.Text = b + " = " + b_answer.ToString();
            string c = "";
            double s3_answer = 0;
            int c_answer = 0;
            for (int i = 1; i <= B; i++)
            {
                if (i == B)
                {
                    c += "+ ... + A^B";
                }
                else
                {
                    if (i == 1)
                    {
                        c += "A^" + i.ToString();
                    }
                    else
                    {
                        c += "+A^";
                        c += i.ToString();
                    }
                }
                c_answer += i;
                s3_answer += Math.Pow(A, i);
            }
            tb_S3.Text = c + " = " + s3_answer.ToString();


        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_S3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
