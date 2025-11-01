using Medicinska_klinika_3._0.FormDodaj;
using MedicinskaKlinika;
using MedicinskaKlinika.Entiteti;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medicinska_klinika_3._0.FormeIzmeni
{
    public partial class IzmeniLokaciju : Form
    {
        public IzmeniLokaciju()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DodajLokaciju forma = new DodajLokaciju(false,null);
            forma.ShowDialog();
            IzmeniLokaciju_Load(sender,e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem selektovaniItem = listView1.SelectedItems[0];
            string id = selektovaniItem.Tag.ToString();

            Lokacija l = DTOManager.nadjiLokaciju(id);

            DodajLokaciju forma = new DodajLokaciju(true,l);
            forma.ShowDialog();
            IzmeniLokaciju_Load(sender, e);
        }

        private void IzmeniLokaciju_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Clear();
            listView1.Columns.Add("Adresa");
            listView1.Columns.Add("RadnoVreme");

            listView1.Items.Clear();

            List<LokacijaBasic> lokacije = DTOManager.prikazLokacije();

            foreach (var l in lokacije) {
                ListViewItem item = new ListViewItem(l.Adresa);
                item.SubItems.Add(l.RadnoVreme);

                item.Tag = l.Adresa;

                listView1.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem selektovaniItem = listView1.SelectedItems[0];
            string id = selektovaniItem.Tag.ToString();

            DTOManager.brisiLokacija(id);


            IzmeniLokaciju_Load(sender, e);
        }
    }
}
