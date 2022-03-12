
namespace Zatvor
{
    partial class ZatvoreniciForma
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
            this.dataGridViewZatvorenici = new System.Windows.Forms.DataGridView();
            this.JMBG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Broj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumSaslusanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusUslovnogOtpusta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZatvorskaJedinica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonNazad = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPrikazi = new System.Windows.Forms.Button();
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.buttonPrekrsaji = new System.Windows.Forms.Button();
            this.buttonPosete = new System.Windows.Forms.Button();
            this.buttonAdvokati = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZatvorenici)).BeginInit();
            this.SuspendLayout();
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
            this.JMBG,
            this.Ime,
            this.Prezime,
            this.Pol,
            this.Broj,
            this.Adresa,
            this.DatumSaslusanja,
            this.StatusUslovnogOtpusta,
            this.ZatvorskaJedinica});
            this.dataGridViewZatvorenici.Location = new System.Drawing.Point(98, 110);
            this.dataGridViewZatvorenici.MultiSelect = false;
            this.dataGridViewZatvorenici.Name = "dataGridViewZatvorenici";
            this.dataGridViewZatvorenici.ReadOnly = true;
            this.dataGridViewZatvorenici.RowHeadersVisible = false;
            this.dataGridViewZatvorenici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewZatvorenici.Size = new System.Drawing.Size(1046, 271);
            this.dataGridViewZatvorenici.TabIndex = 4;
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
            // Broj
            // 
            this.Broj.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Broj.HeaderText = "Broj";
            this.Broj.Name = "Broj";
            this.Broj.ReadOnly = true;
            this.Broj.Width = 50;
            // 
            // Adresa
            // 
            this.Adresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Adresa.HeaderText = "Adresa";
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
            this.Adresa.Width = 65;
            // 
            // DatumSaslusanja
            // 
            this.DatumSaslusanja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DatumSaslusanja.HeaderText = "Datum saslusanja";
            this.DatumSaslusanja.Name = "DatumSaslusanja";
            this.DatumSaslusanja.ReadOnly = true;
            this.DatumSaslusanja.Width = 105;
            // 
            // StatusUslovnogOtpusta
            // 
            this.StatusUslovnogOtpusta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.StatusUslovnogOtpusta.HeaderText = "Status Uslovnog Otpusta";
            this.StatusUslovnogOtpusta.Name = "StatusUslovnogOtpusta";
            this.StatusUslovnogOtpusta.ReadOnly = true;
            this.StatusUslovnogOtpusta.Width = 137;
            // 
            // ZatvorskaJedinica
            // 
            this.ZatvorskaJedinica.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ZatvorskaJedinica.HeaderText = "Zatvorska Jedinica";
            this.ZatvorskaJedinica.Name = "ZatvorskaJedinica";
            this.ZatvorskaJedinica.ReadOnly = true;
            this.ZatvorskaJedinica.Width = 112;
            // 
            // buttonNazad
            // 
            this.buttonNazad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNazad.Location = new System.Drawing.Point(919, 422);
            this.buttonNazad.Name = "buttonNazad";
            this.buttonNazad.Size = new System.Drawing.Size(127, 38);
            this.buttonNazad.TabIndex = 7;
            this.buttonNazad.Text = "Nazad";
            this.buttonNazad.UseVisualStyleBackColor = true;
            this.buttonNazad.Click += new System.EventHandler(this.buttonNazad_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(138, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "LISTA ZATVORENIKA";
            // 
            // buttonPrikazi
            // 
            this.buttonPrikazi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPrikazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrikazi.Location = new System.Drawing.Point(322, 402);
            this.buttonPrikazi.Name = "buttonPrikazi";
            this.buttonPrikazi.Size = new System.Drawing.Size(127, 38);
            this.buttonPrikazi.TabIndex = 8;
            this.buttonPrikazi.Text = "Izmeni";
            this.buttonPrikazi.UseVisualStyleBackColor = true;
            this.buttonPrikazi.Click += new System.EventHandler(this.buttonPrikazi_Click);
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonObrisi.Location = new System.Drawing.Point(503, 402);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(127, 38);
            this.buttonObrisi.TabIndex = 9;
            this.buttonObrisi.Text = "Obrisi";
            this.buttonObrisi.UseVisualStyleBackColor = true;
            this.buttonObrisi.Click += new System.EventHandler(this.buttonObrisi_Click);
            // 
            // buttonPrekrsaji
            // 
            this.buttonPrekrsaji.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPrekrsaji.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrekrsaji.Location = new System.Drawing.Point(138, 460);
            this.buttonPrekrsaji.Name = "buttonPrekrsaji";
            this.buttonPrekrsaji.Size = new System.Drawing.Size(127, 38);
            this.buttonPrekrsaji.TabIndex = 10;
            this.buttonPrekrsaji.Text = "Prekrsaji";
            this.buttonPrekrsaji.UseVisualStyleBackColor = true;
            this.buttonPrekrsaji.Click += new System.EventHandler(this.buttonPrekrsaji_Click);
            // 
            // buttonPosete
            // 
            this.buttonPosete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPosete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPosete.Location = new System.Drawing.Point(322, 460);
            this.buttonPosete.Name = "buttonPosete";
            this.buttonPosete.Size = new System.Drawing.Size(127, 38);
            this.buttonPosete.TabIndex = 11;
            this.buttonPosete.Text = "Posete";
            this.buttonPosete.UseVisualStyleBackColor = true;
            this.buttonPosete.Click += new System.EventHandler(this.buttonPosete_Click);
            // 
            // buttonAdvokati
            // 
            this.buttonAdvokati.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdvokati.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdvokati.Location = new System.Drawing.Point(503, 460);
            this.buttonAdvokati.Name = "buttonAdvokati";
            this.buttonAdvokati.Size = new System.Drawing.Size(127, 38);
            this.buttonAdvokati.TabIndex = 12;
            this.buttonAdvokati.Text = "Advokati";
            this.buttonAdvokati.UseVisualStyleBackColor = true;
            this.buttonAdvokati.Click += new System.EventHandler(this.buttonAdvokati_Click);
            // 
            // ZatvoreniciForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 520);
            this.Controls.Add(this.buttonAdvokati);
            this.Controls.Add(this.buttonPosete);
            this.Controls.Add(this.buttonPrekrsaji);
            this.Controls.Add(this.buttonObrisi);
            this.Controls.Add(this.buttonPrikazi);
            this.Controls.Add(this.dataGridViewZatvorenici);
            this.Controls.Add(this.buttonNazad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "ZatvoreniciForma";
            this.Text = "Zatvorenici";
            this.Load += new System.EventHandler(this.ZatvoreniciForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZatvorenici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewZatvorenici;
        private System.Windows.Forms.Button buttonNazad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPrikazi;
        private System.Windows.Forms.Button buttonObrisi;
        private System.Windows.Forms.Button buttonPrekrsaji;
        private System.Windows.Forms.DataGridViewTextBoxColumn JMBG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Broj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumSaslusanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusUslovnogOtpusta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZatvorskaJedinica;
        private System.Windows.Forms.Button buttonPosete;
        private System.Windows.Forms.Button buttonAdvokati;
    }
}