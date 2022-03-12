
namespace Zatvor.Forme
{
    partial class PrikazZaposlenihForma
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
            this.dataGridViewZaposleni = new System.Windows.Forms.DataGridView();
            this.JMBG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPPZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPocetkaRada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivRadnogMesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StrucnaSprema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zanimanje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pozicija = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZaposleni)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridViewZaposleni.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridViewZaposleni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZaposleni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JMBG,
            this.Ime,
            this.Prezime,
            this.Pol,
            this.DatumPPZ,
            this.DatumPocetkaRada,
            this.NazivRadnogMesta,
            this.StrucnaSprema,
            this.Zanimanje,
            this.Pozicija});
            this.dataGridViewZaposleni.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewZaposleni.MultiSelect = false;
            this.dataGridViewZaposleni.Name = "dataGridViewZaposleni";
            this.dataGridViewZaposleni.ReadOnly = true;
            this.dataGridViewZaposleni.RowHeadersVisible = false;
            this.dataGridViewZaposleni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewZaposleni.Size = new System.Drawing.Size(915, 426);
            this.dataGridViewZaposleni.TabIndex = 5;
            // 
            // JMBG
            // 
            this.JMBG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.JMBG.HeaderText = "JMBG";
            this.JMBG.Name = "JMBG";
            this.JMBG.ReadOnly = true;
            this.JMBG.Width = 61;
            // 
            // Ime
            // 
            this.Ime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ime.HeaderText = "Ime";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            this.Ime.Width = 49;
            // 
            // Prezime
            // 
            this.Prezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            this.Prezime.Width = 69;
            // 
            // Pol
            // 
            this.Pol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Pol.HeaderText = "Pol";
            this.Pol.Name = "Pol";
            this.Pol.ReadOnly = true;
            this.Pol.Width = 47;
            // 
            // DatumPPZ
            // 
            this.DatumPPZ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DatumPPZ.HeaderText = "Datum PPZ";
            this.DatumPPZ.Name = "DatumPPZ";
            this.DatumPPZ.ReadOnly = true;
            this.DatumPPZ.Width = 80;
            // 
            // DatumPocetkaRada
            // 
            this.DatumPocetkaRada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DatumPocetkaRada.HeaderText = "Datum pocetka rada";
            this.DatumPocetkaRada.Name = "DatumPocetkaRada";
            this.DatumPocetkaRada.ReadOnly = true;
            this.DatumPocetkaRada.Width = 99;
            // 
            // NazivRadnogMesta
            // 
            this.NazivRadnogMesta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NazivRadnogMesta.HeaderText = "Naziv radnog mesta";
            this.NazivRadnogMesta.Name = "NazivRadnogMesta";
            this.NazivRadnogMesta.ReadOnly = true;
            this.NazivRadnogMesta.Width = 115;
            // 
            // StrucnaSprema
            // 
            this.StrucnaSprema.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StrucnaSprema.HeaderText = "Strucna sprema";
            this.StrucnaSprema.Name = "StrucnaSprema";
            this.StrucnaSprema.ReadOnly = true;
            this.StrucnaSprema.Width = 97;
            // 
            // Zanimanje
            // 
            this.Zanimanje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Zanimanje.HeaderText = "Zanimanje";
            this.Zanimanje.Name = "Zanimanje";
            this.Zanimanje.ReadOnly = true;
            this.Zanimanje.Width = 81;
            // 
            // Pozicija
            // 
            this.Pozicija.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Pozicija.HeaderText = "Pozicija";
            this.Pozicija.Name = "Pozicija";
            this.Pozicija.ReadOnly = true;
            this.Pozicija.Width = 68;
            // 
            // PrikazZaposlenihForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 450);
            this.Controls.Add(this.dataGridViewZaposleni);
            this.Name = "PrikazZaposlenihForma";
            this.Text = "PrikazZaposlenihForma";
            this.Load += new System.EventHandler(this.PrikazZaposlenihForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZaposleni)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewZaposleni;
        private System.Windows.Forms.DataGridViewTextBoxColumn JMBG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pol;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPPZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPocetkaRada;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivRadnogMesta;
        private System.Windows.Forms.DataGridViewTextBoxColumn StrucnaSprema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zanimanje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pozicija;
    }
}