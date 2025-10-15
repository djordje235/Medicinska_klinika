namespace MedicinskaKlinika.Forme
{
    partial class DodajOdeljenje
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
            textBox2 = new TextBox();
            datumrodjenjalabel = new Label();
            textBox1 = new TextBox();
            pozicijalabel = new Label();
            datzaptextBox = new TextBox();
            datumzaposlenjalabel = new Label();
            jmbgtextBox = new TextBox();
            jmbglabel = new Label();
            dodajlekaralabel = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(44, 468);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(432, 31);
            textBox2.TabIndex = 37;
            // 
            // datumrodjenjalabel
            // 
            datumrodjenjalabel.AutoSize = true;
            datumrodjenjalabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datumrodjenjalabel.Location = new Point(44, 427);
            datumrodjenjalabel.Name = "datumrodjenjalabel";
            datumrodjenjalabel.Size = new Size(341, 38);
            datumrodjenjalabel.TabIndex = 36;
            datumrodjenjalabel.Text = "JmbgOdogovornogLekara:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(44, 368);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(432, 31);
            textBox1.TabIndex = 35;
            // 
            // pozicijalabel
            // 
            pozicijalabel.AutoSize = true;
            pozicijalabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pozicijalabel.Location = new Point(44, 327);
            pozicijalabel.Name = "pozicijalabel";
            pozicijalabel.Size = new Size(190, 38);
            pozicijalabel.TabIndex = 34;
            pozicijalabel.Text = "Radno Vreme:";
            // 
            // datzaptextBox
            // 
            datzaptextBox.Location = new Point(44, 269);
            datzaptextBox.Name = "datzaptextBox";
            datzaptextBox.Size = new Size(432, 31);
            datzaptextBox.TabIndex = 33;
            // 
            // datumzaposlenjalabel
            // 
            datumzaposlenjalabel.AutoSize = true;
            datumzaposlenjalabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datumzaposlenjalabel.Location = new Point(44, 228);
            datumzaposlenjalabel.Name = "datumzaposlenjalabel";
            datumzaposlenjalabel.Size = new Size(197, 38);
            datumzaposlenjalabel.TabIndex = 32;
            datumzaposlenjalabel.Text = "Broj prostorija:";
            // 
            // jmbgtextBox
            // 
            jmbgtextBox.Location = new Point(44, 177);
            jmbgtextBox.Name = "jmbgtextBox";
            jmbgtextBox.Size = new Size(432, 31);
            jmbgtextBox.TabIndex = 31;
            // 
            // jmbglabel
            // 
            jmbglabel.AutoSize = true;
            jmbglabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            jmbglabel.Location = new Point(44, 136);
            jmbglabel.Name = "jmbglabel";
            jmbglabel.Size = new Size(91, 38);
            jmbglabel.TabIndex = 30;
            jmbglabel.Text = "Naziv:";
            // 
            // dodajlekaralabel
            // 
            dodajlekaralabel.AutoSize = true;
            dodajlekaralabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dodajlekaralabel.Location = new Point(44, 53);
            dodajlekaralabel.Name = "dodajlekaralabel";
            dodajlekaralabel.Size = new Size(369, 65);
            dodajlekaralabel.TabIndex = 29;
            dodajlekaralabel.Text = "Dodaj Odeljenje";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(44, 550);
            button1.Name = "button1";
            button1.Size = new Size(235, 52);
            button1.TabIndex = 43;
            button1.Text = "Sacuvaj";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(321, 550);
            button2.Name = "button2";
            button2.Size = new Size(235, 52);
            button2.TabIndex = 44;
            button2.Text = "Otkazi";
            button2.UseVisualStyleBackColor = true;
            // 
            // DodajOdeljenje
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 679);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(datumrodjenjalabel);
            Controls.Add(textBox1);
            Controls.Add(pozicijalabel);
            Controls.Add(datzaptextBox);
            Controls.Add(datumzaposlenjalabel);
            Controls.Add(jmbgtextBox);
            Controls.Add(jmbglabel);
            Controls.Add(dodajlekaralabel);
            Name = "DodajOdeljenje";
            Text = "DodajOdeljenje";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private Label datumrodjenjalabel;
        private TextBox textBox1;
        private Label pozicijalabel;
        private TextBox datzaptextBox;
        private Label datumzaposlenjalabel;
        private TextBox jmbgtextBox;
        private Label jmbglabel;
        private Label dodajlekaralabel;
        private Button button1;
        private Button button2;
    }
}