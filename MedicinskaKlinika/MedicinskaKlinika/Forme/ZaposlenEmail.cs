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
    public partial class ZaposlenEmail : Form
    {
        public string email { get; private set; }

        public ZaposlenEmail()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            email = textBox1.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ZaposlenEmail_Load(object sender, EventArgs e)
        {

        }
    }
}
