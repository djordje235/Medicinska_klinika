using MedicinskaKlinika;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medicinska_klinika_3._0.FormDodaj
{
    public partial class DodajTermin : Form
    {
        public DodajTermin()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DodajTermin_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox3.Items.Clear();
            comboBox2.Items.Clear();
            //Za pogledi
            List<PacijentPogled> pacijenti = DTOManager.vratipogledpacijenta();

            comboBox1.DataSource = pacijenti;
            comboBox1.DisplayMember = "PunoIme";
            comboBox1.ValueMember = "IdKartona";

            //Za odeljenja
            List<OdeljenjePogled> odeljenja = DTOManager.vratipogledodaljenja();

            comboBox3.DataSource = odeljenja;
            comboBox3.DisplayMember = "Naziv";
            comboBox3.ValueMember = "Naziv";

            //Za lekara
            List<ZaposlenPogled> lekari = DTOManager.vratipogledlekara();

            comboBox2.DataSource = lekari;
            comboBox2.DisplayMember = "PunoIme";
            comboBox2.ValueMember = "JMBG";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            TerminBasic t = new TerminBasic();
            t.Pacijent = DTOManager.nadjiPacijenta((int)comboBox1.SelectedValue);
            t.Datum = dateTimePicker2.Value;
            t.Vreme = dateTimePicker1.Value;
            t.Odeljenje = DTOManager.nadjiOdeljenje(comboBox3.SelectedValue.ToString());
            t.Lekar = DTOManager.nadjiLekara(int.Parse(comboBox2.SelectedValue.ToString()));

            DTOManager.dodajTermin(t);

            MessageBox.Show("Termin je uspešno dodat!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
