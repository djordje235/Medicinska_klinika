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
    public partial class IzmeniPlacanje : Form
    {
        public IzmeniPlacanje()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DodajPlacanje forma = new DodajPlacanje(false,null);
            forma.ShowDialog();
            IzmeniPlacanje_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem selektovaniItem = listView1.SelectedItems[0];
            int id = (int)selektovaniItem.Tag;

            Placanje r = DTOManager.nadjiPlacanje(id);

            DodajPlacanje forma = new DodajPlacanje(true,r);
            forma.ShowDialog();
            IzmeniPlacanje_Load(sender, e);
        }

        private void IzmeniPlacanje_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Clear();
            listView1.Columns.Add("IdPlacanja");
            listView1.Columns.Add("Procenat");
            listView1.Columns.Add("Racun");
            listView1.Columns.Add("NacinPlacanja");
            listView1.Columns.Add("PlatioPacijent");
            listView1.Columns.Add("Osiguranje");
            listView1.Columns.Add("BrojPolise");
            listView1.Columns.Add("OsiguravajucaKuca");

            listView1.Items.Clear();

            List<PlacanjeBasic> racuni = DTOManager.prikazPlacanja();

            foreach (var r in racuni)
            {

                ListViewItem item = new ListViewItem(r.IdPlacanja.ToString());
                item.SubItems.Add(r.ProcenatPacijenta.ToString());
                item.SubItems.Add(r.Racun.VrstaUsluge);
                item.SubItems.Add(r.NacinPlacanja);
                item.SubItems.Add(r.PlatioPacijent.ToString());
                if(r.RFZO != null)
                {
                 item.SubItems.Add(r.RFZO.IdOsiguranja.ToString());
                }
                if(r.PrivatnoOsiguranje != null)
                {
                item.SubItems.Add(r.PrivatnoOsiguranje.BrPolise.ToString());
                item.SubItems.Add(r.PrivatnoOsiguranje.OsiguravajucaKuca);
                }


                item.Tag = r.IdPlacanja;

                listView1.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem selektovaniItem = listView1.SelectedItems[0];
            int id = (int)selektovaniItem.Tag;

            DTOManager.brisiPlacanje(id);
            IzmeniPlacanje_Load(sender, e);
        }
    }
}
