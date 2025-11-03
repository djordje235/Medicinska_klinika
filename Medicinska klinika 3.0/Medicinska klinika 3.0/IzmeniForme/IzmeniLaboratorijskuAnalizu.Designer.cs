namespace Medicinska_klinika_3._0.FormeIzmeni
{
    partial class IzmeniLaboratorijskuAnalizu
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
            this.Pacijent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VrstaAnalize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DatumUzorkovanja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rezultat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReferentnaVrednost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vreme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Komentar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Laborant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Pacijent,
            this.VrstaAnalize,
            this.DatumUzorkovanja,
            this.Rezultat,
            this.ReferentnaVrednost,
            this.Vreme,
            this.Komentar,
            this.Laborant});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(11, 18);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1315, 391);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Pacijent
            // 
            this.Pacijent.Text = "JMBG";
            this.Pacijent.Width = 100;
            // 
            // VrstaAnalize
            // 
            this.VrstaAnalize.Text = "VrstaAnalize";
            this.VrstaAnalize.Width = 100;
            // 
            // DatumUzorkovanja
            // 
            this.DatumUzorkovanja.Text = "DatumUzorkovanja";
            this.DatumUzorkovanja.Width = 100;
            // 
            // Rezultat
            // 
            this.Rezultat.Text = "Rezultat";
            this.Rezultat.Width = 100;
            // 
            // ReferentnaVrednost
            // 
            this.ReferentnaVrednost.Text = "ReferentnaVrednost";
            this.ReferentnaVrednost.Width = 100;
            // 
            // Vreme
            // 
            this.Vreme.Text = "Vreme";
            this.Vreme.Width = 100;
            // 
            // Komentar
            // 
            this.Komentar.Text = "Komentar";
            this.Komentar.Width = 100;
            // 
            // Laborant
            // 
            this.Laborant.Text = "Laborant";
            this.Laborant.Width = 100;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(982, 439);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(343, 96);
            this.button3.TabIndex = 21;
            this.button3.Text = "Dodaj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(511, 439);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(343, 96);
            this.button2.TabIndex = 20;
            this.button2.Text = "Obrisi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(11, 439);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(343, 96);
            this.button1.TabIndex = 19;
            this.button1.Text = "Izmeni";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IzmeniLaboratorijskuAnalizu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 670);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "IzmeniLaboratorijskuAnalizu";
            this.Text = "IzmeniLaboratorijskuAnalizu";
            this.Load += new System.EventHandler(this.IzmeniLaboratorijskuAnalizu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Pacijent;
        private System.Windows.Forms.ColumnHeader VrstaAnalize;
        private System.Windows.Forms.ColumnHeader DatumUzorkovanja;
        private System.Windows.Forms.ColumnHeader Rezultat;
        private System.Windows.Forms.ColumnHeader ReferentnaVrednost;
        private System.Windows.Forms.ColumnHeader Vreme;
        private System.Windows.Forms.ColumnHeader Komentar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader Laborant;
    }
}