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
    public partial class IzmeniLekara : Form
    {
        public IzmeniLekara()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DodajLekaraForm forma = new DodajLekaraForm();
            forma.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajLekaraForm forma = new DodajLekaraForm();
            forma.ShowDialog();
        }

        private void IzmeniLekara_Load(object sender, EventArgs e)
        {

        }
    }
}
