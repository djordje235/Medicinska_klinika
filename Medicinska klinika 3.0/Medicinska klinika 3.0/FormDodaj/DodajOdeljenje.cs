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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Medicinska_klinika_3._0.FormDodaj
{
    public partial class DodajOdeljenje : Form
    {
        public DodajOdeljenje()
        {
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
            comboBox3.Items.Clear();

            List<ZaposlenPogled> lekari = DTOManager.vratipogledlekara();

            comboBox2.DataSource = lekari;
            comboBox2.DisplayMember = "PunoIme";
            comboBox2.ValueMember = "JMBG";

            List<LokacijaPogled> lokacija = DTOManager.vratiPogledLokacija();

            comboBox3.DataSource = lokacija;
            comboBox3.DisplayMember = "Adresa";
            comboBox3.ValueMember = "Adresa";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OdeljenjeBasic o = new OdeljenjeBasic();
            o.Naziv = textBox1.Text;
            o.BrProstorije = int.Parse(textBox2.Text);
            o.RadnoVreme = textBox3.Text;
            o.GlavniLekar = DTOManager.nadjiLekara(int.Parse(comboBox2.SelectedValue.ToString()));
            o.Lokacije.Add(DTOManager.nadjiLokaciju(comboBox3.SelectedValue.ToString()));
        }
    }
}
