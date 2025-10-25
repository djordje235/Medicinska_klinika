using Medicinska_klinika_3._0.PomocneForme;
using MedicinskaKlinika;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medicinska_klinika_3._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormaZaAdministraciju forma = new FormaZaAdministraciju();
            forma.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormaKlinika forma = new FormaKlinika();
            forma.ShowDialog();
        }
    }
}
