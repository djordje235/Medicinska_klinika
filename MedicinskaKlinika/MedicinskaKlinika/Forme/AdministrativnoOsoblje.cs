using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicinskaKlinika.Forme
{
    public partial class AdministrativnoOsoblje : Form
    {
        public List<string> Emailovi { get; private set; } = new List<string>();
        public List<string> Telefoni { get; private set; } = new List<string>();

        public List<string> Odeljenja { get; private set; } = new List<string>();
        public AdministrativnoOsoblje()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            AdministrativnoOsobljeBasic a = new AdministrativnoOsobljeBasic();

            a.JMBG = int.Parse(jmbgtextBox.Text);
            a.DatumZaposlenja = DateTime.Parse(dateTimePicker1.Text);
            a.Pozicija = textBox1.Text;
            a.DatumRodjenja = DateTime.Parse(dateTimePicker2.Text);
            a.Adresa = textBox3.Text;
            a.Ime = textBox4.Text;
            a.Prezime = textBox5.Text;
            a.AdresaLokacije = comboBox1.SelectedItem.ToString();
            a.Smena = int.Parse(textBox2.Text);

            DTOManager.dodajAdministrativnoOsoblje(a, Emailovi, Telefoni, Odeljenja);
            Emailovi.Clear();
            Telefoni.Clear();
            Odeljenja.Clear();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ZaposlenEmail forma = new ZaposlenEmail();
            forma.ShowDialog();
            Emailovi.Add(forma.email);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ZaposlenBrTel forma = new ZaposlenBrTel();
            forma.ShowDialog();
            Telefoni.Add(forma.Telefon);
        }

        private void AdministrativnoOsoblje_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Emailovi.Clear();
            Telefoni.Clear();
            Odeljenja.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OdeljenjeZaposlenForma forma = new OdeljenjeZaposlenForma();
            forma.ShowDialog();
            Odeljenja = forma.naziviOdeljenja;
        }

        private void jmbgtextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
