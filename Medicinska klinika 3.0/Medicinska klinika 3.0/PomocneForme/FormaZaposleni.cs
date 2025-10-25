using Medicinska_klinika_3._0.FormeIzmeni;
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

        private void button3_Click(object sender, EventArgs e)
        {
            IzmeniMedicinskaSestra forma = new IzmeniMedicinskaSestra();
            forma.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IzmeniLaboranta forma = new IzmeniLaboranta();
            forma.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IzmeniAdministrativnoOsoblje forma = new IzmeniAdministrativnoOsoblje();
            forma.ShowDialog();
        }

        private void FormaZaposleni_Load(object sender, EventArgs e)
        {

        }
    }
}
