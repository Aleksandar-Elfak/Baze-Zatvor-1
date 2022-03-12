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
    public partial class FirmeForma : Form
    {
        private static List<Firma> sveFirme = new List<Firma>();
        public FirmeForma()
        {
            InitializeComponent();
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            dataGridViewFirme.Rows.Clear();
            sveFirme.Clear();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Firma> firme = from o in s.Query<Firma>()
                                                select o;
                if (firme != null)
                {

                    foreach (Firma f in firme)
                    {
                        sveFirme.Add(f);
                        dataGridViewFirme.Rows.Add(
                            f.Pib,
                            f.ImeFirme
                      
                            );
                    }
                }
                s.Close();
                dataGridViewFirme.Refresh();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            using (DodavanjeFirmeForma forma = new DodavanjeFirmeForma())
            {

                if (forma.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    UcitajPodatke();
            }
        }

        private void buttonNazad_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            if (dataGridViewFirme.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberite firmu koju zelite da obrisete!");
                return;
            }

            string poruka = "Da li zelite da obrisete izabranu firmu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {

                int selectedRow = dataGridViewFirme.SelectedRows[0].Index;
                String pib = (String)dataGridViewFirme["PIB", selectedRow].Value;

                Firma firma = null;
                foreach (Firma f in sveFirme)
                {
                    if (f.Pib == pib)
                    {
                        firma = f;
                        break;
                    }
                }
                sveFirme.Remove(firma);
                try
                {
                    ISession s = DataLayer.GetSession();


                    s.Delete(firma);
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

        private void button1_Click(object sender, EventArgs e)
        {
            using (FirmaOdgovornaLicaForma forma = new FirmaOdgovornaLicaForma())
            {
                forma.firma = VratiFirmu();
                if (forma.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    UcitajPodatke();
            }
        }

        private Firma VratiFirmu()
        {
            foreach (Firma firma in sveFirme)
            {
                if (firma.Pib == dataGridViewFirme.SelectedCells[0].Value.ToString())
                    return firma;
            }
            MessageBox.Show("ID ERROR");
            return null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (FirmaKontaktForma forma = new FirmaKontaktForma())
            {
                forma.firma = VratiFirmu();
                if (forma.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    UcitajPodatke();
            }
        }
    }
}
