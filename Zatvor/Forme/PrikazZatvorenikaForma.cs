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
    public partial class PrikazZatvorenikaForma : Form
    {
        public ZatvorskaJedinica zatvor { get; set; }
        public PrikazZatvorenikaForma()
        {
            InitializeComponent();
        }

        private void PrikazZatvorenika_Load(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();

            ZatvorskaJedinica o = s.Get<ZatvorskaJedinica>(zatvor.Id);

            foreach (Zatvorenik zatvorenik in o.Zatvorenici)
            {
                dataGridViewZatvorenici.Rows.Add(
                    zatvorenik.Jmbg,
                    zatvorenik.Ime, 
                    zatvorenik.Prezime,
                    zatvorenik.Pol, 
                    zatvorenik.Broj,
                    zatvorenik.Adresa, 
                    zatvorenik.DatumSaslusanja != null ?
                    zatvorenik.DatumSaslusanja.Value.Day + "-" +
                    zatvorenik.DatumSaslusanja.Value.Month + "-" +
                    zatvorenik.DatumSaslusanja.Value.Year : "/",
                    zatvorenik.StatusUslovnogOtpusta,
                    zatvorenik.ZatvorskaJedinica.Naziv
                    );
            }
            s.Close();
        }
    }
}
