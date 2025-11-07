using Medicinska_klinika_3._0.PomocneForme;
using MedicinskaKlinika;
using MedicinskaKlinika.Entiteti;
using NHibernate.Criterion;
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
    public partial class DodajAdministrativnoOsoblje : Form
    {
        private List<EmailZaposlenog> emailovi = new List<EmailZaposlenog>();
        private List<BrTelefonaZaposlenog> brojevi = new List<BrTelefonaZaposlenog>();
        private List<Odeljenje> od = new List<Odeljenje>();
        private List<OdeljenjePogled> odeljenja = new List<OdeljenjePogled>();

        private AdministrativnoOsoblje _admin;
        private bool fleg;
        public DodajAdministrativnoOsoblje(bool f, AdministrativnoOsoblje t)
        {
            fleg = f;
            if (f)
            {
                _admin = t;
            }
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
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

        private void DodajAdministrativnoOsoblje_Load(object sender, EventArgs e)
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

            if (_admin != null)
            {
                comboBox1.SelectedValue = _admin.AdresaLokacije.Adresa;
                textBox1.Text = _admin.JMBG.ToString();
                textBox1.ReadOnly = true;
                dateTimePicker1.Value = _admin.DatumZaposlenja;
                dateTimePicker2.Value = _admin.DatumRodjenja;
                textBox2.Text = _admin.Pozicija;
                textBox3.Text = _admin.Ime;
                textBox4.Text = _admin.Prezime;
                textBox5.Text = _admin.Adresa;
                textBox6.Text = _admin.Smena.ToString();

                foreach (var email in _admin.Emails) {
                    emailovi.Add(email);
                }
                foreach (var br in _admin.Telefons)
                {
                    brojevi.Add(br);
                }

                foreach (var o in _admin.Odeljenja)
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

           


            foreach(EmailZaposlenog x in emailovi)
            {
                listView1.Items.Add(x.Email);
            }

            foreach(BrTelefonaZaposlenog x in brojevi)
            {
                listView2.Items.Add(x.BrojTelefona);
            }

            foreach(Odeljenje x in od)
            {
                listView3.Items.Add(x.Naziv);
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            ZaposleniEmail forma = new ZaposleniEmail();
            if (forma.ShowDialog() == DialogResult.OK) {
                EmailZaposlenog novi = forma.email;
                emailovi.Add(novi);

                listView1.Items.Add(novi.Email);
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
                comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Sva polja moraju biti popunjena!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            long jmbg;
            if (!long.TryParse(textBox1.Text, out jmbg))
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

            AdministrativnoOsobljeBasic a = new AdministrativnoOsobljeBasic();
            a.JMBG = long.Parse(textBox1.Text);
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
            
            
            DTOManager.dodajAdministrativnoOsoblje(a,fleg);
            MessageBox.Show("Zaposlen je uspešno dodat!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
