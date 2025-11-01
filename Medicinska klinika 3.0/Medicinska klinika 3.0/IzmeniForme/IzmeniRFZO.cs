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
    public partial class IzmeniRFZO : Form
    {
        public IzmeniRFZO()
        {
            InitializeComponent();
        }

        private void IzmeniRFZO_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Clear();
            listView1.Columns.Add("idOsiguranja");
            listView1.Columns.Add("Pacijent");

            listView1.Items.Clear();

            List<RFZOPrikaz> rfzos = DTOManager.prikazRFZO();

            foreach (var r in rfzos)
            {

                ListViewItem item = new ListViewItem(r.IdOsiguranja.ToString());


                item.SubItems.Add(r.Pacijent.Ime + " " + r.Pacijent.Prezime);

                item.Tag = r.IdOsiguranja;

                listView1.Items.Add(item);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DodajRFZO forma = new DodajRFZO(false,null);
            forma.ShowDialog();
            IzmeniRFZO_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem selektovaniItem = listView1.SelectedItems[0];
            int id = (int)selektovaniItem.Tag;

            RFZO r = DTOManager.nadjiRFZO(id);

            DodajRFZO forma = new DodajRFZO(true,r);
            forma.ShowDialog();
            IzmeniRFZO_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem selektovaniItem = listView1.SelectedItems[0];
            int id = (int)selektovaniItem.Tag;

            DTOManager.brisiRFZO(id);


            IzmeniRFZO_Load(sender, e);
        }
    }
}
