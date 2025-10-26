using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Medicinska_klinika_3._0.PomocneForme;
using MedicinskaKlinika;
using MedicinskaKlinika.Entiteti;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Medicinska_klinika_3._0.FormDodaj
{
    public partial class DodajPacijenta : Form
    {
        private List<EmailZaposlenog> emailovi = new List<EmailZaposlenog>();
        private List<BrTelefonaZaposlenog> brojevi = new List<BrTelefonaZaposlenog>();

        public DodajPacijenta()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ZaposleniBrTel forma = new ZaposleniBrTel();
            if (forma.ShowDialog() == DialogResult.OK)
            {
                BrTelefonaZaposlenog novi = forma.telefon;

                brojevi.Add(novi);

                listView2.Items.Add(novi.BrojTelefona);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ZaposleniEmail forma = new ZaposleniEmail();
            if (forma.ShowDialog() == DialogResult.OK)
            {
                EmailZaposlenog novi = forma.email;
                emailovi.Add(novi);

                listView1.Items.Add(novi.Email);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DodajPacijenta_Load(object sender, EventArgs e)
        {
            List<ZaposlenPogled> lekari = DTOManager.vratipogledlekara();

            comboBox3.DataSource = lekari;
            comboBox3.DisplayMember = "PunoIme";
            comboBox3.ValueMember = "JMBG";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PacijentBasic p = new PacijentBasic();
            p.IdKartona = int.Parse(textBox1.Text);
            p.Adresa = textBox2.Text;
            p.Ime = textBox3.Text;
            p.Prezime = textBox4.Text;
            p.DatumRodjenja = dateTimePicker1.Value;
            if (radioButton1.Checked)
                p.Pol = radioButton1.Text;
            else if(radioButton2.Checked)
                p.Pol = radioButton2.Text;
            p.Lekar = DTOManager.nadjiLekara(int.Parse(comboBox3.SelectedValue.ToString()));

            DTOManager.dodajPacijenta(p);
            MessageBox.Show("Pacijent je uspešno dodat!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
