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

namespace Medicinska_klinika_3._0.FormDodaj
{
    public partial class DodajLokaciju : Form
    {
        public DodajLokaciju()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LokacijaBasic lokacija = new LokacijaBasic();
            lokacija.Adresa = textBox1.Text;
            lokacija.RadnoVreme = textBox2.Text;

            DTOManager.dodajLokaciju(lokacija);

            MessageBox.Show("Uspesno ste dodali novu lokaciju!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DodajLokaciju_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
