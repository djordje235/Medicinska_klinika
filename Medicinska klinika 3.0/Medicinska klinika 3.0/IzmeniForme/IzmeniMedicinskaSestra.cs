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
    public partial class IzmeniMedicinskaSestra : Form
    {
        public IzmeniMedicinskaSestra()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DodajMedicinskuSestru forma = new DodajMedicinskuSestru(false,null);
            forma.ShowDialog();
            IzmeniMedicinskaSestra_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem selektovaniItem = listView1.SelectedItems[0];
            long id = (long)selektovaniItem.Tag;

            MedicinskaSestra admin = DTOManager.nadjiMedicinskuSestru(id);

            DodajMedicinskuSestru forma = new DodajMedicinskuSestru(true,admin);
            forma.ShowDialog();
            IzmeniMedicinskaSestra_Load(sender, e);
        }

        private void IzmeniMedicinskaSestra_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Clear();
            listView1.Columns.Add("JMBG");
            listView1.Columns.Add("DatumRodjenja");
            listView1.Columns.Add("DatumZaposlenja");
            listView1.Columns.Add("Pozicija");
            listView1.Columns.Add("Ime");
            listView1.Columns.Add("Prezime");
            listView1.Columns.Add("Adresa");
            listView1.Columns.Add("AdresaLokacije");
            listView1.Columns.Add("Smena");
            listView1.Columns.Add("Sertifikat");
            listView1.Columns.Add("OblastRada");

            listView1.Items.Clear();

            List<MedicinskaSestraBasic> admini = DTOManager.prikazMedicinskeSestre();

            foreach (var a in admini)
            {

                ListViewItem item = new ListViewItem(a.JMBG.ToString());


                item.SubItems.Add(a.DatumRodjenja.ToString("dd.MM.yyyy"));
                item.SubItems.Add(a.DatumZaposlenja.ToString("dd.MM.yyyy"));

                item.SubItems.Add(a.Pozicija);
                item.SubItems.Add(a.Ime);
                item.SubItems.Add(a.Prezime);
                item.SubItems.Add(a.Adresa);
                item.SubItems.Add(a.AdresaLokacije.Adresa);
                item.SubItems.Add(a.Smena.ToString());
                item.SubItems.Add(a.Sertifikat);
                item.SubItems.Add(a.OblastRada);

                item.Tag = a.JMBG;

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
            long id = (long)selektovaniItem.Tag;

            DTOManager.brisiMedicinskuSestru(id);


            IzmeniMedicinskaSestra_Load(sender, e);
        }
    }
}
