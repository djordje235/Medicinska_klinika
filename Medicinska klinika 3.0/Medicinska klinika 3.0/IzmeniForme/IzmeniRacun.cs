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
    public partial class IzmeniRacun : Form
    {
        public IzmeniRacun()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DodajRacun forma = new DodajRacun(false, null);
            forma.ShowDialog();
            IzmeniRacun_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem selektovaniItem = listView1.SelectedItems[0];
            int id = (int)selektovaniItem.Tag;

            Racun r = DTOManager.nadjiRacun(id);

            DodajRacun forma = new DodajRacun(true,r);
            forma.ShowDialog();
            IzmeniRacun_Load(sender, e);
        }

        private void IzmeniRacun_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Clear();
            listView1.Columns.Add("Id");
            listView1.Columns.Add("Popust");
            listView1.Columns.Add("VrstaUsluge");
            listView1.Columns.Add("Datum");
            listView1.Columns.Add("Cena");
            listView1.Columns.Add("Lekar");
            listView1.Columns.Add("Pacijent");

            listView1.Items.Clear();

            List<RacunBasic> racuni = DTOManager.prikazRacuna();

            foreach (var r in racuni)
            {

                ListViewItem item = new ListViewItem(r.Id.ToString());
                item.SubItems.Add(r.Popust.ToString());
                item.SubItems.Add(r.VrstaUsluge);
                item.SubItems.Add(r.Datum.ToString());
                item.SubItems.Add(r.Cena.ToString());
                item.SubItems.Add(r.Lekar.Ime + " " + r.Lekar.Prezime);
                item.SubItems.Add(r.Pacijent.Ime + " " + r.Pacijent.Prezime);

                item.Tag = r.Id;

                listView1.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListViewItem selektovaniItem = listView1.SelectedItems[0];
            int id = (int)selektovaniItem.Tag;

            DTOManager.brisiRacun(id);

            IzmeniRacun_Load(sender, e);
        }
    }
}
