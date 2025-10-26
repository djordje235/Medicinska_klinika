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
    public partial class IzmeniPregled : Form
    {
        public IzmeniPregled()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DodajPregled forma = new DodajPregled(false);
            forma.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajPregled forma = new DodajPregled(false);
            forma.ShowDialog();
        }

        private void IzmeniPregled_Load(object sender, EventArgs e)
        {

        }
    }
}
