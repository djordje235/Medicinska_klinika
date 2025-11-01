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
    public partial class IzmeniPregled : Form
    {
        public IzmeniPregled()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DodajPregled forma = new DodajPregled(false,false,null);
            forma.ShowDialog();
            IzmeniPregled_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem selektovaniItem = listView1.SelectedItems[0];
            int id = (int)selektovaniItem.Tag;


            Pregled pregled = DTOManager.nadjiPregled(id);

            DodajPregled forma = new DodajPregled(false,true,pregled);
            forma.ShowDialog();
            IzmeniPregled_Load(sender, e);
        }

        private void IzmeniPregled_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Clear();
            listView1.Columns.Add("Pacijent");
            listView1.Columns.Add("Datum");
            listView1.Columns.Add("Vreme");
            listView1.Columns.Add("OpisTegoba");
            listView1.Columns.Add("Dijagnoza");
            listView1.Columns.Add("Terapija");
            listView1.Columns.Add("PreporukaZaLecenje");
            listView1.Columns.Add("Lekar");
            listView1.Columns.Add("Odeljenje");
            listView1.Columns.Add("VrstaPregleda");
            listView1.Columns.Add("Termin");


            listView1.Items.Clear();

            List<PregledBasic> pregledi = DTOManager.prikazPregleda();

            foreach (var t in pregledi)
            {

                ListViewItem item = new ListViewItem(t.Pacijent.Ime + " " + t.Pacijent.Prezime);


                item.SubItems.Add(t.Datum.ToString("dd.MM.yyyy"));
                item.SubItems.Add(t.Vreme.ToString("HH:mm"));
                item.SubItems.Add(t.OpisTegoba);
                item.SubItems.Add(t.Dijagnoza);
                item.SubItems.Add(t.Terapija);
                item.SubItems.Add(t.PreporukaZaLecenje);
                item.SubItems.Add(t.Lekar.Ime + " " + t.Lekar.Prezime);
                item.SubItems.Add(t.Odeljenje.Naziv);
                item.SubItems.Add(t.VrstaPregleda);
                item.SubItems.Add(t.Termin.Datum + " " + t.Termin.Vreme);
                item.Tag = t.IdPregleda;

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

            DTOManager.brisiPregled(id);

            IzmeniPregled_Load(sender, e);
        }
    }
}
