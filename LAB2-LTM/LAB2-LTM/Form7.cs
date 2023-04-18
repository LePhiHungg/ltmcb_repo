using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace LAB2_LTM
{
   /* */

    public partial class Form7 : Form
    {
        [Serializable]
        public class Student : System.Object
        {
            private string studentName = string.Empty;
            private int ID;
            private string phone = string.Empty;
            private float course1;
            private float course2;
            private float course3;
            private float average;

            public Student(string stName, int stID, string stPhone, float stCourse1, float stCourse2, float stCourse3, float stAverage)
            {
                this.studentName = stName;
                this.ID = stID;
                this.phone = stPhone;
                this.course1 = stCourse1;
                this.course2 = stCourse2;
                this.course3 = stCourse3;
                this.average = stAverage;
            }
        }
        private ArrayList studentArray = new ArrayList();
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Filename = @"D:\input4.txt";
            if (File.Exists(Filename))
            {
                File.Delete(Filename);
            }
            FileStream fs = new FileStream(Filename, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, studentArray);
            }
            catch (SerializationException x)
            {
                MessageBox.Show("Failed to serialize. Reason: " + x.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void add_bt_Click(object sender, EventArgs e)
        {
            studentArray.Add(new Student(name_tb.Text.ToString(), int.Parse(id_tb.Text), phone_tb.Text.ToString(),
                float.Parse(course1_tb.Text), float.Parse(course2_tb.Text), float.Parse(course3_tb.Text), float.Parse(average_tb.Text)));
            name_tb.Text = "";
            id_tb.Text = "";
            phone_tb.Text = "";
            course1_tb.Text = "";
            course2_tb.Text = "";
            course3_tb.Text = "";
            average_tb.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // Open the file containing the data that you want to deserialize.

            FileStream fs = new FileStream(@"D:\input4.txt", FileMode.Open);
            try
            {
                ArrayList temp_student;
                BinaryFormatter formatter = new BinaryFormatter();

                // Deserialize the hashtable from the file and
                // assign the reference to the local variable.
                temp_student = (ArrayList)formatter.Deserialize(fs);
                using (StreamReader sr = new StreamReader(@"D:\input4.txt"))
                {
                    rich_tb.AppendText(sr.ReadToEnd());
                }
            }
            catch (SerializationException x)
            {
                MessageBox.Show("Failed to deserialize. Reason: " + x.Message);
            }
            finally
            {
                fs.Close();
            }
        }
    }
}
