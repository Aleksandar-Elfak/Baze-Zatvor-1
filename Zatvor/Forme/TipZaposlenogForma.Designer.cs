
namespace Zatvor
{
    partial class TipZaposlenogForma
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
            this.radioButtonAdministrator = new System.Windows.Forms.RadioButton();
            this.radioButtonUpravnik = new System.Windows.Forms.RadioButton();
            this.radioButtonObezbedjenje = new System.Windows.Forms.RadioButton();
            this.radioButtonPsiholog = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonNastavi = new System.Windows.Forms.Button();
            this.buttonNazad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButtonAdministrator
            // 
            this.radioButtonAdministrator.AutoSize = true;
            this.radioButtonAdministrator.Checked = true;
            this.radioButtonAdministrator.Location = new System.Drawing.Point(229, 142);
            this.radioButtonAdministrator.Name = "radioButtonAdministrator";
            this.radioButtonAdministrator.Size = new System.Drawing.Size(185, 21);
            this.radioButtonAdministrator.TabIndex = 0;
            this.radioButtonAdministrator.TabStop = true;
            this.radioButtonAdministrator.Text = "Zaposlen u administraciji";
            this.radioButtonAdministrator.UseVisualStyleBackColor = true;
            // 
            // radioButtonUpravnik
            // 
            this.radioButtonUpravnik.AutoSize = true;
            this.radioButtonUpravnik.Location = new System.Drawing.Point(229, 191);
            this.radioButtonUpravnik.Name = "radioButtonUpravnik";
            this.radioButtonUpravnik.Size = new System.Drawing.Size(85, 21);
            this.radioButtonUpravnik.TabIndex = 1;
            this.radioButtonUpravnik.Text = "Upravnik";
            this.radioButtonUpravnik.UseVisualStyleBackColor = true;
            // 
            // radioButtonObezbedjenje
            // 
            this.radioButtonObezbedjenje.AutoSize = true;
            this.radioButtonObezbedjenje.Location = new System.Drawing.Point(229, 291);
            this.radioButtonObezbedjenje.Name = "radioButtonObezbedjenje";
            this.radioButtonObezbedjenje.Size = new System.Drawing.Size(162, 21);
            this.radioButtonObezbedjenje.TabIndex = 2;
            this.radioButtonObezbedjenje.Text = "Radnik obezbedjenja";
            this.radioButtonObezbedjenje.UseVisualStyleBackColor = true;
            // 
            // radioButtonPsiholog
            // 
            this.radioButtonPsiholog.AutoSize = true;
            this.radioButtonPsiholog.Location = new System.Drawing.Point(229, 237);
            this.radioButtonPsiholog.Name = "radioButtonPsiholog";
            this.radioButtonPsiholog.Size = new System.Drawing.Size(83, 21);
            this.radioButtonPsiholog.TabIndex = 3;
            this.radioButtonPsiholog.Text = "Psiholog";
            this.radioButtonPsiholog.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Izaberite tip zaposlenog: ";
            // 
            // buttonNastavi
            // 
            this.buttonNastavi.Location = new System.Drawing.Point(574, 356);
            this.buttonNastavi.Name = "buttonNastavi";
            this.buttonNastavi.Size = new System.Drawing.Size(150, 46);
            this.buttonNastavi.TabIndex = 5;
            this.buttonNastavi.Text = "Nastavi";
            this.buttonNastavi.UseVisualStyleBackColor = true;
            this.buttonNastavi.Click += new System.EventHandler(this.buttonNastavi_Click);
            // 
            // buttonNazad
            // 
            this.buttonNazad.Location = new System.Drawing.Point(55, 356);
            this.buttonNazad.Name = "buttonNazad";
            this.buttonNazad.Size = new System.Drawing.Size(134, 45);
            this.buttonNazad.TabIndex = 6;
            this.buttonNazad.Text = "Nazad";
            this.buttonNazad.UseVisualStyleBackColor = true;
            this.buttonNazad.Click += new System.EventHandler(this.buttonNazad_Click);
            // 
            // TipZaposlenogForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonNazad);
            this.Controls.Add(this.buttonNastavi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonPsiholog);
            this.Controls.Add(this.radioButtonObezbedjenje);
            this.Controls.Add(this.radioButtonUpravnik);
            this.Controls.Add(this.radioButtonAdministrator);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "TipZaposlenogForma";
            this.Text = "TipZaposlenogForma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonAdministrator;
        private System.Windows.Forms.RadioButton radioButtonUpravnik;
        private System.Windows.Forms.RadioButton radioButtonObezbedjenje;
        private System.Windows.Forms.RadioButton radioButtonPsiholog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonNastavi;
        private System.Windows.Forms.Button buttonNazad;
    }
}