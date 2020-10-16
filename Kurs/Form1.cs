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

namespace Kurs
{

    Kurs[] k = new Kurs[100];
    public partial class Form1 : Form
    {
        
        private Kurs k;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader f = new StreamReader("Kurs.txt");
            while (!f.EndOfStream)
            {
                string r = f.ReadLine();
                listBox1.Items.Add(r);
                double cena = Convert.ToDouble(f.ReadLine());
                listBox1.Items.Add(r+cena);
                
            }
            f.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kurs[] k = new Kurs[100];25.
            for (int i = 0; i < 3; i++)
            {
                for (int j = i + 1; j < 3; j++)
                {
                    if (k[i].JeftinijiOd(k[j]))
                    {
                        Kurs t = k[i];
                        k[i] = k[j];
                        k[j] = t;
                    }
                }
            }

            listBox2.Items.Clear();
            for (int i = 0; i < 3; i++)
            {
                listBox2.Items.Add(k[i].Prikaz());
            }



        }
    }
}
