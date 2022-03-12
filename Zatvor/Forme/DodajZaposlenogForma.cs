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
    public partial class DodajZaposlenogForma : Form
    {
        public Zaposleni ZaIzmenu { get; set; }
        private int tipZaposlenog;
        private string modRada;
        Regex regexJMBG = new Regex("^[0-9]{13}$");
        Regex regexIme = new Regex("^[A-Z]{1}[a-z]{1,14}$");
        Regex regexPrezime = new Regex("^[A-Z]{1}[a-z]{1,14}(\\s?[A-Z]{1}[a-z]{1,14})?$");
        public DodajZaposlenogForma(int tip, string mod, Zaposleni zaposleni)
        {
            modRada = mod;
            ZaIzmenu = zaposleni;
            tipZaposlenog = tip;
            InitializeComponent();
            
            if (tip != 1)
            {
                labelStrucnaSprema.Visible = false;
                labelPozicija.Visible = false;
                labelZanimanje.Visible = false;
                textBoxStrucnaSprema.Visible = false;
                textBoxPozicija.Visible = false;
                textBoxZanimanje.Visible = false;
            }
            procitajZatvoreIzBaze();
            if (modRada == "izmena")
            {
                popuniPodacimaKodIzmene();
                this.Text = "Izmena zaposlenog";
            }
            else
                this.Text = "Dodavanje zaposlenog";

        }

        private void popuniPodacimaKodIzmene()
        {
            
            textBoxJMBG.Text = ZaIzmenu.Jmbg;
            textBoxIme.Text = ZaIzmenu.Ime;
            textBoxPrezime.Text = ZaIzmenu.Prezime;
            if (ZaIzmenu.Pol == 'M')
                radioButtonM.Checked = true;
            else
                radioButtonZ.Checked = true;
            dateTimePickerPPZ.Value = ZaIzmenu.DatumPPZ.Value;
            
            
            for (int i = 0; i < comboBoxZatvori.Items.Count; i++)
                if (comboBoxZatvori.Items[i].ToString()==ZaIzmenu.ZatvorskaJedinica.Naziv)
                {
                    comboBoxZatvori.SelectedIndex = i;
                    break;
                }
   
            dateTimePickerPocetakRada.Value = ZaIzmenu.DatumPocetkaRada;
            if(tipZaposlenog==1)
            {
                textBoxStrucnaSprema.Text = ZaIzmenu.AStrucnaSprema;
                textBoxPozicija.Text = ZaIzmenu.APozicija;
                textBoxZanimanje.Text = ZaIzmenu.AZanimanje;
            }
        }

        private void procitajZatvoreIzBaze()
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from ZatvorskaJedinica");
                IEnumerable<ZatvorskaJedinica> zatvori = q.Enumerable<ZatvorskaJedinica>();



                if (zatvori != null)
                {
                    comboBoxZatvori.Items.Clear();

                    if (modRada == "izmena")
                        comboBoxZatvori.Items.Add(ZaIzmenu.ZatvorskaJedinica.Naziv);

                    if (tipZaposlenog == 2)
                    {
                        foreach (ZatvorskaJedinica z in zatvori)
                            if (z.Upravnik == null)
                                comboBoxZatvori.Items.Add(z.Naziv);
                    }
                    else
                        foreach (ZatvorskaJedinica z in zatvori)
                        {
                            if (modRada == "izmena")
                            {
                                if (z.Naziv != ZaIzmenu.ZatvorskaJedinica.Naziv)
                                    comboBoxZatvori.Items.Add(z.Naziv);
                            }
                            else
                                comboBoxZatvori.Items.Add(z.Naziv);
                        }
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

        private void btnProsledi_Click(object sender, EventArgs e)
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

            if (dateTimePickerPPZ.Value < dateTimePickerPocetakRada.Value)
            {
                MessageBox.Show("Datum polaganja PPZ-a mora biti nakon zaposlenja !");
                return;
            }
            
            if(tipZaposlenog==1)
            {
                if (textBoxStrucnaSprema.TextLength > 30 || textBoxStrucnaSprema.TextLength< 1)
                {
                    MessageBox.Show("Unesite validnu strucnu spremu koja ima manje od 30 karaktera !");
                    return;
                }
                if (textBoxZanimanje.TextLength > 30 || textBoxZanimanje.TextLength < 1) 
                {
                    MessageBox.Show("Unesite validno zanimanje koje ima manje od 30 karaktera !");
                    return;
                }
                if (textBoxPozicija.TextLength > 30 || textBoxPozicija.TextLength < 1)
                {
                    MessageBox.Show("Unesite validnu poziciju koje ima manje od 30 karaktera !");
                    return;
                }
            }
            if (modRada == "dodavanje")
            {
                if(comboBoxZatvori.Items.Count==0)
                {
                    MessageBox.Show("Ne postoji zatvor za zaposljavanje !");
                    return;
                }
                Zaposleni zaposleni;
                if (tipZaposlenog == 1)
                    zaposleni = new ZaposlenUAdministraciji();
                else if (tipZaposlenog == 2)
                    zaposleni = new Upravnik();
                else if (tipZaposlenog == 3)
                    zaposleni = new Psiholog();
                else
                    zaposleni = new Radnik_obezbedjenja();

                zaposleni.Jmbg = textBoxJMBG.Text;
                zaposleni.Ime = textBoxIme.Text;
                zaposleni.Prezime = textBoxPrezime.Text;
                if (radioButtonM.Checked)
                    zaposleni.Pol = 'M';
                else
                    zaposleni.Pol = 'Z';

                zaposleni.DatumPPZ = dateTimePickerPPZ.Value;

                try
                {
                   
                    ISession s = DataLayer.GetSession();

                    IQuery q = s.CreateQuery("from ZatvorskaJedinica as z where z.Naziv = ?");
                    q.SetParameter(0, comboBoxZatvori.Text);
                    ZatvorskaJedinica zatvorskaJedinica = q.UniqueResult<ZatvorskaJedinica>();
                    if(zatvorskaJedinica==null)
                    {
                        MessageBox.Show("Ne postoji takav zatvor !");
                        return;
                    }
                    zaposleni.ZatvorskaJedinica = zatvorskaJedinica;

                    zaposleni.DatumPocetkaRada = dateTimePickerPocetakRada.Value;

                    if (tipZaposlenog == 1)
                    {
                        zaposleni.AStrucnaSprema = textBoxStrucnaSprema.Text;
                        zaposleni.AZanimanje = textBoxZanimanje.Text;
                        zaposleni.APozicija = textBoxPozicija.Text;
                    }
                    zaposleni.NazivRadnogMesta = zaposleni.ToString();

                    if (tipZaposlenog == 2)
                    {
                        zatvorskaJedinica.Upravnik = zaposleni;
                        s.Update(zatvorskaJedinica);
                    }
                    s.Save(zaposleni);
                   
                    s.Flush();
                    s.Close();

                    MessageBox.Show("Uspesno dodavanje zaposlenog !");

                    
                   
                }
                catch (Exception ec)
                {
                    if (ec.InnerException.Message == "ORA-00001: unique constraint (S17513.SYS_C00277617) violated")
                    {
                        MessageBox.Show("Zaposleni sa ovim JMBG-om vec postoji ! ");
                    }
                    else
                        MessageBox.Show(ec.Message);
                }
            }
            else
            {
                ZaIzmenu.Jmbg = textBoxJMBG.Text;
                ZaIzmenu.Ime = textBoxIme.Text;
                ZaIzmenu.Prezime = textBoxPrezime.Text;
                if (radioButtonM.Checked)
                    ZaIzmenu.Pol = 'M';
                else
                    ZaIzmenu.Pol = 'Z';

                ZaIzmenu.DatumPPZ = dateTimePickerPPZ.Value;


                try
                {
                  
                    ISession s = DataLayer.GetSession();

                  
                    IQuery q = s.CreateQuery("from ZatvorskaJedinica as z where z.Naziv = ?");
                    q.SetParameter(0, comboBoxZatvori.Text);
                    ZatvorskaJedinica zatvorskaJedinica = q.UniqueResult<ZatvorskaJedinica>();
                    if (zatvorskaJedinica == null)
                    {
                        MessageBox.Show("Ne postoji takav zatvor !");
                        return;
                    }

                    if (ZaIzmenu.ZatvorskaJedinica.Sifra != zatvorskaJedinica.Sifra) // proveravamo da li je stvarno izmenjena zatvorska jedinica, kako ne bi pristupali bezveze bazi sa update za zatvor
                    {
                        if (tipZaposlenog == 2)
                        {
                            ZatvorskaJedinica stariZatvor = ZaIzmenu.ZatvorskaJedinica;
                            stariZatvor.Upravnik = null;
                            s.Update(stariZatvor);
                        }
                        ZaIzmenu.ZatvorskaJedinica = zatvorskaJedinica;

                        if (tipZaposlenog == 2)
                        {
                            zatvorskaJedinica.Upravnik = ZaIzmenu;
                            s.Update(zatvorskaJedinica);         
                        }
                    }
                    ZaIzmenu.DatumPocetkaRada = dateTimePickerPocetakRada.Value;

                    if (tipZaposlenog == 1)
                    {
                        ZaIzmenu.AStrucnaSprema = textBoxStrucnaSprema.Text;
                        ZaIzmenu.AZanimanje = textBoxZanimanje.Text;
                        ZaIzmenu.APozicija = textBoxPozicija.Text;
                    }
                   

                    s.Update(ZaIzmenu);
                    s.Flush();
                    s.Close();

                    MessageBox.Show("Uspesno ste izmenili zaposlenog !");

                    
                    
                }
                catch (Exception ec)
                {
                    if (ec.InnerException.Message == "ORA-00001: unique constraint (S17513.SYS_C00277617) violated")
                    {
                        MessageBox.Show("Zaposleni sa ovim JMBG-om vec postoji ! ");
                    }
                    else
                        MessageBox.Show(ec.Message);
                }
                
            }
            this.DialogResult = DialogResult.OK;
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

        private void buttonNazad_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

     
    }
}
