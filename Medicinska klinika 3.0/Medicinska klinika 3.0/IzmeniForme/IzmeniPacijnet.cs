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
    public partial class IzmeniPacijnet : Form
    {
        public IzmeniPacijnet()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DodajPacijenta forma = new DodajPacijenta(false,null);
            forma.ShowDialog();
            IzmeniPacijnet_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem selektovaniItem = listView1.SelectedItems[0];
            int id = (int)selektovaniItem.Tag;

            Pacijent admin = DTOManager.nadjiPacijenta(id);

            DodajPacijenta forma = new DodajPacijenta(true,admin);
            forma.ShowDialog();
            IzmeniPacijnet_Load(sender, e);
        }

        private void IzmeniPacijnet_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Clear();
            listView1.Columns.Add("Ime");
            listView1.Columns.Add("Prezime");
            listView1.Columns.Add("Adresa");
            listView1.Columns.Add("DatumRodjenja");
            listView1.Columns.Add("Pol");

            listView1.Items.Clear();

            List<PacijentBasic> admini = DTOManager.prikazPacijenta();

            foreach (var a in admini)
            {

                ListViewItem item = new ListViewItem(a.IdKartona.ToString());

                item.SubItems.Add(a.Ime);
                item.SubItems.Add(a.Prezime);
                item.SubItems.Add(a.Adresa);
                item.SubItems.Add(a.DatumRodjenja.ToString("dd.MM.yyyy"));
                item.SubItems.Add(a.Pol);

                item.Tag = a.IdKartona;

                listView1.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListViewItem selektovaniItem = listView1.SelectedItems[0];
            int id = (int)selektovaniItem.Tag;

            DTOManager.brisiPacijenta(id);

            IzmeniPacijnet_Load(sender, e);
        }
    }
}
