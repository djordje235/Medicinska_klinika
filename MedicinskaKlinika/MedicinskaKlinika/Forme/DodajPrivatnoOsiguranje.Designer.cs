namespace MedicinskaKlinika.Forme
{
    partial class DodajPrivatnoOsiguranje
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
            textBox1 = new TextBox();
            pozicijalabel = new Label();
            datumzaposlenjalabel = new Label();
            jmbgtextBox = new TextBox();
            jmbglabel = new Label();
            dodajlekaralabel = new Label();
            button2 = new Button();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(45, 354);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(432, 31);
            textBox1.TabIndex = 32;
            // 
            // pozicijalabel
            // 
            pozicijalabel.AutoSize = true;
            pozicijalabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pozicijalabel.Location = new Point(45, 313);
            pozicijalabel.Name = "pozicijalabel";
            pozicijalabel.Size = new Size(115, 38);
            pozicijalabel.TabIndex = 31;
            pozicijalabel.Text = "Pozicija:";
            // 
            // datumzaposlenjalabel
            // 
            datumzaposlenjalabel.AutoSize = true;
            datumzaposlenjalabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datumzaposlenjalabel.Location = new Point(45, 214);
            datumzaposlenjalabel.Name = "datumzaposlenjalabel";
            datumzaposlenjalabel.Size = new Size(244, 38);
            datumzaposlenjalabel.TabIndex = 29;
            datumzaposlenjalabel.Text = "Datum zaposlenja:";
            // 
            // jmbgtextBox
            // 
            jmbgtextBox.Location = new Point(45, 163);
            jmbgtextBox.Name = "jmbgtextBox";
            jmbgtextBox.Size = new Size(432, 31);
            jmbgtextBox.TabIndex = 28;
            // 
            // jmbglabel
            // 
            jmbglabel.AutoSize = true;
            jmbglabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            jmbglabel.Location = new Point(45, 122);
            jmbglabel.Name = "jmbglabel";
            jmbglabel.Size = new Size(93, 38);
            jmbglabel.TabIndex = 27;
            jmbglabel.Text = "JMBG:";
            // 
            // dodajlekaralabel
            // 
            dodajlekaralabel.AutoSize = true;
            dodajlekaralabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dodajlekaralabel.Location = new Point(45, 39);
            dodajlekaralabel.Name = "dodajlekaralabel";
            dodajlekaralabel.Size = new Size(582, 65);
            dodajlekaralabel.TabIndex = 26;
            dodajlekaralabel.Text = "Dodaj Privatno Osiguranje";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(348, 456);
            button2.Name = "button2";
            button2.Size = new Size(235, 52);
            button2.TabIndex = 46;
            button2.Text = "Otkazi";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(45, 456);
            button1.Name = "button1";
            button1.Size = new Size(235, 52);
            button1.TabIndex = 45;
            button1.Text = "Sacuvaj";
            button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(45, 255);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(432, 31);
            dateTimePicker1.TabIndex = 73;
            // 
            // DodajPrivatnoOsiguranje
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 585);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(pozicijalabel);
            Controls.Add(datumzaposlenjalabel);
            Controls.Add(jmbgtextBox);
            Controls.Add(jmbglabel);
            Controls.Add(dodajlekaralabel);
            Name = "DodajPrivatnoOsiguranje";
            Text = "DodajPrivatnoOsiguranje";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label pozicijalabel;
        private Label datumzaposlenjalabel;
        private TextBox jmbgtextBox;
        private Label jmbglabel;
        private Label dodajlekaralabel;
        private Button button2;
        private Button button1;
        private DateTimePicker dateTimePicker1;
    }
}