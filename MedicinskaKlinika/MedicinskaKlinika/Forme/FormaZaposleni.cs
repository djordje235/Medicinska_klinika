using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicinskaKlinika.Forme
{
    public partial class FormaZaposleni : Form
    {
        public FormaZaposleni()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IzmeniLekara forma = new IzmeniLekara();
            forma.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IzmeniMedicinskuSestru forma = new IzmeniMedicinskuSestru();
            forma.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IzmeniLaboranta forma = new IzmeniLaboranta();
            forma.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IzmeniAdministrativnoOsoblje forma = new IzmeniAdministrativnoOsoblje();
            forma.ShowDialog();
        }
    }
}
