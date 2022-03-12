using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using Zatvor.Entiteti;
using Zatvor.Forme;

namespace Zatvor
{
    public partial class ZatvoreniciForma : Form
    {
        List<Zatvorenik> zatvorenici = new List<Zatvorenik>();
        public ZatvoreniciForma()
        {
            InitializeComponent();
        }

        private void VratiZatvorenike()
        {
            dataGridViewZatvorenici.Rows.Clear();
            zatvorenici.Clear();
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Zatvorenik");

                IEnumerable<Zatvorenik> zatvoreniciIzBaze = q.Enumerable<Zatvorenik>();

                foreach (Zatvorenik zatvorenik in zatvoreniciIzBaze)
                {
                    zatvorenici.Add(zatvorenik);
                    dataGridViewZatvorenici.Rows.Add(
                        zatvorenik.Jmbg,
                        zatvorenik.Ime, zatvorenik.Prezime,
                        zatvorenik.Pol, zatvorenik.Broj, 
                        zatvorenik.Adresa, zatvorenik.DatumSaslusanja!= null ?
                        zatvorenik.DatumSaslusanja.Value.Day + "-" + 
                        zatvorenik.DatumSaslusanja.Value.Month + "-" + 
                        zatvorenik.DatumSaslusanja.Value.Year : "/",
                        zatvorenik.StatusUslovnogOtpusta, 
                        zatvorenik.ZatvorskaJedinica.Naziv
                        );
                }
                s.Close();
                
                dataGridViewZatvorenici.Refresh();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            using (DodajZatvorenikaForma dzf = new DodajZatvorenikaForma())
            {
                dzf.ShowDialog();
                VratiZatvorenike();
            }
        }

        private void ZatvoreniciForma_Load(object sender, EventArgs e)
        {
            VratiZatvorenike();
        }

        private void buttonPrikazi_Click(object sender, EventArgs e)
        {
            using (DodajZatvorenikaForma dzf = new DodajZatvorenikaForma())
            {
                dzf.zaIzmenu = NadjiZatvorenika();
                dzf.ShowDialog();
                VratiZatvorenike();
            }
        }

        private void buttonNazad_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private Zatvorenik NadjiZatvorenika()
        {
            foreach (Zatvorenik zatvorenik in zatvorenici)
            {
                if (zatvorenik.Jmbg == dataGridViewZatvorenici.SelectedCells[0].Value.ToString())
                    return zatvorenik;
            }
            MessageBox.Show("JMBG ERROR");
            return null;
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zatvorenik z = s.Load<Zatvorenik>(NadjiZatvorenika().Id);

                s.Delete(z);

                s.Flush();
                s.Close();
                VratiZatvorenike();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void buttonPrekrsaji_Click(object sender, EventArgs e)
        {
            using (PrekrsajiZatvorenikaForma prekrsaji = new PrekrsajiZatvorenikaForma())
            {
                prekrsaji.zatvorenik = NadjiZatvorenika();
                prekrsaji.ShowDialog();
                VratiZatvorenike();
            }
        }

        private void buttonPosete_Click(object sender, EventArgs e)
        {
            using (PoseteForma p = new PoseteForma())
            {
                p.zatvorenik = NadjiZatvorenika();
                p.ShowDialog();
                VratiZatvorenike();
            }
        }

        private void buttonAdvokati_Click(object sender, EventArgs e)
        {
            using (ZastupaForma z = new ZastupaForma())
            {
                z.zatvorenik = NadjiZatvorenika();
                z.ShowDialog();
                VratiZatvorenike();
            }
        }
    }
}
