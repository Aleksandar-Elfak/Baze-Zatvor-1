using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zatvor
{
    public partial class TipZaposlenogForma : Form
    {
        public TipZaposlenogForma()
        {
            InitializeComponent();
        }

        private void buttonNastavi_Click(object sender, EventArgs e)
        {
            int tip;
            if (radioButtonAdministrator.Checked)
                tip = 1;
            else if (radioButtonUpravnik.Checked)
                tip = 2;
            else if (radioButtonPsiholog.Checked)
                tip = 3;
            else
                tip = 4;

            using (DodajZaposlenogForma forma = new DodajZaposlenogForma(tip, "dodavanje", null))
            {
                forma.ShowDialog();
            }
            
        }

        private void buttonNazad_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
