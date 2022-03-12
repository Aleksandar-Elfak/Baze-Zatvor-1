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

namespace Zatvor.Forme
{
    public partial class DodajZatvorForma : Form
    {
        public ZatvorskaJedinica zaIzmenu{ get; set; }
        Regex regexSifra = new Regex("^[0-9]{1,30}$");
        Regex regexZakljucavanje = new Regex("^[0-2][0-9]:[0-5][0-9]-[0-2][0-9]:[0-5][0-9]$");
        Regex regexSetnja = new Regex("^[0-2][0-9]:[0-5][0-9]-[0-2][0-9]:[0-5][0-9](\\s[0-2][0-9]:[0-5][0-9]-[0-2][0-9]:[0-5][0-9])?$");
        public DodajZatvorForma()
        {
            InitializeComponent();
        }
        private void PripremaZaIzmenu()
        {
            if(zaIzmenu != null)
            {
                textBoxSifra.Text = zaIzmenu.Sifra;
                textBoxNaziv.Text = zaIzmenu.Naziv;
                textBoxAdresa.Text = zaIzmenu.Adresa;
                numericUpDownKapacitet.Value = zaIzmenu.Kapacitet;
                if (zaIzmenu.OtvoreniF == 'Y')
                {
                    checkBoxOtvoreni.Checked = true;
                    textBoxZakljucavanje.Enabled = true;
                }
                if (zaIzmenu.PoluOtvoreniF == 'Y')
                {
                    checkBoxPoluotvoreni.Checked = true;
                    textBoxZakljucavanje.Enabled = true;
                }
                if (zaIzmenu.StrogiF == 'Y')
                {
                    checkBoxStrogi.Checked = true;
                    textBoxSetnja.Enabled = true;
                }
                textBoxZakljucavanje.Text = zaIzmenu.PeriodZakljucavanja;
                textBoxSetnja.Text = zaIzmenu.Setnja;
            }
        }
        private void ProveraTipa()
        {
            if (checkBoxOtvoreni.Checked == true || checkBoxPoluotvoreni.Checked == true || checkBoxStrogi.Checked == true)
                buttonOk.Enabled = true;
            else
                buttonOk.Enabled = false;
        }
        private void OtvoreniPoluotvoreni()
        {
            if (checkBoxOtvoreni.Checked == true || checkBoxPoluotvoreni.Checked == true)
                textBoxZakljucavanje.Enabled = true;
            else
                textBoxZakljucavanje.Enabled = false;
        }
        private void textBoxSifra_TextChanged(object sender, EventArgs e)
        {
            if (!regexSifra.IsMatch(textBoxSifra.Text))
            {
                textBoxSifra.ForeColor = Color.Red;
            }
            else
            {
                textBoxSifra.ForeColor = Color.Black;
            }
        }
        private void buttonNazad_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void textBoxNaziv_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNaziv.TextLength > 30)
            {
                textBoxNaziv.ForeColor = Color.Red;
            }
            else
            {
                textBoxNaziv.ForeColor = Color.Black;
            }
        }
        private void textBoxAdresa_TextChanged(object sender, EventArgs e)
        {
            if (textBoxAdresa.TextLength > 30)
            {
                textBoxAdresa.ForeColor = Color.Red;
            }
            else
            {
                textBoxAdresa.ForeColor = Color.Black;
            }
        }
        private void numericUpDownKapacitet_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownKapacitet.Value < 1)
            {
                numericUpDownKapacitet.ForeColor = Color.Red;
            }
            else
            {
                numericUpDownKapacitet.ForeColor = Color.Black;
            }
        }
        private void checkBoxStrogi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxStrogi.Checked == true)
                textBoxSetnja.Enabled = true;
            else
                textBoxSetnja.Enabled = false;
            ProveraTipa();
        }
        private void checkBoxOtvoreni_CheckedChanged(object sender, EventArgs e)
        {
            OtvoreniPoluotvoreni();
            ProveraTipa();
        }
        private void checkBoxPoluotvoreni_CheckedChanged(object sender, EventArgs e)
        {
            OtvoreniPoluotvoreni();
            ProveraTipa();
        }
        private void textBoxZakljucavanje_TextChanged(object sender, EventArgs e)
        {
            if (!regexZakljucavanje.IsMatch(textBoxZakljucavanje.Text))
            {
                textBoxZakljucavanje.ForeColor = Color.Red;
            }
            else
            {
                textBoxZakljucavanje.ForeColor = Color.Black;
            }
        }
        private void textBoxSetnja_TextChanged(object sender, EventArgs e)
        {
            if (!regexSetnja.IsMatch(textBoxSetnja.Text))
            {
                textBoxSetnja.ForeColor = Color.Red;
            }
            else
            {
                textBoxSetnja.ForeColor = Color.Black;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (!regexSifra.IsMatch(textBoxSifra.Text))
            {
                MessageBox.Show("Unesite validnu sifru.");
                return;
            }
            if (textBoxNaziv.TextLength > 30)
            {
                MessageBox.Show("Unesite validan naziv.");
                return;
            }
            if (textBoxAdresa.TextLength > 30)
            {
                MessageBox.Show("Unesite validnu adresu.");
                return;
            }
            if(checkBoxOtvoreni.Checked == true || checkBoxPoluotvoreni.Checked == true)
                if (!regexZakljucavanje.IsMatch(textBoxZakljucavanje.Text))
                {
                    MessageBox.Show("Primer validnog formata: 11:00-13:00");
                        return;
                }
            if(checkBoxStrogi.Checked == true)
                if (!regexSetnja.IsMatch(textBoxSetnja.Text))
                {
                    MessageBox.Show("Primer validnog formata: 11:00-13:00[ 11:00-13:00]");
                    return;
                }

            string sifra = textBoxSifra.Text;
            string naziv = textBoxNaziv.Text;
            string adresa = textBoxAdresa.Text;
            int kapacitet = (int)numericUpDownKapacitet.Value;
            char tipo = 'N';
            char tipp = 'N';
            char tips = 'N';
            string zaklucavanje = "";
            string setnja = "";
            if (checkBoxOtvoreni.Checked == true)
            {
                tipo = 'Y';
                zaklucavanje = textBoxZakljucavanje.Text;
            }
            if (checkBoxPoluotvoreni.Checked == true)
            {
                tipp = 'Y';
                zaklucavanje = textBoxZakljucavanje.Text;
            }
            if (checkBoxStrogi.Checked == true)
            {
                tips = 'Y';
                setnja = textBoxSetnja.Text;
            }

            if (zaIzmenu == null)
            {
                try
                {
                    ISession s = DataLayer.GetSession();


                    ZatvorskaJedinica z = new ZatvorskaJedinica();

                    z.Sifra = sifra;
                    z.Naziv = naziv;
                    z.Adresa = adresa;
                    z.Kapacitet = kapacitet;
                    z.OtvoreniF = tipo;
                    z.PoluOtvoreniF = tipp;
                    z.StrogiF = tips;
                    z.PeriodZakljucavanja = zaklucavanje;
                    z.Setnja = setnja;

                    s.Save(z);

                    s.Flush();
                    s.Close();
                }
                catch (Exception ec)
                {
                    if (ec.InnerException.Message == "ORA-00001: unique constraint (S17513.SYS_C00277591) violated")
                        MessageBox.Show("Vec postoji zatvor sa tom sifrom.");
                    else
                        MessageBox.Show(ec.Message);
                }
            }
            else
            {
                try
                {
                    ISession s = DataLayer.GetSession();

                    ZatvorskaJedinica z = s.Load<ZatvorskaJedinica>(zaIzmenu.Id);

                    z.Sifra = sifra;
                    z.Naziv = naziv;
                    z.Adresa = adresa;
                    z.Kapacitet = kapacitet;
                    z.OtvoreniF = tipo;
                    z.PoluOtvoreniF = tipp;
                    z.StrogiF = tips;
                    z.PeriodZakljucavanja = zaklucavanje;
                    z.Setnja = setnja;

                    s.Update(z);

                    s.Flush();
                    s.Close();

                }
                catch (Exception ec)
                {
                    if (ec.InnerException.Message == "ORA-00001: unique constraint (S17513.SYS_C00277591) violated")
                        MessageBox.Show("Vec postoji zatvor sa tom sifrom.");
                    else
                        MessageBox.Show(ec.Message);
                }
            }

            this.DialogResult = DialogResult.OK;
        }

        private void DodajZatvorForma_Load(object sender, EventArgs e)
        {
            PripremaZaIzmenu();
        }
    }
}
