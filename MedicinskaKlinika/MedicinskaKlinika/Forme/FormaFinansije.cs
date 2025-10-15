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
    public partial class FormaFinansije : Form
    {
        public FormaFinansije()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IzmeniRacun forma = new IzmeniRacun();
            forma.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IzmeniPlacanje forma = new IzmeniPlacanje();
            forma.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IzmeniRFZO forma = new IzmeniRFZO();
            forma.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IzmeniPrivatnoOsiguranje forma = new IzmeniPrivatnoOsiguranje();
            forma.ShowDialog();
        }
    }
}
