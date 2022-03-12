using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zatvor.Entiteti
{
    public class ZatvorskaJedinica
    {
        public virtual int Id { get; set; }
		public virtual string Sifra { get; set; }
		public virtual string Naziv { get; set; }
		public virtual string Adresa { get; set; }
		public virtual int Kapacitet { get; set; }
		public virtual char OtvoreniF { get; set; }
		public virtual char PoluOtvoreniF { get; set; }
		public virtual string PeriodZakljucavanja { get; set; }
		public virtual char StrogiF { get; set; }
		public virtual string Setnja { get; set; }
		public virtual Zaposleni Upravnik { get; set; }
        public virtual IList<Zatvorenik> Zatvorenici { get; set; }
		public virtual IList<Zaposleni> Zaposleni { get; set; }
		public virtual IList<Firma> Firme { get; set; }
        public virtual IList<StrogTerminPosete> TerminiPosete { get; set; }

        public ZatvorskaJedinica()
        {
			Firme = new List<Firma>();
			Zatvorenici = new List<Zatvorenik>();
			Zaposleni = new List<Zaposleni>();
			TerminiPosete = new List<StrogTerminPosete>();
		}
	}
}
