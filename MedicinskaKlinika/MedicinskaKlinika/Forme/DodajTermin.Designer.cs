namespace MedicinskaKlinika.Forme
{
    partial class DodajTermin
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
            textBox3 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            datumrodjenjalabel = new Label();
            textBox1 = new TextBox();
            pozicijalabel = new Label();
            datumzaposlenjalabel = new Label();
            jmbglabel = new Label();
            dodajlekaralabel = new Label();
            button2 = new Button();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(53, 556);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(432, 31);
            textBox3.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(53, 515);
            label1.Name = "label1";
            label1.Size = new Size(169, 38);
            label1.TabIndex = 39;
            label1.Text = "JmbgLekara:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(53, 463);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(432, 31);
            textBox2.TabIndex = 38;
            // 
            // datumrodjenjalabel
            // 
            datumrodjenjalabel.AutoSize = true;
            datumrodjenjalabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datumrodjenjalabel.Location = new Point(53, 422);
            datumrodjenjalabel.Name = "datumrodjenjalabel";
            datumrodjenjalabel.Size = new Size(212, 38);
            datumrodjenjalabel.TabIndex = 37;
            datumrodjenjalabel.Text = "Naziv odeljenja:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(53, 363);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(432, 31);
            textBox1.TabIndex = 36;
            // 
            // pozicijalabel
            // 
            pozicijalabel.AutoSize = true;
            pozicijalabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pozicijalabel.Location = new Point(53, 322);
            pozicijalabel.Name = "pozicijalabel";
            pozicijalabel.Size = new Size(141, 38);
            pozicijalabel.TabIndex = 35;
            pozicijalabel.Text = "IdKartona:";
            // 
            // datumzaposlenjalabel
            // 
            datumzaposlenjalabel.AutoSize = true;
            datumzaposlenjalabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datumzaposlenjalabel.Location = new Point(53, 223);
            datumzaposlenjalabel.Name = "datumzaposlenjalabel";
            datumzaposlenjalabel.Size = new Size(103, 38);
            datumzaposlenjalabel.TabIndex = 33;
            datumzaposlenjalabel.Text = "Vreme:";
            // 
            // jmbglabel
            // 
            jmbglabel.AutoSize = true;
            jmbglabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            jmbglabel.Location = new Point(53, 131);
            jmbglabel.Name = "jmbglabel";
            jmbglabel.Size = new Size(106, 38);
            jmbglabel.TabIndex = 31;
            jmbglabel.Text = "Datum:";
            // 
            // dodajlekaralabel
            // 
            dodajlekaralabel.AutoSize = true;
            dodajlekaralabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dodajlekaralabel.Location = new Point(53, 48);
            dodajlekaralabel.Name = "dodajlekaralabel";
            dodajlekaralabel.Size = new Size(309, 65);
            dodajlekaralabel.TabIndex = 30;
            dodajlekaralabel.Text = "Dodaj Termin";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(356, 632);
            button2.Name = "button2";
            button2.Size = new Size(235, 52);
            button2.TabIndex = 46;
            button2.Text = "Otkazi";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(53, 632);
            button1.Name = "button1";
            button1.Size = new Size(235, 52);
            button1.TabIndex = 45;
            button1.Text = "Sacuvaj";
            button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(53, 172);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(432, 31);
            dateTimePicker1.TabIndex = 73;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(53, 264);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(432, 31);
            dateTimePicker2.TabIndex = 74;
            // 
            // DodajTermin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 751);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(datumrodjenjalabel);
            Controls.Add(textBox1);
            Controls.Add(pozicijalabel);
            Controls.Add(datumzaposlenjalabel);
            Controls.Add(jmbglabel);
            Controls.Add(dodajlekaralabel);
            Name = "DodajTermin";
            Text = "DodajTermin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private Label label1;
        private TextBox textBox2;
        private Label datumrodjenjalabel;
        private TextBox textBox1;
        private Label pozicijalabel;
        private Label datumzaposlenjalabel;
        private Label jmbglabel;
        private Label dodajlekaralabel;
        private Button button2;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
    }
}