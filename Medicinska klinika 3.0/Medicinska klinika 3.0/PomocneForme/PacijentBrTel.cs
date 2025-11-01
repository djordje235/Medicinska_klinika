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
    public partial class PacijentBrTel : Form
    {
        public BrTelefonaPacijenta telefon { get; private set; }
        public PacijentBrTel()
        {
            InitializeComponent();
        }

        private void PacijentBrTel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            telefon = new BrTelefonaPacijenta();
            telefon.BrojTelefona = textBox1.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
