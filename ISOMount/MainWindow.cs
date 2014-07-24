using System;
using System.Windows.Forms;

namespace ISOMount
{
    public partial class MainWindow : Form
    {
        public string iso1 = string.Empty;
        public string mount1 = string.Empty;
        public string dismount1 = string.Empty;
        public string iso2 = string.Empty;
        public string mount2 = string.Empty;
        public string dismount2 = string.Empty;
        public string iso3 = string.Empty;
        public string mount3 = string.Empty;
        public string dismount3 = string.Empty;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = false;
            button5.Enabled = true;
            button6.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();

            string filename = string.Empty;
            string path = string.Empty;
            

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filename = System.IO.Path.GetFileName(ofd.FileName);
                path = System.IO.Path.GetDirectoryName(ofd.FileName);
                iso1 = "\"" + path + "\\" + filename + "\"";

                if(!filename.EndsWith(".iso"))
                {
                    MessageBox.Show(@"File is not a valid ISO");
                }
                else
                {
                    mount1 = "Mount-DiskImage -ImagePath " + iso1;
                    System.Diagnostics.Process.Start("mount.bat", mount1);
                    textBox1.Text = iso1;
                    button1.Enabled = false;
                    button2.Enabled = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dismount1 = "Dismount-DiskImage -ImagePath " + iso1;
            System.Diagnostics.Process.Start("mount.bat", dismount1);
            textBox1.Text = string.Empty;
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();

            string filename = string.Empty;
            string path = string.Empty;


            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filename = System.IO.Path.GetFileName(ofd.FileName);
                path = System.IO.Path.GetDirectoryName(ofd.FileName);
                iso2 = "\"" + path + "\\" + filename + "\"";

                if (!filename.EndsWith(".iso"))
                {
                    MessageBox.Show(@"File is not a valid ISO");
                }
                else
                {
                    mount2 = "Mount-DiskImage -ImagePath " + iso2;
                    System.Diagnostics.Process.Start("mount.bat", mount2);
                    textBox2.Text = iso2;
                    button3.Enabled = false;
                    button4.Enabled = true;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dismount2 = "Dismount-DiskImage -ImagePath " + iso2;
            System.Diagnostics.Process.Start("mount.bat", dismount2);
            textBox2.Text = string.Empty;
            button3.Enabled = true;
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();

            string filename = string.Empty;
            string path = string.Empty;


            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filename = System.IO.Path.GetFileName(ofd.FileName);
                path = System.IO.Path.GetDirectoryName(ofd.FileName);
                iso3 = "\"" + path + "\\" + filename + "\"";

                if (!filename.EndsWith(".iso"))
                {
                    MessageBox.Show(@"File is not a valid ISO");
                }
                else
                {
                    mount3 = "Mount-DiskImage -ImagePath " + iso3;
                    System.Diagnostics.Process.Start("mount.bat", mount3);
                    textBox3.Text = iso3;
                    button5.Enabled = false;
                    button6.Enabled = true;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dismount3 = "Dismount-DiskImage -ImagePath " + iso3;
            System.Diagnostics.Process.Start("mount.bat", dismount3);
            textBox3.Text = string.Empty;
            button5.Enabled = true;
            button6.Enabled = false;
        }
    }
}
