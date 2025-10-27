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
    public partial class DodajRFZO : Form
    {
        private RFZO _rfzo;
        private bool fleg;
        public DodajRFZO(bool f, RFZO t)
        {
            fleg = f;
            if (f)
            {
                _rfzo = t;
            }
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RFZOBasic r = new RFZOBasic();
            r.IdOsiguranja = int.Parse(textBox1.Text);
            r.Pacijent = DTOManager.nadjiPacijenta((int)comboBox1.SelectedValue);

            DTOManager.dodajRFZO(r,fleg);
            MessageBox.Show("RFZO je uspešno dodat!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

        private void DodajRFZO_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            List<PacijentBasic> pacijenti = DTOManager.vratipacijentebasic();
            List <PacijentBasic> filtriranipacijenti = new List<PacijentBasic> ();

            foreach(var p in pacijenti)
            {
                if(p.RFZO == null && p.PrivatnoOsiguranje == null)
                {
                    filtriranipacijenti.Add(p);
                }
            }

            comboBox1.DataSource = filtriranipacijenti;
            comboBox1.DisplayMember = "PunoIme";
            comboBox1.ValueMember = "IdKartona";

            if (_rfzo != null)
            {
                textBox1.Text = _rfzo.IdOsiguranja.ToString();
                textBox1.ReadOnly = true;

                comboBox1.SelectedValue = _rfzo.Pacijent.IdKartona;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
