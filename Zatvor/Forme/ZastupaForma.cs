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
using NHibernate.Criterion;
using Zatvor.Entiteti;

namespace Zatvor.Forme
{
    public partial class ZastupaForma : Form
    {
        public Zatvorenik zatvorenik { get; set; }
        public List<Advokat> advokati = new List<Advokat>();
        public List<Zastupa> zastupas = new List<Zastupa>();
        public ZastupaForma()
        {
            InitializeComponent();
        }

        private void ZastupaForma_Load(object sender, EventArgs e)
        {
            PripremiAdvokate();
            PopuniZastupanja();
        }

        private void PopuniZastupanja()
        {
            dataGridViewZastupa.Rows.Clear();
            zastupas.Clear();
            try
            {
                ISession s = DataLayer.GetSession();

                ICriteria c = s.CreateCriteria<Zastupa>();
                c.Add(Expression.Eq("Zatvorenik", zatvorenik));

                IList<Zastupa> poseteIzBaze = c.List<Zastupa>();


                foreach (Zastupa z in poseteIzBaze)
                {
                    zastupas.Add(z);
                    dataGridViewZastupa.Rows.Add(
                        z.Id,
                        z.Advokat.Id,
                        z.Advokat.Ime + " " +
                        z.Advokat.Prezime,
                        z.ZastupaOd.Day + "-" + 
                        z.ZastupaOd.Month + "-" + 
                        z.ZastupaOd.Year,
                        z.DatumPoslednjegKontakta.Day + "-" +
                        z.DatumPoslednjegKontakta.Month + "-" +
                        z.DatumPoslednjegKontakta.Year
                        );
                }
                s.Close();
                dataGridViewZastupa.Refresh();

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void PripremiAdvokate()
        {
            comboBox1.Items.Clear();
            advokati.Clear();
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Advokat");

                IList<Advokat> advokatiIzBaze = q.List<Advokat>();

                foreach (Advokat a in advokatiIzBaze)
                {
                    advokati.Add(a);
                    comboBox1.Items.Add(a.Ime + " " + a.Prezime);
                }

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewZastupa.Rows)
            {
                if (row.Cells[1].Value.ToString() == advokati[comboBox1.SelectedIndex].Id.ToString())
                {
                    MessageBox.Show("Odabrani advokat vec zastupa zatvorenika");
                    return;
                }
            }
            if(dateTimePickerZastupaOd.Value > dateTimePickerPoslednjiKontakt.Value)
            {
                MessageBox.Show("Vreme poslednjeg kontakta ne moze biti pre nego sto je advokat poceo da zastupa zatvorenika");
                return;
            }
            try
            {
                ISession s = DataLayer.GetSession();

                Zastupa z = new Zastupa();

                z.ZastupaOd = dateTimePickerZastupaOd.Value;
                z.DatumPoslednjegKontakta = dateTimePickerPoslednjiKontakt.Value;
                z.Zatvorenik = zatvorenik;
                z.Advokat = advokati[comboBox1.SelectedIndex];

                s.Save(z);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            PopuniZastupanja();
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Zastupa p = s.Load<Zastupa>(NadjiZastupanje().Id);

                s.Delete(p);

                s.Flush();
                s.Close();
                NadjiZastupanje();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            PopuniZastupanja();
        }

        private Zastupa NadjiZastupanje()
        {
            foreach (Zastupa z in zastupas)
            {
                if (z.Id.ToString() == dataGridViewZastupa.SelectedCells[0].Value.ToString())
                    return z;
            }
            MessageBox.Show("Pocinio Error");
            return null;
        }

        private void buttonNazad_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
