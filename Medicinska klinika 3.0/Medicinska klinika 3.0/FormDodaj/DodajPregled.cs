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
        public PregledBasic p { get; private set; }
        public PregledBasic dodatni { get; private set; }

        public bool f { get; private set; }
        public DodajPregled(bool flag)
        {
            f = flag;
            InitializeComponent();
            p = new PregledBasic();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DodajPregled forma = new DodajPregled(true);
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

            List<ZaposlenPogled> lekari = DTOManager.vratipogledlekara();

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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
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
<<<<<<< HEAD
            p.DodatniPregled = dodatni;
            if (!f)
            {
                DTOManager.dodajPregled(p);
            }
            MessageBox.Show("Pregled je uspešno dodat!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
=======

            DTOManager.dodajPregled(p);
            MessageBox.Show("Pregled je uspešno dodat!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
>>>>>>> e8d3338178f9b4ceb43bd41161f5fc375ce93994
        }

        //ako zatreba
        //dtpVreme.Format = DateTimePickerFormat.Custom;
        //dtpVreme.CustomFormat = "HH:mm";   // samo sati i minuti
        //dtpVreme.ShowUpDown = true;        // uklanja kalendar i daje spinner

    }
}
