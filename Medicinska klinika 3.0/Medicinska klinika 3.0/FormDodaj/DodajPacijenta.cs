using Medicinska_klinika_3._0.PomocneForme;
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
    public partial class DodajPacijenta : Form
    {
        public DodajPacijenta()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ZaposleniBrTel forma = new ZaposleniBrTel();
            forma.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ZaposleniEmail forma = new ZaposleniEmail();
            forma.ShowDialog();
        }
    }
}
