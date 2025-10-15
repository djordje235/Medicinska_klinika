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
            comboBox1 = new ComboBox();
            label1 = new Label();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // datumrodjenjalabel
            // 
            datumrodjenjalabel.AutoSize = true;
            datumrodjenjalabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datumrodjenjalabel.Location = new Point(44, 402);
            datumrodjenjalabel.Name = "datumrodjenjalabel";
            datumrodjenjalabel.Size = new Size(167, 38);
            datumrodjenjalabel.TabIndex = 36;
            datumrodjenjalabel.Text = "Glavni lekar:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(44, 343);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(432, 31);
            textBox1.TabIndex = 35;
            // 
            // pozicijalabel
            // 
            pozicijalabel.AutoSize = true;
            pozicijalabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pozicijalabel.Location = new Point(44, 302);
            pozicijalabel.Name = "pozicijalabel";
            pozicijalabel.Size = new Size(190, 38);
            pozicijalabel.TabIndex = 34;
            pozicijalabel.Text = "Radno Vreme:";
            // 
            // datzaptextBox
            // 
            datzaptextBox.Location = new Point(44, 244);
            datzaptextBox.Name = "datzaptextBox";
            datzaptextBox.Size = new Size(432, 31);
            datzaptextBox.TabIndex = 33;
            // 
            // datumzaposlenjalabel
            // 
            datumzaposlenjalabel.AutoSize = true;
            datumzaposlenjalabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datumzaposlenjalabel.Location = new Point(44, 203);
            datumzaposlenjalabel.Name = "datumzaposlenjalabel";
            datumzaposlenjalabel.Size = new Size(197, 38);
            datumzaposlenjalabel.TabIndex = 32;
            datumzaposlenjalabel.Text = "Broj prostorija:";
            // 
            // jmbgtextBox
            // 
            jmbgtextBox.Location = new Point(44, 152);
            jmbgtextBox.Name = "jmbgtextBox";
            jmbgtextBox.Size = new Size(432, 31);
            jmbgtextBox.TabIndex = 31;
            // 
            // jmbglabel
            // 
            jmbglabel.AutoSize = true;
            jmbglabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            jmbglabel.Location = new Point(44, 111);
            jmbglabel.Name = "jmbglabel";
            jmbglabel.Size = new Size(91, 38);
            jmbglabel.TabIndex = 30;
            jmbglabel.Text = "Naziv:";
            // 
            // dodajlekaralabel
            // 
            dodajlekaralabel.AutoSize = true;
            dodajlekaralabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dodajlekaralabel.Location = new Point(44, 28);
            dodajlekaralabel.Name = "dodajlekaralabel";
            dodajlekaralabel.Size = new Size(369, 65);
            dodajlekaralabel.TabIndex = 29;
            dodajlekaralabel.Text = "Dodaj Odeljenje";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(44, 614);
            button1.Name = "button1";
            button1.Size = new Size(235, 52);
            button1.TabIndex = 43;
            button1.Text = "Sacuvaj";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(325, 614);
            button2.Name = "button2";
            button2.Size = new Size(235, 52);
            button2.TabIndex = 44;
            button2.Text = "Otkazi";
            button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(44, 551);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(432, 33);
            comboBox1.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 510);
            label1.Name = "label1";
            label1.Size = new Size(121, 38);
            label1.TabIndex = 46;
            label1.Text = "Lokacija:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(44, 443);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(432, 33);
            comboBox2.TabIndex = 47;
            // 
            // DodajOdeljenje
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 698);
            Controls.Add(comboBox2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(button1);
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
        private ComboBox comboBox1;
        private Label label1;
        private ComboBox comboBox2;
    }
}