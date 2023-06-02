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
    public partial class Form1 : Form
    {
        public static int indeks;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 forma2 = new Form2();
            forma2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader procitaj = new StreamReader("podaci_skola.txt", true);
            string b = "", c, d = "";
            for (int i= 0;i< 1000; i++)
            {
                if (procitaj.EndOfStream == true)
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
                if (comboBox1.FindStringExact(d) >= 0)
                {

                }
                else comboBox1.Items.Add(d);
                d = "";
            }
            procitaj.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex!=-1)
            {
                Form3 forma3 = new Form3();
                forma3.Show();
                indeks = comboBox1.SelectedIndex;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader procitaj = new StreamReader("podaci_skola.txt", true);
            string b = "", c, d = "";
            for (int i = 0; i < 1000; i++)
            {
                if (procitaj.EndOfStream == true)
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
                if (comboBox1.FindStringExact(d) >= 0)
                {

                }
                else comboBox1.Items.Add(d);
                d = "";
            }
            procitaj.Close();
            }
    }
}
