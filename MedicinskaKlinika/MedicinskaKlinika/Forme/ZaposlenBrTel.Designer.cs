namespace MedicinskaKlinika.Forme
{
    partial class ZaposlenBrTel
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "BrojTelefona" }, -1, Color.Empty, SystemColors.Window, null);
            label1 = new Label();
            textBox1 = new TextBox();
            button3 = new Button();
            button1 = new Button();
            listView1 = new ListView();
            BrojTelefona = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 152);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(243, 32);
            label1.TabIndex = 84;
            label1.Text = "Unesite broj telefona:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(23, 185);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(550, 27);
            textBox1.TabIndex = 83;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(384, 239);
            button3.Margin = new Padding(2, 2, 2, 2);
            button3.Name = "button3";
            button3.Size = new Size(188, 42);
            button3.TabIndex = 82;
            button3.Text = "Izbrisi";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(23, 239);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(188, 42);
            button1.TabIndex = 81;
            button1.Text = "Dodaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { BrojTelefona });
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView1.Location = new Point(23, 27);
            listView1.Margin = new Padding(2, 2, 2, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(550, 71);
            listView1.TabIndex = 80;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // BrojTelefona
            // 
            BrojTelefona.Text = "BrojTelefona";
            // 
            // ZaposlenBrTel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(listView1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "ZaposlenBrTel";
            Text = "ZaposlenBrTel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button3;
        private Button button1;
        private ListView listView1;
        private ColumnHeader BrojTelefona;
    }
}