
namespace Zatvor.Forme
{
    partial class PrekrsajiZatvorenikaForma
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewPrestupi = new System.Windows.Forms.DataGridView();
            this.PocinioId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivPrekrsaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KategorijaPrekrsaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumPrestupa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MestoPrestupa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinimalnaKazna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaximalnaKazna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpisPrekrsaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonNazad = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonObrisi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrestupi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPrestupi
            // 
            this.dataGridViewPrestupi.AllowUserToAddRows = false;
            this.dataGridViewPrestupi.AllowUserToDeleteRows = false;
            this.dataGridViewPrestupi.AllowUserToResizeColumns = false;
            this.dataGridViewPrestupi.AllowUserToResizeRows = false;
            this.dataGridViewPrestupi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPrestupi.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPrestupi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPrestupi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrestupi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PocinioId,
            this.NazivPrekrsaja,
            this.KategorijaPrekrsaja,
            this.DatumPrestupa,
            this.MestoPrestupa,
            this.MinimalnaKazna,
            this.MaximalnaKazna,
            this.OpisPrekrsaja});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPrestupi.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPrestupi.Location = new System.Drawing.Point(53, 82);
            this.dataGridViewPrestupi.MultiSelect = false;
            this.dataGridViewPrestupi.Name = "dataGridViewPrestupi";
            this.dataGridViewPrestupi.ReadOnly = true;
            this.dataGridViewPrestupi.RowHeadersVisible = false;
            this.dataGridViewPrestupi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPrestupi.Size = new System.Drawing.Size(834, 232);
            this.dataGridViewPrestupi.TabIndex = 0;
            // 
            // PocinioId
            // 
            this.PocinioId.HeaderText = "Id";
            this.PocinioId.Name = "PocinioId";
            this.PocinioId.ReadOnly = true;
            this.PocinioId.Visible = false;
            // 
            // NazivPrekrsaja
            // 
            this.NazivPrekrsaja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NazivPrekrsaja.HeaderText = "Naziv";
            this.NazivPrekrsaja.Name = "NazivPrekrsaja";
            this.NazivPrekrsaja.ReadOnly = true;
            this.NazivPrekrsaja.Width = 59;
            // 
            // KategorijaPrekrsaja
            // 
            this.KategorijaPrekrsaja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.KategorijaPrekrsaja.HeaderText = "Kategorija";
            this.KategorijaPrekrsaja.Name = "KategorijaPrekrsaja";
            this.KategorijaPrekrsaja.ReadOnly = true;
            this.KategorijaPrekrsaja.Width = 79;
            // 
            // DatumPrestupa
            // 
            this.DatumPrestupa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DatumPrestupa.HeaderText = "Datum";
            this.DatumPrestupa.Name = "DatumPrestupa";
            this.DatumPrestupa.ReadOnly = true;
            this.DatumPrestupa.Width = 63;
            // 
            // MestoPrestupa
            // 
            this.MestoPrestupa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MestoPrestupa.HeaderText = "Mesto prestupa";
            this.MestoPrestupa.Name = "MestoPrestupa";
            this.MestoPrestupa.ReadOnly = true;
            this.MestoPrestupa.Width = 96;
            // 
            // MinimalnaKazna
            // 
            this.MinimalnaKazna.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MinimalnaKazna.HeaderText = "Minimalna kazna";
            this.MinimalnaKazna.Name = "MinimalnaKazna";
            this.MinimalnaKazna.ReadOnly = true;
            this.MinimalnaKazna.Width = 102;
            // 
            // MaximalnaKazna
            // 
            this.MaximalnaKazna.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaximalnaKazna.HeaderText = "Maximalna kazna";
            this.MaximalnaKazna.Name = "MaximalnaKazna";
            this.MaximalnaKazna.ReadOnly = true;
            this.MaximalnaKazna.Width = 105;
            // 
            // OpisPrekrsaja
            // 
            this.OpisPrekrsaja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.OpisPrekrsaja.HeaderText = "Opis";
            this.OpisPrekrsaja.Name = "OpisPrekrsaja";
            this.OpisPrekrsaja.ReadOnly = true;
            this.OpisPrekrsaja.Width = 53;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 21.75F);
            this.label1.Location = new System.Drawing.Point(287, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prestupi zatvorenika";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(441, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Dodaj novi prekrsaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonNazad
            // 
            this.buttonNazad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNazad.Location = new System.Drawing.Point(767, 392);
            this.buttonNazad.Name = "buttonNazad";
            this.buttonNazad.Size = new System.Drawing.Size(120, 38);
            this.buttonNazad.TabIndex = 8;
            this.buttonNazad.Text = "Nazad";
            this.buttonNazad.UseVisualStyleBackColor = true;
            this.buttonNazad.Click += new System.EventHandler(this.buttonNazad_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(162, 330);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Prestup";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Datum prestupa";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mesto prestupa";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(162, 367);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(96, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(162, 406);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonObrisi.Location = new System.Drawing.Point(767, 333);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(120, 38);
            this.buttonObrisi.TabIndex = 15;
            this.buttonObrisi.Text = "Obrisi";
            this.buttonObrisi.UseVisualStyleBackColor = true;
            this.buttonObrisi.Click += new System.EventHandler(this.buttonObrisi_Click);
            // 
            // PrekrsajiZatvorenikaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 451);
            this.Controls.Add(this.buttonObrisi);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonNazad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewPrestupi);
            this.Name = "PrekrsajiZatvorenikaForma";
            this.Text = "PrekrsajiZatvorenika";
            this.Load += new System.EventHandler(this.PrekrsajiZatvorenika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrestupi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPrestupi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PocinioId;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivPrekrsaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn KategorijaPrekrsaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumPrestupa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MestoPrestupa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinimalnaKazna;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaximalnaKazna;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpisPrekrsaja;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonNazad;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonObrisi;
    }
}