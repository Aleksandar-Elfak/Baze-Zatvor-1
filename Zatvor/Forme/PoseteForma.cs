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
    public partial class PoseteForma : Form
    {
        public Zatvorenik zatvorenik { get; set; }
        public List<Posecuje> posete = new List<Posecuje>();
        public List<Advokat> advokati = new List<Advokat>();
        public PoseteForma()
        {
            InitializeComponent();
        }

        private void PoseteForma_Load(object sender, EventArgs e)
        {
            PripremiAdvokate();
            PopuniPosete();
            if(advokati.Count == 0)
            {
                buttonDodaj.Enabled = false;
                buttonObrisi.Enabled = false;
            }
        }

        private void PripremiAdvokate()
        {
            comboBox1.Items.Clear();
            advokati.Clear();
            try
            {
                ISession s = DataLayer.GetSession();

                ICriteria c = s.CreateCriteria<Zastupa>();
                c.Add(Expression.Eq("Zatvorenik", zatvorenik));

                IList<Zastupa> zastupanjaIzBaze = c.List<Zastupa>();

                foreach (Zastupa item in zastupanjaIzBaze)
                {
                    advokati.Add(item.Advokat);
                    comboBox1.Items.Add(item.Advokat.Ime + " " + item.Advokat.Prezime);
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

        private void PopuniPosete()
        {
            dataGridViewPosete.Rows.Clear();
            posete.Clear();
            try
            {
                ISession s = DataLayer.GetSession();

                ICriteria c = s.CreateCriteria<Posecuje>();
                c.Add(Expression.Eq("Zatvorenik", zatvorenik));

                IList<Posecuje> poseteIzBaze = c.List<Posecuje>();


                foreach (Posecuje poseta in poseteIzBaze)
                {
                    posete.Add(poseta);
                    dataGridViewPosete.Rows.Add(
                        poseta.Id,
                        poseta.Advokat.Ime + " " +
                        poseta.Advokat.Prezime,
                        poseta.VremePocetka,
                        poseta.VremeKraja
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

        private void buttonNazad_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Posecuje p = s.Load<Posecuje>(NadjiPosetu().Id);

                s.Delete(p);

                s.Flush();
                s.Close();
                NadjiPosetu();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            PopuniPosete();
        }

        private Posecuje NadjiPosetu()
        {
            foreach (Posecuje poseta in posete)
            {
                if (poseta.Id.ToString() == dataGridViewPosete.SelectedCells[0].Value.ToString())
                    return poseta;
            }
            MessageBox.Show("Pocinio Error");
            return null;
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if(dateTimePickerPocetak.Value > dateTimePickerKraj.Value)
            {
                MessageBox.Show("Vreme kraja ne moze biti pre vremena pocetka.");
                return; ;
            }
            try
            {
                ISession s = DataLayer.GetSession();

                Posecuje p = new Posecuje();

                p.VremePocetka = dateTimePickerPocetak.Value;
                p.VremeKraja = dateTimePickerKraj.Value;
                p.Zatvorenik = zatvorenik;
                p.Advokat = advokati[comboBox1.SelectedIndex];

                s.Save(p);

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            PopuniPosete();
        }
    }
}
