using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayisalLotoUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[,] tahmin = new int[6,6];
        Random random = new Random();
        string[] girilenSayi = new string[6];
        int dogru = 0;
        int boyutsatir;
        int boyutsutun;
        int dogruSayisi;
        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void sayilarigetirbtn_Click(object sender, EventArgs e)
        {
            int boyutsatir = tahmin.GetLength(0);
            int boyutsutun = tahmin.GetLength(1);

            for (int i = 0; i < boyutsatir; i++)
            {
                for (int j = 0; j < boyutsutun; j++)
                {
                    tahmin[i,j] = random.Next(1,100);
                    textBox1.Text = tahmin[0, 0] + " ";
                    textBox2.Text = tahmin[0, 1] + " ";
                    textBox3.Text = tahmin[0, 2] + " ";
                    textBox4.Text = tahmin[0, 3] + " ";
                    textBox5.Text = tahmin[0, 4] + " ";
                    textBox6.Text = tahmin[0, 5] + " ";
                    textBox12.Text = tahmin[1, 0] + " ";
                    textBox11.Text = tahmin[1, 1] + " ";
                    textBox10.Text = tahmin[1, 2] + " ";
                    textBox9.Text = tahmin[1, 3] + " ";
                    textBox8.Text = tahmin[1, 4] + " ";
                    textBox7.Text = tahmin[1, 5] + " ";
                    textBox18.Text = tahmin[2, 0] + " ";
                    textBox17.Text = tahmin[2, 1] + " ";
                    textBox16.Text = tahmin[2, 2] + " ";
                    textBox15.Text = tahmin[2, 3] + " ";
                    textBox14.Text = tahmin[2, 4] + " ";
                    textBox13.Text = tahmin[2, 5] + " ";
                    textBox24.Text = tahmin[3, 0] + " ";
                    textBox19.Text = tahmin[3, 1] + " ";
                    textBox20.Text = tahmin[3, 2] + " ";
                    textBox21.Text = tahmin[3, 3] + " ";
                    textBox22.Text = tahmin[3, 4] + " ";
                    textBox23.Text = tahmin[3, 5] + " ";
                    textBox30.Text = tahmin[4, 0] + " ";
                    textBox29.Text = tahmin[4, 1] + " ";
                    textBox28.Text = tahmin[4, 2] + " ";
                    textBox27.Text = tahmin[4, 3] + " ";
                    textBox26.Text = tahmin[4, 4] + " ";
                    textBox25.Text = tahmin[4, 5] + " ";
                    textBox36.Text = tahmin[5, 0] + " ";
                    textBox35.Text = tahmin[5, 1] + " ";
                    textBox34.Text = tahmin[5, 2] + " ";
                    textBox33.Text = tahmin[5, 3] + " ";
                    textBox32.Text = tahmin[5, 4] + " ";
                    textBox31.Text = tahmin[5, 5] + " ";


                }
              
            }

        }

        

        private void oynabtn_Click(object sender, EventArgs e)
        {
            girilenSayi[0] = textBox42.Text;
            girilenSayi[1] = textBox41.Text;
            girilenSayi[2] = textBox40.Text;
            girilenSayi[3] = textBox39.Text;
            girilenSayi[4] = textBox38.Text;
            girilenSayi[5] = textBox37.Text;

            listBox1.Items.Add(girilenSayi[0]);
            listBox1.Items.Add(girilenSayi[1]);
            listBox1.Items.Add(girilenSayi[2]);
            listBox1.Items.Add(girilenSayi[3]);
            listBox1.Items.Add(girilenSayi[4]);
            listBox1.Items.Add(girilenSayi[5]);

            //for (int i = 0; i < boyutsatir; i++)
            //{
            //    for (int j = 0; j < boyutsutun; j++)
            //    {
            //        for (int z = 0; z < girilenSayi.GetLength(0); z++)
            //        {
            //            if (tahmin[i, j] == int.Parse(girilenSayi[z]))
            //            {
            //                dogru++;
            //                listBox1.Items.Add(girilenSayi[z]).ToString();
            //            }
            //        }
            //    }
            //}

            foreach (var item in girilenSayi)
            {
                foreach (var item1 in tahmin)
                {
                    if (item == item1.ToString())
                    {
                        dogru++;
                        listBox1.Items.Add(item1);
                        break;
                    }
                    else
                    {
                      listBox1.Items.Remove(item);
                    }
                      
                }
            }
            int elemanSayisi = 0;
            elemanSayisi = listBox1.Items.Count;

            if (elemanSayisi==0)
            {
                aciklamalbl.Text = "Kazanamadınız";
            }

            else if (elemanSayisi == 1)
            {
                aciklamalbl.Text = "10 tl kazandınız";
            }

            else if (elemanSayisi == 2)
            {
                aciklamalbl.Text = "20 tl kazandınız";
            }
            else if (elemanSayisi == 3)
            {
                aciklamalbl.Text = "30 tl kazandınız";
            }
            else if (elemanSayisi == 4)
            {
                aciklamalbl.Text = "40 tl kazandınız";
            }
            else if (elemanSayisi == 5)
            {
                aciklamalbl.Text = "50 tl kazandınız";
            }
            else if (elemanSayisi == 6)
            {
                aciklamalbl.Text = "60 tl kazandınız";
            }
            else if (elemanSayisi == 7)
            {
                aciklamalbl.Text = "70 tl kazandınız";
            }
            else if (elemanSayisi == 8)
            {
                aciklamalbl.Text = "80 tl kazandınız";
            }
            else if (elemanSayisi == 9)
            {
                aciklamalbl.Text = "90 tl kazandınız";
            }
            else if (elemanSayisi == 10)
            {
                aciklamalbl.Text = "100 tl kazandınız";
            }




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }
    }
}
