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
    public partial class AdvokatiForma : Form
    {
        private static List<Advokat> sviAdvokati = new List<Advokat>();
        public AdvokatiForma()
        {
            InitializeComponent();
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            dataGridViewAdvokati.Rows.Clear();
            sviAdvokati.Clear();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Advokat> advokati = from o in s.Query<Advokat>()
                                                select o;
                if (advokati != null)
                {

                    foreach (Advokat a in advokati)
                    {
                        sviAdvokati.Add(a);
                        dataGridViewAdvokati.Rows.Add(
                            a.Jmbg,
                            a.Ime,
                            a.Prezime,
                            a.Pol
                            );
                    }
                }
                s.Close();
                dataGridViewAdvokati.Refresh();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            using (DodavanjeAdvokataForma forma = new DodavanjeAdvokataForma())
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
            if (dataGridViewAdvokati.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberite advokata koga zelite da obrisete!");
                return;
            }

            string poruka = "Da li zelite da obrisete izabranog advokata?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {

                int selectedRow = dataGridViewAdvokati.SelectedRows[0].Index;
                String jmbg = (String)dataGridViewAdvokati["JMBG", selectedRow].Value;

                Advokat advokat = null;
                foreach (Advokat a in sviAdvokati)
                {
                    if (a.Jmbg == jmbg)
                    {
                        advokat = a;
                        break;
                    }
                }
                sviAdvokati.Remove(advokat);
                try
                {
                    ISession s = DataLayer.GetSession();


                    s.Delete(advokat);
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
    }
}
