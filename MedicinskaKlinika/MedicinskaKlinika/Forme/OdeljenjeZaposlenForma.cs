using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MedicinskaKlinika.Forme
{
    public partial class OdeljenjeZaposlenForma : Form
    {
        public List<string> naziviOdeljenja { get; private set; }
        public OdeljenjeZaposlenForma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> naziviOdeljenja = new List<string>();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    naziviOdeljenja.Add(checkedListBox1.GetItemText(i));
                }
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OdeljenjeZaposlenForma_Load(object sender, EventArgs e)
        {
            PopuniListViewOdeljenja();
        }
        private void PopuniListViewOdeljenja()
        {
            checkedListBox1.Items.Clear(); // očisti prethodne stavke

            List<OdeljenjePogled> odeljenja =DTOManager.citajOdeljenja();

            foreach (var od in odeljenja)
            {
                checkedListBox1.Items.Add(od.Naziv);
            }
        }

    }
}
