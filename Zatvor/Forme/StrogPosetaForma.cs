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
    public partial class StrogPosetaForma : Form
    {
        Regex regex = new Regex("^(Ponedeljak|Utorak|Sreda|Cetvrtak|Petak|Subota|Nedelja) [0-2][0-9]:[0-5][0-9]-[0-2][0-9]:[0-5][0-9]$");
        public ZatvorskaJedinica zatvor { get; set; }
        public List<StrogTerminPosete> posete = new List<StrogTerminPosete>();
        public StrogPosetaForma()
        {
            InitializeComponent();
        }

        private void StrogPosetaForma_Load(object sender, EventArgs e)
        {
            UcitajTerminePosete();
        }

        private void UcitajTerminePosete()
        {
            dataGridViewPosete.Rows.Clear();
            posete.Clear();
            try
            {

                ISession s = DataLayer.GetSession();

                ICriteria c = s.CreateCriteria<StrogTerminPosete>();

                c.Add(Expression.Eq("Zatvor", zatvor));

                IList<StrogTerminPosete> poseteIzBaze = c.List<StrogTerminPosete>();

                foreach (StrogTerminPosete poseta in poseteIzBaze)
                {
                    posete.Add(poseta);
                    dataGridViewPosete.Rows.Add(
                        poseta.Id,
                        poseta.TerminPosete
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
            if (!regex.IsMatch(textBoxPoseta.Text))
            {
                MessageBox.Show("Unesite validan termin(Dan Vreme).");
                return;
            }
            try
            {
                ISession s = DataLayer.GetSession();


                StrogTerminPosete stp = new StrogTerminPosete();

                stp.TerminPosete = textBoxPoseta.Text;
                stp.Zatvor = zatvor;

                s.Save(stp);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            UcitajTerminePosete();
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

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                StrogTerminPosete z = s.Load<StrogTerminPosete>(NadjiTerminPosete().Id);

                s.Delete(z);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            UcitajTerminePosete();
        }

        private StrogTerminPosete NadjiTerminPosete()
        {
            foreach (StrogTerminPosete poseta in posete)
            {
                if (poseta.Id.ToString() == dataGridViewPosete.SelectedCells[0].Value.ToString())
                    return poseta;
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
