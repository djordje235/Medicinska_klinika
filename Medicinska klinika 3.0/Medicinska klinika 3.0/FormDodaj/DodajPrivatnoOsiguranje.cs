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
    public partial class DodajPrivatnoOsiguranje : Form
    {
        public DodajPrivatnoOsiguranje()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            PrivatnoOsiguranjeBasic priv = new PrivatnoOsiguranjeBasic();
            priv.OsiguravajucaKuca = textBox1.Text;
            priv.BrPolise = int.Parse(textBox2.Text);
            priv.Pacijent = DTOManager.nadjiPacijenta((int)comboBox1.SelectedValue);

            DTOManager.dodajPrivatnoOsiguranje(priv);
            MessageBox.Show("Privatno osiguranje je uspešno dodat!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DodajPrivatnoOsiguranje_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            List<PacijentPogled> pacijenti = DTOManager.vratipogledpacijenta();
            comboBox1.DataSource = pacijenti;
            comboBox1.DisplayMember = "PunoIme";
            comboBox1.ValueMember = "IdKartona";
        }
    }
}
