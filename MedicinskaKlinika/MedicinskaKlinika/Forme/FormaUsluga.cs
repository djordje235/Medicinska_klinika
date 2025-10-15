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
    public partial class FormaUsluga : Form
    {
        public FormaUsluga()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IzmeniTermin forma = new IzmeniTermin();
            forma.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IzmeniPregled forma = new IzmeniPregled();
            forma.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IzmeniLaboratorijskuAnalizu forma = new IzmeniLaboratorijskuAnalizu();
            forma.ShowDialog();
        }
    }
}
