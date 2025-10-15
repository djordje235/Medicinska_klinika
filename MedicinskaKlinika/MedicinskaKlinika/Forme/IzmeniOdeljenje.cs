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
    public partial class IzmeniOdeljenje : Form
    {
        public IzmeniOdeljenje()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DodajOdeljenje forma = new DodajOdeljenje();
            forma.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajOdeljenje forma = new DodajOdeljenje();
            forma.ShowDialog();
        }
    }
}
