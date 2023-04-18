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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void initilizing_tree ()
        {
            string[] drives = Directory.GetLogicalDrives();
            TreeNode node = null;
            foreach(string drv in drives)
            {
                node = new TreeNode(drv);
                dir_tree.Nodes.Add(node);
                node.Nodes.Add("EMPTY");
            }
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
        }
        private void pic_box_click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pic_box.Image = pic.Image;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            initilizing_tree();
        }
        private bool IsImageFile(string path)
        {
            string ext = Path.GetExtension(path).ToLower();
            return ext == ".jpg" || ext == ".jpeg" || ext == ".png" || ext == ".gif" || ext == ".bmp";
        }
        private bool IsTextFile(string path)
        {
            string ext = Path.GetExtension(path).ToLower();
            return ext == ".txt";
        }
        private void dir_tree_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            pic_box.Image = null;
            TreeNode node = e.Node;
            node.Nodes.Clear();
            if (Directory.Exists(node.FullPath))
            {
                node.ImageIndex = 1;
                try
                {
                    foreach (string path in Directory.GetFileSystemEntries(node.FullPath))
                    {
                        TreeNode n = node.Nodes.Add(Path.GetFileName(path));
                        if (Directory.Exists(path))
                        {
                            n.Nodes.Add("Empty");
                        }
                    }
                }
                catch { }
            }
        }
        private void dir_tree_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.ImageIndex = 0;  
        }

        private void dir_tree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode node = e.Node;
            if (IsImageFile(node.FullPath))
            {
                pic_box.Image = null;
                pic_box.SizeMode = PictureBoxSizeMode.StretchImage;
                pic_box.Image = Image.FromFile(e.Node.FullPath);
                //478, 244
                pic_box.Height = 200;
                pic_box.Width = 350;
                pic_box.Cursor = Cursors.Hand;
                pic_box.Click += new EventHandler(pic_box_click);
            }
            if (IsTextFile(node.FullPath))
            {
                using (StreamReader rd = new StreamReader(node.FullPath))
                {
                    rich_tb.AppendText(rd.ReadToEnd());
                }
            }
        }

        private void rich_tb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
