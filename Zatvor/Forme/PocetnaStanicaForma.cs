using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zatvor.Entiteti;

namespace Zatvor
{
    public partial class PocetnaStanicaForma : Form
    {
        public PocetnaStanicaForma()
        {
            InitializeComponent();
        }
        private void buttonPrestupi_Click(object sender, EventArgs e)
        {
            using (PrestupiForma p = new PrestupiForma())
            {
                p.ShowDialog();
            }
        }
        private void buttonZatvorenici_Click(object sender, EventArgs e)
        {
            using (ZatvoreniciForma z = new ZatvoreniciForma())
            {
                z.ShowDialog();
            }
        }

        private void buttonZaposleni_Click(object sender, EventArgs e)
        {
            using (ZaposleniForma z = new ZaposleniForma())
            {
                z.ShowDialog();
            }
        }

        private void buttonZatvorskeJedinice_Click(object sender, EventArgs e)
        {
            using (ZatvorskeJediniceForma z = new ZatvorskeJediniceForma())
            {
                z.ShowDialog();
            }
        }

        private void buttonAdvokati_Click(object sender, EventArgs e)
        {
            using (AdvokatiForma z = new AdvokatiForma())
            {
                z.ShowDialog();
            }
        }

        private void buttonFirme_Click(object sender, EventArgs e)
        {
            using (FirmeForma z = new FirmeForma())
            {
                z.ShowDialog();
            }
        }
    }
}
