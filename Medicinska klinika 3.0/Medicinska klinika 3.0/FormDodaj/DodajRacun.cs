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
    public partial class DodajRacun : Form
    {
        public DodajRacun()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RacunBasic r = new RacunBasic();
            r.Popust = int.Parse(textBox1.Text);
            r.VrstaUsluge = textBox2.Text;
            r.Datum = dateTimePicker1.Value;
            r.Cena = double.Parse(textBox3.Text);
            r.Lekar = DTOManager.nadjiLekara((int)comboBox2.SelectedValue);
            r.Pacijent = DTOManager.nadjiPacijenta((int)comboBox3.SelectedValue);

            DTOManager.dodajRacun(r);
            MessageBox.Show("Racun je uspešno dodat!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DodajRacun_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();

            List<PacijentPogled> pacijenti = DTOManager.vratipogledpacijenta();
            comboBox3.DataSource = pacijenti;
            comboBox3.DisplayMember = "PunoIme";
            comboBox3.ValueMember = "IdKartona";

            List<ZaposlenPogled> lekari = DTOManager.vratipogledlekara();
            comboBox2.DataSource = lekari;
            comboBox2.DisplayMember = "PunoIme";
            comboBox2.ValueMember = "JMBG";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
