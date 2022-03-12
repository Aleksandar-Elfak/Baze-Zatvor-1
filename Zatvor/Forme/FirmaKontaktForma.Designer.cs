
namespace Zatvor.Forme
{
    partial class FirmaKontaktForma
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
            this.textBoxPoseta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.buttonNazad = new System.Windows.Forms.Button();
            this.dataGridViewPosete = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TerminPosete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPosete)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPoseta
            // 
            this.textBoxPoseta.Location = new System.Drawing.Point(16, 279);
            this.textBoxPoseta.Name = "textBoxPoseta";
            this.textBoxPoseta.Size = new System.Drawing.Size(131, 20);
            this.textBoxPoseta.TabIndex = 24;
            this.textBoxPoseta.TextChanged += new System.EventHandler(this.textBoxPoseta_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Termin posete";
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(16, 305);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(131, 23);
            this.buttonDodaj.TabIndex = 22;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.Location = new System.Drawing.Point(16, 334);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(131, 23);
            this.buttonObrisi.TabIndex = 21;
            this.buttonObrisi.Text = "Obrisi";
            this.buttonObrisi.UseVisualStyleBackColor = true;
            this.buttonObrisi.Click += new System.EventHandler(this.buttonObrisi_Click);
            // 
            // buttonNazad
            // 
            this.buttonNazad.Location = new System.Drawing.Point(16, 363);
            this.buttonNazad.Name = "buttonNazad";
            this.buttonNazad.Size = new System.Drawing.Size(131, 23);
            this.buttonNazad.TabIndex = 20;
            this.buttonNazad.Text = "Nazad";
            this.buttonNazad.UseVisualStyleBackColor = true;
            this.buttonNazad.Click += new System.EventHandler(this.buttonNazad_Click);
            // 
            // dataGridViewPosete
            // 
            this.dataGridViewPosete.AllowUserToAddRows = false;
            this.dataGridViewPosete.AllowUserToDeleteRows = false;
            this.dataGridViewPosete.AllowUserToResizeColumns = false;
            this.dataGridViewPosete.AllowUserToResizeRows = false;
            this.dataGridViewPosete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPosete.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridViewPosete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPosete.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.TerminPosete});
            this.dataGridViewPosete.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewPosete.MultiSelect = false;
            this.dataGridViewPosete.Name = "dataGridViewPosete";
            this.dataGridViewPosete.ReadOnly = true;
            this.dataGridViewPosete.RowHeadersVisible = false;
            this.dataGridViewPosete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPosete.Size = new System.Drawing.Size(136, 248);
            this.dataGridViewPosete.TabIndex = 19;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // TerminPosete
            // 
            this.TerminPosete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TerminPosete.HeaderText = "Termin posete";
            this.TerminPosete.Name = "TerminPosete";
            this.TerminPosete.ReadOnly = true;
            this.TerminPosete.Width = 99;
            // 
            // FirmaKontaktForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(160, 392);
            this.Controls.Add(this.textBoxPoseta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.buttonObrisi);
            this.Controls.Add(this.buttonNazad);
            this.Controls.Add(this.dataGridViewPosete);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(176, 431);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(176, 431);
            this.Name = "FirmaKontaktForma";
            this.Text = "FirmaKontaktForma";
            this.Load += new System.EventHandler(this.FirmaKontaktForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPosete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPoseta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonObrisi;
        private System.Windows.Forms.Button buttonNazad;
        private System.Windows.Forms.DataGridView dataGridViewPosete;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn TerminPosete;
    }
}