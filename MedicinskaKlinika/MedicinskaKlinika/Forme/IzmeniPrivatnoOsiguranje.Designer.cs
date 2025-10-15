namespace MedicinskaKlinika.Forme
{
    partial class IzmeniPrivatnoOsiguranje
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
            BrPolise = new ColumnHeader();
            OsiguravajucaKuca = new ColumnHeader();
            Pacijent = new ColumnHeader();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(713, 449);
            button3.Name = "button3";
            button3.Size = new Size(257, 80);
            button3.TabIndex = 23;
            button3.Text = "Dodaj";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(365, 449);
            button2.Name = "button2";
            button2.Size = new Size(257, 80);
            button2.TabIndex = 22;
            button2.Text = "Obrisi";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(25, 449);
            button1.Name = "button1";
            button1.Size = new Size(257, 80);
            button1.TabIndex = 21;
            button1.Text = "Izmeni";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { BrPolise, OsiguravajucaKuca, Pacijent });
            listView1.Location = new Point(12, 59);
            listView1.Name = "listView1";
            listView1.Size = new Size(1013, 325);
            listView1.TabIndex = 20;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // BrPolise
            // 
            BrPolise.Text = "BrPolise";
            BrPolise.Width = 100;
            // 
            // OsiguravajucaKuca
            // 
            OsiguravajucaKuca.Text = "OsiguravajucaKuca";
            OsiguravajucaKuca.Width = 100;
            // 
            // Pacijent
            // 
            Pacijent.Text = "Pacijent";
            Pacijent.Width = 100;
            // 
            // IzmeniPrivatnoOsiguranje
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 736);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Name = "IzmeniPrivatnoOsiguranje";
            Text = "IzmeniPrivatnoOsiguranje";
            ResumeLayout(false);
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private ListView listView1;
        private ColumnHeader BrPolise;
        private ColumnHeader OsiguravajucaKuca;
        private ColumnHeader Pacijent;
    }
}