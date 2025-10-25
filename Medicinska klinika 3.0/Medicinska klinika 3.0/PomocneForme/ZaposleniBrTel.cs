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

namespace Medicinska_klinika_3._0.PomocneForme
{
    public partial class ZaposleniBrTel : Form
    {
        public BrTelefonaZaposlenog telefon { get; private set; }
        public ZaposleniBrTel()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ZaposleniBrTel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            telefon = new BrTelefonaZaposlenog();
            telefon.BrojTelefona = textBox1.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
