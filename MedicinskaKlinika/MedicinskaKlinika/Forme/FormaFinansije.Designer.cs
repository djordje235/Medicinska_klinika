﻿namespace MedicinskaKlinika.Forme
{
    partial class FormaFinansije
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
            label1 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(55, 12);
            label1.Name = "label1";
            label1.Size = new Size(157, 48);
            label1.TabIndex = 7;
            label1.Text = "Finansije";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(25, 101);
            button3.Name = "button3";
            button3.Size = new Size(221, 62);
            button3.TabIndex = 6;
            button3.Text = "Racun";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(25, 338);
            button2.Name = "button2";
            button2.Size = new Size(221, 62);
            button2.TabIndex = 5;
            button2.Text = "RFZO";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(25, 219);
            button1.Name = "button1";
            button1.Size = new Size(221, 62);
            button1.TabIndex = 4;
            button1.Text = "Placanje";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(25, 449);
            button4.Name = "button4";
            button4.Size = new Size(221, 106);
            button4.TabIndex = 8;
            button4.Text = "Privatno osiguranje";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // FormaFinansije
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 617);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FormaFinansije";
            Text = "FormaFinansije";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
    }
}