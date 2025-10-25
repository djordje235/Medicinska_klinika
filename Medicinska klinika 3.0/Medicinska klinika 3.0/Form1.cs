using MedicinskaKlinika;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medicinska_klinika_3._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LokacijaBasic lokacija = new LokacijaBasic();
            //lokacija.Adresa = textBox1.Text;
            //lokacija.RadnoVreme = textBox2.Text;

            DTOManager.dodajLokaciju(lokacija);

            MessageBox.Show("Uspesno ste dodali novu lokaciju!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
