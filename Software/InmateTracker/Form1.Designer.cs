namespace InmateTracker
{
    partial class Form1
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
            this.dgvOsobniUredaji.Location = new System.Drawing.Point(31, 12);
            this.dgvOsobniUredaji.Name = "dgvOsobniUredaji";
            this.dgvOsobniUredaji.Size = new System.Drawing.Size(495, 347);
            this.dgvOsobniUredaji.TabIndex = 0;
            this.dgvOsobniUredaji.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BtnDodaj
            // 
            this.BtnDodaj.Location = new System.Drawing.Point(544, 12);
            this.BtnDodaj.Name = "BtnDodaj";
            this.BtnDodaj.Size = new System.Drawing.Size(183, 57);
            this.BtnDodaj.TabIndex = 1;
            this.BtnDodaj.Text = "Dodaj";
            this.BtnDodaj.UseVisualStyleBackColor = true;
            this.BtnDodaj.Click += new System.EventHandler(this.BtnDodaj_Click);
            // 
            // BtnUredi
            // 
            this.BtnUredi.Location = new System.Drawing.Point(544, 84);
            this.BtnUredi.Name = "BtnUredi";
            this.BtnUredi.Size = new System.Drawing.Size(183, 57);
            this.BtnUredi.TabIndex = 2;
            this.BtnUredi.Text = "Uredi";
            this.BtnUredi.UseVisualStyleBackColor = true;
            this.BtnUredi.Click += new System.EventHandler(this.BtnUredi_Click);
            // 
            // BtnOsvjezi
            // 
            this.BtnOsvjezi.Location = new System.Drawing.Point(544, 161);
            this.BtnOsvjezi.Name = "BtnOsvjezi";
            this.BtnOsvjezi.Size = new System.Drawing.Size(183, 55);
            this.BtnOsvjezi.TabIndex = 3;
            this.BtnOsvjezi.Text = "Osvježi";
            this.BtnOsvjezi.UseVisualStyleBackColor = true;
            this.BtnOsvjezi.Click += new System.EventHandler(this.BtnOsvjezi_Click);
            // 
            // BtnObrisi
            // 
            this.BtnObrisi.Location = new System.Drawing.Point(544, 232);
            this.BtnObrisi.Name = "BtnObrisi";
            this.BtnObrisi.Size = new System.Drawing.Size(183, 53);
            this.BtnObrisi.TabIndex = 4;
            this.BtnObrisi.Text = "Obriši";
            this.BtnObrisi.UseVisualStyleBackColor = true;
            this.BtnObrisi.Click += new System.EventHandler(this.BtnObrisi_Click);
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(545, 306);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(182, 53);
            this.btnPretrazi.TabIndex = 5;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.BtnObrisi);
            this.Controls.Add(this.BtnOsvjezi);
            this.Controls.Add(this.BtnUredi);
            this.Controls.Add(this.BtnDodaj);
            this.Controls.Add(this.dgvOsobniUredaji);
            this.Name = "Form1";
            this.Text = "Form1";
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

