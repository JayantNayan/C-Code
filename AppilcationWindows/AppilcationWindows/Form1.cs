using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AppilcationWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();

            string  s = open.FileName;
           
            pictureBox2.Image = Image.FromFile(s);


            



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            

        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            save.ShowDialog();

        }
    }
}
