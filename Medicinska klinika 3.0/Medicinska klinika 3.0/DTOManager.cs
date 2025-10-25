using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Medicinska_klinika_3._0.FormDodaj;
using MedicinskaKlinika.Entiteti;
using NHibernate;

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

        public static void dodajTermin(TerminBasic ter)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {
                    
                    Termin termin = new Termin
                    {
                        Datum = ter.Datum,
                        Vreme = ter.Vreme,
                        Pacijent = ter.Pacijent,
                        Lekar = ter.Lekar,
                        Odeljenje = ter.Odeljenje,
                    };

                    s.SaveOrUpdate(termin);
                    s.Flush();
                    s.Close();
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

        public static List<TerminPogled> vratiPogledTermin()
        {
            List<TerminPogled> termini = new List<TerminPogled>();
            ISession s = DataLayer.GetSession();
            var t = s.Query<Termin>().ToList();
            foreach (Termin termin in t)
            {
                termini.Add(new TerminPogled(termin.IdTermina,termin.Datum,termin.Vreme));
            }
            s.Close();
            return termini;
        }

        public static List<RFZOPogled> vratiPogledRFZO()
        {
            List<RFZOPogled> rfzos = new List<RFZOPogled>();
            ISession s = DataLayer.GetSession();
            var r = s.Query<RFZO>().ToList();
            foreach(RFZO rfzo in r)
            {
                rfzos.Add(new RFZOPogled(rfzo.IdOsiguranja, rfzo.Pacijent));
            }
            s.Close();
            return rfzos;
        }

        public static List<RacunPogled> vratiPogledRacun()
        {
            List<RacunPogled> racuni = new List<RacunPogled>();
            ISession s = DataLayer.GetSession();
            var r = s.Query<Racun>().ToList();
            foreach (Racun racun in r)
            {
                racuni.Add(new RacunPogled(racun.Id, racun.Cena,racun.VrstaUsluge));
            }
            s.Close();
            return racuni;
        }

        public static List<PrivatnoOsiguranjePogled> vratiPogledPrivatnoOsiguranje()
        {
            List<PrivatnoOsiguranjePogled> osiguranja = new List<PrivatnoOsiguranjePogled>();
            ISession s = DataLayer.GetSession();
            var o = s.Query<PrivatnoOsiguranje>().ToList();
            foreach (PrivatnoOsiguranje osiguranje in o)
            {
                osiguranja.Add(new PrivatnoOsiguranjePogled(osiguranje.BrPolise, osiguranje.OsiguravajucaKuca));
            }
            s.Close();
            return osiguranja;
        }
        public static Pacijent nadjiPacijenta(int idKartona)
        {
            ISession s = DataLayer.GetSession();
            Pacijent p = s.Query<Pacijent>().FirstOrDefault(x => x.IdKartona == idKartona);
            s.Close();
            return p;
        }

        public static Odeljenje nadjiOdeljenje(string Naziv)
        {
            ISession s = DataLayer.GetSession();
            Odeljenje odeljenje = s.Query<Odeljenje>().FirstOrDefault(x => x.Naziv == Naziv);
            s.Close();
            return odeljenje;
        }

        public static Lekar nadjiLekara(int JMBG)
        {
            ISession s = DataLayer.GetSession();
            Lekar lekar = s.Query<Lekar>().FirstOrDefault(x => x.JMBG == JMBG);
            s.Close();
            return lekar;
        }

        public static Termin nadjiTermin(int idTermina)
        {
            ISession s = DataLayer.GetSession();
            Termin termin = s.Query<Termin>().FirstOrDefault(x=> x.IdTermina == idTermina);
            s.Close();
            return termin;
        }

        public static RFZO nadjiRFZO(int idOsiguranja)
        {
            ISession s = DataLayer.GetSession();
            RFZO rfzo = s.Query<RFZO>().FirstOrDefault(x => x.IdOsiguranja == idOsiguranja);
            s.Close();
            return rfzo;
        }
        public static void dodajRFZO(RFZOBasic r)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {


                    RFZO rfzo = new RFZO
                    {
                        IdOsiguranja = r.IdOsiguranja,
                        Pacijent = r.Pacijent,
                    };
                    s.SaveOrUpdate(rfzo);
                    s.Flush();
                    s.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Greška pri dodavanju RFZO: " + ex.Message);
            }

        }
        public static Lokacija nadjiLokaciju(string Adresa)
        {
            ISession s = DataLayer.GetSession();
            Lokacija lokacija = s.Query<Lokacija>().FirstOrDefault(x => x.Adresa == Adresa);
            s.Close();
            return lokacija;
        }

        public static Racun nadjiRacun(int Id)
        {
            ISession s = DataLayer.GetSession();
            Racun racun = s.Query<Racun>().FirstOrDefault(x => x.Id == Id);
            s.Close();
            return racun;
        }

        public static PrivatnoOsiguranje nadjiPrivatnoOsiguranje(int idOsiguranja)
        {
            ISession s = DataLayer.GetSession();
            PrivatnoOsiguranje osiguranje = s.Query<PrivatnoOsiguranje>().FirstOrDefault(x => x.IdOsiguranja == idOsiguranja);
            s.Close();
            return osiguranje;
        }
        public static void dodajAdministrativnoOsoblje(AdministrativnoOsobljeBasic a)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {

                    
                    AdministrativnoOsoblje admin = new AdministrativnoOsoblje();

                    admin.Adresa = a.Adresa;
                    admin.Pozicija = a.Pozicija;
                    admin.DatumZaposlenja = a.DatumZaposlenja;
                    admin.AdresaLokacije = a.AdresaLokacije;
                    admin.Emails = a.Emails;
                    admin.DatumRodjenja = a.DatumRodjenja;
                    admin.Odeljenja = a.Odeljenja;
                    admin.Ime = a.Ime;
                    admin.Prezime = a.Prezime;
                    admin.JMBG = a.JMBG;
                    admin.Smena = a.Smena;
                    admin.Telefons = a.Telefons;

                    foreach (var email in admin.Emails)
                    {
                        email.Zaposlen = admin;
                    }

                    foreach (var broj in admin.Telefons)
                    {
                        broj.Zaposlen = admin;
                    }

                    s.SaveOrUpdate(admin);
                    s.Flush();
                    s.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri dodavanju termina: " + ex.Message);
            }
        }
        public static void dodajRacun(RacunBasic r)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {

                    Racun racun = new Racun
                    {
                        Popust = r.Popust,
                        VrstaUsluge = r.VrstaUsluge,
                        Datum = r.Datum,
                        Cena = r.Cena,
                        Lekar = r.Lekar,
                        Pacijent = r.Pacijent
                    };

                    s.SaveOrUpdate(racun);
                    s.Flush();
                    s.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri dodavanju racuna: " + ex.Message);
            }
        }

        public static void dodajPrivatnoOsiguranje(PrivatnoOsiguranjeBasic p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {

                    PrivatnoOsiguranje priv = new PrivatnoOsiguranje
                    {
                        BrPolise = p.BrPolise,
                        OsiguravajucaKuca = p.OsiguravajucaKuca,
                        Pacijent = p.Pacijent,
                    };
                    s.SaveOrUpdate(priv);
                    s.Flush();
                    s.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri dodavanju termina: " + ex.Message);
            }
        }

        public static void dodajPregled(PregledBasic p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {

                    Pregled pr = new Pregled
                    {
                        Pacijent = p.Pacijent,
                        Lekar = p.Lekar,
                        Termin = p.Termin,
                        Odeljenje = p.Odeljenje,
                        Vreme = p.Vreme,
                        Datum = p.Datum,
                        OpisTegoba = p.OpisTegoba,
                        Dijagnoza = p.Dijagnoza,
                        PreporukaZaLecenje = p.PreporukaZaLecenje,
                        Terapija = p.Terapija,
                        VrstaPregleda = p.VrstaPregleda,
                    };
                    s.SaveOrUpdate(pr);
                    s.Flush();
                    s.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri dodavanju termina: " + ex.Message);
            }
        }

        public static void dodajPlacanje(PlacanjeBasic p)
        {
            try
            {
                using (ISession s = DataLayer.GetSession())
                {

                    Placanje pl = new Placanje
                    {
                        ProcenatPacijenta = p.ProcenatPacijenta,
                        NacinPlacanja = p.NacinPlacanja,
                        PlatioPacijent = p.PlatioPacijent,
                        Racun = p.Racun,
                        PrivatnoOsiguranje = p.PrivatnoOsiguranje,
                        RFZO = p.RFZO,
                    };
                    s.SaveOrUpdate(pl);
                    s.Flush();
                    s.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri dodavanju termina: " + ex.Message);
            }
        }






    }
}

