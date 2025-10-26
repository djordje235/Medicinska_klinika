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
    public partial class DodajLaboratorijsku_Analizu : Form
    {
        public DodajLaboratorijsku_Analizu()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DodajLaboratorijsku_Analizu_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();

            List<ZaposlenPogled> laboranti = DTOManager.vratipogledlaboranti();

            comboBox1.DataSource = laboranti;
            comboBox1.DisplayMember = "PunoIme";
            comboBox1.ValueMember = "JMBG";

            List<PacijentPogled> pacijenti = DTOManager.vratipogledpacijenta();

            comboBox2.DataSource = pacijenti;
            comboBox2.DisplayMember = "PunoIme";
            comboBox2.ValueMember = "IdKartona";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LaboratorijskaAnalizaBasic l = new LaboratorijskaAnalizaBasic();
            l.Pacijent = DTOManager.nadjiPacijenta(int.Parse(comboBox2.SelectedValue.ToString()));
            l.DatumUzorkovanja = dateTimePicker1.Value;
            l.VrstaAnalize = textBox2.Text;
            l.Vreme = dateTimePicker2.Value;
            l.Rezultat = textBox1.Text;
            l.ReferentnaVrednost = textBox3.Text;
            l.Komentar = textBox4.Text;
            l.Laborant = DTOManager.nadjiLaboranta(int.Parse(comboBox1.SelectedValue.ToString()));

            DTOManager.dodajLaboratorijskuAnalizu(l);
            MessageBox.Show("Laboratorijska analiza je uspešno dodata!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
