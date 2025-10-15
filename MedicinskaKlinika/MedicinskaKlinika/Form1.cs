using MedicinskaKlinika.Forme;

namespace MedicinskaKlinika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormaZaAdministraciju forma = new FormaZaAdministraciju();
            forma.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormaKlinika forma = new FormaKlinika();
            forma.ShowDialog();
        }
    }
}
