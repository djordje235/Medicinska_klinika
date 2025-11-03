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
    public partial class IzmeniLaboratorijskuAnalizu : Form
    {
        public IzmeniLaboratorijskuAnalizu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DodajLaboratorijsku_Analizu forma = new DodajLaboratorijsku_Analizu(false,null);
            forma.ShowDialog();
            IzmeniLaboratorijskuAnalizu_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }
            ListViewItem selektovaniItem = listView1.SelectedItems[0];
            int id = (int)selektovaniItem.Tag;

            LaboratorijskaAnaliza lab = DTOManager.nadjiLaboratorijskuAnalizu(id);

            DodajLaboratorijsku_Analizu forma = new DodajLaboratorijsku_Analizu(true,lab);
            forma.ShowDialog();
            IzmeniLaboratorijskuAnalizu_Load(sender, e);
        }

        private void IzmeniLaboratorijskuAnalizu_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Clear();
            listView1.Columns.Add("Pacijent");
            listView1.Columns.Add("VrstaAnalize");
            listView1.Columns.Add("DatumUzorkovanja");
            listView1.Columns.Add("Rezultat");
            listView1.Columns.Add("ReferentnaVrednost");
            listView1.Columns.Add("Vreme");
            listView1.Columns.Add("Komentar");
            listView1.Columns.Add("Laborant");
            listView1.Columns.Add("Pregled");
            listView1.Items.Clear();

            List<LaboratorijskaAnalizaBasic> labovi = DTOManager.prikazLaboratorijskeAnalize();

            foreach(var l in labovi)
            {
                ListViewItem item = new ListViewItem(l.Pacijent.Ime + " " + l.Pacijent.Prezime);
                item.SubItems.Add(l.VrstaAnalize);
                item.SubItems.Add(l.DatumUzorkovanja.ToString());
                item.SubItems.Add(l.Rezultat);
                item.SubItems.Add(l.ReferentnaVrednost);
                item.SubItems.Add(l.Vreme.ToString());
                item.SubItems.Add(l.Komentar);
                item.SubItems.Add(l.Laborant.Ime + " " + l.Laborant.Prezime);
                item.SubItems.Add(l.Pregled.VrstaPregleda);

                item.Tag = l.IdAnalize;

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

            DTOManager.brisiLaboratorijskuAnalizu(id);
            IzmeniLaboratorijskuAnalizu_Load(sender, e);
        }
    }
}
