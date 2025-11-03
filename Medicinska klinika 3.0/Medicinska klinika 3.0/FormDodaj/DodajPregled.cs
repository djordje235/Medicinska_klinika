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
    public partial class DodajPregled : Form
    {
        private Pregled _pregled;
        private bool fleg;

        public PregledBasic p { get; private set; }
        public PregledBasic dodatni { get; private set; }

        public bool f { get; private set; }
        public DodajPregled(bool flag, bool f, Pregled t)
        {
            this.f = flag;

            fleg = f;
            if (f)
            {
                _pregled = t;
            }

            InitializeComponent();
            p = new PregledBasic();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DodajPregled forma = new DodajPregled(true,false,null);
            if (forma.ShowDialog() == DialogResult.OK)
            {
                dodatni = forma.p;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DodajPregled_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            comboBox5.Items.Clear();

            List<PacijentPogled> pacijenti = DTOManager.vratipogledpacijenta();

            comboBox2.DataSource = pacijenti;
            comboBox2.DisplayMember = "PunoIme";
            comboBox2.ValueMember = "IdKartona";

            List<LekarPogled> lekari = DTOManager.vratipogledlekara();

            comboBox3.DataSource = lekari;
            comboBox3.DisplayMember = "PunoIme";
            comboBox3.ValueMember = "JMBG";

            List<TerminPogled> termini = DTOManager.vratiPogledTermin();

            comboBox4.DataSource = termini;
            comboBox4.DisplayMember = "PunDatum";
            comboBox4.ValueMember = "IdTermina";

            List<OdeljenjePogled> odeljenja = DTOManager.vratipogledodaljenja();

            comboBox5.DataSource = odeljenja;
            comboBox5.DisplayMember = "Naziv";
            comboBox5.ValueMember = "Naziv";

            if (_pregled != null)
            {
                comboBox2.SelectedValue = _pregled.Pacijent.IdKartona;
                comboBox3.SelectedValue = _pregled.Lekar.JMBG;
                comboBox5.SelectedValue = _pregled.Odeljenje.Naziv;
                comboBox4.SelectedValue = _pregled.Termin.IdTermina;

                dateTimePicker1.Value = _pregled.Vreme;
                dateTimePicker2.Value = _pregled.Datum;

                textBox2.Text = _pregled.OpisTegoba;
                textBox1.Text = _pregled.Dijagnoza;
                textBox3.Text = _pregled.PreporukaZaLecenje;
                textBox4.Text = _pregled.Terapija;
                textBox5.Text = _pregled.VrstaPregleda;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedValue == null || comboBox3.SelectedValue == null || comboBox4.SelectedValue == null || comboBox5.SelectedValue == null)
            {
                MessageBox.Show("Sva polja moraju biti popunjena!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Sva tekstualna polja moraju biti popunjena!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (fleg)
            {
                p.IdPregleda = _pregled.IdPregleda;
            }

            p.Pacijent = DTOManager.nadjiPacijenta((int)comboBox2.SelectedValue);
            p.Lekar = DTOManager.nadjiLekara((int)comboBox3.SelectedValue);
            p.Termin = DTOManager.nadjiTermin((int)comboBox4.SelectedValue);
            p.Odeljenje = DTOManager.nadjiOdeljenje(comboBox5.SelectedValue.ToString());
            p.Vreme = dateTimePicker1.Value;
            p.Datum = dateTimePicker2.Value;
            p.OpisTegoba = textBox2.Text;
            p.Dijagnoza = textBox1.Text;
            p.PreporukaZaLecenje = textBox3.Text;
            p.Terapija = textBox4.Text;
            p.VrstaPregleda = textBox5.Text;

            p.DodatniPregled = dodatni;
            if (!f)
            {
                DTOManager.dodajPregled(p,fleg);
            }

            MessageBox.Show("Pregled je uspešno dodat!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        //ako zatreba
        //dtpVreme.Format = DateTimePickerFormat.Custom;
        //dtpVreme.CustomFormat = "HH:mm";   // samo sati i minuti
        //dtpVreme.ShowUpDown = true;        // uklanja kalendar i daje spinner

    }
}
