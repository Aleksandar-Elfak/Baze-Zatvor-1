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
    public partial class ZaposleniForma : Form
    {
        private static List<Zaposleni> sviZaposleni = new List<Zaposleni>();
        public ZaposleniForma()
        {
            InitializeComponent();

            UcitajPodatke();
        }

        public void UcitajPodatke()
        {
            dataGridViewZaposleni.Rows.Clear();
            sviZaposleni.Clear();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Zaposleni> zaposleni = from o in s.Query<Zaposleni>()
                                                   select o;
                if (zaposleni != null)
                {

                    foreach (Zaposleni z in zaposleni)
                    {
                        sviZaposleni.Add(z);
                        dataGridViewZaposleni.Rows.Add(
                            z.Jmbg,
                            z.Ime,
                            z.Prezime,
                            z.Pol,
                            z.DatumPPZ,
                            z.ToString(),
                            z.AStrucnaSprema,
                            z.AZanimanje,
                            z.APozicija,
                            z.ZatvorskaJedinica.Naziv,
                            z.DatumPocetkaRada.Day + "-" + z.DatumPocetkaRada.Month + "-" + z.DatumPocetkaRada.Year
                            );
                    }
                }
                s.Close();
                dataGridViewZaposleni.Refresh();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }


        private void btnDodajZaposlenog_Click(object sender, EventArgs e)
        {
            using (TipZaposlenogForma forma = new TipZaposlenogForma())
            {
                forma.ShowDialog();
                UcitajPodatke();
            }
        }

        private void buttonNazad_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {
            if (dataGridViewZaposleni.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberite zaposlenog koga zelite da obrisete!");
                return;
            }


            int selectedRow = dataGridViewZaposleni.SelectedRows[0].Index;
            String jmbg = (String)dataGridViewZaposleni["JMBG", selectedRow].Value;

            Zaposleni zaposleni = null;
            foreach (Zaposleni z in sviZaposleni)
            {
                if (z.Jmbg == jmbg)
                {
                    zaposleni = z;
                    break;
                }
            }
           
            DodajZaposlenogForma forma;

            if (zaposleni.ToString() == "Administracija")
            {
                using (forma = new DodajZaposlenogForma(1, "izmena", zaposleni))
                {
                    if (forma.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        UcitajPodatke();
                }
            }
            else if(zaposleni.ToString()=="Upravnik")
            {
                using (forma = new DodajZaposlenogForma(2, "izmena", zaposleni))
                {
                    if (forma.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        UcitajPodatke();
                }
            }
            else if(zaposleni.ToString()=="Psiholog")
            {
                using (forma = new DodajZaposlenogForma(3, "izmena", zaposleni))
                {
                    if (forma.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        UcitajPodatke();
                }
            }
            else
            {
                using (forma = new DodajZaposlenogForma(3, "izmena", zaposleni))
                {
                    if (forma.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        UcitajPodatke();
                }
            }    
            
             

        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            if (dataGridViewZaposleni.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberite zaposlenog koga zelite da obrisete!");
                return;
            }

            string poruka = "Da li zelite da obrisete izabranog zaposlenog?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {

                int selectedRow = dataGridViewZaposleni.SelectedRows[0].Index;
                String jmbg = (String)dataGridViewZaposleni["JMBG", selectedRow].Value;

                Zaposleni zaposleni = null;
                foreach (Zaposleni z in sviZaposleni)
                {
                    if (z.Jmbg == jmbg)
                    {
                        zaposleni = z;
                        break;
                    }
                }
                sviZaposleni.Remove(zaposleni);
                try
                {
                    ISession s = DataLayer.GetSession();


                    s.Delete(zaposleni);
                    s.Flush();

                    s.Close();

                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }

                UcitajPodatke();


            }
        }

        private void buttonLekarski_Click(object sender, EventArgs e)
        {
            if (dataGridViewZaposleni.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberite zaposlenog kome zelite da pogledate lekarski pregled !");
                return;
            }


            int selectedRow = dataGridViewZaposleni.SelectedRows[0].Index;
            String jmbg = (String)dataGridViewZaposleni["JMBG", selectedRow].Value;

            Zaposleni zaposleni = null;
            foreach (Zaposleni z in sviZaposleni)
            {
                if (z.Jmbg == jmbg)
                {
                    zaposleni = z;
                    break;
                }
            }

           LekarskiPregledForma forma;

            if (zaposleni.ToString() == "Administracija")
            {
                MessageBox.Show("Administratori ne mogu izvaditi lekarski pregled !");
                return;
            }
            else if (zaposleni.ToString() == "Upravnik")
            {
                MessageBox.Show("Upravnici ne mogu izvaditi lekarski pregled !");
                return;
            }
            else
            {
                using (forma = new LekarskiPregledForma(zaposleni))
                {
                    if (forma.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        UcitajPodatke();
                }
            }
        }

        private void buttonOruzje_Click(object sender, EventArgs e)
        {
            if (dataGridViewZaposleni.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberite zaposlenog kome zelite da pogledate dozvolu za vatreno oruzje !");
                return;
            }


            int selectedRow = dataGridViewZaposleni.SelectedRows[0].Index;
            String jmbg = (String)dataGridViewZaposleni["JMBG", selectedRow].Value;

            Zaposleni zaposleni = null;
            foreach (Zaposleni z in sviZaposleni)
            {
                if (z.Jmbg == jmbg)
                {
                    zaposleni = z;
                    break;
                }
            }

            if (zaposleni.ToString() == "Administracija")
            {
                MessageBox.Show("Administratori ne mogu izvaditi dozvolu za vatreno oruzje !");
                return;
            }
            else if (zaposleni.ToString() == "Upravnik")
            {
                MessageBox.Show("Upravnici ne mogu izvaditi dozvolu za vatreno oruzje !");
                return;
            }
            else if (zaposleni.ToString() == "Psiholog")
            {
                MessageBox.Show("Psiholozi ne mogu izvaditi dozvolu za vatreno oruzje !");
                return;
            }
            else
            {
                using (DozvolaZaOruzjeForma forma = new DozvolaZaOruzjeForma(zaposleni))
                {
                    if (forma.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        UcitajPodatke();
                }
            }
        }
    }
}
