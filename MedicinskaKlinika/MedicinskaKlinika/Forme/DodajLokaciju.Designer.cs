namespace MedicinskaKlinika.Forme
{
    partial class DodajLokaciju
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
            datzaptextBox = new TextBox();
            datumzaposlenjalabel = new Label();
            jmbgtextBox = new TextBox();
            jmbglabel = new Label();
            dodajlekaralabel = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // datzaptextBox
            // 
            datzaptextBox.Location = new Point(46, 266);
            datzaptextBox.Name = "datzaptextBox";
            datzaptextBox.Size = new Size(432, 31);
            datzaptextBox.TabIndex = 28;
            // 
            // datumzaposlenjalabel
            // 
            datumzaposlenjalabel.AutoSize = true;
            datumzaposlenjalabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datumzaposlenjalabel.Location = new Point(46, 225);
            datumzaposlenjalabel.Name = "datumzaposlenjalabel";
            datumzaposlenjalabel.Size = new Size(190, 38);
            datumzaposlenjalabel.TabIndex = 27;
            datumzaposlenjalabel.Text = "Radno Vreme:";
            // 
            // jmbgtextBox
            // 
            jmbgtextBox.Location = new Point(46, 174);
            jmbgtextBox.Name = "jmbgtextBox";
            jmbgtextBox.Size = new Size(432, 31);
            jmbgtextBox.TabIndex = 26;
            // 
            // jmbglabel
            // 
            jmbglabel.AutoSize = true;
            jmbglabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            jmbglabel.Location = new Point(46, 133);
            jmbglabel.Name = "jmbglabel";
            jmbglabel.Size = new Size(108, 38);
            jmbglabel.TabIndex = 25;
            jmbglabel.Text = "Adresa:";
            // 
            // dodajlekaralabel
            // 
            dodajlekaralabel.AutoSize = true;
            dodajlekaralabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dodajlekaralabel.Location = new Point(46, 50);
            dodajlekaralabel.Name = "dodajlekaralabel";
            dodajlekaralabel.Size = new Size(328, 65);
            dodajlekaralabel.TabIndex = 24;
            dodajlekaralabel.Text = "Dodaj lokaciju";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(46, 362);
            button1.Name = "button1";
            button1.Size = new Size(235, 52);
            button1.TabIndex = 43;
            button1.Text = "Sacuvaj";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(349, 362);
            button2.Name = "button2";
            button2.Size = new Size(235, 52);
            button2.TabIndex = 44;
            button2.Text = "Otkazi";
            button2.UseVisualStyleBackColor = true;
            // 
            // DodajLokaciju
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
            Name = "DodajLokaciju";
            Text = "DodajLokaciju";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox datzaptextBox;
        private Label datumzaposlenjalabel;
        private TextBox jmbgtextBox;
        private Label jmbglabel;
        private Label dodajlekaralabel;
        private Button button1;
        private Button button2;
    }
}