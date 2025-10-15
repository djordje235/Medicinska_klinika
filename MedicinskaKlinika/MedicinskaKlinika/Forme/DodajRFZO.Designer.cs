namespace MedicinskaKlinika.Forme
{
    partial class DodajRFZO
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
            button2 = new Button();
            button1 = new Button();
            datzaptextBox = new TextBox();
            datumzaposlenjalabel = new Label();
            jmbgtextBox = new TextBox();
            jmbglabel = new Label();
            dodajlekaralabel = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(351, 345);
            button2.Name = "button2";
            button2.Size = new Size(235, 52);
            button2.TabIndex = 51;
            button2.Text = "Otkazi";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(48, 345);
            button1.Name = "button1";
            button1.Size = new Size(235, 52);
            button1.TabIndex = 50;
            button1.Text = "Sacuvaj";
            button1.UseVisualStyleBackColor = true;
            // 
            // datzaptextBox
            // 
            datzaptextBox.Location = new Point(48, 249);
            datzaptextBox.Name = "datzaptextBox";
            datzaptextBox.Size = new Size(432, 31);
            datzaptextBox.TabIndex = 49;
            // 
            // datumzaposlenjalabel
            // 
            datumzaposlenjalabel.AutoSize = true;
            datumzaposlenjalabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datumzaposlenjalabel.Location = new Point(48, 208);
            datumzaposlenjalabel.Name = "datumzaposlenjalabel";
            datumzaposlenjalabel.Size = new Size(251, 38);
            datumzaposlenjalabel.TabIndex = 48;
            datumzaposlenjalabel.Text = "IdKartonaPacijenta:";
            // 
            // jmbgtextBox
            // 
            jmbgtextBox.Location = new Point(48, 157);
            jmbgtextBox.Name = "jmbgtextBox";
            jmbgtextBox.Size = new Size(432, 31);
            jmbgtextBox.TabIndex = 47;
            // 
            // jmbglabel
            // 
            jmbglabel.AutoSize = true;
            jmbglabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            jmbglabel.Location = new Point(48, 116);
            jmbglabel.Name = "jmbglabel";
            jmbglabel.Size = new Size(179, 38);
            jmbglabel.TabIndex = 46;
            jmbglabel.Text = "IdOsiguranja:";
            // 
            // dodajlekaralabel
            // 
            dodajlekaralabel.AutoSize = true;
            dodajlekaralabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dodajlekaralabel.Location = new Point(48, 33);
            dodajlekaralabel.Name = "dodajlekaralabel";
            dodajlekaralabel.Size = new Size(282, 65);
            dodajlekaralabel.TabIndex = 45;
            dodajlekaralabel.Text = "Dodaj RFZO";
            // 
            // DodajRFZO
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 486);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(datzaptextBox);
            Controls.Add(datumzaposlenjalabel);
            Controls.Add(jmbgtextBox);
            Controls.Add(jmbglabel);
            Controls.Add(dodajlekaralabel);
            Name = "DodajRFZO";
            Text = "DodajRFZO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox datzaptextBox;
        private Label datumzaposlenjalabel;
        private TextBox jmbgtextBox;
        private Label jmbglabel;
        private Label dodajlekaralabel;
    }
}