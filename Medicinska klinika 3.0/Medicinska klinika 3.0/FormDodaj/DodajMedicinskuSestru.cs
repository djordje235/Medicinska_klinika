using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Medicinska_klinika_3._0.PomocneForme;
using MedicinskaKlinika;
using MedicinskaKlinika.Entiteti;

namespace Medicinska_klinika_3._0.FormDodaj
{
    public partial class DodajMedicinskuSestru : Form
    {

        private List<EmailZaposlenog> emailovi = new List<EmailZaposlenog>();
        private List<BrTelefonaZaposlenog> brojevi = new List<BrTelefonaZaposlenog>();
        private List<Odeljenje> od = new List<Odeljenje>();
        private List<OdeljenjePogled> odeljenja;

        private MedicinskaSestra _sestra;
        private bool fleg;
        public DodajMedicinskuSestru(bool f, MedicinskaSestra t)
        {
            fleg = f;
            if (f)
            {
                _sestra = t;
            }
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ZaposleniBrTel forma = new ZaposleniBrTel();
            if (forma.ShowDialog() == DialogResult.OK)
            {
                BrTelefonaZaposlenog novi = forma.telefon;

                brojevi.Add(novi);

                listView2.Items.Add(novi.BrojTelefona);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ZaposleniEmail forma = new ZaposleniEmail();
            if (forma.ShowDialog() == DialogResult.OK)
            {
                EmailZaposlenog novi = forma.email;
                emailovi.Add(novi);

                listView1.Items.Add(novi.Email);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DodajMedicinskuSestru_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();

            List<LokacijaPogled> lokacija = DTOManager.vratiPogledLokacija();

            comboBox1.DataSource = lokacija;
            comboBox1.DisplayMember = "Adresa";
            comboBox1.ValueMember = "Adresa";

            odeljenja = DTOManager.vratipogledodaljenja();

            comboBox2.DataSource = odeljenja;
            comboBox2.DisplayMember = "Naziv";
            comboBox2.ValueMember = "Naziv";

            if (_sestra != null)
            {
                comboBox1.SelectedValue = _sestra.AdresaLokacije.Adresa;
                textBox1.Text = _sestra.JMBG.ToString();
                textBox1.ReadOnly = true;
                dateTimePicker1.Value = _sestra.DatumZaposlenja;
                dateTimePicker2.Value = _sestra.DatumRodjenja;
                textBox2.Text = _sestra.Pozicija;
                textBox3.Text = _sestra.Ime;
                textBox4.Text = _sestra.Prezime;
                textBox5.Text = _sestra.Adresa;
                textBox6.Text = _sestra.Smena.ToString();
                textBox8.Text = _sestra.OblastRada;
                textBox7.Text = _sestra.Sertifikat;

                foreach (var email in _sestra.Emails)
                {
                    emailovi.Add(email);
                }
                foreach (var br in _sestra.Telefons)
                {
                    brojevi.Add(br);
                }

                foreach (var o in _sestra.Odeljenja)
                {
                    od.Add(o);
                    OdeljenjePogled ode = odeljenja.Where(x => x.Naziv == o.Naziv).FirstOrDefault();
                    odeljenja.Remove(ode);
                }
                comboBox2.DataSource = null;
                comboBox2.DataSource = odeljenja;
                comboBox2.DisplayMember = "Naziv";
                comboBox2.ValueMember = "Naziv";
            }




            foreach (EmailZaposlenog x in emailovi)
            {
                listView1.Items.Add(x.Email);
            }

            foreach (BrTelefonaZaposlenog x in brojevi)
            {
                listView2.Items.Add(x.BrojTelefona);
            }

            foreach (Odeljenje x in od)
            {
                listView3.Items.Add(x.Naziv);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Odeljenje odeljenje = DTOManager.nadjiOdeljenje(comboBox2.SelectedValue.ToString());
            od.Add(odeljenje);
            listView3.Items.Add(odeljenje.Naziv);
            var selektovano = comboBox2.SelectedItem as OdeljenjePogled;
            if (selektovano != null)
            {
                odeljenja.Remove(selektovano);
                comboBox2.DataSource = null;
                comboBox2.DataSource = odeljenja;
                comboBox2.DisplayMember = "Naziv";
                comboBox2.ValueMember = "Naziv";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                    string.IsNullOrWhiteSpace(textBox2.Text) ||
                    string.IsNullOrWhiteSpace(textBox3.Text) ||
                    string.IsNullOrWhiteSpace(textBox4.Text) ||
                    string.IsNullOrWhiteSpace(textBox5.Text) ||
                    string.IsNullOrWhiteSpace(textBox6.Text) ||
                    string.IsNullOrWhiteSpace(textBox7.Text) ||
                    string.IsNullOrWhiteSpace(textBox8.Text) ||
                    comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Sva polja moraju biti popunjena!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int jmbg;
            if (!int.TryParse(textBox1.Text, out jmbg))
            {
                MessageBox.Show("JMBG mora biti broj!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int smena;
            if (!int.TryParse(textBox6.Text, out smena))
            {
                MessageBox.Show("Smena mora biti broj!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (emailovi == null || emailovi.Count == 0)
            {
                MessageBox.Show("Unesite bar jedan email!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (brojevi == null || brojevi.Count == 0)
            {
                MessageBox.Show("Unesite bar jedan broj telefona!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (od == null || od.Count == 0)
            {
                MessageBox.Show("Morate izabrati bar jedno odeljenje!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MedicinskaSestraBasic a = new MedicinskaSestraBasic();
            a.JMBG = int.Parse(textBox1.Text);
            a.DatumZaposlenja = dateTimePicker1.Value;
            a.Pozicija = textBox2.Text;
            a.DatumRodjenja = dateTimePicker2.Value;
            a.Ime = textBox3.Text;
            a.Prezime = textBox4.Text;
            a.Adresa = textBox5.Text;
            a.AdresaLokacije = DTOManager.nadjiLokaciju(comboBox1.SelectedValue.ToString());
            a.Smena = int.Parse(textBox6.Text);
            a.Emails = emailovi;
            a.Telefons = brojevi;
            a.Odeljenja = od;
            a.OblastRada = textBox8.Text;
            a.Sertifikat = textBox7.Text;

            DTOManager.dodajMedicinskuSestru(a,fleg);
            MessageBox.Show("Zaposlen je uspešno dodat!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
