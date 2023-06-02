using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drzavna_matura_Andrej_Paunovic
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            StreamReader procitaj = new StreamReader("podaci_ucenika.txt", true);
            for(int i=0;i<1000;i++)
            {
                if(procitaj.EndOfStream!=true)
                {
                    listBox1.Items.Add(procitaj.ReadLine());
                }
                else
                {
                    break;
                }
            }
            procitaj.Close();
            
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
                if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (comboBox1.SelectedIndex == -1) || (comboBox2.SelectedIndex == -1) || (comboBox3.SelectedIndex == -1) || (comboBox4.SelectedIndex == -1) || (comboBox5.SelectedIndex == -1))
                MessageBox.Show("Neki od parametara nije unet!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string a = "", c="", d = "";
                char b='0';
                a = a + textBox1.Text + " " + textBox2.Text + " " + textBox3.Text +" ";
                StreamReader procitaj = new StreamReader("podaci_skola.txt", true);

                for (int i = 0; i <= Form1.indeks; i++)
                {

                    c = procitaj.ReadLine();

                }
                for (int j = 0; j < c.Length; j++)
                {
                    if (c[j] != '0')
                    {

                        d = d + c[j];
                    }
                    else
                    {
                        b = c[j + 1];
                        break;
                    }
                }
                a = a + d+ " ";
                switch(b)
                {
                    case 's':
                        a = a + "strucna";
                        break;
                    case 'g':
                        a = a + "opsta";
                        break;
                    case 'u':
                        a = a + "umetnicka";
                            break;
                    case 'm':
                        a = a + "umetnicka(muzicka)";
                        break;
                        default:
                        MessageBox.Show("Doslo je do greske", "Greska");
                        break;

                }
                a = a +" "+ comboBox2.Items[comboBox2.SelectedIndex];
                a = a + " " + comboBox3.Items[comboBox3.SelectedIndex];
                a=a + " "+ comboBox4.Items[comboBox4.SelectedIndex];
                a = a + " " + comboBox5.Items[comboBox5.SelectedIndex];
                listBox1.Items.Clear();
                StreamWriter pisac = new StreamWriter("podaci_ucenika.txt", true);
                pisac.WriteLine(a);
                pisac.Close();
                procitaj = new StreamReader("podaci_ucenika.txt", true);
                for (int i = 0; i < 1000; i++)
                {
                    if (procitaj.EndOfStream != true)
                    {
                        listBox1.Items.Add(procitaj.ReadLine());
                    }
                    else
                    {
                        break;
                    }
                }
                procitaj.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                comboBox1.Items.Clear();
                comboBox5.Items.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe", "podaci_ucenika.txt");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Length==0)
            {
                comboBox1.Items.Clear();
                comboBox5.Items.Clear();
            }
           if(textBox1.Text.Length==1)
            {
                string a = "", c = "", d = "";
                char b = '0';
                a = a + textBox1.Text + " " + textBox2.Text + " " + textBox3.Text;
                StreamReader procitaj = new StreamReader("podaci_skola.txt", true);
                for (int i = 0; i <= Form1.indeks; i++)
                {

                    c = procitaj.ReadLine();

                }
                for (int j = 0; j < c.Length; j++)
                {
                    if (c[j] != '0')
                    {

                        d = d + c[j];
                    }
                    else
                    {
                        b = c[j + 1];
                        break;
                    }
                }
                a = a + d;
                switch (b)
                {
                    case 's':
                        comboBox1.Items.Add("Strucna");
                        comboBox5.Items.Add("Poljoprivreda, proizvodnja i prerade hrane");
                        comboBox5.Items.Add("Sumarstvo i obrada drveta");
                        comboBox5.Items.Add("Geologija, rudarstvo i metalurgija");
                        comboBox5.Items.Add("Masinstvo i obrada metala");
                        comboBox5.Items.Add("Elektrotehnika");
                        comboBox5.Items.Add("Hemija, nemetali i graficarstvo");
                        comboBox5.Items.Add("Tekstilstvo i kozarstvo");
                        comboBox5.Items.Add("Gradjevinarstvo");
                        comboBox5.Items.Add("Saobracaj");
                        break;
                    case 'g':
                        comboBox1.Items.Add("Opsta");
                        comboBox5.Items.Add("Biologija");
                        comboBox5.Items.Add("Geografija");
                        comboBox5.Items.Add("Engleski jezik");
                        comboBox5.Items.Add("Istorija");
                        comboBox5.Items.Add("Italijanski jezik");
                        comboBox5.Items.Add("Nemački jezik");
                        comboBox5.Items.Add("Ruski jezik");
                        comboBox5.Items.Add("Srpski kao nematernji jezik");
                        comboBox5.Items.Add("Fizika");
                        comboBox5.Items.Add("Francuski jezik");
                        comboBox5.Items.Add("Hemija");
                        comboBox5.Items.Add("Španski jezik");
                        break;
                    case 'u':
                        comboBox1.Items.Add("Umetnicka");
                        comboBox5.Items.Add("/");
                        break;
                    case 'm':
                        comboBox1.Items.Add("Umetnicka(muzicka)");
                        comboBox5.Items.Add("Solfeđo");
                        comboBox5.Items.Add("Harmonija");
                        break;
                    default:
                        MessageBox.Show("Doslo je do greske", "Greska");
                        break;
                }
                procitaj.Close();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           
        }
    }
}
