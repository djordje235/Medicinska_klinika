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
    public partial class FormaZaAdministraciju : Form
    {
        public FormaZaAdministraciju()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormaZaposleni forma = new FormaZaposleni();
            forma.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IzmeniOdeljenje forma = new IzmeniOdeljenje();
            forma.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IzmeniLokaciju forma = new IzmeniLokaciju();
            forma.ShowDialog();
        }

        private void FormaZaAdministraciju_Load(object sender, EventArgs e)
        {

        }
    }
}
