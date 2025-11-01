using MedicinskaKlinika;
using MedicinskaKlinika.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Medicinska_klinika_3._0.FormDodaj
{
    public partial class DodajLokaciju : Form
    {
        private Lokacija _lokacija;
        private bool fleg;
        public DodajLokaciju(bool f, Lokacija t)
        {
            fleg = f;
            if (f)
            {
                _lokacija = t;
            }
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Sva polja moraju biti popunjena!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LokacijaBasic lokacija = new LokacijaBasic();
            lokacija.Adresa = textBox1.Text;
            lokacija.RadnoVreme = textBox2.Text;

            DTOManager.dodajLokaciju(lokacija,fleg);

            MessageBox.Show("Uspesno ste dodali novu lokaciju!");
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DodajLokaciju_Load(object sender, EventArgs e)
        {
            if (_lokacija != null) {
                textBox1.Text = _lokacija.Adresa;
                textBox1.ReadOnly = true;
                textBox2.Text = _lokacija.RadnoVreme;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
