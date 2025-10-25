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
        public DodajAdministrativnoOsoblje()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ZaposleniBrTel forma = new ZaposleniBrTel();
            forma.ShowDialog();
        }

        private void DodajAdministrativnoOsoblje_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            List<LokacijaPogled> lokacija = DTOManager.vratiPogledLokacija();

            comboBox1.DataSource = lokacija;
            comboBox1.DisplayMember = "Adresa";
            comboBox1.ValueMember = "Adresa";


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
            AdministrativnoOsobljeBasic a = new AdministrativnoOsobljeBasic();
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
        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
