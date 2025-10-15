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
    public partial class IzmeniLaboranta : Form
    {
        public IzmeniLaboranta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajLaboranta forma = new DodajLaboranta();
            forma.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DodajLaboranta forma = new DodajLaboranta();
            forma.ShowDialog();
        }
    }
}
