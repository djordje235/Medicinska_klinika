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
    public partial class IzmeniRFZO : Form
    {
        public IzmeniRFZO()
        {
            InitializeComponent();
        }

        private void IzmeniRFZO_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DodajRFZO forma = new DodajRFZO();
            forma.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajRFZO forma = new DodajRFZO();
            forma.ShowDialog();
        }
    }
}
