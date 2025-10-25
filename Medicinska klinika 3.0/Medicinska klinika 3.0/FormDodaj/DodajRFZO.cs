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

namespace Medicinska_klinika_3._0.FormDodaj
{
    public partial class DodajRFZO : Form
    {
        public DodajRFZO()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RFZOBasic r = new RFZOBasic();
            r.IdOsiguranja = int.Parse(textBox1.Text);
            r.Pacijent = DTOManager.nadjiPacijenta((int)comboBox1.SelectedValue);

            DTOManager.dodajRFZO(r);
            MessageBox.Show("RFZO je uspešno dodat!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void DodajRFZO_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            List<PacijentPogled> pacijenti = DTOManager.vratipogledpacijenta();

            comboBox1.DataSource = pacijenti;
            comboBox1.DisplayMember = "PunoIme";
            comboBox1.ValueMember = "IdKartona";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
