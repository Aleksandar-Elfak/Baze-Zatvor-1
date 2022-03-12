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

namespace Zatvor                                // pogledaj za ogranicenje kod jmbg za korisnika, mora unique !!!!!!!
{


    public partial class LekarskiPregledForma : Form
    {
        

        private Zaposleni zaposleni;
        private bool lekarskiPostoji = false;
        private LekarskiPregled lekarskiPregled;
        public LekarskiPregledForma(Zaposleni z)
        {
            InitializeComponent();
            zaposleni = z;
            ProveraLekarskogPregleda();

        }

        private void ProveraLekarskogPregleda()
        {
            
            try
            {

                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from LekarskiPregled");
                IEnumerable<LekarskiPregled> lekarskiPregledi = q.Enumerable<LekarskiPregled>();

              


                if (lekarskiPregledi != null)
                {
                    foreach (LekarskiPregled lekarski in lekarskiPregledi)
                    {
                        if (lekarski.Zaposleni.Jmbg == zaposleni.Jmbg)
                        {
                            lekarskiPostoji = true;
                            lekarskiPregled = lekarski;
                            buttonObrisi.Visible = true;
                            buttonDodaj.Text = "Sacuvaj";
                            this.Text = "Izmena lekarskog pregleda";
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

            if (!lekarskiPostoji)
            {
                buttonObrisi.Visible = false;
                buttonDodaj.Text = "Dodaj";
                this.Text = "Kreiranje lekarskog pregleda";
            }
            else
                UcitajPodatkeZaIzmenu();

        }

        private void UcitajPodatkeZaIzmenu()
        {
            textBoxNaziv.Text = lekarskiPregled.NazivUstanove;
            textBoxAdresa.Text = lekarskiPregled.AdresaUstanove;
            textBoxLekar.Text = lekarskiPregled.Lekar;
            dateTimePickerDatum.Value = lekarskiPregled.Datum;
        }

      

        private void buttonDodaj_Click(object sender, EventArgs e)
        {

            if (textBoxNaziv.Text.Length > 30 || textBoxNaziv.Text.Length < 1)
            {
                MessageBox.Show("Unesite validan naziv ustanove");
                return;
            }
            else
            {
                textBoxNaziv.Text= textBoxNaziv.Text.ToUpper();
            }
            if (textBoxAdresa.Text.Length > 30 || textBoxAdresa.Text.Length < 1)
            {
                MessageBox.Show("Unesite validnu adresu ustanove");
                return;
            }
           
            if (textBoxLekar.Text.Length > 30 || textBoxLekar.Text.Length < 1)
            {
                MessageBox.Show("Unesite validno ime i prezime lekara");
                return;
            }
            
            if (lekarskiPostoji == false)
            {
               
                LekarskiPregled lekarskiPregled = new LekarskiPregled();
                lekarskiPregled.NazivUstanove = textBoxNaziv.Text;
                lekarskiPregled.AdresaUstanove = textBoxAdresa.Text;
                lekarskiPregled.Datum = dateTimePickerDatum.Value;
                lekarskiPregled.Lekar = textBoxLekar.Text;
                lekarskiPregled.Zaposleni = zaposleni;
                try
                {
                    ISession s = DataLayer.GetSession();
                    s.Save(lekarskiPregled);

                    s.Flush();
                    s.Close();
                    MessageBox.Show("Uspesno dodavanje lekarskog pregleda !");
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }

            }
            else
            {
               
                lekarskiPregled.NazivUstanove = textBoxNaziv.Text;
                lekarskiPregled.AdresaUstanove = textBoxAdresa.Text;
                lekarskiPregled.Lekar = textBoxLekar.Text;
                lekarskiPregled.Datum = dateTimePickerDatum.Value;

                try
                {
                    ISession s = DataLayer.GetSession();
                    s.Update(lekarskiPregled);
                    s.Flush();
                    s.Close();

                    MessageBox.Show("Uspesno ste izmenili lekarski pregled !");

                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }
            }
            this.DialogResult = DialogResult.OK;
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da obrisete lekarski pregled ?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                try
                {
                    ISession s = DataLayer.GetSession();


                    s.Delete(lekarskiPregled);
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
        
