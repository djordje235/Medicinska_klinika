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
    public partial class IzmeniTermin : Form
    {
        public IzmeniTermin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DodajTermin forma = new DodajTermin(false,null);
            forma.ShowDialog();
            IzmeniTermin_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem selektovaniItem = listView1.SelectedItems[0];
            int idTermina = (int)selektovaniItem.Tag;

            Termin termin = DTOManager.nadjiTermin(idTermina);

            DodajTermin forma = new DodajTermin(true,termin);
            forma.ShowDialog();
            IzmeniTermin_Load(sender, e);
        }

        
            private void IzmeniTermin_Load(object sender, EventArgs e)
        {
            
            listView1.View = View.Details;
            listView1.Columns.Clear();
            listView1.Columns.Add("Pacijent");
            listView1.Columns.Add("Datum");
            listView1.Columns.Add("Vreme");
            listView1.Columns.Add("Odeljenje");
            listView1.Columns.Add("Lekar");

            
            listView1.Items.Clear();

            
            List<TerminiPrikaz> termini = DTOManager.prikazTermina();

            foreach (var t in termini)
            {
                
                ListViewItem item = new ListViewItem(t.Pacijent.Ime + " " + t.Pacijent.Prezime);

                
                item.SubItems.Add(t.Datum.ToString("dd.MM.yyyy"));
                item.SubItems.Add(t.Vreme.ToString("HH:mm"));
                item.SubItems.Add(t.Odeljenje.Naziv);
                item.SubItems.Add(t.Lekar.Ime + " " + t.Lekar.Prezime);

                item.Tag = t.IdTermina;

                listView1.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListViewItem selektovaniItem = listView1.SelectedItems[0];
            int idTermina = (int)selektovaniItem.Tag;

            DTOManager.brisiTermin(idTermina);


            IzmeniTermin_Load(sender, e);
        }
    }
}

