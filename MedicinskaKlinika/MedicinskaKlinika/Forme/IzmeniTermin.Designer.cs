namespace MedicinskaKlinika.Forme
{
    partial class IzmeniTermin
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
            Odeljenje = new ColumnHeader();
            Lekar = new ColumnHeader();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(713, 429);
            button3.Name = "button3";
            button3.Size = new Size(257, 80);
            button3.TabIndex = 35;
            button3.Text = "Dodaj";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(365, 429);
            button2.Name = "button2";
            button2.Size = new Size(257, 80);
            button2.TabIndex = 34;
            button2.Text = "Obrisi";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(25, 429);
            button1.Name = "button1";
            button1.Size = new Size(257, 80);
            button1.TabIndex = 33;
            button1.Text = "Izmeni";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Pacijent, Datum, Vreme, Odeljenje, Lekar });
            listView1.Location = new Point(12, 39);
            listView1.Name = "listView1";
            listView1.Size = new Size(1013, 325);
            listView1.TabIndex = 32;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
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
            // Odeljenje
            // 
            Odeljenje.Text = "Odeljenje";
            Odeljenje.Width = 100;
            // 
            // Lekar
            // 
            Lekar.Text = "Lekar";
            Lekar.Width = 100;
            // 
            // IzmeniTermin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 736);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Name = "IzmeniTermin";
            Text = "IzmeniTermin";
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
        private ColumnHeader Odeljenje;
        private ColumnHeader Lekar;
    }
}