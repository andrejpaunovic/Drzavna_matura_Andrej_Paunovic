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
using System.Globalization;

namespace Drzavna_matura_Andrej_Paunovic
{
    public partial class Form2 : Form
    {
        Form1 forma1 = new Form1();
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe", "podaci_skola.txt");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(checkedListBox1.CheckedItems.Count!=1)
            {
                MessageBox.Show("Uneto je vise od jednog podatka, ili nije uopste unet u check listi!", "Greska");
                return;
            }
            else
            {
                StreamReader procitaj;
                string b="",c,d="";
                int k = 1;

                    b = textBox1.Text;
                    procitaj = new StreamReader("podaci_skola.txt", true);
                    for(int i=0;i<1000;i++)
                    {
                        if(procitaj.EndOfStream==true)
                        {
                            break;
                        }
                            
                            c = procitaj.ReadLine();
                            for (int j = 0; j < c.Length; j++)
                            {
                                if (c[j] != '0')
                                {

                                    d = d + c[j];
                                }
                                else break;
                            }
                            if (d.ToLower() == b.ToLower())
                            {
                                MessageBox.Show("Uneta je skola koja vec postoji!" +d +" " + b, "Greska");
                                procitaj.Close();
                                return;                                
                            }
                            d = "";
                    }
                    procitaj.Close();

                StreamWriter writer = new StreamWriter("podaci_skola.txt", true);
                if(checkedListBox1.GetItemChecked(0)== true)
                writer.WriteLine(textBox1.Text + "0s;");
                if (checkedListBox1.GetItemChecked(1) == true)
                    writer.WriteLine(textBox1.Text + "0g;");
                if (checkedListBox1.GetItemChecked(2) == true)
                    writer.WriteLine(textBox1.Text + "0u;");
                if (checkedListBox1.GetItemChecked(3) == true)
                    writer.WriteLine(textBox1.Text + "0m;");


                writer.Close();
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(checkedListBox1.CheckedItems.Count > 1)
            {
            MessageBox.Show( "Uneto je vise od jednog podatka u check listi!", "Greska");

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
