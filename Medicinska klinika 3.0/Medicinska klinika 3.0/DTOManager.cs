using MedicinskaKlinika.Entiteti;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicinskaKlinika
{
    public class DTOManager
    {
        public static void dodajAdministrativnoOsoblje(AdministrativnoOsobljeBasic a, List<string> emails, List<string> telefons, List<string> odeljenja)
        {
            ISession s = DataLayer.GetSession();

            AdministrativnoOsoblje ad = new AdministrativnoOsoblje();

            
            ad.Adresa = a.Adresa;
            ad.DatumRodjenja = a.DatumRodjenja;
            var loc = s.Load<Lokacija>(a.AdresaLokacije);
            ad.AdresaLokacije = loc;
            //ad.AdresaLokacije = a.AdresaLokacije;
            ad.Pozicija = a.Pozicija;
            ad.JMBG = a.JMBG;
            ad.DatumZaposlenja = a.DatumZaposlenja;
            ad.Pozicija = a.Pozicija;
            ad.Ime = a.Ime;
            ad.Prezime = a.Prezime;
            ad.Smena = a.Smena;


            foreach (var item in odeljenja)
            {
                var od = s.Load<Odeljenje>(item);
                ad.Odeljenja.Add(od);
            }

            s.SaveOrUpdate(ad);


            foreach (var item in emails)
            {
                EmailZaposlenog em = new EmailZaposlenog();
                em.Zaposlen = ad;
                em.Email = item;
                s.SaveOrUpdate(em);
            }

            foreach (var item in telefons)
            {
                BrTelefonaZaposlenog tel = new BrTelefonaZaposlenog();
                tel.Zaposlen = ad;
                tel.BrojTelefona = item;
                s.SaveOrUpdate(tel);
            }


            s.Flush();
            s.Close();
        }

        public static List<OdeljenjePogled> vratipogledodaljenja()
        {
            List<OdeljenjePogled> odeljenja = new List<OdeljenjePogled>();

            ISession s = DataLayer.GetSession();

            var o = s.Query<Odeljenje>().ToList();

            foreach (Odeljenje odeljenje in o)
            {
                odeljenja.Add(new OdeljenjePogled(odeljenje.Naziv));
            }
            s.Close();
            return odeljenja;
        }

        public static void dodajLokaciju(LokacijaBasic l)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Lokacija lokacija = new Lokacija();
                lokacija.Adresa = l.Adresa;
                lokacija.RadnoVreme = l.RadnoVreme;

                s.SaveOrUpdate(lokacija);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
            }
        }

        public static List<PacijentPogled> vratipogledpacijenta()
        {
            List<PacijentPogled> pacijenti = new List<PacijentPogled>();
            ISession s = DataLayer.GetSession();
            var p = s.Query<Pacijent>().ToList();
            foreach (Pacijent pacijent in p)
            {
                pacijenti.Add(new PacijentPogled(pacijent.IdKartona,pacijent.Ime, pacijent.Prezime));
            }
            s.Close();
            return pacijenti;
        }

        public static List<ZaposlenPogled> vratipogledlekara()
        {
            List<ZaposlenPogled> lekari = new List<ZaposlenPogled>();
            ISession s = DataLayer.GetSession();
            var p = s.Query<Lekar>().ToList();
            foreach (Lekar lekar in p)
            {
                lekari.Add(new ZaposlenPogled(lekar.JMBG, lekar.Ime, lekar.Prezime));
            }
            s.Close();
            return lekari;
        }

        public static void dodajTermin(DateTime datum, DateTime vreme, int idKartona, string nazivOdeljenja, int jmbgLekara)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    
                    Pacijent p = s.Query<Pacijent>()
                                  .FirstOrDefault(x => x.IdKartona == idKartona);

                    
                    Lekar lekar = s.Query<Lekar>()
                                   .FirstOrDefault(x => x.JMBG == jmbgLekara);

                    
                    Odeljenje odeljenje = s.Query<Odeljenje>()
                                           .FirstOrDefault(x => x.Naziv == nazivOdeljenja);

                    
                    Termin termin = new Termin
                    {
                        Datum = datum,
                        Vreme = vreme,
                        Pacijent = p,
                        Lekar = lekar,
                        Odeljenje = odeljenje
                    };

                    s.SaveOrUpdate(termin);
                    s.Flush();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri dodavanju termina: " + ex.Message);
            }
        }

        public static List<LokacijaPogled> vratiPogledLokacija()
        {
            List<LokacijaPogled> lokacije = new List<LokacijaPogled>();
            ISession s = DataLayer.GetSession();
            var p = s.Query<Lokacija>().ToList();
            foreach (Lokacija lokacija in p)
            {
                lokacije.Add(new LokacijaPogled(lokacija.Adresa));
            }
            s.Close();
            return lokacije;
        }

    }
}
