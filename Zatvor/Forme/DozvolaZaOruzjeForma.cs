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
    public partial class DozvolaZaOruzjeForma : Form
    {
        

        private Zaposleni zaposleni;
        private bool dozvolaPostoji = false;
        private DozvolaZaOruzje dozvolaZaOruzje;
        public DozvolaZaOruzjeForma(Zaposleni z)
        {
            InitializeComponent();
            zaposleni = z;
            ProveraDozvole();
        }

        private void ProveraDozvole()
        {
            try
            {

                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from DozvolaZaOruzje");
                IEnumerable<DozvolaZaOruzje> dozvoleZaOruzje = q.Enumerable<DozvolaZaOruzje>();

                if (dozvoleZaOruzje != null)
                {
                    foreach (DozvolaZaOruzje dozvola in dozvoleZaOruzje)
                    {
                        if (dozvola.Zaposleni.Jmbg == zaposleni.Jmbg)
                        {
                            dozvolaPostoji = true;
                            dozvolaZaOruzje = dozvola;
                            buttonObrisi.Visible = true;
                            buttonDodaj.Text = "Sacuvaj";
                            this.Text = "Izmena dozvole za vatreno oruzje";
                            break;
                        }
                    }
                }
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            if (!dozvolaPostoji)
            {
                buttonObrisi.Visible = false;
                buttonDodaj.Text = "Dodaj";
                this.Text = "Kreiranje dozvole za vatreno oruzje";
            }
            else
                UcitajPodatkeZaIzmenu();
        }

        private void UcitajPodatkeZaIzmenu()
        {
            textBoxSifra.Text = dozvolaZaOruzje.SifraDozvole;
            textBoxPolicija.Text = dozvolaZaOruzje.PolicijskaUprava;
            dateTimePickerDatum.Value = dozvolaZaOruzje.Datum;
        }

       
        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if (textBoxSifra.Text.Length > 30 || textBoxSifra.Text.Length < 1)
            {
                MessageBox.Show("Unesite validan broj sifre koja mora da ima manje od 30 karaktera ! ");
                return;
            }
            if (textBoxPolicija.Text.Length > 30 || textBoxPolicija.Text.Length < 1)
            {
                MessageBox.Show("Unesite validnu policijsku upravu");
                return;
            }
            else
            {
                textBoxPolicija.Text = textBoxPolicija.Text.ToUpper();
            }

            if (dozvolaPostoji == false)
            {

                DozvolaZaOruzje dozvolaZaOruzje = new DozvolaZaOruzje();
                dozvolaZaOruzje.SifraDozvole = textBoxSifra.Text;
                dozvolaZaOruzje.PolicijskaUprava = textBoxPolicija.Text;
                dozvolaZaOruzje.Datum = dateTimePickerDatum.Value;

                dozvolaZaOruzje.Zaposleni = zaposleni;

                try
                {
                    ISession s = DataLayer.GetSession();
                    s.Save(dozvolaZaOruzje);

                    s.Flush();
                    s.Close();
                    MessageBox.Show("Uspesno dodavanje dozvole za vatreno oruzje !");
                }
                catch (Exception ec)
                {
                    if (ec.InnerException.Message == "ORA-00001: unique constraint (S17513.SYS_C00277630) violated")
                    {
                        MessageBox.Show("Uneta sifra vec postoji ! ");
                    }
                    else
                        MessageBox.Show(ec.Message);
                }

            }
            else
            {

                dozvolaZaOruzje.SifraDozvole = textBoxSifra.Text;
                dozvolaZaOruzje.PolicijskaUprava = textBoxPolicija.Text;
                dozvolaZaOruzje.Datum = dateTimePickerDatum.Value;

                try
                {
                    ISession s = DataLayer.GetSession();
                    s.Update(dozvolaZaOruzje);
                    s.Flush();
                    s.Close();

                    MessageBox.Show("Uspesno ste izmenili dozvolu za oruzje !");

                }
                catch (Exception ec)
                {
                    if (ec.InnerException.Message == "ORA-00001: unique constraint (S17513.SYS_C00277630) violated")
                    {
                        MessageBox.Show("Uneta sifra vec postoji ! ");
                    }
                    else
                        MessageBox.Show(ec.Message);
                }
            }
            this.DialogResult = DialogResult.OK;
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da obrisete dozvolu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                try
                {
                    ISession s = DataLayer.GetSession();


                    s.Delete(dozvolaZaOruzje);
                    s.Flush();

                    s.Close();

                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }
                this.DialogResult = DialogResult.OK;
            }
        }

        private void buttonNazad_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}