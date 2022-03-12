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
    public partial class FirmaOdgovornaLicaForma : Form
    {
        public Firma firma { get; set; }
        private List<FirmaOdgovornaLica> lica = new List<FirmaOdgovornaLica>();
        public FirmaOdgovornaLicaForma()
        {
            InitializeComponent();
        }

        private void buttonNazad_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void FirmaOdgovornaLicaForma_Load(object sender, EventArgs e)
        {
            UcitajOdgovornaLica();
        }

        private void UcitajOdgovornaLica()
        {
            dataGridViewPosete.Rows.Clear();
            lica.Clear();
            try
            {

                ISession s = DataLayer.GetSession();

                ICriteria c = s.CreateCriteria<FirmaOdgovornaLica>();

                c.Add(Expression.Eq("Firma", firma));

                IList<FirmaOdgovornaLica> licaIzBaze = c.List<FirmaOdgovornaLica>();

                foreach (FirmaOdgovornaLica lice in licaIzBaze)
                {
                    lica.Add(lice);
                    dataGridViewPosete.Rows.Add(
                        lice.Id,
                        lice.OdgovornoLice
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

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if (textBoxLice.TextLength > 30 || textBoxLice.TextLength == 0)
            {
                MessageBox.Show("Naziv odgovornog lica mora biti izmedju 1 i 30 karakatera.");
                return;
            }
            try
            {
                ISession s = DataLayer.GetSession();


                FirmaOdgovornaLica stp = new FirmaOdgovornaLica();

                stp.OdgovornoLice = textBoxLice.Text;
                stp.Firma = firma;

                s.Save(stp);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            UcitajOdgovornaLica();
        }

        private void textBoxLice_TextChanged(object sender, EventArgs e)
        {
            if (textBoxLice.TextLength > 30)
            {
                textBoxLice.ForeColor = Color.Red;
            }
            else
            {
                textBoxLice.ForeColor = Color.Black;
            }
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                FirmaOdgovornaLica z = s.Load<FirmaOdgovornaLica>(NadjiLice().Id);

                s.Delete(z);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            UcitajOdgovornaLica();
        }

        private FirmaOdgovornaLica NadjiLice()
        {
            foreach (FirmaOdgovornaLica lice in lica)
            {
                if (lice.Id.ToString() == dataGridViewPosete.SelectedCells[0].Value.ToString())
                    return lice;
            }
            MessageBox.Show("ID ERROR");
            return null;
        }
    }
}
