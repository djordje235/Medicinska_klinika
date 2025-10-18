namespace Medicinska_klinika_3._0.FormeIzmeni
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BrPolise = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OsiguravajucaKuca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pacijent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BrPolise,
            this.OsiguravajucaKuca,
            this.Pacijent});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(37, 33);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1479, 488);
            this.listView1.TabIndex = 21;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1130, 573);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(386, 120);
            this.button3.TabIndex = 36;
            this.button3.Text = "Dodaj";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(581, 573);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(386, 120);
            this.button2.TabIndex = 35;
            this.button2.Text = "Obrisi";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(37, 573);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(386, 120);
            this.button1.TabIndex = 34;
            this.button1.Text = "Izmeni";
            this.button1.UseVisualStyleBackColor = true;
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
            // Pacijent
            // 
            this.Pacijent.Text = "Pacijent";
            this.Pacijent.Width = 100;
            // 
            // IzmeniPrivatnoOsiguranje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1702, 839);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Name = "IzmeniPrivatnoOsiguranje";
            this.Text = "IzmeniPrivatnoOsiguranje";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader BrPolise;
        private System.Windows.Forms.ColumnHeader OsiguravajucaKuca;
        private System.Windows.Forms.ColumnHeader Pacijent;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}