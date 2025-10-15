namespace MedicinskaKlinika.Forme
{
    partial class IzmeniPregled
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            listView1 = new ListView();
            Pacijent = new ColumnHeader();
            Datum = new ColumnHeader();
            Vreme = new ColumnHeader();
            OpisTegoba = new ColumnHeader();
            Dijagnoza = new ColumnHeader();
            Terapija = new ColumnHeader();
            PreporukaZaLecenje = new ColumnHeader();
            Lekar = new ColumnHeader();
            Odeljenje = new ColumnHeader();
            VrstaPregleda = new ColumnHeader();
            Termin = new ColumnHeader();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(713, 431);
            button3.Name = "button3";
            button3.Size = new Size(257, 80);
            button3.TabIndex = 23;
            button3.Text = "Dodaj";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(365, 431);
            button2.Name = "button2";
            button2.Size = new Size(257, 80);
            button2.TabIndex = 22;
            button2.Text = "Obrisi";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(25, 431);
            button1.Name = "button1";
            button1.Size = new Size(257, 80);
            button1.TabIndex = 21;
            button1.Text = "Izmeni";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Pacijent, Datum, Vreme, OpisTegoba, Dijagnoza, Terapija, PreporukaZaLecenje, Lekar, Odeljenje, VrstaPregleda, Termin });
            listView1.Location = new Point(12, 41);
            listView1.Name = "listView1";
            listView1.Size = new Size(1013, 325);
            listView1.TabIndex = 20;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Pacijent
            // 
            Pacijent.Text = "Pacijent";
            Pacijent.Width = 100;
            // 
            // Datum
            // 
            Datum.Text = "Datum";
            Datum.Width = 100;
            // 
            // Vreme
            // 
            Vreme.Text = "Vreme";
            Vreme.Width = 100;
            // 
            // OpisTegoba
            // 
            OpisTegoba.Text = "OpisTegoba";
            OpisTegoba.Width = 100;
            // 
            // Dijagnoza
            // 
            Dijagnoza.Text = "Dijagnoza";
            Dijagnoza.Width = 100;
            // 
            // Terapija
            // 
            Terapija.Text = "Terapija";
            Terapija.Width = 100;
            // 
            // PreporukaZaLecenje
            // 
            PreporukaZaLecenje.Text = "PreporukaZaLecenje";
            PreporukaZaLecenje.Width = 100;
            // 
            // Lekar
            // 
            Lekar.Text = "Lekar";
            Lekar.Width = 100;
            // 
            // Odeljenje
            // 
            Odeljenje.Text = "Odeljenje";
            Odeljenje.Width = 100;
            // 
            // VrstaPregleda
            // 
            VrstaPregleda.Text = "VrstaPregleda";
            VrstaPregleda.Width = 100;
            // 
            // IzmeniPregled
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 736);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Name = "IzmeniPregled";
            Text = "IzmeniPregled";
            ResumeLayout(false);
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private ListView listView1;
        private ColumnHeader Pacijent;
        private ColumnHeader Datum;
        private ColumnHeader Vreme;
        private ColumnHeader OpisTegoba;
        private ColumnHeader Dijagnoza;
        private ColumnHeader Terapija;
        private ColumnHeader PreporukaZaLecenje;
        private ColumnHeader Lekar;
        private ColumnHeader Odeljenje;
        private ColumnHeader VrstaPregleda;
        private ColumnHeader Termin;
    }
}