using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;



namespace Secimanket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        int t = 0;


        string[] dosyalar = Directory.GetFiles(@"C:\resim\", "*.png");
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;
            pictureBox1.Enabled = false;
            label3.Text =DateTime.Now.ToLongDateString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t++;
            pictureBox1.Enabled = true;
            Random rd = new Random();
            int a = rd.Next(1, 101);
            Random rd2 = new Random();
            int b = rd2.Next(0, 3);
            progressBar1.Value = a;
            label1.Text = "%"+" "+a.ToString();
            pictureBox1.ImageLocation = dosyalar[rd2.Next(0, dosyalar.Length)];
            this.pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
            if (t==5)
            {
                Form2 fr2 = new Form2();
                fr2.Show();
                this.Hide();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
