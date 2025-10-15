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
    public partial class DodajPregled : Form
    {
        public DodajPregled()
        {
            InitializeComponent();
        }

        private void DodajPregled_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DodajPregled forma = new DodajPregled();
            forma.ShowDialog();
        }
    }
}
