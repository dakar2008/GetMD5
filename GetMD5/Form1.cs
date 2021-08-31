using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GetMD5;

namespace GetMD5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textbox_md5.Text = Helper.GetHashFromFile(openFileDialog1.FileName, Helper.Algorithms.MD5);
                textbox_sha1.Text = Helper.GetHashFromFile(openFileDialog1.FileName, Helper.Algorithms.SHA1);
                textbox_sha256.Text = Helper.GetHashFromFile(openFileDialog1.FileName, Helper.Algorithms.SHA256);
                textbox_sha384.Text = Helper.GetHashFromFile(openFileDialog1.FileName, Helper.Algorithms.SHA384);
                textbox_sha512.Text = Helper.GetHashFromFile(openFileDialog1.FileName, Helper.Algorithms.SHA512);
                textbox_ripemd160.Text = Helper.GetHashFromFile(openFileDialog1.FileName, Helper.Algorithms.RIPEMD160);
            }
        }
    }
}
