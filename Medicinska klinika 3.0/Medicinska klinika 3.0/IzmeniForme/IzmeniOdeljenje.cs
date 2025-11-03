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
    public partial class IzmeniOdeljenje : Form
    {
        public IzmeniOdeljenje()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DodajOdeljenje forma = new DodajOdeljenje(false,null);
            forma.ShowDialog();
            IzmeniOdeljenje_Load(sender,e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem selektovaniItem = listView1.SelectedItems[0];
            string naziv = selektovaniItem.Tag.ToString();

            Odeljenje r = DTOManager.nadjiOdeljenje(naziv);

            DodajOdeljenje forma = new DodajOdeljenje(true,r);
            forma.ShowDialog();
            IzmeniOdeljenje_Load(sender, e);
        }

        private void IzmeniOdeljenje_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Clear();
            listView1.Columns.Add("Naziv");
            listView1.Columns.Add("RadnoVreme");
            listView1.Columns.Add("BrProstorija");
            listView1.Columns.Add("Lekar");

            listView1.Items.Clear();

            List<OdeljenjeBasic> odeljenja = DTOManager.prikazOdeljenja();

            foreach(var r in odeljenja)
            {
                ListViewItem item = new ListViewItem(r.Naziv);
                item.SubItems.Add(r.RadnoVreme);
                item.SubItems.Add(r.BrProstorije.ToString());
                item.SubItems.Add(r.GlavniLekar.Ime + " " + r.GlavniLekar.Prezime);

                item.Tag = r.Naziv;

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
            string naziv = selektovaniItem.Tag.ToString();

            DTOManager.brisiOdeljenje(naziv);

            IzmeniOdeljenje_Load(sender, e);
        }
    }
}
