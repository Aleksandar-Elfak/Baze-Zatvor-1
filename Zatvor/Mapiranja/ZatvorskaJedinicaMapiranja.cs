using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zatvor.Entiteti;
using FluentNHibernate.Mapping;

namespace Zatvor.Mapiranja
{
    class ZatvorskaJedinicaMapiranja : ClassMap<ZatvorskaJedinica>
    {
        public ZatvorskaJedinicaMapiranja()
        {
            Table("ZATVORSKA_JEDINICA");

            //mapiranje primarnog kljuca
            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            //mapiranje svojstava
            Map(x => x.Sifra, "SIFRA");
            Map(x => x.Naziv, "NAZIV");
            Map(x => x.Adresa, "ADRESA");
            Map(x => x.Kapacitet, "KAPACITET");
            Map(x => x.OtvoreniF, "OTVORENI_F");
            Map(x => x.PoluOtvoreniF, "POLUOTVORENI_F");
            Map(x => x.PeriodZakljucavanja, "PERIOD_ZAKLJUCAVANJA");
            Map(x => x.StrogiF, "STROGI_F");
            Map(x => x.Setnja, "SETNJA");

            References(x => x.Upravnik).Column("ID_UPRAVNIKA").LazyLoad();
            HasMany(x => x.Zatvorenici).KeyColumn("ID_ZATVORSKE_JEDINICE").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Zaposleni).KeyColumn("ID_ZATVORSKE_JEDINICE").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.TerminiPosete).KeyColumn("ID_ZATVORSKE_JEDINICE").LazyLoad().Cascade.All().Inverse();

            HasManyToMany(x => x.Firme)
                .Table("SARADJUJE")
                .ParentKeyColumn("ID_ZATVORSKE_JEDINICE")
                .ChildKeyColumn("ID_FIRME")
                .Cascade.All()
                .Inverse();
        }
    }
}
