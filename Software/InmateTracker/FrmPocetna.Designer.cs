﻿namespace InmateTracker
{
    partial class FrmPocetna
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
            this.dgvOsobniUredaji = new System.Windows.Forms.DataGridView();
            this.BtnDodaj = new System.Windows.Forms.Button();
            this.BtnUredi = new System.Windows.Forms.Button();
            this.BtnOsvjezi = new System.Windows.Forms.Button();
            this.BtnObrisi = new System.Windows.Forms.Button();
            this.btnPretrazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOsobniUredaji)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOsobniUredaji
            // 
            this.dgvOsobniUredaji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOsobniUredaji.Location = new System.Drawing.Point(41, 15);
            this.dgvOsobniUredaji.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvOsobniUredaji.Name = "dgvOsobniUredaji";
            this.dgvOsobniUredaji.Size = new System.Drawing.Size(660, 427);
            this.dgvOsobniUredaji.TabIndex = 0;
            this.dgvOsobniUredaji.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BtnDodaj
            // 
            this.BtnDodaj.Location = new System.Drawing.Point(725, 15);
            this.BtnDodaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnDodaj.Name = "BtnDodaj";
            this.BtnDodaj.Size = new System.Drawing.Size(244, 70);
            this.BtnDodaj.TabIndex = 1;
            this.BtnDodaj.Text = "Dodaj";
            this.BtnDodaj.UseVisualStyleBackColor = true;
            this.BtnDodaj.Click += new System.EventHandler(this.BtnDodaj_Click);
            // 
            // BtnUredi
            // 
            this.BtnUredi.Location = new System.Drawing.Point(725, 103);
            this.BtnUredi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnUredi.Name = "BtnUredi";
            this.BtnUredi.Size = new System.Drawing.Size(244, 70);
            this.BtnUredi.TabIndex = 2;
            this.BtnUredi.Text = "Uredi";
            this.BtnUredi.UseVisualStyleBackColor = true;
            this.BtnUredi.Click += new System.EventHandler(this.BtnUredi_Click);
            // 
            // BtnOsvjezi
            // 
            this.BtnOsvjezi.Location = new System.Drawing.Point(725, 198);
            this.BtnOsvjezi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnOsvjezi.Name = "BtnOsvjezi";
            this.BtnOsvjezi.Size = new System.Drawing.Size(244, 68);
            this.BtnOsvjezi.TabIndex = 3;
            this.BtnOsvjezi.Text = "Osvježi";
            this.BtnOsvjezi.UseVisualStyleBackColor = true;
            this.BtnOsvjezi.Click += new System.EventHandler(this.BtnOsvjezi_Click);
            // 
            // BtnObrisi
            // 
            this.BtnObrisi.Location = new System.Drawing.Point(725, 286);
            this.BtnObrisi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnObrisi.Name = "BtnObrisi";
            this.BtnObrisi.Size = new System.Drawing.Size(244, 65);
            this.BtnObrisi.TabIndex = 4;
            this.BtnObrisi.Text = "Obriši";
            this.BtnObrisi.UseVisualStyleBackColor = true;
            this.BtnObrisi.Click += new System.EventHandler(this.BtnObrisi_Click);
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(727, 377);
            this.btnPretrazi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(243, 65);
            this.btnPretrazi.TabIndex = 5;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // FrmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.BtnObrisi);
            this.Controls.Add(this.BtnOsvjezi);
            this.Controls.Add(this.BtnUredi);
            this.Controls.Add(this.BtnDodaj);
            this.Controls.Add(this.dgvOsobniUredaji);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPocetna";
            this.Text = "Pocetna";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOsobniUredaji)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOsobniUredaji;
        private System.Windows.Forms.Button BtnDodaj;
        private System.Windows.Forms.Button BtnUredi;
        private System.Windows.Forms.Button BtnOsvjezi;
        private System.Windows.Forms.Button BtnObrisi;
        private System.Windows.Forms.Button btnPretrazi;
    }
}

