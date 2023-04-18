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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string path_in = @"D:\input1.txt";
        string path_out = @"D:\output1.txt";

        private void read_bt_Click(object sender, EventArgs e)
        {
            if (File.Exists(path_in))
            {
                File.Delete(path_in);
            }
            using (StreamWriter sw = new StreamWriter(path_in))
            {
                sw.WriteLine("Nguyen Van A");
                sw.WriteLine("MSSV: 16520001");
                sw.WriteLine("ANTT");
            }
            using (StreamReader sr = new StreamReader(path_in))
            {
                rich_tb.AppendText(sr.ReadToEnd());
            }
        }

        private void write_bt_Click(object sender, EventArgs e)
        {
            if (File.Exists(path_out))
            {
                File.Delete(path_out);
            }
            using (StreamWriter sw = new StreamWriter(path_out))
            {
                sw.WriteLine(rich_tb.Text.ToUpper());
            }
        }
    }
}
