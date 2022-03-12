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
using Zatvor.Forme;

namespace Zatvor
{
    public partial class ZatvorskeJediniceForma : Form
    {
        public List<ZatvorskaJedinica> zatvori = new List<ZatvorskaJedinica>();
        public ZatvorskeJediniceForma()
        {
            InitializeComponent();
        }

        private void ZatvorskeJediniceForma_Load(object sender, EventArgs e)
        {
            VratiZatvorskeJedinice();
        }

        private void VratiZatvorskeJedinice()
        {
            dataGridViewZatvori.Rows.Clear();
            zatvori.Clear();
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from ZatvorskaJedinica");

                IEnumerable<ZatvorskaJedinica> zatvoriIzBaze = q.Enumerable<ZatvorskaJedinica>();

                foreach (ZatvorskaJedinica zatvor in zatvoriIzBaze)
                {
                    zatvori.Add(zatvor);
                    dataGridViewZatvori.Rows.Add(
                        zatvor.Id,
                        zatvor.Sifra,
                        zatvor.Naziv,
                        zatvor.Adresa,
                        zatvor.Kapacitet,
                        zatvor.OtvoreniF,
                        zatvor.PoluOtvoreniF,
                        zatvor.PeriodZakljucavanja ?? "-",
                        zatvor.StrogiF,
                        zatvor.Setnja ?? "-",
                        zatvor.Upravnik != null ? zatvor.Upravnik.Ime + " " +
                        zatvor.Upravnik.Prezime : "-"
                        );
                }
                s.Close();

                dataGridViewZatvori.Refresh();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            using (DodajZatvorForma dzf = new DodajZatvorForma())
            {
                if (dzf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    VratiZatvorskeJedinice();
            }
        }

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {
            using (DodajZatvorForma dzf = new DodajZatvorForma())
            {
                dzf.zaIzmenu = NadjiZatvor();
                if (dzf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    VratiZatvorskeJedinice();
            }
        }

        private ZatvorskaJedinica NadjiZatvor()
        {
            foreach (ZatvorskaJedinica zatvor in zatvori)
            {
                if (zatvor.Id.ToString() == dataGridViewZatvori.SelectedCells[0].Value.ToString())
                    return zatvor;
            }
            MessageBox.Show("ID ERROR");
            return null;
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                ZatvorskaJedinica z = s.Load<ZatvorskaJedinica>(NadjiZatvor().Id);

                s.Delete(z);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            VratiZatvorskeJedinice();
        }

        private void buttonZaposleni_Click(object sender, EventArgs e)
        {
            using (PrikazZaposlenihForma pzf = new PrikazZaposlenihForma())
            {
                pzf.zatvor = NadjiZatvor();
                pzf.ShowDialog();
            }
        }

        private void buttonZatvorenici_Click(object sender, EventArgs e)
        {
            using (PrikazZatvorenikaForma pzf = new PrikazZatvorenikaForma())
            {
                pzf.zatvor = NadjiZatvor();
                pzf.ShowDialog();
            }
        }

        private void buttonPosete_Click(object sender, EventArgs e)
        {
            using (StrogPosetaForma spf = new StrogPosetaForma())
            {
                spf.zatvor = NadjiZatvor();
                if (spf.zatvor.StrogiF == 'Y')
                    spf.ShowDialog();
                else
                    MessageBox.Show("Zatvor mora biti stogog tipa");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void buttonFirme_Click(object sender, EventArgs e)
        {
            using (SaradnjeForma spf = new SaradnjeForma())
            {
                spf.zatvor = NadjiZatvor();
                if (spf.zatvor.OtvoreniF == 'Y')
                    spf.ShowDialog();
                else
                    MessageBox.Show("Zatvor mora biti stogog tipa");
            }
        }
    }
}
