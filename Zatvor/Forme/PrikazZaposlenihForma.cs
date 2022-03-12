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

namespace Zatvor.Forme
{
    public partial class PrikazZaposlenihForma : Form
    {
        public ZatvorskaJedinica zatvor { get; set; }
        public PrikazZaposlenihForma()
        {
            InitializeComponent();
        }

        private void PrikazZaposlenihForma_Load(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();

            ZatvorskaJedinica o = s.Get<ZatvorskaJedinica>(zatvor.Id);

            foreach (Zaposleni zaposleni in o.Zaposleni)
            {
                dataGridViewZaposleni.Rows.Add(
                    zaposleni.Jmbg,
                    zaposleni.Ime,
                    zaposleni.Prezime,
                    zaposleni.Pol,
                    zaposleni.DatumPPZ,
                    zaposleni.NazivRadnogMesta,
                    zaposleni.DatumPocetkaRada,
                    zaposleni.NazivRadnogMesta == "Administracija" ? zaposleni.AStrucnaSprema : "-",
                    zaposleni.NazivRadnogMesta == "Administracija" ? zaposleni.AZanimanje : "-",
                    zaposleni.NazivRadnogMesta == "Administracija" ? zaposleni.APozicija : "-"
                    );
            }
            s.Close();
        }
    }
}
