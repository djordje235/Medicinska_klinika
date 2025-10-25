using Medicinska_klinika_3._0.FormDodaj;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medicinska_klinika_3._0.FormeIzmeni
{
    public partial class IzmeniPrivatnoOsiguranje : Form
    {
        public IzmeniPrivatnoOsiguranje()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DodajPrivatnoOsiguranje forma = new DodajPrivatnoOsiguranje();
            forma.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajPrivatnoOsiguranje forma = new DodajPrivatnoOsiguranje();
            forma.ShowDialog();
        }
    }
}
