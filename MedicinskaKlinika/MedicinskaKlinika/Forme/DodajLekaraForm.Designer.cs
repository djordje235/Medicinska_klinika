namespace MedicinskaKlinika.Forme
{
    partial class DodajLekaraForm
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
            NumericUpDown numericUpDown1;
            fontDialog1 = new FontDialog();
            dodajlekaralabel = new Label();
            jmbglabel = new Label();
            jmbgtextBox = new TextBox();
            datumzaposlenjalabel = new Label();
            pozicijalabel = new Label();
            textBox1 = new TextBox();
            datumrodjenjalabel = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox4 = new TextBox();
            label3 = new Label();
            textBox5 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox7 = new TextBox();
            label7 = new Label();
            textBox8 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            comboBox1 = new ComboBox();
            button3 = new Button();
            button4 = new Button();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(54, 918);
            numericUpDown1.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(187, 31);
            numericUpDown1.TabIndex = 18;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // fontDialog1
            // 
            fontDialog1.Apply += fontDialog1_Apply;
            // 
            // dodajlekaralabel
            // 
            dodajlekaralabel.AutoSize = true;
            dodajlekaralabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dodajlekaralabel.Location = new Point(49, 34);
            dodajlekaralabel.Name = "dodajlekaralabel";
            dodajlekaralabel.Size = new Size(304, 65);
            dodajlekaralabel.TabIndex = 0;
            dodajlekaralabel.Text = "Dodaj Lekara";
            // 
            // jmbglabel
            // 
            jmbglabel.AutoSize = true;
            jmbglabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            jmbglabel.Location = new Point(49, 121);
            jmbglabel.Name = "jmbglabel";
            jmbglabel.Size = new Size(93, 38);
            jmbglabel.TabIndex = 1;
            jmbglabel.Text = "JMBG:";
            // 
            // jmbgtextBox
            // 
            jmbgtextBox.Location = new Point(49, 162);
            jmbgtextBox.Name = "jmbgtextBox";
            jmbgtextBox.Size = new Size(432, 31);
            jmbgtextBox.TabIndex = 2;
            // 
            // datumzaposlenjalabel
            // 
            datumzaposlenjalabel.AutoSize = true;
            datumzaposlenjalabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datumzaposlenjalabel.Location = new Point(49, 213);
            datumzaposlenjalabel.Name = "datumzaposlenjalabel";
            datumzaposlenjalabel.Size = new Size(244, 38);
            datumzaposlenjalabel.TabIndex = 3;
            datumzaposlenjalabel.Text = "Datum zaposlenja:";
            datumzaposlenjalabel.Click += label1_Click_1;
            // 
            // pozicijalabel
            // 
            pozicijalabel.AutoSize = true;
            pozicijalabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pozicijalabel.Location = new Point(49, 312);
            pozicijalabel.Name = "pozicijalabel";
            pozicijalabel.Size = new Size(115, 38);
            pozicijalabel.TabIndex = 5;
            pozicijalabel.Text = "Pozicija:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(49, 353);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(432, 31);
            textBox1.TabIndex = 6;
            // 
            // datumrodjenjalabel
            // 
            datumrodjenjalabel.AutoSize = true;
            datumrodjenjalabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datumrodjenjalabel.Location = new Point(49, 412);
            datumrodjenjalabel.Name = "datumrodjenjalabel";
            datumrodjenjalabel.Size = new Size(215, 38);
            datumrodjenjalabel.TabIndex = 7;
            datumrodjenjalabel.Text = "Datum rodjenja:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 505);
            label1.Name = "label1";
            label1.Size = new Size(108, 38);
            label1.TabIndex = 9;
            label1.Text = "Adresa:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(49, 546);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(432, 31);
            textBox3.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(49, 598);
            label2.Name = "label2";
            label2.Size = new Size(69, 38);
            label2.TabIndex = 11;
            label2.Text = "Ime:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(56, 639);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(432, 31);
            textBox4.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(49, 688);
            label3.Name = "label3";
            label3.Size = new Size(123, 38);
            label3.TabIndex = 13;
            label3.Text = "Prezime:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(54, 729);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(432, 31);
            textBox5.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(49, 781);
            label4.Name = "label4";
            label4.Size = new Size(209, 38);
            label4.TabIndex = 15;
            label4.Text = "Adresa lokacije:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(54, 877);
            label5.Name = "label5";
            label5.Size = new Size(107, 38);
            label5.TabIndex = 17;
            label5.Text = "Smena:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(54, 976);
            label6.Name = "label6";
            label6.Size = new Size(192, 38);
            label6.TabIndex = 19;
            label6.Text = "Specijalizacija:";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(54, 1026);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(432, 31);
            textBox7.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(54, 1083);
            label7.Name = "label7";
            label7.Size = new Size(166, 38);
            label7.TabIndex = 21;
            label7.Text = "Broj licence:";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(54, 1124);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(432, 31);
            textBox8.TabIndex = 22;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(532, 1018);
            button1.Name = "button1";
            button1.Size = new Size(235, 52);
            button1.TabIndex = 23;
            button1.Text = "Sacuvaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(532, 1104);
            button2.Name = "button2";
            button2.Size = new Size(235, 52);
            button2.TabIndex = 24;
            button2.Text = "Otkazi";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(49, 254);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(432, 31);
            dateTimePicker1.TabIndex = 72;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(49, 453);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(432, 31);
            dateTimePicker2.TabIndex = 73;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(54, 822);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(434, 33);
            comboBox1.TabIndex = 75;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(532, 918);
            button3.Name = "button3";
            button3.Size = new Size(235, 52);
            button3.TabIndex = 76;
            button3.Text = "Dodaj Email";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(532, 781);
            button4.Name = "button4";
            button4.Size = new Size(235, 93);
            button4.TabIndex = 77;
            button4.Text = "Dodaj kontakt telefon";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // DodajLekaraForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(813, 1050);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox8);
            Controls.Add(label7);
            Controls.Add(textBox7);
            Controls.Add(label6);
            Controls.Add(numericUpDown1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox5);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(datumrodjenjalabel);
            Controls.Add(textBox1);
            Controls.Add(pozicijalabel);
            Controls.Add(datumzaposlenjalabel);
            Controls.Add(jmbgtextBox);
            Controls.Add(jmbglabel);
            Controls.Add(dodajlekaralabel);
            Name = "DodajLekaraForm";
            Text = "DodajLekaraForm";
            Load += DodajLekaraForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontDialog fontDialog1;
        private Label dodajlekaralabel;
        private Label jmbglabel;
        private TextBox jmbgtextBox;
        private Label datumzaposlenjalabel;
        private Label pozicijalabel;
        private TextBox textBox1;
        private Label datumrodjenjalabel;
        private Label label1;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox4;
        private Label label3;
        private TextBox textBox5;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox7;
        private Label label7;
        private TextBox textBox8;
        private Button button1;
        private Button button2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private ComboBox comboBox1;
        private Button button3;
        private Button button4;
    }
}