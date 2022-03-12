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
    public partial class PrekrsajiZatvorenikaForma : Form
    {
        public Zatvorenik zatvorenik { get; set; }
        public List<Prestup> Prestupi = new List<Prestup>();
        public List<Pocinio> Pocinio = new List<Pocinio>();
        public PrekrsajiZatvorenikaForma()
        {
            InitializeComponent();
        }

        private void PrekrsajiZatvorenika_Load(object sender, EventArgs e)
        {
            PribaviPrekrsaje();
            PribaviPrekrsajeZatvorenika();
        }

        private void PribaviPrekrsaje()
        {
            comboBox1.Items.Clear();
            Prestupi.Clear();
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Prestup");

                IList<Prestup> prestupi = q.List<Prestup>();

                foreach (Prestup p in prestupi)
                {
                    Prestupi.Add(p);
                    comboBox1.Items.Add(p.Naziv);
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

        private void PribaviPrekrsajeZatvorenika()
        {
            dataGridViewPrestupi.Rows.Clear();
            Pocinio.Clear();
            try
            {
                ISession s = DataLayer.GetSession();

                ICriteria c = s.CreateCriteria<Pocinio>();
                c.Add(Expression.Eq("Zatvorenik", zatvorenik));

                IList<Pocinio> pocinioIzBaze = c.List<Pocinio>();


                foreach (Pocinio pocinio in pocinioIzBaze)
                {
                    Pocinio.Add(pocinio);
                    dataGridViewPrestupi.Rows.Add(
                        pocinio.Id,
                        pocinio.Prestup.Naziv,
                        pocinio.Prestup.Kategorija,
                        pocinio.Datum,
                        pocinio.MestoPrestupa,
                        pocinio.Prestup.MinimalnaKazna,
                        pocinio.Prestup.MaximalnaKazna,
                        pocinio.Prestup.Opis
                        );
                }
                s.Close();
                dataGridViewPrestupi.Refresh();

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Length<30)
            {
                textBox1.ForeColor = Color.Black;
            }
            else
            {
                textBox1.ForeColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lokacija = "Error";
            DateTime datum = dateTimePicker1.Value;
            if (textBox1.Text.Length < 30 && textBox1.Text.Length > 1)
                lokacija = textBox1.Text;
            else
                MessageBox.Show("Unesite validnu adresu");

            try
            {
                ISession s = DataLayer.GetSession();


                Pocinio p = new Pocinio();

                p.Datum = datum;
                p.MestoPrestupa = lokacija;
                p.Prestup = pronadjiPrestup();
                p.Zatvorenik = this.zatvorenik;

                s.Save(p);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            PribaviPrekrsajeZatvorenika();
        }

        private Prestup pronadjiPrestup()
        {
            if (Prestupi.Count > 0 && comboBox1.Items.Count > 0)
                return Prestupi[comboBox1.SelectedIndex];
            return null;
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Pocinio p = s.Load<Pocinio>(NadjiPrestup().Id);

                s.Delete(p);

                s.Flush();
                s.Close();
                NadjiPrestup();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            PribaviPrekrsajeZatvorenika();
        }

        private Pocinio NadjiPrestup()
        {
            foreach (Pocinio p in Pocinio)
            {
                if (p.Id.ToString() == dataGridViewPrestupi.SelectedCells[0].Value.ToString())
                    return p;
            }
            MessageBox.Show("Pocinio Error");
            return null;
        }
    }
}
