using NHibernate;
using NHibernate.Criterion;
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

namespace Zatvor.Forme
{
    public partial class SaradnjeForma : Form
    {
        public ZatvorskaJedinica zatvor { get; set; }
        private List<Saradjuje> firme = new List<Saradjuje>();
        private List<Firma> sveFirme = new List<Firma>();
        public SaradnjeForma()
        {
            InitializeComponent();
        }

        private void SaradnjeFroma_Load(object sender, EventArgs e)
        {
            UcitajFirme();
            ComboBoxPriprema();
        }

        private void ComboBoxPriprema()
        {
            comboBoxFirme.Items.Clear();
            sveFirme.Clear();
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Firma");

                IEnumerable<Firma> firmeIzBaze = q.Enumerable<Firma>();

                foreach (Firma firma in firmeIzBaze)
                {
                    sveFirme.Add(firma);
                    comboBoxFirme.Items.Add(firma.Pib + " " + firma.ImeFirme);
                }
                s.Close();
                if (comboBoxFirme.Items.Count > 0)
                    comboBoxFirme.SelectedIndex = 0;
                comboBoxFirme.Refresh();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void UcitajFirme()
        {
            dataGridViewFirme.Rows.Clear();
            firme.Clear();
            try
            {

                ISession s = DataLayer.GetSession();

                ICriteria c = s.CreateCriteria<Saradjuje>();

                c.Add(Expression.Eq("ZatvorskaJedinica", zatvor));

                IList<Saradjuje> firmeIzBaze = c.List<Saradjuje>();

                foreach (Saradjuje firma in firmeIzBaze)
                {
                    firme.Add(firma);
                    dataGridViewFirme.Rows.Add(
                        firma.Id,
                        firma.Firma.Pib + " " + firma.Firma.ImeFirme
                        );
                }
                s.Close();

                dataGridViewFirme.Refresh();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void buttonNazad_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Saradjuje z = s.Load<Saradjuje>(NadjiFirmu().Id);

                s.Delete(z);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            UcitajFirme();
        }

        private Saradjuje NadjiFirmu()
        {
            foreach (Saradjuje firma in firme)
            {
                if (firma.Id.ToString() == dataGridViewFirme.SelectedCells[0].Value.ToString())
                    return firma;
            }
            MessageBox.Show("ID ERROR");
            return null;
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if(comboBoxFirme.Items.Count < 1)
            {
                MessageBox.Show("Ne postoje firme.");
                return;
            }
            try
            {
                ISession s = DataLayer.GetSession();


                Saradjuje stp = new Saradjuje();

                stp.ZatvorskaJedinica = zatvor;
                stp.Firma = sveFirme[comboBoxFirme.SelectedIndex];

                s.Save(stp);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            UcitajFirme();
        }
    }
}
