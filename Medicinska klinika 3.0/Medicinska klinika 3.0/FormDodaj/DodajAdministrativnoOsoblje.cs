using Medicinska_klinika_3._0.PomocneForme;
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
    public partial class DodajAdministrativnoOsoblje : Form
    {
        public DodajAdministrativnoOsoblje()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ZaposleniBrTel forma = new ZaposleniBrTel();
            forma.ShowDialog();
        }

        private void DodajAdministrativnoOsoblje_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            List<LokacijaPogled> lokacija = DTOManager.vratiPogledLokacija();

            comboBox1.DataSource = lokacija;
            comboBox1.DisplayMember = "Adresa";
            comboBox1.ValueMember = "Adresa";


        }

        private void button4_Click(object sender, EventArgs e)
        {
            ZaposleniEmail forma = new ZaposleniEmail();
            forma.ShowDialog();
        }
    }
}
