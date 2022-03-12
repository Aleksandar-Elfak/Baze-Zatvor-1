using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zatvor.Entiteti
{
    abstract public class Zaposleni
    {
        public virtual int Id { get; set; }
        public virtual string Jmbg { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual char Pol { get; set; }
        public virtual DateTime? DatumPPZ { get; set; }
        public virtual string NazivRadnogMesta { get; set; }
        public virtual string AStrucnaSprema { get; set; }
        public virtual string AZanimanje { get; set; }
        public virtual string APozicija { get; set; }
        public virtual DateTime DatumPocetkaRada { get; set; }
        public virtual ZatvorskaJedinica ZatvorskaJedinica { get; set; }


        public Zaposleni() { }



    }
    public class Upravnik : Zaposleni
    {
        public Upravnik() { }


        public override string ToString()
        {
            return "Upravnik";
        }
    }
    public class ZaposlenUAdministraciji : Zaposleni
    {
        public ZaposlenUAdministraciji() { }


        public override string ToString()
        {
            return "Administracija";
        }
    }
    public class Psiholog : Zaposleni
    {
        public Psiholog() { }

        public override string ToString()
        {
            return "Psiholog";
        }
    }
    public class Radnik_obezbedjenja : Zaposleni
    {
        public Radnik_obezbedjenja() { }


        public override string ToString()
        {
            return "Obezbedjenje";
        }
    }
}
