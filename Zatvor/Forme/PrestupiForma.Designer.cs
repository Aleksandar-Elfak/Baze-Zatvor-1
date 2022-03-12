
namespace Zatvor
{
    partial class PrestupiForma
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
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.buttonNazad = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewZatvorenici = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.textBoxKategorja = new System.Windows.Forms.TextBox();
            this.textBoxMinimalnaKazna = new System.Windows.Forms.TextBox();
            this.textBoxMaximalnaKasna = new System.Windows.Forms.TextBox();
            this.textBoxOpis = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategorija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinimalnaKazna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaximalnaKazna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZatvorenici)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonObrisi.Location = new System.Drawing.Point(663, 505);
            this.buttonObrisi.MaximumSize = new System.Drawing.Size(106, 38);
            this.buttonObrisi.MinimumSize = new System.Drawing.Size(106, 38);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(106, 38);
            this.buttonObrisi.TabIndex = 21;
            this.buttonObrisi.Text = "Obrisi";
            this.buttonObrisi.UseVisualStyleBackColor = true;
            this.buttonObrisi.Click += new System.EventHandler(this.buttonObrisi_Click);
            // 
            // buttonNazad
            // 
            this.buttonNazad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNazad.Location = new System.Drawing.Point(663, 549);
            this.buttonNazad.MaximumSize = new System.Drawing.Size(106, 38);
            this.buttonNazad.MinimumSize = new System.Drawing.Size(106, 38);
            this.buttonNazad.Name = "buttonNazad";
            this.buttonNazad.Size = new System.Drawing.Size(106, 38);
            this.buttonNazad.TabIndex = 19;
            this.buttonNazad.Text = "Nazad";
            this.buttonNazad.UseVisualStyleBackColor = true;
            this.buttonNazad.Click += new System.EventHandler(this.buttonNazad_Click);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDodaj.Location = new System.Drawing.Point(663, 461);
            this.buttonDodaj.MaximumSize = new System.Drawing.Size(106, 38);
            this.buttonDodaj.MinimumSize = new System.Drawing.Size(106, 38);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(106, 38);
            this.buttonDodaj.TabIndex = 18;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 42);
            this.label1.TabIndex = 17;
            this.label1.Text = "LISTA PRESTUPA";
            // 
            // dataGridViewZatvorenici
            // 
            this.dataGridViewZatvorenici.AllowUserToAddRows = false;
            this.dataGridViewZatvorenici.AllowUserToDeleteRows = false;
            this.dataGridViewZatvorenici.AllowUserToResizeColumns = false;
            this.dataGridViewZatvorenici.AllowUserToResizeRows = false;
            this.dataGridViewZatvorenici.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewZatvorenici.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridViewZatvorenici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZatvorenici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Naziv,
            this.Kategorija,
            this.MinimalnaKazna,
            this.MaximalnaKazna,
            this.Opis});
            this.dataGridViewZatvorenici.Location = new System.Drawing.Point(36, 75);
            this.dataGridViewZatvorenici.MultiSelect = false;
            this.dataGridViewZatvorenici.Name = "dataGridViewZatvorenici";
            this.dataGridViewZatvorenici.ReadOnly = true;
            this.dataGridViewZatvorenici.RowHeadersVisible = false;
            this.dataGridViewZatvorenici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewZatvorenici.Size = new System.Drawing.Size(733, 380);
            this.dataGridViewZatvorenici.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 468);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Naziv";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 496);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Kategorija";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 522);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Minimalna kazna";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 549);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Maximalna kazna";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 577);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Opis";
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNaziv.Location = new System.Drawing.Point(141, 468);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(489, 20);
            this.textBoxNaziv.TabIndex = 28;
            this.textBoxNaziv.TextChanged += new System.EventHandler(this.textBoxNaziv_TextChanged);
            // 
            // textBoxKategorja
            // 
            this.textBoxKategorja.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxKategorja.Location = new System.Drawing.Point(141, 496);
            this.textBoxKategorja.Name = "textBoxKategorja";
            this.textBoxKategorja.Size = new System.Drawing.Size(489, 20);
            this.textBoxKategorja.TabIndex = 29;
            this.textBoxKategorja.TextChanged += new System.EventHandler(this.textBoxKategorja_TextChanged);
            // 
            // textBoxMinimalnaKazna
            // 
            this.textBoxMinimalnaKazna.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMinimalnaKazna.Location = new System.Drawing.Point(141, 523);
            this.textBoxMinimalnaKazna.Name = "textBoxMinimalnaKazna";
            this.textBoxMinimalnaKazna.Size = new System.Drawing.Size(489, 20);
            this.textBoxMinimalnaKazna.TabIndex = 30;
            this.textBoxMinimalnaKazna.TextChanged += new System.EventHandler(this.textBoxMinimalnaKazna_TextChanged);
            // 
            // textBoxMaximalnaKasna
            // 
            this.textBoxMaximalnaKasna.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMaximalnaKasna.Location = new System.Drawing.Point(141, 549);
            this.textBoxMaximalnaKasna.Name = "textBoxMaximalnaKasna";
            this.textBoxMaximalnaKasna.Size = new System.Drawing.Size(489, 20);
            this.textBoxMaximalnaKasna.TabIndex = 31;
            this.textBoxMaximalnaKasna.TextChanged += new System.EventHandler(this.textBoxMaximalnaKasna_TextChanged);
            // 
            // textBoxOpis
            // 
            this.textBoxOpis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOpis.Location = new System.Drawing.Point(141, 575);
            this.textBoxOpis.Name = "textBoxOpis";
            this.textBoxOpis.Size = new System.Drawing.Size(489, 20);
            this.textBoxOpis.TabIndex = 32;
            this.textBoxOpis.TextChanged += new System.EventHandler(this.textBoxOpis_TextChanged);
            // 
            // Id
            // 
            this.Id.HeaderText = "id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            this.Naziv.Width = 59;
            // 
            // Kategorija
            // 
            this.Kategorija.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Kategorija.HeaderText = "Kategorija";
            this.Kategorija.Name = "Kategorija";
            this.Kategorija.ReadOnly = true;
            this.Kategorija.Width = 79;
            // 
            // MinimalnaKazna
            // 
            this.MinimalnaKazna.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MinimalnaKazna.HeaderText = "Minimalna Kazna";
            this.MinimalnaKazna.Name = "MinimalnaKazna";
            this.MinimalnaKazna.ReadOnly = true;
            this.MinimalnaKazna.Width = 103;
            // 
            // MaximalnaKazna
            // 
            this.MaximalnaKazna.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaximalnaKazna.HeaderText = "Maximalna kazna";
            this.MaximalnaKazna.Name = "MaximalnaKazna";
            this.MaximalnaKazna.ReadOnly = true;
            this.MaximalnaKazna.Width = 105;
            // 
            // Opis
            // 
            this.Opis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            this.Opis.Width = 53;
            // 
            // PrestupiForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 599);
            this.Controls.Add(this.textBoxOpis);
            this.Controls.Add(this.textBoxMaximalnaKasna);
            this.Controls.Add(this.textBoxMinimalnaKazna);
            this.Controls.Add(this.textBoxKategorja);
            this.Controls.Add(this.textBoxNaziv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewZatvorenici);
            this.Controls.Add(this.buttonObrisi);
            this.Controls.Add(this.buttonNazad);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.label1);
            this.Name = "PrestupiForma";
            this.Text = "PrestupiForma";
            this.Load += new System.EventHandler(this.PrestupiForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZatvorenici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonObrisi;
        private System.Windows.Forms.Button buttonNazad;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewZatvorenici;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.TextBox textBoxKategorja;
        private System.Windows.Forms.TextBox textBoxMinimalnaKazna;
        private System.Windows.Forms.TextBox textBoxMaximalnaKasna;
        private System.Windows.Forms.TextBox textBoxOpis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategorija;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinimalnaKazna;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaximalnaKazna;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
    }
}