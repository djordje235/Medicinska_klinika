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

namespace Medicinska_klinika_3._0.FormDodaj
{
    public partial class DodajPlacanje : Form
    {
        public DodajPlacanje()
        {
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
            PlacanjeBasic p = new PlacanjeBasic();
            p.ProcenatPacijenta = int.Parse(textBox1.Text);
            p.NacinPlacanja = textBox2.Text;
            p.PlatioPacijent = Boolean.Parse(textBox3.Text);
            p.Racun = DTOManager.nadjiRacun((int)comboBox2.SelectedValue);
            p.RFZO = DTOManager.nadjiRFZO((int)comboBox3.SelectedValue);
            p.PrivatnoOsiguranje = DTOManager.nadjiPrivatnoOsiguranje((int)comboBox3.SelectedValue);

            DTOManager.dodajPlacanje(p);
            MessageBox.Show("Placanje je uspešno dodat!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DodajPlacanje_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();

            List<RacunPogled> racuni = DTOManager.vratiPogledRacun();
            comboBox2.DataSource = racuni;
            comboBox2.DisplayMember = "PunRacun";
            comboBox2.ValueMember = "Id";

            List<RFZOPogled> rfzos = DTOManager.vratiPogledRFZO();
            comboBox3.DataSource = rfzos;
            comboBox3.DisplayMember = "RFZOPrikaz";
            comboBox3.ValueMember = "IdOsiguranja";

            List<PrivatnoOsiguranjePogled> osiguranja = DTOManager.vratiPogledPrivatnoOsiguranje();
            comboBox3.DataSource = osiguranja;
            comboBox3.DisplayMember = "Osiguranje";
            comboBox3.ValueMember = "BrPolise";

        }
    }
}
