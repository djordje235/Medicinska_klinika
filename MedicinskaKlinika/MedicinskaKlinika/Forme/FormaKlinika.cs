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
    public partial class FormaKlinika : Form
    {
        public FormaKlinika()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IzmeniPacijenta forma = new IzmeniPacijenta();
            forma.ShowDialog();
        }

        private void FormaKlinika_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormaFinansije forma = new FormaFinansije();
            forma.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormaUsluga forma = new FormaUsluga();
            forma.ShowDialog();
        }
    }
}
