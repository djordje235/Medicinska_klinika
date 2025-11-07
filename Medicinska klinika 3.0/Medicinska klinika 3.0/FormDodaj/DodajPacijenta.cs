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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Medicinska_klinika_3._0.FormDodaj
{
    public partial class DodajPacijenta : Form
    {
        private List<EmailPacijenta> emailovi = new List<EmailPacijenta>();
        private List<BrTelefonaPacijenta> brojevi = new List<BrTelefonaPacijenta>();


        private Pacijent _pacijent;
        private bool fleg;
        public DodajPacijenta(bool f, Pacijent t)
        {
            fleg = f;
            if (f)
            {
                _pacijent = t;
            }
            
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PacijentBrTel forma = new PacijentBrTel();
            if (forma.ShowDialog() == DialogResult.OK)
            {
                BrTelefonaPacijenta novi = forma.telefon;

                brojevi.Add(novi);

                listView2.Items.Add(novi.BrojTelefona);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PacijentEmail forma = new PacijentEmail();
            if (forma.ShowDialog() == DialogResult.OK)
            {
                EmailPacijenta novi = forma.email;
                emailovi.Add(novi);

                listView1.Items.Add(novi.Email);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DodajPacijenta_Load(object sender, EventArgs e)
        {
            List<LekarPogled> lekari = DTOManager.vratipogledlekara();

            comboBox3.DataSource = lekari;
            comboBox3.DisplayMember = "PunoIme";
            comboBox3.ValueMember = "JMBG";
            textBox1.Enabled = false;
            if (_pacijent != null)
            {
                textBox1.Text = _pacijent.IdKartona.ToString();
                textBox1.Enabled = false;
                dateTimePicker1.Value = _pacijent.DatumRodjenja;
                textBox2.Text = _pacijent.Adresa;
                textBox3.Text = _pacijent.Ime;
                textBox4.Text = _pacijent.Prezime;
                comboBox3.SelectedValue = _pacijent.Lekar.JMBG;
                if(_pacijent.Pol == "M")
                {
                    radioButton2.Checked = false;
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                }
                    foreach (var email in _pacijent.Emails)
                    {
                        emailovi.Add(email);
                    }
                foreach (var br in _pacijent.Telefons)
                {
                    brojevi.Add(br);
                }

            }

            foreach (EmailPacijenta x in emailovi)
            {
                listView1.Items.Add(x.Email);
            }

            foreach (BrTelefonaPacijenta x in brojevi)
            {
                listView2.Items.Add(x.BrojTelefona);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PacijentBasic p = new PacijentBasic();
            if (fleg)
            {
             p.IdKartona = int.Parse(textBox1.Text);
            }
            
            p.Adresa = textBox2.Text;
            p.Ime = textBox3.Text;
            p.Prezime = textBox4.Text;
            p.DatumRodjenja = dateTimePicker1.Value;
            if (radioButton1.Checked)
                p.Pol = "M";
            else if(radioButton2.Checked)
                p.Pol = "Z";
            p.Lekar = DTOManager.nadjiLekara(long.Parse(comboBox3.SelectedValue.ToString()));
            p.Emails = emailovi;
            p.Telefons = brojevi;

            DTOManager.dodajPacijenta(p,fleg);
            MessageBox.Show("Pacijent je uspešno dodat!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
