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

namespace Medicinska_klinika_3._0.FormDodaj
{
    public partial class DodajPrivatnoOsiguranje : Form
    {
        private PrivatnoOsiguranje _privatno_osiguranje;
        private bool fleg;
        public DodajPrivatnoOsiguranje(bool f, PrivatnoOsiguranje t)
        {
            fleg = f;
            if (f)
            {
                _privatno_osiguranje = t;
            }
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
            if (fleg)
            {
                priv.IdOsiguranja = _privatno_osiguranje.IdOsiguranja;
            }
            DTOManager.dodajPrivatnoOsiguranje(priv,fleg);
            MessageBox.Show("Privatno osiguranje je uspešno dodat!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DodajPrivatnoOsiguranje_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            List<PacijentBasic> pacijenti = DTOManager.vratipacijentebasic();
            List<PacijentBasic> filtriranipacijenti = new List<PacijentBasic>();

            foreach (var p in pacijenti)
            {
                if (p.RFZO == null && p.PrivatnoOsiguranje == null)
                {
                    filtriranipacijenti.Add(p);
                }
            }
            comboBox1.DataSource = filtriranipacijenti;
            comboBox1.DisplayMember = "PunoIme";
            comboBox1.ValueMember = "IdKartona";

            if (_privatno_osiguranje != null)
            {
                textBox1.Text = _privatno_osiguranje.OsiguravajucaKuca;
                textBox2.Text = _privatno_osiguranje.BrPolise.ToString();

                comboBox1.SelectedValue = _privatno_osiguranje.Pacijent.IdKartona;
            }
        }
    }
}
