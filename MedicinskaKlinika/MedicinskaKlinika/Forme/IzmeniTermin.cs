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
    public partial class IzmeniTermin : Form
    {
        public IzmeniTermin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajTermin forma = new DodajTermin();
            forma.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DodajTermin forma = new DodajTermin();
            forma.ShowDialog();
        }
    }
}
