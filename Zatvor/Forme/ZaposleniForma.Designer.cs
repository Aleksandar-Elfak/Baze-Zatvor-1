
namespace Zatvor
{
    partial class ZaposleniForma
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
            this.buttonIzmeni = new System.Windows.Forms.Button();
            this.dataGridViewZaposleni = new System.Windows.Forms.DataGridView();
            this.JMBG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPPZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivRadnogMesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AStrucnaSprema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AZanimanje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APozicija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZatvorskaJedinica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPocetkaRada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonNazad = new System.Windows.Forms.Button();
            this.btnDodajZaposlenog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLekarski = new System.Windows.Forms.Button();
            this.buttonOruzje = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZaposleni)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonObrisi.Location = new System.Drawing.Point(912, 548);
            this.buttonObrisi.Margin = new System.Windows.Forms.Padding(4);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(132, 47);
            this.buttonObrisi.TabIndex = 17;
            this.buttonObrisi.Text = "Obrisi";
            this.buttonObrisi.UseVisualStyleBackColor = true;
            this.buttonObrisi.Click += new System.EventHandler(this.buttonObrisi_Click);
            // 
            // buttonIzmeni
            // 
            this.buttonIzmeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIzmeni.Location = new System.Drawing.Point(1070, 548);
            this.buttonIzmeni.Margin = new System.Windows.Forms.Padding(4);
            this.buttonIzmeni.Name = "buttonIzmeni";
            this.buttonIzmeni.Size = new System.Drawing.Size(132, 47);
            this.buttonIzmeni.TabIndex = 16;
            this.buttonIzmeni.Text = "Izmeni";
            this.buttonIzmeni.UseVisualStyleBackColor = true;
            this.buttonIzmeni.Click += new System.EventHandler(this.buttonIzmeni_Click);
            // 
            // dataGridViewZaposleni
            // 
            this.dataGridViewZaposleni.AllowUserToAddRows = false;
            this.dataGridViewZaposleni.AllowUserToDeleteRows = false;
            this.dataGridViewZaposleni.AllowUserToResizeColumns = false;
            this.dataGridViewZaposleni.AllowUserToResizeRows = false;
            this.dataGridViewZaposleni.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewZaposleni.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewZaposleni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZaposleni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JMBG,
            this.Ime,
            this.Prezime,
            this.Pol,
            this.DatumPPZ,
            this.NazivRadnogMesta,
            this.AStrucnaSprema,
            this.AZanimanje,
            this.APozicija,
            this.ZatvorskaJedinica,
            this.DatumPocetkaRada});
            this.dataGridViewZaposleni.Location = new System.Drawing.Point(130, 176);
            this.dataGridViewZaposleni.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewZaposleni.MaximumSize = new System.Drawing.Size(1328, 340);
            this.dataGridViewZaposleni.MinimumSize = new System.Drawing.Size(1328, 340);
            this.dataGridViewZaposleni.MultiSelect = false;
            this.dataGridViewZaposleni.Name = "dataGridViewZaposleni";
            this.dataGridViewZaposleni.ReadOnly = true;
            this.dataGridViewZaposleni.RowHeadersVisible = false;
            this.dataGridViewZaposleni.RowHeadersWidth = 51;
            this.dataGridViewZaposleni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewZaposleni.Size = new System.Drawing.Size(1328, 340);
            this.dataGridViewZaposleni.TabIndex = 12;
            // 
            // JMBG
            // 
            this.JMBG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.JMBG.HeaderText = "JMBG";
            this.JMBG.MinimumWidth = 6;
            this.JMBG.Name = "JMBG";
            this.JMBG.ReadOnly = true;
            this.JMBG.Width = 75;
            // 
            // Ime
            // 
            this.Ime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ime.HeaderText = "Ime";
            this.Ime.MinimumWidth = 6;
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            this.Ime.Width = 59;
            // 
            // Prezime
            // 
            this.Prezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.MinimumWidth = 6;
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            this.Prezime.Width = 88;
            // 
            // Pol
            // 
            this.Pol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Pol.HeaderText = "Pol";
            this.Pol.MinimumWidth = 6;
            this.Pol.Name = "Pol";
            this.Pol.ReadOnly = true;
            this.Pol.Width = 57;
            // 
            // DatumPPZ
            // 
            this.DatumPPZ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DatumPPZ.HeaderText = "Datum PPZ";
            this.DatumPPZ.MinimumWidth = 6;
            this.DatumPPZ.Name = "DatumPPZ";
            this.DatumPPZ.ReadOnly = true;
            // 
            // NazivRadnogMesta
            // 
            this.NazivRadnogMesta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NazivRadnogMesta.HeaderText = "Naziv radnog mesta";
            this.NazivRadnogMesta.MinimumWidth = 6;
            this.NazivRadnogMesta.Name = "NazivRadnogMesta";
            this.NazivRadnogMesta.ReadOnly = true;
            this.NazivRadnogMesta.Width = 149;
            // 
            // AStrucnaSprema
            // 
            this.AStrucnaSprema.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AStrucnaSprema.HeaderText = "Strucna sprema";
            this.AStrucnaSprema.MinimumWidth = 6;
            this.AStrucnaSprema.Name = "AStrucnaSprema";
            this.AStrucnaSprema.ReadOnly = true;
            this.AStrucnaSprema.Width = 126;
            // 
            // AZanimanje
            // 
            this.AZanimanje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AZanimanje.HeaderText = "Zanimanje";
            this.AZanimanje.MinimumWidth = 6;
            this.AZanimanje.Name = "AZanimanje";
            this.AZanimanje.ReadOnly = true;
            this.AZanimanje.Width = 103;
            // 
            // APozicija
            // 
            this.APozicija.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.APozicija.HeaderText = "Pozicija";
            this.APozicija.MinimumWidth = 6;
            this.APozicija.Name = "APozicija";
            this.APozicija.ReadOnly = true;
            this.APozicija.Width = 85;
            // 
            // ZatvorskaJedinica
            // 
            this.ZatvorskaJedinica.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ZatvorskaJedinica.HeaderText = "Zatvorska jedinica";
            this.ZatvorskaJedinica.MinimumWidth = 6;
            this.ZatvorskaJedinica.Name = "ZatvorskaJedinica";
            this.ZatvorskaJedinica.ReadOnly = true;
            this.ZatvorskaJedinica.Width = 139;
            // 
            // DatumPocetkaRada
            // 
            this.DatumPocetkaRada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DatumPocetkaRada.HeaderText = "Datum pocetka rada";
            this.DatumPocetkaRada.MinimumWidth = 6;
            this.DatumPocetkaRada.Name = "DatumPocetkaRada";
            this.DatumPocetkaRada.ReadOnly = true;
            this.DatumPocetkaRada.Width = 125;
            // 
            // buttonNazad
            // 
            this.buttonNazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNazad.Location = new System.Drawing.Point(130, 548);
            this.buttonNazad.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNazad.Name = "buttonNazad";
            this.buttonNazad.Size = new System.Drawing.Size(132, 47);
            this.buttonNazad.TabIndex = 15;
            this.buttonNazad.Text = "Nazad";
            this.buttonNazad.UseVisualStyleBackColor = true;
            this.buttonNazad.Click += new System.EventHandler(this.buttonNazad_Click);
            // 
            // btnDodajZaposlenog
            // 
            this.btnDodajZaposlenog.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajZaposlenog.Location = new System.Drawing.Point(1229, 548);
            this.btnDodajZaposlenog.Margin = new System.Windows.Forms.Padding(4);
            this.btnDodajZaposlenog.Name = "btnDodajZaposlenog";
            this.btnDodajZaposlenog.Size = new System.Drawing.Size(132, 47);
            this.btnDodajZaposlenog.TabIndex = 14;
            this.btnDodajZaposlenog.Text = "Dodaj zatvor";
            this.btnDodajZaposlenog.UseVisualStyleBackColor = true;
            this.btnDodajZaposlenog.Click += new System.EventHandler(this.btnDodajZaposlenog_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(531, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 51);
            this.label1.TabIndex = 13;
            this.label1.Text = "LISTA ZAPOSLENIH";
            // 
            // buttonLekarski
            // 
            this.buttonLekarski.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLekarski.Location = new System.Drawing.Point(12, 50);
            this.buttonLekarski.Name = "buttonLekarski";
            this.buttonLekarski.Size = new System.Drawing.Size(329, 45);
            this.buttonLekarski.TabIndex = 18;
            this.buttonLekarski.Text = "Lekarski pregled";
            this.buttonLekarski.UseVisualStyleBackColor = true;
            this.buttonLekarski.Click += new System.EventHandler(this.buttonLekarski_Click);
            // 
            // buttonOruzje
            // 
            this.buttonOruzje.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOruzje.Location = new System.Drawing.Point(12, 113);
            this.buttonOruzje.Name = "buttonOruzje";
            this.buttonOruzje.Size = new System.Drawing.Size(329, 45);
            this.buttonOruzje.TabIndex = 19;
            this.buttonOruzje.Text = "Dozvola za oruzje";
            this.buttonOruzje.UseVisualStyleBackColor = true;
            this.buttonOruzje.Click += new System.EventHandler(this.buttonOruzje_Click);
            // 
            // ZaposleniForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1542, 656);
            this.Controls.Add(this.buttonOruzje);
            this.Controls.Add(this.buttonLekarski);
            this.Controls.Add(this.buttonObrisi);
            this.Controls.Add(this.buttonIzmeni);
            this.Controls.Add(this.dataGridViewZaposleni);
            this.Controls.Add(this.buttonNazad);
            this.Controls.Add(this.btnDodajZaposlenog);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1560, 703);
            this.MinimumSize = new System.Drawing.Size(1560, 703);
            this.Name = "ZaposleniForma";
            this.Text = "Zaposleni";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZaposleni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonObrisi;
        private System.Windows.Forms.Button buttonIzmeni;
        private System.Windows.Forms.DataGridView dataGridViewZaposleni;
        private System.Windows.Forms.Button buttonNazad;
        private System.Windows.Forms.Button btnDodajZaposlenog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn JMBG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPPZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivRadnogMesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn AStrucnaSprema;
        private System.Windows.Forms.DataGridViewTextBoxColumn AZanimanje;
        private System.Windows.Forms.DataGridViewTextBoxColumn APozicija;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZatvorskaJedinica;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPocetkaRada;
        private System.Windows.Forms.Button buttonLekarski;
        private System.Windows.Forms.Button buttonOruzje;
    }
}