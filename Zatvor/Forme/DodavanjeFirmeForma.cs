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
    public partial class DodavanjeFirmeForma : Form
    {
        public DodavanjeFirmeForma()
        {
            InitializeComponent();
        }



        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if (textBoxPIB.Text.Length > 30 || textBoxPIB.Text.Length < 1)
            {
                MessageBox.Show("Unesite validan broj PIB-a koji mora da ima manje od 30 karaktera ! ");
                return;
            }
            if (textBoxIme.Text.Length > 30 || textBoxIme.Text.Length < 1)
            {
                MessageBox.Show("Unesite validno ime firme koje mora da ima manje od 30 karaktera !");
                return;
            }

            Firma firma = new Firma();
            firma.Pib = textBoxPIB.Text;
            firma.ImeFirme = textBoxIme.Text;

            try
            {

                ISession s = DataLayer.GetSession();
                s.Save(firma);

                s.Flush();
                s.Close();

                MessageBox.Show("Uspesno dodavanje firme !");

            }
            catch (Exception ec)
            {
                if (ec.InnerException.Message == "ORA-00001: unique constraint (S17513.SYS_C00277581) violated")
                {
                    MessageBox.Show("Firma sa ovim PIB-om vec postoji ! ");
                }
                else
                    MessageBox.Show(ec.Message);
            }

            this.DialogResult = DialogResult.OK;

        }

        private void buttonNazad_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
