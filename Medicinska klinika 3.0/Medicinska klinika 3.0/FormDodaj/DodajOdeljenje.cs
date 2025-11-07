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
    public partial class DodajOdeljenje : Form
    {
        private List<Lokacija> loc = new List<Lokacija>();
        private List<LokacijaPogled> lokacije = new List<LokacijaPogled>();

        private Odeljenje _odeljenje;
        private bool fleg;
        public DodajOdeljenje(bool f, Odeljenje o)
        {
            fleg = f;
            if (f)
            {
                _odeljenje = o;
            }
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DodajOdeljenje_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox1.Items.Clear();

            List<LekarPogled> lekari = DTOManager.vratipogledlekara();
            List<LekarPogled> filtrirani_lekari = lekari.Where(x => x.Odeljenje == null).ToList();


            lokacije = DTOManager.vratiPogledLokacija();

            comboBox1.DataSource = lokacije;
            comboBox1.DisplayMember = "Adresa";
            comboBox1.ValueMember = "Adresa";

            if(_odeljenje != null)
            {
                filtrirani_lekari.Add(new LekarPogled(_odeljenje.GlavniLekar.JMBG, _odeljenje.GlavniLekar.Ime, _odeljenje.GlavniLekar.Prezime, _odeljenje));
                textBox1.Text = _odeljenje.Naziv;
                textBox2.Text = _odeljenje.BrProstorije.ToString();
                textBox3.Text = _odeljenje.RadnoVreme;

                comboBox2.SelectedValue = _odeljenje.GlavniLekar.JMBG;

                foreach(var l in _odeljenje.Lokacije)
                {
                    loc.Add(l);
                    LokacijaPogled lo = lokacije.Where(x => x.Adresa == l.Adresa).FirstOrDefault();
                    lokacije.Remove(lo);
                }
                comboBox1.DataSource = null;
                comboBox1.DataSource = lokacije;
                comboBox1.DisplayMember = "Adresa";
                comboBox1.ValueMember = "Adresa";

                foreach(Lokacija x in loc)
                {
                    listView2.Items.Add(x.Adresa);
                }
            }
            comboBox2.DataSource = filtrirani_lekari;
            comboBox2.DisplayMember = "PunoIme";
            comboBox2.ValueMember = "JMBG";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OdeljenjeBasic o = new OdeljenjeBasic();
            o.Naziv = textBox1.Text;
            o.BrProstorije = int.Parse(textBox2.Text);
            o.RadnoVreme = textBox3.Text;
            o.GlavniLekar = DTOManager.nadjiLekara(long.Parse(comboBox2.SelectedValue.ToString()));
            o.Lokacije = loc;

            DTOManager.dodajOdeljenje(o,fleg);

            MessageBox.Show("Odeljenje je uspešno dodat!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lokacija lokacija = DTOManager.nadjiLokaciju(comboBox1.SelectedValue.ToString());
            loc.Add(lokacija);
            listView2.Items.Add(lokacija.Adresa);
            var selektovano = comboBox1.SelectedItem as LokacijaPogled;
            if(selektovano != null)
            {
                lokacije.Remove(selektovano);
                comboBox1.DataSource = null;
                comboBox1.DataSource = lokacije;
                comboBox1.DisplayMember = "Adresa";
                comboBox1.ValueMember = "Adresa";
            }
        }
    }
}
