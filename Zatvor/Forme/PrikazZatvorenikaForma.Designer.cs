
namespace Zatvor.Forme
{
    partial class PrikazZatvorenikaForma
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
            this.dataGridViewZatvorenici.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewZatvorenici.MultiSelect = false;
            this.dataGridViewZatvorenici.Name = "dataGridViewZatvorenici";
            this.dataGridViewZatvorenici.ReadOnly = true;
            this.dataGridViewZatvorenici.RowHeadersVisible = false;
            this.dataGridViewZatvorenici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewZatvorenici.Size = new System.Drawing.Size(923, 426);
            this.dataGridViewZatvorenici.TabIndex = 5;
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
            // PrikazZatvorenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 450);
            this.Controls.Add(this.dataGridViewZatvorenici);
            this.Name = "PrikazZatvorenika";
            this.Text = "PrikazZatvorenika";
            this.Load += new System.EventHandler(this.PrikazZatvorenika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZatvorenici)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewZatvorenici;
        private System.Windows.Forms.DataGridViewTextBoxColumn JMBG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Broj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumSaslusanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusUslovnogOtpusta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZatvorskaJedinica;
    }
}