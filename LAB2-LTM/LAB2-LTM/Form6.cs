using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace LAB2_LTM
{
    public partial class Form6 : Form
    {
        string expression = string.Empty;
        public Form6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader rd = new StreamReader(fileDialog.FileName))
                {
                    rich_tb.AppendText(rd.ReadToEnd());
                    expression = rd.ReadToEnd();
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stack<int> expression_stack = new Stack<int>();
            string[] expression_sequence = { };

            int flag = 0;
            int j = 0;
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '\n')
                {
                    Array.Resize(ref expression_sequence, expression_sequence.Length + 1);
                    expression_sequence[j] = expression.Substring(flag, i - 1);
                    j++;
                    flag = i + 1;
                }
                if (i == expression.Length - 1)
                {
                    expression_sequence[j] = expression.Substring(flag, i - 1);
                }
            }
            for (int i = 0; i < expression_sequence.Length; i++)
            {
                rich_tb2.AppendText(expression_sequence[i]);
            }
        }
    }
}
