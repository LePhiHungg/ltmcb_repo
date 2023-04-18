using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Threading;
using System.Windows.Forms; 

namespace LAB2_LTM
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string zip_path = string.Empty;
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                zip_path = fileDialog.FileName;
            }
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            string compressed_input = string.Empty;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                compressed_input = saveFileDialog1.FileName;
                using (var archive = ZipFile.Open(compressed_input, ZipArchiveMode.Create))
                {
                    archive.CreateEntryFromFile(zip_path, Path.GetFileName(zip_path));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string zip_path = string.Empty;
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                zip_path = fileDialog.FileName;
            }
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            string extracted_output = string.Empty;
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                extracted_output = saveFileDialog1.FileName;
                ZipFile.ExtractToDirectory(zip_path, extracted_output);
            }
            

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            string noti = "Mô tả cách hoạt động: khi click vào button NÉN \nCửa sổ mở lên và ta chọn file cần giải nén \nSau đó chọn nơi cần lưu file nén và đặt tên với .zip và ấn Save\nKhi click vào button giải nén\nCửa sổ window mở lên, ta chọn file zip cần giải nén và sau đó chọn nơi cần giải nén và fill tên folder cần giải nén rồi ấn save";
            richTextBox1.Text = noti;
        }
    }
}
