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
    public partial class IzmeniPrivatnoOsiguranje : Form
    {
        public IzmeniPrivatnoOsiguranje()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DodajPrivatnoOsiguranje forma = new DodajPrivatnoOsiguranje(false,null);
            forma.ShowDialog();
            IzmeniPrivatnoOsiguranje_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem selektovaniItem = listView1.SelectedItems[0];
            int id = (int)selektovaniItem.Tag;

            PrivatnoOsiguranje o = DTOManager.nadjiPrivatnoOsiguranje(id);

            DodajPrivatnoOsiguranje forma = new DodajPrivatnoOsiguranje(true,o);
            forma.ShowDialog();
            IzmeniPrivatnoOsiguranje_Load(sender, e);
        }

        private void IzmeniPrivatnoOsiguranje_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Clear();
            listView1.Columns.Add("BrPolise");
            listView1.Columns.Add("OsiguravajucaKuca");
            listView1.Columns.Add("Pacijent");

            listView1.Items.Clear();

            List<PrivatnoOsiguranjePrikaz> osiguranja = DTOManager.prikazPrivatnogOsiguranja();

            foreach (var o in osiguranja)
            {

                ListViewItem item = new ListViewItem(o.BrPolise.ToString());

                item.SubItems.Add(o.OsiguravajucaKuca);
                item.SubItems.Add(o.Pacijent.Ime + " " + o.Pacijent.Prezime);

                item.Tag = o.id;

                listView1.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListViewItem selektovaniItem = listView1.SelectedItems[0];
            int id = (int)selektovaniItem.Tag;

            DTOManager.brisiPrivatnoOsiguranje(id);


            IzmeniPrivatnoOsiguranje_Load(sender, e);
        }
    }
}
