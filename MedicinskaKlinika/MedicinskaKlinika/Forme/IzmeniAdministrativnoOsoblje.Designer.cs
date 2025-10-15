using System.Windows.Forms;

namespace MedicinskaKlinika.Forme
{
    partial class IzmeniAdministrativnoOsoblje
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listView1 = new ListView();
            JMBG = new ColumnHeader();
            DatumZaposlenja = new ColumnHeader();
            Pozicija = new ColumnHeader();
            DatumRodjenja = new ColumnHeader();
            Ime = new ColumnHeader();
            Prezime = new ColumnHeader();
            Adresa = new ColumnHeader();
            AdresaLokacije = new ColumnHeader();
            Smena = new ColumnHeader();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { JMBG, DatumZaposlenja, Pozicija, DatumRodjenja, Ime, Prezime, Adresa, AdresaLokacije, Smena });
            listView1.Location = new Point(28, 60);
            listView1.Name = "listView1";
            listView1.Size = new Size(986, 325);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // JMBG
            // 
            JMBG.Text = "JMBG";
            JMBG.Width = 100;
            // 
            // DatumZaposlenja
            // 
            DatumZaposlenja.Text = "DatumZaposlenja";
            DatumZaposlenja.Width = 100;
            // 
            // Pozicija
            // 
            Pozicija.Text = "Pozicija";
            Pozicija.Width = 100;
            // 
            // DatumRodjenja
            // 
            DatumRodjenja.Text = "DatumRodjenja";
            DatumRodjenja.Width = 100;
            // 
            // Ime
            // 
            Ime.Text = "Ime";
            Ime.Width = 100;
            // 
            // Prezime
            // 
            Prezime.Text = "Prezime";
            Prezime.Width = 100;
            // 
            // Adresa
            // 
            Adresa.Text = "Adresa";
            Adresa.Width = 100;
            // 
            // AdresaLokacije
            // 
            AdresaLokacije.Text = "AdresaLokacije";
            AdresaLokacije.Width = 100;
            // 
            // Smena
            // 
            Smena.Text = "Smena";
            Smena.Width = 100;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(28, 444);
            button1.Name = "button1";
            button1.Size = new Size(257, 80);
            button1.TabIndex = 1;
            button1.Text = "Izmeni";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(368, 444);
            button2.Name = "button2";
            button2.Size = new Size(257, 80);
            button2.TabIndex = 2;
            button2.Text = "Obrisi";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(716, 444);
            button3.Name = "button3";
            button3.Size = new Size(257, 80);
            button3.TabIndex = 3;
            button3.Text = "Dodaj";
            button3.UseVisualStyleBackColor = true;
            // 
            // IzmeniAdministrativnoOsoblje
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 736);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Name = "IzmeniAdministrativnoOsoblje";
            Text = "IzmeniAdministrativnoOsoblje";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader JMBG;
        private ColumnHeader DatumZaposlenja;
        private ColumnHeader Pozicija;
        private ColumnHeader DatumRodjenja;
        private ColumnHeader Ime;
        private ColumnHeader Prezime;
        private ColumnHeader Adresa;
        private ColumnHeader AdresaLokacije;
        private ColumnHeader Smena;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}