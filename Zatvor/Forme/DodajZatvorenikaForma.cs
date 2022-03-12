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
using NHibernate;
using Zatvor.Entiteti;

namespace Zatvor.Forme
{
    public partial class DodajZatvorenikaForma : Form
    {
        public Zatvorenik zaIzmenu { get; set; }
        Regex regexJMBG = new Regex("^[0-9]{13}$");
        Regex regexBroj = new Regex("^[0-9]{1,5}$");
        Regex regexIme = new Regex("^[A-Z]{1}[a-z]{1,14}$");
        Regex regexPrezime = new Regex("^[A-Z]{1}[a-z]{1,14}(\\s?[A-Z]{1}[a-z]{1,14})?$");
        List<ZatvorskaJedinica> zatvorskeJedinice = new List<ZatvorskaJedinica>();
        public DodajZatvorenikaForma()
        {
            InitializeComponent();
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
        private void textBoxAdresa_TextChanged(object sender, EventArgs e)
        {
            if (textBoxAdresa.TextLength > 40)
            {
                textBoxAdresa.ForeColor = Color.Red;
            }
            else
            {
                textBoxAdresa.ForeColor = Color.Black;
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
        private void textBoxBroj_TextChanged(object sender, EventArgs e)
        {
            if (!regexBroj.IsMatch(textBoxBroj.Text))
            {
                textBoxBroj.ForeColor = Color.Red;
            }
            else
            {
                textBoxBroj.ForeColor = Color.Black;
            }
        }
        public void PronadjiZatvorskeJedinice()
        {
            comboBoxZatvori.Items.Clear();
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from ZatvorskaJedinica");

                IEnumerable<ZatvorskaJedinica> zatvori = q.Enumerable<ZatvorskaJedinica>();

                foreach (ZatvorskaJedinica zatvor in zatvori)
                {
                    zatvorskeJedinice.Add(zatvor);
                    comboBoxZatvori.Items.Add(zatvor.Naziv);
                }
                s.Close();
                if (comboBoxZatvori.Items.Count > 0)
                    comboBoxZatvori.SelectedIndex = 0;
                comboBoxZatvori.Refresh();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

       

        private void DodajZatvorenikaForma_Load(object sender, EventArgs e)
        {
            this.CancelButton = this.btnNazad;
            this.AcceptButton = this.btnDodaj;
            PronadjiZatvorskeJedinice();
            if (zaIzmenu != null)
                PripremaZaIzmenu();
            else
            if (comboBoxUslovniOtpust.Items.Count > 0)
                comboBoxUslovniOtpust.SelectedIndex = 0;
            if (zaIzmenu != null)
                btnDodaj.Text = "Izmeni";
            else
                btnDodaj.Text = "Dodaj";
        }

        private void PripremaZaIzmenu()
        {
            textBoxIme.Text = zaIzmenu.Ime;
            textBoxPrezime.Text = zaIzmenu.Prezime;
            textBoxBroj.Text = zaIzmenu.Broj;
            textBoxJMBG.Text = zaIzmenu.Jmbg;
            if(zaIzmenu.Pol == 'M')
            {
                radioButtonPolM.Checked = true;
                radioButtonPolZ.Checked = false;
            }
            else
            {
                radioButtonPolM.Checked = false;
                radioButtonPolZ.Checked = true;
            }
            textBoxAdresa.Text = zaIzmenu.Adresa;
            if (zaIzmenu.DatumSaslusanja != null)
            {
                dateTimePickerSaslusanje.Value = (DateTime)zaIzmenu.DatumSaslusanja;
                checkBoxSaslusanje.Checked = true;
            }
            else
            {
                checkBoxSaslusanje.Checked = false;
            }
            comboBoxUslovniOtpust.SelectedIndex = zaIzmenu.StatusUslovnogOtpusta == 'Y' ? 1 : 0;
            int ind = 0;
            foreach (ZatvorskaJedinica zatvor in this.zatvorskeJedinice)
            {
                if (zatvor.Id == zaIzmenu.ZatvorskaJedinica.Id)
                    break;
                ind++;      
            }
            if (ind < zatvorskeJedinice.Count)
                comboBoxZatvori.SelectedIndex = ind;
            else
                comboBoxZatvori.SelectedIndex = -1;
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (!regexIme.IsMatch(textBoxIme.Text))
            {
                MessageBox.Show("Unesite validno ime.");
                return;
            }
            if (!regexPrezime.IsMatch(textBoxPrezime.Text))
            {
                MessageBox.Show("Unesite validno prezime.");
                return;
            }
            if (!regexBroj.IsMatch(textBoxBroj.Text))
            {
                MessageBox.Show("Unesite validan broj.");
                return;
            }
            if (!regexJMBG.IsMatch(textBoxJMBG.Text))
            {
                MessageBox.Show("Unesite valida JMBG");
                return;
            }
            if (textBoxAdresa.TextLength > 40)
            {
                MessageBox.Show("Unesite validnu adresu. (Manje od 40 karaktera)");
                return;
            }

            string ime = textBoxIme.Text;
            string prezime = textBoxPrezime.Text;
            string broj = textBoxBroj.Text;
            string jmbg = textBoxJMBG.Text;
            char pol = radioButtonPolM.Checked ? 'M' : 'Z';
            string adresa = textBoxAdresa.Text;
            DateTime saslusanje = dateTimePickerSaslusanje.Value;
            char uslovna = comboBoxUslovniOtpust.SelectedIndex == 0 ? 'N' : 'Y';
            ZatvorskaJedinica zatvor = zatvorskeJedinice[comboBoxZatvori.SelectedIndex];

            if (zaIzmenu == null)
            {
                try
                {
                    ISession s = DataLayer.GetSession();


                    Zatvorenik z = new Zatvorenik();

                    z.Ime = ime;
                    z.Prezime = prezime;
                    z.Broj = broj;
                    z.Jmbg = jmbg;
                    z.Pol = pol;
                    z.StatusUslovnogOtpusta = uslovna;
                    z.Adresa = adresa;
                    if (checkBoxSaslusanje.Checked)
                        z.DatumSaslusanja = saslusanje;
                    z.ZatvorskaJedinica = zatvor;

                    s.Save(z);

                    s.Flush();
                    s.Close();
                }
                catch (Exception ec)
                {
                    if (ec.InnerException.Message == "ORA-00001: unique constraint (S17513.SYS_C00277601) violated")
                        MessageBox.Show("Vec postoji zatvorenik sa tim brojem.");
                    else if (ec.InnerException.Message == "ORA-00001: unique constraint (S17513.SYS_C00277600) violated")
                        MessageBox.Show("Vec postoji zatvorenik sa tim JMBG-om");
                    else
                    MessageBox.Show(ec.Message);
                }
            }
            else
            {
                try
                {
                    ISession s = DataLayer.GetSession();

                    Zatvorenik z = s.Load<Zatvorenik>(zaIzmenu.Id);

                    //originalna sesija se zatvara i raskida se veza izmedju objekta i sesije
                    

                    //objekat se modifikuje potpuno nezavisno od sesije
                    z.Ime = ime;
                    z.Prezime = prezime;
                    z.Broj = broj;
                    z.Jmbg = jmbg;
                    z.Pol = pol;
                    z.StatusUslovnogOtpusta = uslovna;
                    z.Adresa = adresa;
                    if (checkBoxSaslusanje.Checked)
                        z.DatumSaslusanja = saslusanje;
                    z.ZatvorskaJedinica = zatvor;

                    s.Update(z);

                    s.Flush();
                    s.Close();

                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }
            }

                this.DialogResult = DialogResult.OK;
            }

        private void checkBoxSaslusanje_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxSaslusanje.Checked)
            {
                dateTimePickerSaslusanje.Enabled = false;
                return;
            }
            dateTimePickerSaslusanje.Enabled = true;
        }
    }
}
