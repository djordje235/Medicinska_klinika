using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicinskaKlinika;
using MedicinskaKlinika.Entiteti;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Medicinska_klinika_3._0.FormDodaj
{
    public partial class DodajPlacanje : Form
    {
        private Placanje _placanje;
        private bool fleg;
        public DodajPlacanje(bool f, Placanje t)
        {
            fleg = f;
            if (f)
            {
                _placanje = t;
            }
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Unesite procenat koji plaća pacijent!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int procenatPacijenta;
            if (!int.TryParse(textBox1.Text, out procenatPacijenta))
            {
                MessageBox.Show("Procenat mora biti ceo broj!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Unesite način plaćanja!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool platioPacijent;
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Unesite da li je pacijent platio (true/false)!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!bool.TryParse(textBox3.Text, out platioPacijent))
            {
                MessageBox.Show("Polje 'Platio pacijent' mora biti 'true' ili 'false'!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (comboBox2.SelectedValue == null)
            {
                MessageBox.Show("Izaberite račun!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (comboBox3.SelectedValue == null)
            {
                MessageBox.Show("Izaberite RFZO!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            PlacanjeBasic p = new PlacanjeBasic();
            if (fleg)
            {
                p.IdPlacanja = _placanje.IdPlacanja;
            }
            p.ProcenatPacijenta = int.Parse(textBox1.Text);
            p.NacinPlacanja = textBox2.Text;
            p.PlatioPacijent = Boolean.Parse(textBox3.Text);
            p.Racun = DTOManager.nadjiRacun((int)comboBox2.SelectedValue);
            if (radioButton1.Checked == true) {
            p.PrivatnoOsiguranje = DTOManager.nadjiPrivatnoOsiguranje((int)comboBox3.SelectedValue);
            }
            if (radioButton2.Checked == true) {
            p.RFZO = DTOManager.nadjiRFZO((int)comboBox3.SelectedValue);
            }
            DTOManager.dodajPlacanje(p, fleg);
            MessageBox.Show("Placanje je uspešno dodat!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void DodajPlacanje_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();

            List<RacunPogled> racuni = DTOManager.vratiPogledRacun();
            List<RacunPogled> filtirani_racuni = racuni.Where(x => x.Placanje == null).ToList();
            comboBox2.DataSource = filtirani_racuni;
            comboBox2.DisplayMember = "PunRacun";
            comboBox2.ValueMember = "Id";

            if(radioButton2.Checked == true)
            {
            List<RFZOPogled> rfzos = DTOManager.vratiPogledRFZO();
            comboBox3.DataSource = rfzos;
            comboBox3.DisplayMember = "RFZOPrikaz";
            comboBox3.ValueMember = "IdOsiguranja";
            }

            if (radioButton1.Checked == true)
            {
                List<PrivatnoOsiguranjePogled> osiguranja = DTOManager.vratiPogledPrivatnoOsiguranje();
                comboBox3.DataSource = osiguranja;
                comboBox3.DisplayMember = "Osiguranje";
                comboBox3.ValueMember = "BrPolise";
            }

            if (_placanje != null)
            {
                textBox1.Text = _placanje.ProcenatPacijenta.ToString();
                textBox2.Text = _placanje.NacinPlacanja;
                textBox3.Text = _placanje.PlatioPacijent.ToString();

                comboBox2.SelectedValue = _placanje.Racun.Id;

                if (_placanje.PrivatnoOsiguranje != null)
                {
                    radioButton1.Checked = true;
                comboBox3.SelectedValue = _placanje.PrivatnoOsiguranje.IdOsiguranja;
                }
                if (_placanje.RFZO !=null) {
                    radioButton2.Checked = true;
                    comboBox3.SelectedValue = _placanje.RFZO.IdOsiguranja;
                }

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                List<PrivatnoOsiguranjePogled> osiguranja = DTOManager.vratiPogledPrivatnoOsiguranje();
                comboBox3.DataSource = osiguranja;
                comboBox3.DisplayMember = "Osiguranje";
                comboBox3.ValueMember = "IdOsiguranja";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                List<RFZOPogled> rfzos = DTOManager.vratiPogledRFZO();
                comboBox3.DataSource = rfzos;
                comboBox3.DisplayMember = "RFZOPrikaz";
                comboBox3.ValueMember = "IdOsiguranja";
            }
        }
    }
}
