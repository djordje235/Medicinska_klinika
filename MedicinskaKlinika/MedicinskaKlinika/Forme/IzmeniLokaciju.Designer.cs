namespace MedicinskaKlinika.Forme
{
    partial class IzmeniLokaciju
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
            Adresa = new ColumnHeader();
            RadnoVreme = new ColumnHeader();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(713, 417);
            button3.Name = "button3";
            button3.Size = new Size(257, 80);
            button3.TabIndex = 19;
            button3.Text = "Dodaj";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(365, 417);
            button2.Name = "button2";
            button2.Size = new Size(257, 80);
            button2.TabIndex = 18;
            button2.Text = "Obrisi";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(25, 417);
            button1.Name = "button1";
            button1.Size = new Size(257, 80);
            button1.TabIndex = 17;
            button1.Text = "Izmeni";
            button1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Adresa, RadnoVreme });
            listView1.Location = new Point(12, 27);
            listView1.Name = "listView1";
            listView1.Size = new Size(1013, 325);
            listView1.TabIndex = 16;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Adresa
            // 
            Adresa.Text = "Adresa";
            Adresa.Width = 100;
            // 
            // RadnoVreme
            // 
            RadnoVreme.Text = "RadnoVreme";
            RadnoVreme.Width = 100;
            // 
            // IzmeniLokaciju
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 736);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Name = "IzmeniLokaciju";
            Text = "IzmeniLokaciju";
            ResumeLayout(false);
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private ListView listView1;
        private ColumnHeader Adresa;
        private ColumnHeader RadnoVreme;
    }
}