
namespace Zatvor.Forme
{
    partial class ZastupaForma
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
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerPoslednjiKontakt = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerZastupaOd = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonNazad = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.dataGridViewZastupa = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdAdvokata = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Advokat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZastupaOd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PoslednjiKontakt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZastupa)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(123, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(316, 42);
            this.label4.TabIndex = 36;
            this.label4.Text = "LISTA AVOKATA";
            // 
            // dateTimePickerPoslednjiKontakt
            // 
            this.dateTimePickerPoslednjiKontakt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePickerPoslednjiKontakt.CustomFormat = "dd-MM-yyy";
            this.dateTimePickerPoslednjiKontakt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerPoslednjiKontakt.Location = new System.Drawing.Point(136, 413);
            this.dateTimePickerPoslednjiKontakt.Name = "dateTimePickerPoslednjiKontakt";
            this.dateTimePickerPoslednjiKontakt.Size = new System.Drawing.Size(105, 20);
            this.dateTimePickerPoslednjiKontakt.TabIndex = 35;
            // 
            // dateTimePickerZastupaOd
            // 
            this.dateTimePickerZastupaOd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePickerZastupaOd.CustomFormat = "dd-MM-yyy ";
            this.dateTimePickerZastupaOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerZastupaOd.Location = new System.Drawing.Point(136, 369);
            this.dateTimePickerZastupaOd.Name = "dateTimePickerZastupaOd";
            this.dateTimePickerZastupaOd.Size = new System.Drawing.Size(105, 20);
            this.dateTimePickerZastupaOd.TabIndex = 34;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(136, 324);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 21);
            this.comboBox1.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.Location = new System.Drawing.Point(27, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Poslednji kontakt";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.Location = new System.Drawing.Point(27, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Zastupa od";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Location = new System.Drawing.Point(27, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Advokat";
            // 
            // buttonNazad
            // 
            this.buttonNazad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNazad.Location = new System.Drawing.Point(413, 402);
            this.buttonNazad.Name = "buttonNazad";
            this.buttonNazad.Size = new System.Drawing.Size(120, 38);
            this.buttonNazad.TabIndex = 30;
            this.buttonNazad.Text = "Nazad";
            this.buttonNazad.UseVisualStyleBackColor = true;
            this.buttonNazad.Click += new System.EventHandler(this.buttonNazad_Click);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDodaj.Location = new System.Drawing.Point(413, 314);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(120, 38);
            this.buttonDodaj.TabIndex = 29;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonObrisi.Location = new System.Drawing.Point(413, 358);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(120, 38);
            this.buttonObrisi.TabIndex = 28;
            this.buttonObrisi.Text = "Obrisi";
            this.buttonObrisi.UseVisualStyleBackColor = true;
            this.buttonObrisi.Click += new System.EventHandler(this.buttonObrisi_Click);
            // 
            // dataGridViewZastupa
            // 
            this.dataGridViewZastupa.AllowUserToAddRows = false;
            this.dataGridViewZastupa.AllowUserToDeleteRows = false;
            this.dataGridViewZastupa.AllowUserToResizeColumns = false;
            this.dataGridViewZastupa.AllowUserToResizeRows = false;
            this.dataGridViewZastupa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewZastupa.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridViewZastupa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZastupa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.IdAdvokata,
            this.Advokat,
            this.ZastupaOd,
            this.PoslednjiKontakt});
            this.dataGridViewZastupa.Location = new System.Drawing.Point(27, 81);
            this.dataGridViewZastupa.MultiSelect = false;
            this.dataGridViewZastupa.Name = "dataGridViewZastupa";
            this.dataGridViewZastupa.ReadOnly = true;
            this.dataGridViewZastupa.RowHeadersVisible = false;
            this.dataGridViewZastupa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewZastupa.Size = new System.Drawing.Size(506, 219);
            this.dataGridViewZastupa.TabIndex = 27;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Id.HeaderText = "id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 21;
            // 
            // IdAdvokata
            // 
            this.IdAdvokata.HeaderText = "Id advokata";
            this.IdAdvokata.Name = "IdAdvokata";
            this.IdAdvokata.ReadOnly = true;
            this.IdAdvokata.Visible = false;
            // 
            // Advokat
            // 
            this.Advokat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Advokat.HeaderText = "Advokat";
            this.Advokat.Name = "Advokat";
            this.Advokat.ReadOnly = true;
            this.Advokat.Width = 72;
            // 
            // ZastupaOd
            // 
            this.ZastupaOd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ZastupaOd.HeaderText = "Zastupa od";
            this.ZastupaOd.Name = "ZastupaOd";
            this.ZastupaOd.ReadOnly = true;
            this.ZastupaOd.Width = 86;
            // 
            // PoslednjiKontakt
            // 
            this.PoslednjiKontakt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PoslednjiKontakt.HeaderText = "Poslednji kontakt";
            this.PoslednjiKontakt.Name = "PoslednjiKontakt";
            this.PoslednjiKontakt.ReadOnly = true;
            this.PoslednjiKontakt.Width = 104;
            // 
            // ZastupaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerPoslednjiKontakt);
            this.Controls.Add(this.dateTimePickerZastupaOd);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNazad);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.buttonObrisi);
            this.Controls.Add(this.dataGridViewZastupa);
            this.Name = "ZastupaForma";
            this.Text = "ZastupaForma";
            this.Load += new System.EventHandler(this.ZastupaForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZastupa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerPoslednjiKontakt;
        private System.Windows.Forms.DateTimePicker dateTimePickerZastupaOd;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonNazad;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonObrisi;
        private System.Windows.Forms.DataGridView dataGridViewZastupa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAdvokata;
        private System.Windows.Forms.DataGridViewTextBoxColumn Advokat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZastupaOd;
        private System.Windows.Forms.DataGridViewTextBoxColumn PoslednjiKontakt;
    }
}