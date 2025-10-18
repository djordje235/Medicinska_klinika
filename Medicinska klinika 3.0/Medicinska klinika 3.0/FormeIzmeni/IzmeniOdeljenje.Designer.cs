namespace Medicinska_klinika_3._0.FormeIzmeni
{
    partial class IzmeniOdeljenje
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
            this.Naziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RadnoVreme = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BrProstorija = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Lekar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Naziv,
            this.RadnoVreme,
            this.BrProstorija,
            this.Lekar});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(21, 31);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1479, 488);
            this.listView1.TabIndex = 18;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Naziv
            // 
            this.Naziv.Text = "Naziv";
            this.Naziv.Width = 100;
            // 
            // RadnoVreme
            // 
            this.RadnoVreme.Text = "RadnoVreme";
            this.RadnoVreme.Width = 100;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1114, 556);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(386, 120);
            this.button3.TabIndex = 27;
            this.button3.Text = "Dodaj";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(545, 556);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(386, 120);
            this.button2.TabIndex = 26;
            this.button2.Text = "Obrisi";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(21, 556);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(386, 120);
            this.button1.TabIndex = 25;
            this.button1.Text = "Izmeni";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BrProstorija
            // 
            this.BrProstorija.Text = "BrProstorija";
            this.BrProstorija.Width = 100;
            // 
            // Lekar
            // 
            this.Lekar.Text = "Lekar";
            this.Lekar.Width = 100;
            // 
            // IzmeniOdeljenje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1561, 842);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Name = "IzmeniOdeljenje";
            this.Text = "IzmeniOdeljenje";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Naziv;
        private System.Windows.Forms.ColumnHeader RadnoVreme;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader BrProstorija;
        private System.Windows.Forms.ColumnHeader Lekar;
    }
}