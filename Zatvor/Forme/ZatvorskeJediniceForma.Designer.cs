
namespace Zatvor
{
    partial class ZatvorskeJediniceForma
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.buttonIzmeni = new System.Windows.Forms.Button();
            this.dataGridViewZatvori = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kapacitet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Otvoreni_F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Poluotvoreni_f = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeriodZakljucavanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Strogi_F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Setnja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Upravnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonZatvorenici = new System.Windows.Forms.Button();
            this.buttonZaposleni = new System.Windows.Forms.Button();
            this.buttonPosete = new System.Windows.Forms.Button();
            this.buttonFirme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZatvori)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(397, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "LISTA ZATVORA";
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDodaj.Location = new System.Drawing.Point(48, 442);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(164, 38);
            this.buttonDodaj.TabIndex = 2;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1077, 485);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 38);
            this.button2.TabIndex = 3;
            this.button2.Text = "Nazad";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonObrisi.Location = new System.Drawing.Point(388, 442);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(164, 38);
            this.buttonObrisi.TabIndex = 11;
            this.buttonObrisi.Text = "Obrisi";
            this.buttonObrisi.UseVisualStyleBackColor = true;
            this.buttonObrisi.Click += new System.EventHandler(this.buttonObrisi_Click);
            // 
            // buttonIzmeni
            // 
            this.buttonIzmeni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonIzmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIzmeni.Location = new System.Drawing.Point(218, 442);
            this.buttonIzmeni.Name = "buttonIzmeni";
            this.buttonIzmeni.Size = new System.Drawing.Size(164, 38);
            this.buttonIzmeni.TabIndex = 10;
            this.buttonIzmeni.Text = "Izmeni";
            this.buttonIzmeni.UseVisualStyleBackColor = true;
            this.buttonIzmeni.Click += new System.EventHandler(this.buttonIzmeni_Click);
            // 
            // dataGridViewZatvori
            // 
            this.dataGridViewZatvori.AllowUserToAddRows = false;
            this.dataGridViewZatvori.AllowUserToDeleteRows = false;
            this.dataGridViewZatvori.AllowUserToResizeColumns = false;
            this.dataGridViewZatvori.AllowUserToResizeRows = false;
            this.dataGridViewZatvori.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewZatvori.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridViewZatvori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZatvori.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Sifra,
            this.Naziv,
            this.Adresa,
            this.Kapacitet,
            this.Otvoreni_F,
            this.Poluotvoreni_f,
            this.PeriodZakljucavanja,
            this.Strogi_F,
            this.Setnja,
            this.Upravnik});
            this.dataGridViewZatvori.Location = new System.Drawing.Point(48, 66);
            this.dataGridViewZatvori.MultiSelect = false;
            this.dataGridViewZatvori.Name = "dataGridViewZatvori";
            this.dataGridViewZatvori.ReadOnly = true;
            this.dataGridViewZatvori.RowHeadersVisible = false;
            this.dataGridViewZatvori.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewZatvori.Size = new System.Drawing.Size(1097, 370);
            this.dataGridViewZatvori.TabIndex = 12;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Sifra
            // 
            this.Sifra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Sifra.HeaderText = "Sifra";
            this.Sifra.Name = "Sifra";
            this.Sifra.ReadOnly = true;
            this.Sifra.Width = 53;
            // 
            // Naziv
            // 
            this.Naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            this.Naziv.Width = 59;
            // 
            // Adresa
            // 
            this.Adresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
            this.Adresa.Width = 65;
            // 
            // Kapacitet
            // 
            this.Kapacitet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Kapacitet.HeaderText = "Kapacitet";
            this.Kapacitet.Name = "Kapacitet";
            this.Kapacitet.ReadOnly = true;
            this.Kapacitet.Width = 77;
            // 
            // Otvoreni_F
            // 
            this.Otvoreni_F.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Otvoreni_F.HeaderText = "Otvoreni tip";
            this.Otvoreni_F.Name = "Otvoreni_F";
            this.Otvoreni_F.ReadOnly = true;
            this.Otvoreni_F.Width = 79;
            // 
            // Poluotvoreni_f
            // 
            this.Poluotvoreni_f.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Poluotvoreni_f.HeaderText = "Poluotvoreni tip";
            this.Poluotvoreni_f.Name = "Poluotvoreni_f";
            this.Poluotvoreni_f.ReadOnly = true;
            this.Poluotvoreni_f.Width = 96;
            // 
            // PeriodZakljucavanja
            // 
            this.PeriodZakljucavanja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PeriodZakljucavanja.HeaderText = "Period Zakljucavanja";
            this.PeriodZakljucavanja.Name = "PeriodZakljucavanja";
            this.PeriodZakljucavanja.ReadOnly = true;
            this.PeriodZakljucavanja.Width = 121;
            // 
            // Strogi_F
            // 
            this.Strogi_F.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Strogi_F.HeaderText = "Strogi tip";
            this.Strogi_F.Name = "Strogi_F";
            this.Strogi_F.ReadOnly = true;
            this.Strogi_F.Width = 68;
            // 
            // Setnja
            // 
            this.Setnja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Setnja.HeaderText = "Setnja";
            this.Setnja.Name = "Setnja";
            this.Setnja.ReadOnly = true;
            this.Setnja.Width = 62;
            // 
            // Upravnik
            // 
            this.Upravnik.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Upravnik.HeaderText = "Upravnik";
            this.Upravnik.Name = "Upravnik";
            this.Upravnik.ReadOnly = true;
            this.Upravnik.Width = 75;
            // 
            // buttonZatvorenici
            // 
            this.buttonZatvorenici.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonZatvorenici.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZatvorenici.Location = new System.Drawing.Point(218, 486);
            this.buttonZatvorenici.Name = "buttonZatvorenici";
            this.buttonZatvorenici.Size = new System.Drawing.Size(164, 38);
            this.buttonZatvorenici.TabIndex = 14;
            this.buttonZatvorenici.Text = "Zatvorenici";
            this.buttonZatvorenici.UseVisualStyleBackColor = true;
            this.buttonZatvorenici.Click += new System.EventHandler(this.buttonZatvorenici_Click);
            // 
            // buttonZaposleni
            // 
            this.buttonZaposleni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonZaposleni.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZaposleni.Location = new System.Drawing.Point(48, 486);
            this.buttonZaposleni.Name = "buttonZaposleni";
            this.buttonZaposleni.Size = new System.Drawing.Size(164, 38);
            this.buttonZaposleni.TabIndex = 13;
            this.buttonZaposleni.Text = "Zaposleni";
            this.buttonZaposleni.UseVisualStyleBackColor = true;
            this.buttonZaposleni.Click += new System.EventHandler(this.buttonZaposleni_Click);
            // 
            // buttonPosete
            // 
            this.buttonPosete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPosete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPosete.Location = new System.Drawing.Point(388, 485);
            this.buttonPosete.Name = "buttonPosete";
            this.buttonPosete.Size = new System.Drawing.Size(164, 38);
            this.buttonPosete.TabIndex = 15;
            this.buttonPosete.Text = "Posete";
            this.buttonPosete.UseVisualStyleBackColor = true;
            this.buttonPosete.Click += new System.EventHandler(this.buttonPosete_Click);
            // 
            // buttonFirme
            // 
            this.buttonFirme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonFirme.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFirme.Location = new System.Drawing.Point(558, 486);
            this.buttonFirme.Name = "buttonFirme";
            this.buttonFirme.Size = new System.Drawing.Size(164, 38);
            this.buttonFirme.TabIndex = 16;
            this.buttonFirme.Text = "Firme";
            this.buttonFirme.UseVisualStyleBackColor = true;
            this.buttonFirme.Click += new System.EventHandler(this.buttonFirme_Click);
            // 
            // ZatvorskeJediniceForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 535);
            this.Controls.Add(this.buttonFirme);
            this.Controls.Add(this.buttonPosete);
            this.Controls.Add(this.buttonZatvorenici);
            this.Controls.Add(this.buttonZaposleni);
            this.Controls.Add(this.dataGridViewZatvori);
            this.Controls.Add(this.buttonObrisi);
            this.Controls.Add(this.buttonIzmeni);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.label1);
            this.Name = "ZatvorskeJediniceForma";
            this.Text = "ZatvorskeJedinice";
            this.Load += new System.EventHandler(this.ZatvorskeJediniceForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZatvori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonObrisi;
        private System.Windows.Forms.Button buttonIzmeni;
        private System.Windows.Forms.DataGridView dataGridViewZatvori;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kapacitet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Otvoreni_F;
        private System.Windows.Forms.DataGridViewTextBoxColumn Poluotvoreni_f;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeriodZakljucavanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Strogi_F;
        private System.Windows.Forms.DataGridViewTextBoxColumn Setnja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Upravnik;
        private System.Windows.Forms.Button buttonZatvorenici;
        private System.Windows.Forms.Button buttonZaposleni;
        private System.Windows.Forms.Button buttonPosete;
        private System.Windows.Forms.Button buttonFirme;
    }
}