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
    public partial class ZaposlenBrTel : Form
    {
        public string Telefon { get; private set; }
        public ZaposlenBrTel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Telefon = textBox1.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
