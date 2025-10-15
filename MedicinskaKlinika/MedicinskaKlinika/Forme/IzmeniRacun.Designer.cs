namespace MedicinskaKlinika.Forme
{
    partial class IzmeniRacun
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
            Id = new ColumnHeader();
            Popust = new ColumnHeader();
            VrstaUsluge = new ColumnHeader();
            Datum = new ColumnHeader();
            Cena = new ColumnHeader();
            Lekar = new ColumnHeader();
            Pacijent = new ColumnHeader();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(713, 429);
            button3.Name = "button3";
            button3.Size = new Size(257, 80);
            button3.TabIndex = 27;
            button3.Text = "Dodaj";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(365, 429);
            button2.Name = "button2";
            button2.Size = new Size(257, 80);
            button2.TabIndex = 26;
            button2.Text = "Obrisi";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(25, 429);
            button1.Name = "button1";
            button1.Size = new Size(257, 80);
            button1.TabIndex = 25;
            button1.Text = "Izmeni";
            button1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Id, Popust, VrstaUsluge, Datum, Cena, Lekar, Pacijent });
            listView1.Location = new Point(12, 39);
            listView1.Name = "listView1";
            listView1.Size = new Size(1013, 325);
            listView1.TabIndex = 24;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Id
            // 
            Id.Text = "Id";
            Id.Width = 100;
            // 
            // Popust
            // 
            Popust.Text = "Popust";
            Popust.Width = 100;
            // 
            // VrstaUsluge
            // 
            VrstaUsluge.Text = "VrstaUsluge";
            VrstaUsluge.Width = 100;
            // 
            // Datum
            // 
            Datum.Text = "Datum";
            Datum.Width = 100;
            // 
            // Cena
            // 
            Cena.Text = "Cena";
            Cena.Width = 100;
            // 
            // Lekar
            // 
            Lekar.Text = "Lekar";
            Lekar.Width = 100;
            // 
            // Pacijent
            // 
            Pacijent.Text = "Pacijent";
            // 
            // IzmeniRacun
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 736);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Name = "IzmeniRacun";
            Text = "IzmeniRacun";
            ResumeLayout(false);
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private ListView listView1;
        private ColumnHeader Id;
        private ColumnHeader Popust;
        private ColumnHeader VrstaUsluge;
        private ColumnHeader Datum;
        private ColumnHeader Cena;
        private ColumnHeader Lekar;
        private ColumnHeader Pacijent;
    }
}