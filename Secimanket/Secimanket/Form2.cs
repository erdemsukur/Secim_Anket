using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Secimanket
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int sayac = 0;
        double o1, o2, o3, o4, ot = 0;
        double t1, t2, t3, t4 = 0;
       
        private void Form1_Load(object sender, EventArgs e)
        {
           
            pictureBox1.Image = Image.FromFile("C:\\resim\\soruisaret.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            label16.Text = DateTime.Now.ToLongDateString();

            label10.Visible = false;
            button2.Enabled = false;
            button1.Enabled = false;
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            comboBox1.Items.Add("İzmir");
            comboBox1.Items.Add("İstanbul");
            
            comboBox3.Items.Add("2");
            comboBox3.Items.Add("3");
            comboBox3.Items.Add("4");

            comboBox2.Enabled = false;
            comboBox3.Enabled = false;

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                comboBox2.Enabled = true;
           
              if (comboBox1.SelectedIndex == 1)
                  {
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("Beylikdüzü");
                    comboBox2.Items.Add("Maltepe");
                  }
            
               else
                {
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("Alsancak");
                    comboBox2.Items.Add("Bornova");
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1)
            {
                comboBox3.Enabled = true;
            }
            if (comboBox2.SelectedIndex ==0)
            {
                comboBox3.Enabled = true;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            checkBox4.Enabled = true;
            button1.Enabled = true;
         
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
           
            //for (int i = 0; i < this.Controls.Count; i++)
            //{
            //    if (Controls[i] is CheckBox)
            //    {
            //        if (((CheckBox)Controls[i]).Checked)
            //            sayac++;
            //    }
            //    label5.Text = sayac.ToString();
            //}
          
            if (checkBox1.Checked == true)
            {
                sayac++;
            }
             if (checkBox2.Checked==true)
            {
                sayac++;
            }
             if (checkBox3.Checked == true)
            {
                sayac++;
            }
             if (checkBox4.Checked == true)
            {
                sayac++;
            }
           // label5.Text = sayac.ToString();

            if (sayac==0)
            {
                MessageBox.Show("Parti Seçimi Yapın");
            }
            //
             if (comboBox3.SelectedIndex == 0 && sayac == 2)
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                label10.Visible = true;
                if (checkBox1.Checked==true)
                {
                    textBox1.Enabled = true;
                }
                if (checkBox2.Checked == true)
                {
                    textBox2.Enabled = true;
                }
                if (checkBox3.Checked == true)
                {
                    textBox3.Enabled = true;
                }
                if (checkBox4.Checked == true)
                {
                    textBox4.Enabled = true;
                }
                label10.Text = comboBox2.SelectedItem.ToString() + " " + "İlçesi";
                button2.Enabled = true;
                button1.Enabled = false;
            }
                if (comboBox3.SelectedIndex == 0 && sayac != 2)
                {
                    sayac = 0;
                    MessageBox.Show("Seçimi Doğru Yapın");
                }
              
             if (comboBox3.SelectedIndex == 1 && sayac == 3)
             {
                 checkBox1.Enabled = false;
                 checkBox2.Enabled = false;
                 checkBox3.Enabled = false;
                 checkBox4.Enabled = false;
                 label10.Visible = true;
                 if (checkBox1.Checked == true)
                 {
                     textBox1.Enabled = true;
                 }
                 if (checkBox2.Checked == true)
                 {
                     textBox2.Enabled = true;
                 }
                 if (checkBox3.Checked == true)
                 {
                     textBox3.Enabled = true;
                 }
                 if (checkBox4.Checked == true)
                 {
                     textBox4.Enabled = true;
                 }
                 label10.Text = comboBox2.SelectedItem.ToString() + " " + "İlçesi";
                 button1.Enabled = false;
                 button2.Enabled = true;
             }
                 if (comboBox3.SelectedIndex == 1 && sayac != 3)
                 {
                     sayac = 0;
                     MessageBox.Show("Seçimi Doğru Yapın");
                 }
           
             
           
             if (comboBox3.SelectedIndex == 2 && sayac == 4)
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                label10.Visible = true;
                if (checkBox1.Checked == true)
                {
                    textBox1.Enabled = true;
                }
                if (checkBox2.Checked == true)
                {
                    textBox2.Enabled = true;
                }
                if (checkBox3.Checked == true)
                {
                    textBox3.Enabled = true;
                }
                if (checkBox4.Checked == true)
                {
                    textBox4.Enabled = true;
                }
                label10.Text = comboBox2.SelectedItem.ToString() + " " + "İlçesi";
                button1.Enabled = false;
                button2.Enabled = true;
            }
             if (comboBox3.SelectedIndex == 2 && sayac != 4)
             {
                 sayac = 0;
                 MessageBox.Show("Seçimi Doğru Yapın");
             }
           
                }

        private void button2_Click(object sender, EventArgs e)
        {
            //textBox1.Text * 100 / toplam;
            //double a = 3.567;
            //a = Math.Round(a, 2);
            //label15.Text = a.ToString();
           

            if (sayac==2)
            {
                if (checkBox1.Checked==true && checkBox2.Checked==true)
                {
                     o1 = Convert.ToInt32(textBox1.Text);
                     o2 = Convert.ToInt32(textBox2.Text);
                     ot = o1 + o2;
                     t1 = (o1 * 100) / ot; t1 = Math.Round(t1,2); progressBar1.Value = Convert.ToInt32(t1);
                     t2 = (o2 * 100) / ot; t2 = Math.Round(t2,2); progressBar2.Value = Convert.ToInt32(t2);
                     label11.Text = t1.ToString() + "%";
                     label12.Text = t2.ToString() + "%";
                     listBox1.Items.Add(label10.Text + " A PARTİ:" + "%" + t1.ToString() + "  " + "B PARTİ:" + "%" + t2.ToString()+"\n"+label16.Text);
                     if (t1>t2)
                     {
                          pictureBox1.Image = Image.FromFile("C:\\resim\\p1.png");
                          pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                          label18.Text = "A PARTİ";
                     }
                     else
                     {
                         pictureBox1.Image = Image.FromFile("C:\\resim\\p2.png");
                         pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                         label18.Text = "B PARTİ";
                     }

                }
                if (checkBox1.Checked == true && checkBox3.Checked == true)
                {
                    o1 = Convert.ToInt32(textBox1.Text);
                    o3 = Convert.ToInt32(textBox3.Text);
                    ot = o1 + o3;
                    t1 = (o1 * 100) / ot; t1 = Math.Round(t1,2); progressBar1.Value = Convert.ToInt32(t1);
                    t3 = (o3 * 100) / ot; t3 = Math.Round(t3,2); progressBar3.Value = Convert.ToInt32(t3);
                    label11.Text = t1.ToString() + "%";
                    label13.Text = t3.ToString() + "%";
                    listBox1.Items.Add(label10.Text + " A PARTİ:" + "%" + t1.ToString() + "  " + "C PARTİ:" + "%" + t3.ToString());
                    if (t1 > t3)
                    {
                        pictureBox1.Image = Image.FromFile("C:\\resim\\p1.png");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        label18.Text = "A PARTİ";
                    }
                    else
                    {
                        pictureBox1.Image = Image.FromFile("C:\\resim\\p3.png");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        label18.Text = "C PARTİ";
                    }
                }
                if (checkBox1.Checked == true && checkBox4.Checked == true)
                {
                    o1 = Convert.ToInt32(textBox1.Text);
                    o4 = Convert.ToInt32(textBox4.Text);
                    ot = o1 + o4;
                    t1 = (o1 * 100) / ot; t1 = Math.Round(t1,2); progressBar1.Value = Convert.ToInt32(t1);
                    t4 = (o4 * 100) / ot; t4 = Math.Round(t4,2); progressBar4.Value = Convert.ToInt32(t4);
                    label11.Text = t1.ToString() + "%";
                    label14.Text = t4.ToString() + "%";
                    listBox1.Items.Add(label10.Text + " A PARTİ:" + "%" + t1.ToString() + "  " + "D PARTİ:" + "%" + t4.ToString());
                    if (t1 > t4)
                    {
                        pictureBox1.Image = Image.FromFile("C:\\resim\\p1.png");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        label18.Text = "A PARTİ";
                    }
                    else
                    {
                        pictureBox1.Image = Image.FromFile("C:\\resim\\p4.png");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        label18.Text = "D PARTİ";
                    }
                }
                if (checkBox2.Checked == true && checkBox3.Checked == true)
                {
                    o2 = Convert.ToInt32(textBox2.Text);
                    o3 = Convert.ToInt32(textBox3.Text);
                    ot = o2 + o3;
                    t2 = (o2 * 100) / ot; t2 = Math.Round(t2,2); progressBar2.Value = Convert.ToInt32(t2);
                    t3 = (o3 * 100) / ot; t3 = Math.Round(t3,2); progressBar3.Value = Convert.ToInt32(t3);
                    label12.Text = t2.ToString() + "%";
                    label13.Text = t3.ToString() + "%";
                    listBox1.Items.Add(label10.Text + " B PARTİ:" + "%" + t2.ToString() + "  " + "C PARTİ:" + "%" + t3.ToString());
                    if (t2 > t3)
                    {
                        pictureBox1.Image = Image.FromFile("C:\\resim\\p2.png");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        label18.Text = "B PARTİ";
                    }
                    else
                    {
                        pictureBox1.Image = Image.FromFile("C:\\resim\\p3.png");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        label18.Text = "C PARTİ";
                    }
                }
                if (checkBox2.Checked == true && checkBox4.Checked == true)
                {
                    o2 = Convert.ToInt32(textBox2.Text);
                    o4 = Convert.ToInt32(textBox4.Text);
                    ot = o2 + o4;
                    t2 = (o2 * 100) / ot; t2 = Math.Round(t2,2); progressBar2.Value = Convert.ToInt32(t2);
                    t4 = (o4 * 100) / ot; t4 = Math.Round(t4,2); progressBar4.Value = Convert.ToInt32(t4);
                    label11.Text = t2.ToString() + "%";
                    label14.Text = t4.ToString() + "%";
                    listBox1.Items.Add(label10.Text + " B PARTİ:" + "%" + t2.ToString() + "  " + "D PARTİ:" + "%" + t4.ToString());
                    if (t2 > t3)
                    {
                        pictureBox1.Image = Image.FromFile("C:\\resim\\p2.png");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        label18.Text = "B PARTİ";
                    }
                    else
                    {
                        pictureBox1.Image = Image.FromFile("C:\\resim\\p4.png");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        label18.Text = "D PARTİ";
                    }
                }
                if (checkBox3.Checked == true && checkBox4.Checked == true)
                {
                    o3 = Convert.ToInt32(textBox3.Text);
                    o4 = Convert.ToInt32(textBox4.Text);
                    ot = o4 + o3;
                    t3 = (o3 * 100) / ot; t3 = Math.Round(t3,2); progressBar3.Value = Convert.ToInt32(t3);
                    t4 = (o4 * 100) / ot; t4 = Math.Round(t4,2); progressBar4.Value = Convert.ToInt32(t4);
                    label13.Text = t3.ToString() + "%";
                    label14.Text = t4.ToString() + "%";
                    listBox1.Items.Add(label10.Text + " C PARTİ:" + "%" + t3.ToString() + "  " + "D PARTİ:" + "%" + t4.ToString());
                    if (t3 > t4)
                    {
                        pictureBox1.Image = Image.FromFile("C:\\resim\\p3.png");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        label18.Text = "C PARTİ";
                    }
                    else
                    {
                        pictureBox1.Image = Image.FromFile("C:\\resim\\p4.png");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        label18.Text = "D PARTİ";
                    }
                }

            }

            if (sayac == 3)
            {
                if (checkBox1.Checked==true && checkBox2.Checked==true && checkBox3.Checked==true)
                {
                    o1 = Convert.ToInt32(textBox1.Text);
                    o2 = Convert.ToInt32(textBox2.Text);
                    o3 = Convert.ToInt32(textBox3.Text);
                    ot = o2 + o3+ o1;
                    t1 = (o1 * 100) / ot; t1 = Math.Round(t1,2); progressBar1.Value = Convert.ToInt32(t1);
                    t2 = (o2 * 100) / ot; t2 = Math.Round(t2,2); progressBar2.Value = Convert.ToInt32(t2);
                    t3 = (o3 * 100) / ot; t3 = Math.Round(t3,2); progressBar3.Value = Convert.ToInt32(t3);
                    label11.Text = t1.ToString() + "%";
                    label12.Text = t2.ToString() + "%";
                    label13.Text = t3.ToString() + "%";
                    listBox1.Items.Add(label10.Text + " A PARTİ:" + "%" + t1.ToString() + "  " + "B PARTİ:" + "%" + t2.ToString() + "  " + "C PARTİ:" + "%" + t3.ToString());

                    if (t1 > t2 && t1 > t3 )
                    {
                        pictureBox1.Image = Image.FromFile("C:\\resim\\p1.png");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        label18.Text = "A PARTİ";
                    }
                    else if (t2 > t1 && t2 > t3)
                    {
                        pictureBox1.Image = Image.FromFile("C:\\resim\\p2.png");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        label18.Text = "B PARTİ";
                    }
                    else 
                    {
                        pictureBox1.Image = Image.FromFile("C:\\resim\\p3.png");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        label18.Text = "C PARTİ";
                    }
                
                }
                if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox4.Checked == true)
                {
                    o1 = Convert.ToInt32(textBox1.Text);
                    o2 = Convert.ToInt32(textBox2.Text);
                    o4 = Convert.ToInt32(textBox4.Text);
                    ot = o2 + o4 + o1;
                    t1 = (o1 * 100) / ot; t1 = Math.Round(t1,2); progressBar1.Value = Convert.ToInt32(t1);
                    t2 = (o2 * 100) / ot; t2 = Math.Round(t2,2); progressBar2.Value = Convert.ToInt32(t2);
                    t4 = (o4 * 100) / ot; t4=  Math.Round(t4,2); progressBar4.Value = Convert.ToInt32(t4);
                    label11.Text = t1.ToString() + "%";
                    label12.Text = t2.ToString() + "%";
                    label14.Text = t4.ToString() + "%";
                    listBox1.Items.Add(label10.Text + " A PARTİ:" + "%" + t1.ToString() + "  " + "B PARTİ:" + "%" + t2.ToString() + "  " + "D PARTİ:" + "%" + t4.ToString());
                   
                    if (t1 > t2 && t1 > t4)
                    {
                        pictureBox1.Image = Image.FromFile("C:\\resim\\p1.png");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        label18.Text = "A PARTİ";
                    }
                    else if (t2 > t1 && t2 > t4)
                    {
                        pictureBox1.Image = Image.FromFile("C:\\resim\\p2.png");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        label18.Text = "B PARTİ";
                    }
                    else
                    {
                        pictureBox1.Image = Image.FromFile("C:\\resim\\p4.png");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        label18.Text = "D PARTİ";
                    }
                
                }
                if (checkBox1.Checked == true && checkBox4.Checked == true && checkBox3.Checked == true)
                {
                    o1 = Convert.ToInt32(textBox1.Text);
                    o4 = Convert.ToInt32(textBox4.Text);
                    o3 = Convert.ToInt32(textBox3.Text);
                    ot = o3 + o4 + o1;
                    t1 = (o1 * 100) / ot; t1 = Math.Round(t1,2); progressBar1.Value = Convert.ToInt32(t1);
                    t3 = (o3 * 100) / ot; t3 = Math.Round(t3,2); progressBar3.Value = Convert.ToInt32(t3);
                    t4 = (o4 * 100) / ot; t4 = Math.Round(t4,2); progressBar4.Value = Convert.ToInt32(t4);
                    label11.Text = t1.ToString() + "%";
                    label13.Text = t3.ToString() + "%";
                    label14.Text = t4.ToString() + "%";
                    listBox1.Items.Add(label10.Text + " A PARTİ:" + "%" + t1.ToString() + "  " + "C PARTİ:" + "%" + t3.ToString() + "  " + "D PARTİ:" + "%" + t4.ToString());
                   
                    if (t1 > t3 && t1 > t4)
                    {
                        pictureBox1.Image = Image.FromFile("C:\\resim\\p1.png");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        label18.Text = "A PARTİ";
                    }
                    else if (t3 > t1 && t3 > t4)
                    {
                        pictureBox1.Image = Image.FromFile("C:\\resim\\p3.png");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        label18.Text = "C PARTİ";
                    }
                    else
                    {
                        pictureBox1.Image = Image.FromFile("C:\\resim\\p4.png");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        label18.Text = "D PARTİ";
                    }
                }
                if (checkBox2.Checked == true && checkBox3.Checked == true && checkBox4.Checked == true)
                {
                    o4 = Convert.ToInt32(textBox4.Text);
                    o2 = Convert.ToInt32(textBox2.Text);
                    o3 = Convert.ToInt32(textBox3.Text);
                    ot = o2 + o3 + o4;
                    t4 = (o4 * 100) / ot; t4 = Math.Round(t4,2); progressBar4.Value = Convert.ToInt32(t4);
                    t2 = (o2 * 100) / ot; t2 = Math.Round(t2,2); progressBar2.Value = Convert.ToInt32(t2);
                    t3 = (o3 * 100) / ot; t3 = Math.Round(t3,2); progressBar3.Value = Convert.ToInt32(t3);
                    label14.Text = t4.ToString() + "%";
                    label12.Text = t2.ToString() + "%";
                    label13.Text = t3.ToString() + "%";
                    listBox1.Items.Add(label10.Text + " B PARTİ:" + "%" + t2.ToString() + "  " + "C PARTİ:" + "%" + t3.ToString() + "  " + "D PARTİ:" + "%" + t4.ToString());
                    if (t2 > t3 && t2 > t4)
                    {
                        pictureBox1.Image = Image.FromFile("C:\\resim\\p2.png");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        label18.Text = "B PARTİ";
                    }
                    else if (t3 > t1 && t3 > t4)
                    {
                        pictureBox1.Image = Image.FromFile("C:\\resim\\p3.png");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        label18.Text = "C PARTİ";
                    }
                    else
                    {
                        pictureBox1.Image = Image.FromFile("C:\\resim\\p4.png");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        label18.Text = "D PARTİ";
                    }
                }

              
            }
            if (sayac == 4)
            {
                if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true && checkBox4.Checked == true)
                {
                    o1 = Convert.ToInt16(textBox1.Text);
                    o2 = Convert.ToInt16(textBox2.Text);
                    o3 = Convert.ToInt16(textBox3.Text);
                    o4 = Convert.ToInt16(textBox4.Text);
                    ot = o1 + o2 + o3 + o4;
                    t1 = (o1 * 100) / ot; t1 = Math.Round(t1, 2); progressBar1.Value = Convert.ToInt16(t1);
                    t2 = (o2 * 100) / ot; t2 = Math.Round(t2, 2); progressBar2.Value = Convert.ToInt16(t2);
                    t3 = (o3 * 100) / ot; t3 = Math.Round(t3, 2); progressBar3.Value = Convert.ToInt16(t3);
                    t4 = (o4 * 100) / ot; t4 = Math.Round(t4, 2); progressBar4.Value = Convert.ToInt16(t4);

                    label11.Text = t1.ToString() + "%";
                    label12.Text = t2.ToString() + "%";
                    label13.Text = t3.ToString() + "%";
                    label14.Text = t4.ToString() + "%";
                    listBox1.Items.Add(label10.Text + " A PARTİ:" + "%" + t1.ToString() + "  " + "B PARTİ:" + "%" + t2.ToString() + "  " + "C PARTİ:" + "%" + t3.ToString() + "  " + "D PARTİ:" + "%" + t4.ToString());
                    if (t1 > t3 && t1 > t4 && t1 > t2)
                    {
                        pictureBox1.Image = Image.FromFile("C:\\resim\\p1.png");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        label18.Text = "A PARTİ";
                    }
                    else if (t2 > t3 && t2 > t4 && t2 > t4)
                    {
                        pictureBox1.Image = Image.FromFile("C:\\resim\\p2.png");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        label18.Text = "B PARTİ";
                    }
                    else if (t3 > t2 && t3 > t1 && t3 > t4)
                    {
                        pictureBox1.Image = Image.FromFile("C:\\resim\\p3.png");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        label18.Text = "C PARTİ";
                    }
                    else
                    {
                        pictureBox1.Image = Image.FromFile("C:\\resim\\p4.png");
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        label18.Text = "D PARTİ";
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
        listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\resim\\soruisaret.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            label18.Text = "Parti İsmi";
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            button2.Enabled = false;
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
            comboBox3.SelectedItem = null;
            comboBox1.Enabled = true;

            progressBar1.Value = 0;
            progressBar2.Value = 0;
            progressBar3.Value = 0;
            progressBar4.Value = 0;

            label11.Text = "%";
            label12.Text = "%";
            label13.Text = "%";
            label14.Text = "%";

            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;

            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            button1.Enabled = false;
            sayac = 0;
            label10.Text = string.Empty;
          
                 }

 
        private void button5_Click(object sender, EventArgs e)
        {  
            listBox1.Items.Remove(listBox1.SelectedItem);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int basilantus = Convert.ToInt32(e.KeyChar); //stringden çevirme yapmadığımız için int.parse kullanamayız.
            // eğer 48 ile 57 arası DEĞİLSE tuş basımını iptal etmek gerekir.
            // backspace'in çalışması için   || basilantus == 8    koşulunu ekledim.
            if (!(basilantus >= 48 && basilantus <= 57 || basilantus == 8))
            {
                // baştaki ! işareti tüm ifadeyi tersine çevirir.
                e.Handled = true;
                // handled = true yapmamız basılan tuşu geçersiz saymak içindir.

                //e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }


        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
               int basilantus = Convert.ToInt32(e.KeyChar);

               if (!(basilantus >= 48 && basilantus <= 57 || basilantus == 8))
               {

                   e.Handled = true;
               }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            int basilantus = Convert.ToInt32(e.KeyChar);

            if (!(basilantus >= 48 && basilantus <= 57 || basilantus == 8))
            {

                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            int basilantus = Convert.ToInt32(e.KeyChar);

            if (!(basilantus >= 48 && basilantus <= 57 || basilantus == 8))
            {

                e.Handled = true;
            }
        }
            }

        }

  

       
             

   

