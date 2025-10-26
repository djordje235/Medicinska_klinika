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
    public partial class DodajLekaraForma : Form
    {
        private List<EmailZaposlenog> emailovi = new List<EmailZaposlenog>();
        private List<BrTelefonaZaposlenog> brojevi = new List<BrTelefonaZaposlenog>();
        private List<Odeljenje> od = new List<Odeljenje>();
        private List<OdeljenjePogled> odeljenja;

        public DodajLekaraForma()
        {
            InitializeComponent();
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

        private void button2_Click_1(object sender, EventArgs e)
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
            LekarBasic a = new LekarBasic();
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
            a.Specijalizacija = textBox8.Text;
            a.BrLicence = int.Parse(textBox7.Text);

            DTOManager.dodajLekara(a);
            MessageBox.Show("Zaposlen je uspešno dodat!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void DodajLekaraForma_Load(object sender, EventArgs e)
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
        }
    }
}
