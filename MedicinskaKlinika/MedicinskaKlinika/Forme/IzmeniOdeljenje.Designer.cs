namespace MedicinskaKlinika.Forme
{
    partial class IzmeniOdeljenje
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
            Naziv = new ColumnHeader();
            RadnoVreme = new ColumnHeader();
            BrProstorija = new ColumnHeader();
            Lekar = new ColumnHeader();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(570, 331);
            button3.Margin = new Padding(2, 2, 2, 2);
            button3.Name = "button3";
            button3.Size = new Size(206, 64);
            button3.TabIndex = 23;
            button3.Text = "Dodaj";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(292, 331);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(206, 64);
            button2.TabIndex = 22;
            button2.Text = "Obrisi";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(20, 331);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(206, 64);
            button1.TabIndex = 21;
            button1.Text = "Izmeni";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Naziv, RadnoVreme, BrProstorija, Lekar });
            listView1.Location = new Point(10, 19);
            listView1.Margin = new Padding(2, 2, 2, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(811, 261);
            listView1.TabIndex = 20;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Naziv
            // 
            Naziv.Text = "Naziv";
            Naziv.Width = 100;
            // 
            // RadnoVreme
            // 
            RadnoVreme.Text = "RadnoVreme";
            RadnoVreme.Width = 100;
            // 
            // BrProstorija
            // 
            BrProstorija.Text = "BrProstorija";
            BrProstorija.Width = 100;
            // 
            // Lekar
            // 
            Lekar.Text = "Lekar";
            Lekar.Width = 100;
            // 
            // IzmeniOdeljenje
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 589);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "IzmeniOdeljenje";
            Text = "IzmeniOdeljenje";
            ResumeLayout(false);
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private ListView listView1;
        private ColumnHeader Naziv;
        private ColumnHeader RadnoVreme;
        private ColumnHeader BrProstorija;
        private ColumnHeader Lekar;
    }
}