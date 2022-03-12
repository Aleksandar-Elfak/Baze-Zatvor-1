
namespace Zatvor.Forme
{
    partial class SaradnjeForma
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
            this.dataGridViewFirme = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxFirme = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.buttonNazad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFirme)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFirme
            // 
            this.dataGridViewFirme.AllowUserToAddRows = false;
            this.dataGridViewFirme.AllowUserToDeleteRows = false;
            this.dataGridViewFirme.AllowUserToResizeColumns = false;
            this.dataGridViewFirme.AllowUserToResizeRows = false;
            this.dataGridViewFirme.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFirme.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridViewFirme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFirme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Firma});
            this.dataGridViewFirme.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewFirme.MultiSelect = false;
            this.dataGridViewFirme.Name = "dataGridViewFirme";
            this.dataGridViewFirme.ReadOnly = true;
            this.dataGridViewFirme.RowHeadersVisible = false;
            this.dataGridViewFirme.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFirme.Size = new System.Drawing.Size(353, 331);
            this.dataGridViewFirme.TabIndex = 13;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // Firma
            // 
            this.Firma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Firma.HeaderText = "Firma";
            this.Firma.Name = "Firma";
            this.Firma.ReadOnly = true;
            this.Firma.Width = 57;
            // 
            // comboBoxFirme
            // 
            this.comboBoxFirme.FormattingEnabled = true;
            this.comboBoxFirme.Location = new System.Drawing.Point(15, 362);
            this.comboBoxFirme.Name = "comboBoxFirme";
            this.comboBoxFirme.Size = new System.Drawing.Size(172, 21);
            this.comboBoxFirme.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Firme";
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(193, 362);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(172, 23);
            this.buttonDodaj.TabIndex = 16;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.Location = new System.Drawing.Point(15, 389);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(172, 23);
            this.buttonObrisi.TabIndex = 17;
            this.buttonObrisi.Text = "Obrisi";
            this.buttonObrisi.UseVisualStyleBackColor = true;
            this.buttonObrisi.Click += new System.EventHandler(this.buttonObrisi_Click);
            // 
            // buttonNazad
            // 
            this.buttonNazad.Location = new System.Drawing.Point(193, 389);
            this.buttonNazad.Name = "buttonNazad";
            this.buttonNazad.Size = new System.Drawing.Size(172, 23);
            this.buttonNazad.TabIndex = 18;
            this.buttonNazad.Text = "Nazad";
            this.buttonNazad.UseVisualStyleBackColor = true;
            this.buttonNazad.Click += new System.EventHandler(this.buttonNazad_Click);
            // 
            // SaradnjeForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 419);
            this.Controls.Add(this.buttonNazad);
            this.Controls.Add(this.buttonObrisi);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxFirme);
            this.Controls.Add(this.dataGridViewFirme);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(393, 458);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(393, 458);
            this.Name = "SaradnjeForma";
            this.Text = "SaradnjeFroma";
            this.Load += new System.EventHandler(this.SaradnjeFroma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFirme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFirme;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firma;
        private System.Windows.Forms.ComboBox comboBoxFirme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonObrisi;
        private System.Windows.Forms.Button buttonNazad;
    }
}