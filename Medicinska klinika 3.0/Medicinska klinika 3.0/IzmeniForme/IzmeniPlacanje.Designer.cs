namespace Medicinska_klinika_3._0.FormeIzmeni
{
    partial class IzmeniPlacanje
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.IdPlacanja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Procenat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Racun = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NacinPlacanja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PlatioPacijent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Osiguranje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BrPolise = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OsiguravajucaKuca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdPlacanja,
            this.Procenat,
            this.Racun,
            this.NacinPlacanja,
            this.PlatioPacijent,
            this.Osiguranje,
            this.BrPolise,
            this.OsiguravajucaKuca});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(28, 29);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1315, 391);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // IdPlacanja
            // 
            this.IdPlacanja.Text = "IdPlacanja";
            this.IdPlacanja.Width = 100;
            // 
            // Procenat
            // 
            this.Procenat.Text = "Procenat";
            this.Procenat.Width = 100;
            // 
            // Racun
            // 
            this.Racun.Text = "Racun";
            this.Racun.Width = 100;
            // 
            // NacinPlacanja
            // 
            this.NacinPlacanja.Text = "NacinPlacanja";
            this.NacinPlacanja.Width = 100;
            // 
            // PlatioPacijent
            // 
            this.PlatioPacijent.Text = "PlatioPacijent";
            this.PlatioPacijent.Width = 100;
            // 
            // Osiguranje
            // 
            this.Osiguranje.Text = "Osiguranje";
            this.Osiguranje.Width = 100;
            // 
            // BrPolise
            // 
            this.BrPolise.Text = "BrPolise";
            this.BrPolise.Width = 100;
            // 
            // OsiguravajucaKuca
            // 
            this.OsiguravajucaKuca.Text = "OsiguravajucaKuca";
            this.OsiguravajucaKuca.Width = 100;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1000, 455);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(343, 96);
            this.button3.TabIndex = 33;
            this.button3.Text = "Dodaj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(504, 455);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(343, 96);
            this.button2.TabIndex = 32;
            this.button2.Text = "Obrisi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(28, 455);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(343, 96);
            this.button1.TabIndex = 31;
            this.button1.Text = "Izmeni";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IzmeniPlacanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 712);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "IzmeniPlacanje";
            this.Text = "IzmeniPlacanje";
            this.Load += new System.EventHandler(this.IzmeniPlacanje_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader IdPlacanja;
        private System.Windows.Forms.ColumnHeader Procenat;
        private System.Windows.Forms.ColumnHeader Racun;
        private System.Windows.Forms.ColumnHeader NacinPlacanja;
        private System.Windows.Forms.ColumnHeader PlatioPacijent;
        private System.Windows.Forms.ColumnHeader Osiguranje;
        private System.Windows.Forms.ColumnHeader BrPolise;
        private System.Windows.Forms.ColumnHeader OsiguravajucaKuca;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}