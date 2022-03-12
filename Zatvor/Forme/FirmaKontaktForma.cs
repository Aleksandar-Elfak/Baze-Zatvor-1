using NHibernate;
using NHibernate.Criterion;
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
    public partial class FirmaKontaktForma : Form
    {
        Regex regex = new Regex("^[0-9]{10,15}$");
        public Firma firma { get; set; }
        public List<FirmaKontakt> kontakti = new List<FirmaKontakt>();
        public FirmaKontaktForma()
        {
            InitializeComponent();
        }

        private void FirmaKontaktForma_Load(object sender, EventArgs e)
        {
            UcitajKontakte();
        }

        private void UcitajKontakte()
        {
            dataGridViewPosete.Rows.Clear();
            kontakti.Clear();
            try
            {

                ISession s = DataLayer.GetSession();

                ICriteria c = s.CreateCriteria<FirmaKontakt>();

                c.Add(Expression.Eq("Firma", firma));

                IList<FirmaKontakt> kontaktIzBaze = c.List<FirmaKontakt>();

                foreach (FirmaKontakt kontakt in kontaktIzBaze)
                {
                    kontakti.Add(kontakt);
                    dataGridViewPosete.Rows.Add(
                        kontakt.Id,
                        kontakt.KontaktTelefon
                        );
                }
                s.Close();

                dataGridViewPosete.Refresh();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void textBoxPoseta_TextChanged(object sender, EventArgs e)
        {
            if (!regex.IsMatch(textBoxPoseta.Text))
            {
                textBoxPoseta.ForeColor = Color.Red;
            }
            else
            {
                textBoxPoseta.ForeColor = Color.Black;
            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if (!regex.IsMatch(textBoxPoseta.Text))
            {
                MessageBox.Show("Unestite odgovarajuci broj telefona.");
                return;
            }
            try
            {
                ISession s = DataLayer.GetSession();


                FirmaKontakt stp = new FirmaKontakt();

                stp.KontaktTelefon = textBoxPoseta.Text;
                stp.Firma = firma;

                s.Save(stp);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            UcitajKontakte();
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                FirmaKontakt z = s.Load<FirmaKontakt>(NadjiKontakt().Id);

                s.Delete(z);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            UcitajKontakte();
        }

        private FirmaKontakt NadjiKontakt()
        {
            foreach (FirmaKontakt kontakt in kontakti)
            {
                if (kontakt.Id.ToString() == dataGridViewPosete.SelectedCells[0].Value.ToString())
                    return kontakt;
            }
            MessageBox.Show("ID ERROR");
            return null;
        }

        private void buttonNazad_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
