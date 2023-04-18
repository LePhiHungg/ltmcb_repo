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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void read_bt_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string contents = string.Empty;
                url_tb.Text = fileDialog.FileName;
                var fileStream = fileDialog.OpenFile();
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    rich_tb.AppendText(reader.ReadToEnd());
                }
                FileInfo fileInfo = new FileInfo(url_tb.Text);
                long fileSize = fileInfo.Length;
                size_tb.Text = fileSize.ToString();
                filename_tb.Text = Path.GetFileName(url_tb.Text);
                contents = rich_tb.Text;

                int count_line = 0;
                for (int i = 0; i < contents.Length - 1; i++)
                {
                    if (contents[i] == '\n')
                    {
                        count_line++;
                    }
                }
                count_line++;
                linecount_tb.Text = count_line.ToString();

                var count_word = 0;
                for (int i = 0; i < contents.Length - 1; i++)
                {
                    if (i == 0)
                    {
                        count_word++;
                    }
                    if (contents[i] == ' ' || contents[i] == '\n')
                    {
                        count_word++;
                    }

                }
                wordcount_tb.Text = count_word.ToString();

                charcount_tb.Text = (contents.Length - 1).ToString();
            }
        }

        private void exit_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
