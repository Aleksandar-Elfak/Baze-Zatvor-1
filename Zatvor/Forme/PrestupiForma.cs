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

namespace Zatvor
{
    public partial class PrestupiForma : Form
    {
        public List<Prestup> prestupi = new List<Prestup>();
        public PrestupiForma()
        {
            InitializeComponent();
        }

        private void textBoxNaziv_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNaziv.Text.Length > 30)
            {
                textBoxNaziv.ForeColor = Color.Red;
            }
            else
            {
                textBoxNaziv.ForeColor = Color.Black;
            }
        }
        private void textBoxKategorja_TextChanged(object sender, EventArgs e)
        {
            if (textBoxKategorja.Text.Length > 60)
            {
                textBoxKategorja.ForeColor = Color.Red;
            }
            else
            {
                textBoxKategorja.ForeColor = Color.Black;
            }
        }
        private void textBoxMinimalnaKazna_TextChanged(object sender, EventArgs e)
        {
            if (textBoxMinimalnaKazna.Text.Length > 30)
            {
                textBoxMinimalnaKazna.ForeColor = Color.Red;
            }
            else
            {
                textBoxMinimalnaKazna.ForeColor = Color.Black;
            }
        }
        private void textBoxMaximalnaKasna_TextChanged(object sender, EventArgs e)
        {
            if (textBoxMaximalnaKasna.Text.Length > 30)
            {
                textBoxMaximalnaKasna.ForeColor = Color.Red;
            }
            else
            {
                textBoxMaximalnaKasna.ForeColor = Color.Black;
            }
        }
        private void textBoxOpis_TextChanged(object sender, EventArgs e)
        {
            if (textBoxOpis.Text.Length > 255)
            {
                textBoxOpis.ForeColor = Color.Red;
            }
            else
            {
                textBoxOpis.ForeColor = Color.Black;
            }
        }

        private void buttonNazad_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if (textBoxNaziv.Text.Length > 30 || textBoxNaziv.Text.Length < 1)
            {
                MessageBox.Show("Unesite validan naziv.");
                return;
            }
            if (textBoxKategorja.Text.Length > 60 || textBoxKategorja.Text.Length < 1)
            {
                MessageBox.Show("Unesite validnu kategoriju.");
                return;
            }
            if (textBoxMinimalnaKazna.Text.Length > 30 || textBoxMinimalnaKazna.Text.Length < 1)
            {
                MessageBox.Show("Unesite validnu minimalnu kaznu.");
                return;
            }
            if (textBoxMaximalnaKasna.Text.Length > 30 || textBoxMaximalnaKasna.Text.Length < 1)
            {
                MessageBox.Show("Unesite validnu maximalnu kaznu..");
                return;
            }
            if (textBoxOpis.Text.Length > 255 || textBoxOpis.Text.Length < 1)
            {
                MessageBox.Show("Unesite validan opis.");
                return;
            }
            try
            {
                ISession s = DataLayer.GetSession();

                Prestup p = new Prestup();

                p.Naziv = textBoxNaziv.Text;
                p.Kategorija = textBoxKategorja.Text;
                p.MinimalnaKazna = textBoxMinimalnaKazna.Text;
                p.MaximalnaKazna = textBoxMaximalnaKasna.Text;
                p.Opis = textBoxOpis.Text;

                s.Save(p);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                if (ec.InnerException.Message == "ORA-00001: unique constraint (S17513.SYS_C00277637) violated")
                {
                    MessageBox.Show("Vec postoji prestup sa tim imenom.");

                }
                else
                    MessageBox.Show(ec.Message);
            }
            pribaviPrestupe();
        }

        private void PrestupiForma_Load(object sender, EventArgs e)
        {
            pribaviPrestupe();
        }

        private void pribaviPrestupe()
        {
            dataGridViewZatvorenici.Rows.Clear();
            prestupi.Clear();
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Prestup");

                IEnumerable<Prestup> prestupiIzBaze = q.Enumerable<Prestup>();

                foreach (Prestup p in prestupiIzBaze)
                {
                    prestupi.Add(p);
                    dataGridViewZatvorenici.Rows.Add(
                        p.Id,
                        p.Naziv,
                        p.Kategorija,
                        p.MinimalnaKazna,
                        p.MaximalnaKazna,
                        p.Opis
                        );
                }
                s.Close();

                dataGridViewZatvorenici.Refresh();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            if (prestupi.Count == 0)
                buttonObrisi.Enabled = false;
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Prestup p = s.Load<Prestup>(NadjiPrestup().Id);

                s.Delete(p);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            pribaviPrestupe();
        }

        private Prestup NadjiPrestup()
        {
            foreach (Prestup p in prestupi)
            {
                if (p.Id.ToString() == dataGridViewZatvorenici.SelectedCells[0].Value.ToString())
                    return p;
            }
            MessageBox.Show("PRESTUP ERROR");
            return null;
        }
    }
}
