using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zatvor.Entiteti;

namespace Zatvor
{
    public partial class DodavanjeAdvokataForma : Form
    {
        Regex regexJMBG = new Regex("^[0-9]{13}$");
        Regex regexIme = new Regex("^[A-Z]{1}[a-z]{1,14}$");
        Regex regexPrezime = new Regex("^[A-Z]{1}[a-z]{1,14}(\\s?[A-Z]{1}[a-z]{1,14})?$");
        public DodavanjeAdvokataForma()
        {
            InitializeComponent();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if (!regexJMBG.IsMatch(textBoxJMBG.Text))
            {
                MessageBox.Show("Unesite validan JMBG");
                return;
            }
            if (!regexIme.IsMatch(textBoxIme.Text))
            {
                MessageBox.Show("Unesite validno ime");
                return;
            }
            if (!regexPrezime.IsMatch(textBoxPrezime.Text))
            {
                MessageBox.Show("Unesite validno prezime");
                return;
            }

            Advokat advokat = new Advokat();
            advokat.Jmbg = textBoxJMBG.Text;
            advokat.Ime = textBoxIme.Text;
            advokat.Prezime = textBoxPrezime.Text;
            if (radioButtonM.Checked)
                advokat.Pol = 'M';
            else
                advokat.Pol = 'Z';

            try
            {

                ISession s = DataLayer.GetSession();
                s.Save(advokat);

                s.Flush();
                s.Close();

                MessageBox.Show("Uspesno dodavanje advokata !");

            }
            catch (Exception ec)
            {
                if (ec.InnerException.Message == "ORA-00001: unique constraint (S17513.SYS_C00277608) violated")
                {
                    MessageBox.Show("Advokat sa ovim JMBG-om vec postoji ! ");
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

        private void textBoxPrezime_TextChanged(object sender, EventArgs e)
        {
            if (!regexPrezime.IsMatch(textBoxPrezime.Text))
            {
                textBoxPrezime.ForeColor = Color.Red;
            }
            else
            {
                textBoxPrezime.ForeColor = Color.Black;
            }
        }

        private void textBoxJMBG_TextChanged(object sender, EventArgs e)
        {

            if (!regexJMBG.IsMatch(textBoxJMBG.Text))
            {
                textBoxJMBG.ForeColor = Color.Red;
            }
            else
            {
                textBoxJMBG.ForeColor = Color.Black;
            }
        }

        private void textBoxIme_TextChanged(object sender, EventArgs e)
        {
            if (!regexIme.IsMatch(textBoxIme.Text))
            {
                textBoxIme.ForeColor = Color.Red;
            }
            else
            {
                textBoxIme.ForeColor = Color.Black;
            }
        }
    }
}
