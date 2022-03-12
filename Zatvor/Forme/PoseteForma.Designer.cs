
namespace Zatvor.Forme
{
    partial class PoseteForma
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
            this.dataGridViewPosete = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Advokat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VremePocetka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VremeKraja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonNazad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePickerPocetak = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerKraj = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPosete)).BeginInit();
            this.SuspendLayout();
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
            this.Id,
            this.Advokat,
            this.VremePocetka,
            this.VremeKraja});
            this.dataGridViewPosete.Location = new System.Drawing.Point(83, 74);
            this.dataGridViewPosete.MultiSelect = false;
            this.dataGridViewPosete.Name = "dataGridViewPosete";
            this.dataGridViewPosete.ReadOnly = true;
            this.dataGridViewPosete.RowHeadersVisible = false;
            this.dataGridViewPosete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPosete.Size = new System.Drawing.Size(456, 219);
            this.dataGridViewPosete.TabIndex = 5;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Id.HeaderText = "id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Advokat
            // 
            this.Advokat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Advokat.HeaderText = "Advokat";
            this.Advokat.Name = "Advokat";
            this.Advokat.ReadOnly = true;
            this.Advokat.Width = 72;
            // 
            // VremePocetka
            // 
            this.VremePocetka.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.VremePocetka.HeaderText = "Vreme pocetka";
            this.VremePocetka.Name = "VremePocetka";
            this.VremePocetka.ReadOnly = true;
            this.VremePocetka.Width = 96;
            // 
            // VremeKraja
            // 
            this.VremeKraja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.VremeKraja.HeaderText = "Vreme kraja";
            this.VremeKraja.Name = "VremeKraja";
            this.VremeKraja.ReadOnly = true;
            this.VremeKraja.Width = 81;
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonObrisi.Location = new System.Drawing.Point(419, 351);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(120, 38);
            this.buttonObrisi.TabIndex = 16;
            this.buttonObrisi.Text = "Obrisi";
            this.buttonObrisi.UseVisualStyleBackColor = true;
            this.buttonObrisi.Click += new System.EventHandler(this.buttonObrisi_Click);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDodaj.Location = new System.Drawing.Point(419, 307);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(120, 38);
            this.buttonDodaj.TabIndex = 17;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonNazad
            // 
            this.buttonNazad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNazad.Location = new System.Drawing.Point(419, 395);
            this.buttonNazad.Name = "buttonNazad";
            this.buttonNazad.Size = new System.Drawing.Size(120, 38);
            this.buttonNazad.TabIndex = 18;
            this.buttonNazad.Text = "Nazad";
            this.buttonNazad.UseVisualStyleBackColor = true;
            this.buttonNazad.Click += new System.EventHandler(this.buttonNazad_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Location = new System.Drawing.Point(83, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Advokat";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.Location = new System.Drawing.Point(83, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Vreme pocetka";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.Location = new System.Drawing.Point(83, 406);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Vreme kraja";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(192, 317);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 21);
            this.comboBox1.TabIndex = 21;
            // 
            // dateTimePickerPocetak
            // 
            this.dateTimePickerPocetak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePickerPocetak.CustomFormat = "dd-MM-yyy HH:mm:ss";
            this.dateTimePickerPocetak.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerPocetak.Location = new System.Drawing.Point(192, 362);
            this.dateTimePickerPocetak.Name = "dateTimePickerPocetak";
            this.dateTimePickerPocetak.Size = new System.Drawing.Size(176, 20);
            this.dateTimePickerPocetak.TabIndex = 22;
            // 
            // dateTimePickerKraj
            // 
            this.dateTimePickerKraj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePickerKraj.CustomFormat = "dd-MM-yyy HH:mm:ss";
            this.dateTimePickerKraj.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerKraj.Location = new System.Drawing.Point(192, 406);
            this.dateTimePickerKraj.Name = "dateTimePickerKraj";
            this.dateTimePickerKraj.Size = new System.Drawing.Size(176, 20);
            this.dateTimePickerKraj.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(185, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 42);
            this.label4.TabIndex = 25;
            this.label4.Text = "LISTA POSETA";
            // 
            // PoseteForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerKraj);
            this.Controls.Add(this.dateTimePickerPocetak);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNazad);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.buttonObrisi);
            this.Controls.Add(this.dataGridViewPosete);
            this.Name = "PoseteForma";
            this.Text = "PoseteForma";
            this.Load += new System.EventHandler(this.PoseteForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPosete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPosete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Advokat;
        private System.Windows.Forms.DataGridViewTextBoxColumn VremePocetka;
        private System.Windows.Forms.DataGridViewTextBoxColumn VremeKraja;
        private System.Windows.Forms.Button buttonObrisi;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonNazad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerPocetak;
        private System.Windows.Forms.DateTimePicker dateTimePickerKraj;
        private System.Windows.Forms.Label label4;
    }
}