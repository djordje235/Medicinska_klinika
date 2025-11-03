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
using NHibernate.Linq;
using NHibernate.Stat;
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

        public static void dodajLokaciju(LokacijaBasic l,bool f)
        {
            try
            {
                Lokacija lokacija;
                ISession s = DataLayer.GetSession();

                if (f)
                {
                    lokacija = nadjiLokaciju(l.Adresa);
                    lokacija.Adresa = l.Adresa;
                    lokacija.RadnoVreme = l.RadnoVreme;
                }
                else
                {
                lokacija = new Lokacija();
                lokacija.Adresa = l.Adresa;
                lokacija.RadnoVreme = l.RadnoVreme;
                }

                

                s.SaveOrUpdate(lokacija);
                s.Flush();
                s.Close();
            }
            catch (Exception ex)
            {
            }
        }

        public static List<PacijentBasic> vratipacijentebasic()
        {
            List<PacijentBasic> pacijenti = new List<PacijentBasic>();
            ISession s = DataLayer.GetSession();
            var p = s.Query<Pacijent>().ToList();
            foreach (Pacijent pacijent in p)
            {
                pacijenti.Add(new PacijentBasic(pacijent.Adresa, pacijent.IdKartona, pacijent.Ime, pacijent.Prezime, pacijent.DatumRodjenja, pacijent.Pol, pacijent.Lekar, pacijent.RFZO, pacijent.PrivatnoOsiguranje));
            }
            s.Close();
            return pacijenti;
        }

        public static List<PacijentPogled> vratipogledpacijenta()
        {
            List<PacijentPogled> pacijenti = new List<PacijentPogled>();
            ISession s = DataLayer.GetSession();
            var p = s.Query<Pacijent>().ToList();
            foreach (Pacijent pacijent in p)
            {
                pacijenti.Add(new PacijentPogled(pacijent.IdKartona, pacijent.Ime, pacijent.Prezime));
            }
            s.Close();
            return pacijenti;
        }

        public static List<LekarPogled> vratipogledlekara()
        {
            List<LekarPogled> lekari = new List<LekarPogled>();
            ISession s = DataLayer.GetSession();
            var p = s.Query<Lekar>().ToList();
            foreach (Lekar lekar in p)
            {
                lekari.Add(new LekarPogled(lekar.JMBG, lekar.Ime, lekar.Prezime,lekar.Odeljenje));
            }
            s.Close();
            return lekari;
        }

        public static List<ZaposlenPogled> vratipogledlaboranti()
        {
            List<ZaposlenPogled> laboranti = new List<ZaposlenPogled>();
            ISession s = DataLayer.GetSession();
            var p = s.Query<Laborant>().ToList();
            foreach (Laborant laborant in p)
            {
                laboranti.Add(new ZaposlenPogled(laborant.JMBG, laborant.Ime, laborant.Prezime));
            }
            s.Close();
            return laboranti;
        }

        public static void dodajTermin(TerminBasic ter, bool f)
        {
            try
            {
                Termin termin = nadjiTermin(ter.IdTermina);

                using (ISession s = DataLayer.GetSession())
                {


                    if (f)
                    {
                        termin.Datum = ter.Datum;
                        termin.Vreme = ter.Vreme;
                        termin.Pacijent = ter.Pacijent;
                        termin.Lekar = ter.Lekar;
                        termin.Odeljenje = ter.Odeljenje;
                    }
                    else
                    {
                        termin = new Termin
                        {
                            Datum = ter.Datum,
                            Vreme = ter.Vreme,
                            Pacijent = ter.Pacijent,
                            Lekar = ter.Lekar,
                            Odeljenje = ter.Odeljenje,
                        };
                    }

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
                termini.Add(new TerminPogled(termin.IdTermina, termin.Datum, termin.Vreme,termin.Pregled));
            }
            s.Close();
            return termini;
        }

        public static List<RFZOPogled> vratiPogledRFZO()
        {
            List<RFZOPogled> rfzos = new List<RFZOPogled>();
            ISession s = DataLayer.GetSession();
            var r = s.Query<RFZO>().ToList();
            foreach (RFZO rfzo in r)
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
                racuni.Add(new RacunPogled(racun.Id, racun.Cena, racun.VrstaUsluge,racun.Placanje));
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
                osiguranja.Add(new PrivatnoOsiguranjePogled(osiguranje.BrPolise, osiguranje.OsiguravajucaKuca,osiguranje.IdOsiguranja));
            }
            s.Close();
            return osiguranja;
        }
        public static Pacijent nadjiPacijenta(int idKartona)
        {
            ISession s = DataLayer.GetSession();
            Pacijent p = s.Query<Pacijent>().FirstOrDefault(x => x.IdKartona == idKartona);

            if (p != null)
            {
                NHibernateUtil.Initialize(p.Emails);
                NHibernateUtil.Initialize(p.Telefons);
            }
            s.Close();
            return p;
        }

        public static Odeljenje nadjiOdeljenje(string Naziv)
        {
            ISession s = DataLayer.GetSession();
            Odeljenje odeljenje = s.Query<Odeljenje>()
                                    .FetchMany(x => x.Lokacije)
                                    .Fetch(x => x.GlavniLekar)
                                    .Where(x => x.Naziv == Naziv)
                                    .ToList()
                                    .FirstOrDefault();

            s.Close();
            return odeljenje;
        }

        public static Lekar nadjiLekara(int JMBG)
        {
            ISession s = DataLayer.GetSession();
            Lekar lekar = s.Query<Lekar>().FirstOrDefault(x => x.JMBG == JMBG);

            if (lekar != null)
            {
                NHibernateUtil.Initialize(lekar.Emails);
                NHibernateUtil.Initialize(lekar.Telefons);
                NHibernateUtil.Initialize(lekar.Odeljenja);
            }

            s.Close();
            return lekar;
        }

        public static Laborant nadjiLaboranta(int JMBG)
        {
            ISession s = DataLayer.GetSession();
            Laborant laborant = s.Query<Laborant>().FirstOrDefault(x => x.JMBG == JMBG);

            if (laborant != null)
            {
                NHibernateUtil.Initialize(laborant.Emails);
                NHibernateUtil.Initialize(laborant.Telefons);
                NHibernateUtil.Initialize(laborant.Odeljenja);
            }

            s.Close();
            return laborant;
        }

        public static Termin nadjiTermin(int idTermina)
        {
            ISession s = DataLayer.GetSession();
            Termin termin = s.Query<Termin>()
                        .Fetch(t => t.Pregled)
                        .FirstOrDefault(x => x.IdTermina == idTermina);
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
        public static void dodajRFZO(RFZOBasic r, bool f)
        {
            try
            {
                RFZO rfzo = nadjiRFZO(r.IdOsiguranja);
                using (ISession s = DataLayer.GetSession())
                {

                    if (f)
                    {
                        rfzo.IdOsiguranja = r.IdOsiguranja;
                        rfzo.Pacijent = r.Pacijent;
                    }
                    else
                    {
                        rfzo = new RFZO
                        {
                            IdOsiguranja = r.IdOsiguranja,
                            Pacijent = r.Pacijent,
                        };
                    }
                    s.SaveOrUpdate(rfzo);
                    s.Flush();
                    s.Close();
                }
            }
            catch (Exception ex)
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

        public static Pregled nadjiPregled(int id)
        {
            ISession s = DataLayer.GetSession();
            Pregled pregled = s.Query<Pregled>()
                .Fetch(x => x.Termin)
                .FirstOrDefault(x => x.IdPregleda == id);
            s.Close();
            return pregled;
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
        public static void dodajAdministrativnoOsoblje(AdministrativnoOsobljeBasic a,bool f)
        {
            try
            {
                AdministrativnoOsoblje admin;
                using (ISession s = DataLayer.GetSession())
                {
                    if (f)
                    {
                        admin = nadjiAdministrativnoOsoblje(a.JMBG);
                    }
                    else
                    {
                        admin = new AdministrativnoOsoblje();
                    }


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

        public static AdministrativnoOsoblje nadjiAdministrativnoOsoblje(int jmbg)
        {
            ISession s = DataLayer.GetSession();
            AdministrativnoOsoblje osoblje = s.Query<AdministrativnoOsoblje>()
                .FirstOrDefault(x => x.JMBG == jmbg);

            if (osoblje != null)
            {
                NHibernateUtil.Initialize(osoblje.Emails);
                NHibernateUtil.Initialize(osoblje.Telefons);
                NHibernateUtil.Initialize(osoblje.Odeljenja);
            }

            s.Close();
            return osoblje;
        }
        public static void dodajRacun(RacunBasic r, bool f)
        {
            try
            {
                Racun racun = nadjiRacun(r.Id);
                using (ISession s = DataLayer.GetSession())
                {
                    if (f)
                    {
                        racun.Popust = r.Popust;
                        racun.VrstaUsluge = r.VrstaUsluge;
                        racun.Datum = r.Datum;
                        racun.Cena = r.Cena;
                        racun.Lekar = r.Lekar;
                        racun.Pacijent = r.Pacijent;
                    }
                    else
                    {
                        racun = new Racun
                        {
                            Popust = r.Popust,
                            VrstaUsluge = r.VrstaUsluge,
                            Datum = r.Datum,
                            Cena = r.Cena,
                            Lekar = r.Lekar,
                            Pacijent = r.Pacijent
                        };
                    }


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

        public static void dodajPrivatnoOsiguranje(PrivatnoOsiguranjeBasic p, bool f)
        {
            try
            {
                PrivatnoOsiguranje osiguranje = nadjiPrivatnoOsiguranje(p.IdOsiguranja);
                using (ISession s = DataLayer.GetSession())
                {
                    if (f)
                    {
                        osiguranje.BrPolise = p.BrPolise;
                        osiguranje.OsiguravajucaKuca = p.OsiguravajucaKuca;
                        osiguranje.Pacijent = p.Pacijent;
                    }
                    else
                    {
                        osiguranje = new PrivatnoOsiguranje
                        {
                            BrPolise = p.BrPolise,
                            OsiguravajucaKuca = p.OsiguravajucaKuca,
                            Pacijent = p.Pacijent,
                        };
                    }

                    s.SaveOrUpdate(osiguranje);
                    s.Flush();
                    s.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri dodavanju termina: " + ex.Message);
            }
        }



        public static Pregled dodajPregled(PregledBasic p, bool f)
        {
            try
            {
                Pregled dodatni = null;
                Pregled pregled = nadjiPregled(p.IdPregleda);
                if (p.DodatniPregled != null)
                {
                    dodatni = nadjiPregled(p.DodatniPregled.IdPregleda);
                }

                using (ISession s = DataLayer.GetSession())
                {

                    if (f)
                    {


                        pregled.Pacijent = p.Pacijent;
                        pregled.Lekar = p.Lekar;
                        pregled.Termin = p.Termin;
                        pregled.Odeljenje = p.Odeljenje;
                        pregled.Vreme = p.Vreme;
                        pregled.Datum = p.Datum;
                        pregled.OpisTegoba = p.OpisTegoba;
                        pregled.Dijagnoza = p.Dijagnoza;
                        pregled.PreporukaZaLecenje = p.PreporukaZaLecenje;
                        pregled.Terapija = p.Terapija;
                        pregled.VrstaPregleda = p.VrstaPregleda;

                        pregled.DodatniPregled = dodatni;

                    }
                    else
                    {


                        pregled = new Pregled
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
                        if (p.DodatniPregled != null)
                        {
                            dodatni = new Pregled
                            {
                                Pacijent = p.DodatniPregled.Pacijent,
                                Lekar = p.DodatniPregled.Lekar,
                                Termin = p.DodatniPregled.Termin,
                                Odeljenje = p.DodatniPregled.Odeljenje,
                                Vreme = p.DodatniPregled.Vreme,
                                Datum = p.DodatniPregled.Datum,
                                OpisTegoba = p.DodatniPregled.OpisTegoba,
                                Dijagnoza = p.DodatniPregled.Dijagnoza,
                                PreporukaZaLecenje = p.DodatniPregled.PreporukaZaLecenje,
                                Terapija = p.DodatniPregled.Terapija,
                                VrstaPregleda = p.DodatniPregled.VrstaPregleda,
                                DodatniPregled = null,

                            };
                            pregled.DodatniPregled = dodatni;
                        }
                        else
                        {
                            pregled.DodatniPregled = null;
                        }
                    }

                    s.SaveOrUpdate(pregled);
                    s.Flush();
                    s.Close();
                    return pregled;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri dodavanju pregleda: " + ex.Message);
                return null;
            }
        }

        public static void dodajPlacanje(PlacanjeBasic p,bool f)
        {
            try
            {
                Placanje placanje = nadjiPlacanje(p.IdPlacanja);
                using (ISession s = DataLayer.GetSession())
                {

                    if (f)
                    {
                        placanje.ProcenatPacijenta = p.ProcenatPacijenta;
                        placanje.NacinPlacanja = p.NacinPlacanja;
                        placanje.PlatioPacijent = p.PlatioPacijent;
                        placanje.Racun = p.Racun;
                        placanje.PrivatnoOsiguranje = p.PrivatnoOsiguranje;
                        placanje.RFZO = p.RFZO;
                    }
                    else
                    {
                        placanje = new Placanje
                        {
                            ProcenatPacijenta = p.ProcenatPacijenta,
                            NacinPlacanja = p.NacinPlacanja,
                            PlatioPacijent = p.PlatioPacijent,
                            Racun = p.Racun,
                            PrivatnoOsiguranje = p.PrivatnoOsiguranje,
                            RFZO = p.RFZO,
                        };
                    }




                    s.SaveOrUpdate(placanje);
                    s.Flush();
                    s.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri dodavanju termina: " + ex.Message);
            }
        }

        public static Placanje nadjiPlacanje(int Id)
        {
            ISession s = DataLayer.GetSession();
            Placanje placanje = s.Query<Placanje>()
                .Fetch(x => x.Racun)
                .FirstOrDefault(x => x.IdPlacanja == Id);
            s.Close();
            return placanje;
        }

        public static void dodajLaboranta(LaborantBasic a,bool f)
        {
            try
            {
                Laborant admin;
                using (ISession s = DataLayer.GetSession())
                {
                    

                    if (f)
                    {
                        admin = nadjiLaboranta(a.JMBG);
                    }
                    else
                    {
                        admin = new Laborant();
                    }

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
                    admin.OblastRada = a.OblastRada;
                    admin.Sertifikat = a.Sertifikat;

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

        public static void dodajMedicinskuSestru(MedicinskaSestraBasic a,bool f)
        {
            try
            {
                MedicinskaSestra admin;
                using (ISession s = DataLayer.GetSession())
                {

                    if (f)
                    {
                        admin = nadjiMedicinskuSestru(a.JMBG);
                    }
                    else
                    {
                        admin = new MedicinskaSestra();
                    }

                    

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
                    admin.OblastRada = a.OblastRada;
                    admin.Sertifikat = a.Sertifikat;

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

        public static void dodajLekara(LekarBasic a,bool f)
        {
            try
            {
                Lekar admin;
                using (ISession s = DataLayer.GetSession())
                {

                    if (f)
                    {
                        admin = nadjiLekara(a.JMBG);
                    }
                    else
                    {
                        admin = new Lekar();
                    }


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
                    admin.Specijalizacija = a.Specijalizacija;
                    admin.BrLicence = a.BrLicence;

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

        public static void dodajPacijenta(PacijentBasic a,bool f)
        {
            try
            {
                Pacijent admin;
                using (ISession s = DataLayer.GetSession())
                {
                    if (f)
                    {
                        admin = nadjiPacijenta(a.IdKartona);
                    }
                    else
                    {
                        admin = new Pacijent();
                    }

                    admin.Adresa = a.Adresa;
                    admin.Ime = a.Ime;
                    admin.Prezime = a.Prezime;
                    admin.DatumRodjenja = a.DatumRodjenja;
                    admin.Pol = a.Pol;
                    admin.Lekar = a.Lekar;
                    admin.Emails = a.Emails;
                    admin.Telefons = a.Telefons;
                    
                    foreach (var email in admin.Emails)
                    {
                        email.Pacijent = admin;
                    }

                    foreach (var broj in admin.Telefons)
                    {
                        broj.Pacijent = admin;
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

        public static void dodajLaboratorijskuAnalizu(LaboratorijskaAnalizaBasic l,bool f)
        {
            try
            {
                LaboratorijskaAnaliza lab = nadjiLaboratorijskuAnalizu(l.IdAnalize);
                using (ISession s = DataLayer.GetSession())
                {

                    if(f)
                    {
                        lab.Pacijent = l.Pacijent;
                        lab.VrstaAnalize = l.VrstaAnalize;
                        lab.DatumUzorkovanja = l.DatumUzorkovanja;
                        lab.Vreme = l.Vreme;
                        lab.Rezultat = l.Rezultat;
                        lab.ReferentnaVrednost = l.ReferentnaVrednost;
                        lab.Komentar = l.Komentar;
                        lab.Laborant = l.Laborant;
                        lab.Pregled = l.Pregled;
                    }
                    else
                    {
                        lab = new LaboratorijskaAnaliza
                        {
                            Pacijent = l.Pacijent,
                            VrstaAnalize = l.VrstaAnalize,
                            DatumUzorkovanja = l.DatumUzorkovanja,
                            Vreme = l.Vreme,
                            Rezultat = l.Rezultat,
                            ReferentnaVrednost = l.ReferentnaVrednost,
                            Komentar = l.Komentar,
                            Laborant = l.Laborant,
                            Pregled = l.Pregled,
                        };
                    };
                    s.SaveOrUpdate(lab);
                    s.Flush();
                    s.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri dodavanju termina: " + ex.Message);
            }
        }

        public static void dodajOdeljenje(OdeljenjeBasic o,bool f)
        {
            try
            {
                Odeljenje od;
                using (ISession s = DataLayer.GetSession())
                {

                    if (f)
                    {
                        od = nadjiOdeljenje(o.Naziv);
                    }
                    else
                    {
                        od = new Odeljenje();
                    }



                    od.Naziv = o.Naziv;
                    od.BrProstorije = o.BrProstorije;
                    od.RadnoVreme = o.RadnoVreme;
                    od.GlavniLekar = o.GlavniLekar;
                    od.Lokacije = o.Lokacije;
                       
                    s.SaveOrUpdate(od);
                    s.Flush();
                    s.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri dodavanju termina: " + ex.Message);
            }

        }

        public static List<TerminiPrikaz> prikazTermina()
        {
            List<TerminiPrikaz> termini = new List<TerminiPrikaz>();

            using (ISession s = DataLayer.GetSession())
            {

                var t = s.Query<Termin>()
                    .Fetch(x => x.Pacijent)
                    .Fetch(x => x.Lekar)
                    .Fetch(x => x.Odeljenje)
                    .ToList();

                foreach (Termin termin in t)
                {

                    termini.Add(new TerminiPrikaz
                    {
                        IdTermina = termin.IdTermina,
                        Datum = termin.Datum,
                        Vreme = termin.Vreme,
                        Pacijent = new Pacijent
                        {
                            IdKartona = termin.Pacijent.IdKartona,
                            Ime = termin.Pacijent.Ime,
                            Prezime = termin.Pacijent.Prezime
                        },
                        Lekar = new Lekar
                        {
                            JMBG = termin.Lekar.JMBG,
                            Ime = termin.Lekar.Ime,
                            Prezime = termin.Lekar.Prezime
                        },
                        Odeljenje = new Odeljenje
                        {
                            Naziv = termin.Odeljenje.Naziv
                        }
                    });
                }
            }

            return termini;
        }

        public static void brisiTermin(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Termin t = s.Load<Termin>(id);

                s.Delete(t);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {

            }
        }

        public static List<RFZOPrikaz> prikazRFZO()
        {
            List<RFZOPrikaz> rfzos = new List<RFZOPrikaz>();

            using (ISession s = DataLayer.GetSession())
            {
                var r = s.Query<RFZO>().Fetch(x => x.Pacijent);

                foreach (RFZO rfzo in r)
                {
                    rfzos.Add(new RFZOPrikaz
                    {
                        IdOsiguranja = rfzo.IdOsiguranja,
                        Pacijent = new Pacijent
                        {
                            IdKartona = rfzo.Pacijent.IdKartona,
                            Ime = rfzo.Pacijent.Ime,
                            Prezime = rfzo.Pacijent.Prezime
                        }
                    });
                }
            }
            return rfzos;
        }

        public static void brisiRFZO(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                RFZO t = s.Load<RFZO>(id);

                s.Delete(t);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {

            }
        }

        public static List<RacunBasic> prikazRacuna()
        {
            List<RacunBasic> racuni = new List<RacunBasic>();

            using (ISession s = DataLayer.GetSession())
            {
                var r = s.Query<Racun>().Fetch(x => x.Pacijent).Fetch(x => x.Lekar);

                foreach (Racun racun in r)
                {
                    racuni.Add(new RacunBasic
                    {
                        Id = racun.Id,
                        Popust = racun.Popust,
                        VrstaUsluge = racun.VrstaUsluge,
                        Datum = racun.Datum,
                        Cena = racun.Cena,

                        Pacijent = new Pacijent
                        {
                            IdKartona = racun.Pacijent.IdKartona,
                            Ime = racun.Pacijent.Ime,
                            Prezime = racun.Pacijent.Prezime
                        },

                        Lekar = new Lekar
                        {
                            JMBG = racun.Lekar.JMBG,
                            Ime = racun.Lekar.Ime,
                            Prezime = racun.Lekar.Prezime
                        }
                    });
                }
            }
            return racuni;
        }

        public static void brisiRacun(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Racun t = s.Load<Racun>(id);

                s.Delete(t);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {

            }
        }

        public static List<PrivatnoOsiguranjePrikaz> prikazPrivatnogOsiguranja()
        {
            List<PrivatnoOsiguranjePrikaz> osiguranja = new List<PrivatnoOsiguranjePrikaz>();

            using (ISession s = DataLayer.GetSession())
            {
                var r = s.Query<PrivatnoOsiguranje>().Fetch(x => x.Pacijent);

                foreach (PrivatnoOsiguranje osiguranje in r)
                {
                    osiguranja.Add(new PrivatnoOsiguranjePrikaz
                    {
                        id = osiguranje.IdOsiguranja,
                        OsiguravajucaKuca = osiguranje.OsiguravajucaKuca,
                        BrPolise = osiguranje.BrPolise,
                        Pacijent = new Pacijent
                        {
                            IdKartona = osiguranje.Pacijent.IdKartona,
                            Ime = osiguranje.Pacijent.Ime,
                            Prezime = osiguranje.Pacijent.Prezime
                        }
                    });
                }
            }
            return osiguranja;
        }

        public static void brisiPrivatnoOsiguranje(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PrivatnoOsiguranje t = s.Load<PrivatnoOsiguranje>(id);

                s.Delete(t);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {

            }
        }

        public static List<PregledBasic> prikazPregleda()
        {
            List<PregledBasic> pregledi = new List<PregledBasic>();

            using (ISession s = DataLayer.GetSession())
            {

                var t = s.Query<Pregled>()
                    .Fetch(x => x.Pacijent)
                    .Fetch(x => x.Lekar)
                    .Fetch(x => x.Odeljenje)
                    .Fetch(x => x.Termin)
                    .ToList();

                foreach (Pregled pregled in t)
                {

                    pregledi.Add(new PregledBasic
                    {
                        IdPregleda = pregled.IdPregleda,
                        Datum = pregled.Datum,
                        Vreme = pregled.Vreme,
                        OpisTegoba = pregled.OpisTegoba,
                        Dijagnoza = pregled.Dijagnoza,
                        Terapija = pregled.Terapija,
                        PreporukaZaLecenje = pregled.PreporukaZaLecenje,
                        VrstaPregleda = pregled.VrstaPregleda,
                        Pacijent = new Pacijent
                        {
                            IdKartona = pregled.Pacijent.IdKartona,
                            Ime = pregled.Pacijent.Ime,
                            Prezime = pregled.Pacijent.Prezime
                        },
                        Lekar = new Lekar
                        {
                            JMBG = pregled.Lekar.JMBG,
                            Ime = pregled.Lekar.Ime,
                            Prezime = pregled.Lekar.Prezime
                        },
                        Odeljenje = new Odeljenje
                        {
                            Naziv = pregled.Odeljenje.Naziv
                        },
                        Termin = new Termin
                        {
                            Datum = pregled.Termin.Datum,
                            Vreme = pregled.Termin.Vreme
                        },

                    });
                }
            }

            return pregledi;
        }

        public static void brisiPregled(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Pregled pregled = s.Load<Pregled>(id);
                if(pregled.DodatniPregled != null)
                {
                Pregled dodatni = s.Load<Pregled>(pregled.DodatniPregled.IdPregleda);
                s.Delete(dodatni);
                }
                s.Delete(pregled);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {


            }
        }

        public static List<AdministrativnoOsobljeBasic> prikazOsoblja()
        {
            List<AdministrativnoOsobljeBasic> admini = new List<AdministrativnoOsobljeBasic>();

            using (ISession s = DataLayer.GetSession())
            {

                var t = s.Query<AdministrativnoOsoblje>()
                    .Fetch(x => x.AdresaLokacije)
                    .ToList();

                foreach (AdministrativnoOsoblje admin in t)
                {

                    admini.Add(new AdministrativnoOsobljeBasic
                    {
                        JMBG = admin.JMBG,
                        DatumZaposlenja = admin.DatumZaposlenja,
                        DatumRodjenja = admin.DatumRodjenja,
                        Pozicija = admin.Pozicija,
                        Ime = admin.Ime,
                        Prezime = admin.Prezime,
                        Adresa = admin.Adresa,
                        Smena = admin.Smena,
                        AdresaLokacije = new Lokacija
                        {
                            Adresa = admin.AdresaLokacije.Adresa,
                        }

                    });
                }
            }

            return admini;
        }

        public static void brisiAdmina(int jmbg)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                AdministrativnoOsoblje admin = s.Load<AdministrativnoOsoblje>(jmbg);
                s.Delete(admin);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {


            }
        }

        public static MedicinskaSestra nadjiMedicinskuSestru(int jmbg)
        {
            ISession s = DataLayer.GetSession();
            MedicinskaSestra osoblje = s.Query<MedicinskaSestra>()
                .FirstOrDefault(x => x.JMBG == jmbg);

            if (osoblje != null)
            {
                NHibernateUtil.Initialize(osoblje.Emails);
                NHibernateUtil.Initialize(osoblje.Telefons);
                NHibernateUtil.Initialize(osoblje.Odeljenja);
            }

            s.Close();
            return osoblje;
        }

        public static List<MedicinskaSestraBasic> prikazMedicinskeSestre()
        {
            List<MedicinskaSestraBasic> admini = new List<MedicinskaSestraBasic>();

            using (ISession s = DataLayer.GetSession())
            {

                var t = s.Query<MedicinskaSestra>()
                    .Fetch(x => x.AdresaLokacije)
                    .ToList();

                foreach (MedicinskaSestra admin in t)
                {

                    admini.Add(new MedicinskaSestraBasic
                    {
                        JMBG = admin.JMBG,
                        DatumZaposlenja = admin.DatumZaposlenja,
                        DatumRodjenja = admin.DatumRodjenja,
                        Pozicija = admin.Pozicija,
                        Ime = admin.Ime,
                        Prezime = admin.Prezime,
                        Adresa = admin.Adresa,
                        Smena = admin.Smena,
                        AdresaLokacije = new Lokacija
                        {
                            Adresa = admin.AdresaLokacije.Adresa,
                        },
                        Sertifikat = admin.Sertifikat,
                        OblastRada = admin.OblastRada,

                    });
                }
            }

            return admini;
        }

        public static void brisiMedicinskuSestru(int jmbg)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                MedicinskaSestra admin = s.Load<MedicinskaSestra>(jmbg);
                s.Delete(admin);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {


            }
        }

        public static List<LekarBasic> prikazLekara()
        {
            List<LekarBasic> admini = new List<LekarBasic>();

            using (ISession s = DataLayer.GetSession())
            {

                var t = s.Query<Lekar>()
                    .Fetch(x => x.AdresaLokacije)
                    .ToList();

                foreach (Lekar admin in t)
                {

                    admini.Add(new LekarBasic
                    {
                        JMBG = admin.JMBG,
                        DatumZaposlenja = admin.DatumZaposlenja,
                        DatumRodjenja = admin.DatumRodjenja,
                        Pozicija = admin.Pozicija,
                        Ime = admin.Ime,
                        Prezime = admin.Prezime,
                        Adresa = admin.Adresa,
                        Smena = admin.Smena,
                        AdresaLokacije = new Lokacija
                        {
                            Adresa = admin.AdresaLokacije.Adresa,
                        },
                        Specijalizacija = admin.Specijalizacija,
                        BrLicence = admin.BrLicence,

                    });
                }
            }

            return admini;
        }

        public static void brisiLekara(int jmbg)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Lekar admin = s.Load<Lekar>(jmbg);

                s.Delete(admin);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {


            }
        }

        public static List<LaborantBasic> prikazLaboranta()
        {
            List<LaborantBasic> admini = new List<LaborantBasic>();

            using (ISession s = DataLayer.GetSession())
            {

                var t = s.Query<Laborant>()
                    .Fetch(x => x.AdresaLokacije)
                    .ToList();

                foreach (Laborant admin in t)
                {

                    admini.Add(new LaborantBasic
                    {
                        JMBG = admin.JMBG,
                        DatumZaposlenja = admin.DatumZaposlenja,
                        DatumRodjenja = admin.DatumRodjenja,
                        Pozicija = admin.Pozicija,
                        Ime = admin.Ime,
                        Prezime = admin.Prezime,
                        Adresa = admin.Adresa,
                        Smena = admin.Smena,
                        AdresaLokacije = new Lokacija
                        {
                            Adresa = admin.AdresaLokacije.Adresa,
                        },
                        Sertifikat = admin.Sertifikat,
                        OblastRada = admin.OblastRada,

                    });
                }
            }

            return admini;
        }

        public static void brisiLaboranta(int jmbg)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Laborant admin = s.Load<Laborant>(jmbg);

                foreach (var analiza in admin.LaboratorijskeAnalize)
                {
                    analiza.Laborant = null;
                    s.Update(analiza);
                }


                admin.LaboratorijskeAnalize.Clear();

                s.Delete(admin);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {


            }
        }

        public static List<LokacijaBasic> prikazLokacije()
        {
            List<LokacijaBasic> lokacije = new List<LokacijaBasic>();

            using (ISession s = DataLayer.GetSession())
            {
                var r = s.Query<Lokacija>();

                foreach (Lokacija lokacija in r)
                {
                    lokacije.Add(new LokacijaBasic
                    {
                        Adresa = lokacija.Adresa,
                        RadnoVreme = lokacija.RadnoVreme
                    });
                }
            }
            return lokacije;
        }

        public static void brisiLokacija(string adresa) {
            try
            {
                ISession s = DataLayer.GetSession();

                Lokacija t = s.Load<Lokacija>(adresa);
                t.Zaposleni.Clear();
                t.Odeljenja.Clear();
                s.Delete(t);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {

            }
        }

        public static List<PacijentBasic> prikazPacijenta()
        {
            List<PacijentBasic> admini = new List<PacijentBasic>();

            using (ISession s = DataLayer.GetSession())
            {

                var t = s.Query<Pacijent>()
                    .Fetch(x => x.Lekar)
                    .ToList();

                foreach (Pacijent admin in t)
                {

                    admini.Add(new PacijentBasic
                    {
                        IdKartona = admin.IdKartona,
                        DatumRodjenja = admin.DatumRodjenja,
                        Ime = admin.Ime,
                        Prezime = admin.Prezime,
                        Adresa = admin.Adresa,
                        Pol = admin.Pol,
                        Lekar = new Lekar
                        {
                            JMBG = admin.Lekar.JMBG,
                        },
                    });
                }
            }

            return admini;
        }

        public static void brisiPacijenta(int idKartona)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Pacijent admin = s.Load<Pacijent>(idKartona);


                s.Delete(admin);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {


            }
        }

        public static List<PregledPogled> vratipogledpregleda()
        {
            List<PregledPogled> pregledi = new List<PregledPogled>();
            ISession s = DataLayer.GetSession();
            var p = s.Query<Pregled>().ToList();
            foreach (Pregled pregled in p)
            {
                pregledi.Add(new PregledPogled(pregled.Datum, pregled.Vreme, pregled.Pacijent,pregled.IdPregleda));
            }
            s.Close();
            return pregledi;
        }


        public static LaboratorijskaAnaliza nadjiLaboratorijskuAnalizu(int id)
        {
            ISession s = DataLayer.GetSession();
            LaboratorijskaAnaliza lab = s.Query<LaboratorijskaAnaliza>()
            .Fetch(x => x.Pacijent)
            .Fetch(x => x.Laborant)
            .Fetch(x => x.Pregled)
            .FirstOrDefault(x => x.IdAnalize == id);

            s.Close();
            return lab;
        }

        public static List<LaboratorijskaAnalizaBasic> prikazLaboratorijskeAnalize()
        {
            List<LaboratorijskaAnalizaBasic> labovi = new List<LaboratorijskaAnalizaBasic>();

            using (ISession s = DataLayer.GetSession())
            {
                var r = s.Query<LaboratorijskaAnaliza>().Fetch(x => x.Pacijent).Fetch(x => x.Pregled).Fetch(x => x.Laborant);

                foreach (LaboratorijskaAnaliza lab in r)
                {
                    labovi.Add(new LaboratorijskaAnalizaBasic
                    {
                        IdAnalize = lab.IdAnalize,
                        VrstaAnalize = lab.VrstaAnalize,
                        Rezultat = lab.Rezultat,
                        ReferentnaVrednost = lab.ReferentnaVrednost,
                        Komentar = lab.Komentar,
                        DatumUzorkovanja = lab.DatumUzorkovanja,
                        Vreme = lab.Vreme,

                        Pacijent = new Pacijent
                        {
                            IdKartona = lab.Pacijent.IdKartona,
                            Ime = lab.Pacijent.Ime,
                            Prezime = lab.Pacijent.Prezime
                        },

                        Laborant = new Laborant
                        {
                            JMBG = lab.Laborant.JMBG,
                            Ime = lab.Laborant.Ime,
                            Prezime = lab.Laborant.Prezime
                        },
                        Pregled = new Pregled
                        {
                            VrstaPregleda = lab.Pregled.VrstaPregleda
                        }
                    });
                }
            }
            return labovi;
        }

        public static void brisiLaboratorijskuAnalizu(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                LaboratorijskaAnaliza t = s.Load<LaboratorijskaAnaliza>(id);

                s.Delete(t);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {

            }
        }

        public static List<PlacanjeBasic> prikazPlacanja()
        {
            List<PlacanjeBasic> placanja = new List<PlacanjeBasic>();

            using (ISession s = DataLayer.GetSession())
            {
                var r = s.Query<Placanje>().Fetch(x => x.Racun).Fetch(x => x.RFZO).Fetch(x => x.PrivatnoOsiguranje).ToList();



                foreach (Placanje placanje in r)
                {
                    placanja.Add(new PlacanjeBasic
                    {
                        IdPlacanja = placanje.IdPlacanja,
                        ProcenatPacijenta = placanje.ProcenatPacijenta,
                        NacinPlacanja = placanje.NacinPlacanja,
                        PlatioPacijent = placanje.PlatioPacijent,

                        Racun = new Racun
                        {
                            Id = placanje.Racun.Id,
                            VrstaUsluge = placanje.Racun.VrstaUsluge,
                        },
                        PrivatnoOsiguranje = placanje.PrivatnoOsiguranje != null ? new PrivatnoOsiguranje
                        {
                            IdOsiguranja = placanje.PrivatnoOsiguranje.IdOsiguranja,
                            OsiguravajucaKuca = placanje.PrivatnoOsiguranje.OsiguravajucaKuca,
                            BrPolise = placanje.PrivatnoOsiguranje.BrPolise
                        } : null,
                        RFZO = placanje.RFZO != null ? new RFZO
                        {
                            IdOsiguranja = placanje.RFZO.IdOsiguranja,
                            
                        } : null
                    });
                }
            }
            return placanja;
        }

        public static void brisiPlacanje(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Placanje t = s.Load<Placanje>(id);

                s.Delete(t);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {

            }
        }

        public static List<OdeljenjeBasic> prikazOdeljenja()
        {
            List<OdeljenjeBasic> odeljenja = new List<OdeljenjeBasic>();

            using (ISession s = DataLayer.GetSession())
            {
                var r = s.Query<Odeljenje>().Fetch(x => x.GlavniLekar).Fetch(x => x.Lokacije).ToList();



                foreach (Odeljenje odeljenje in r)
                {
                    odeljenja.Add(new OdeljenjeBasic
                    {
                        Naziv = odeljenje.Naziv,
                        RadnoVreme = odeljenje.RadnoVreme,
                        BrProstorije = odeljenje.BrProstorije,
                        GlavniLekar = new Lekar
                        {
                            JMBG = odeljenje.GlavniLekar.JMBG,
                            Ime = odeljenje.GlavniLekar.Ime,
                            Prezime = odeljenje.GlavniLekar.Prezime
                        },
                    });
                }
            }
            return odeljenja;
        }

        public static void brisiOdeljenje(string id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Odeljenje t = s.Load<Odeljenje>(id);

                s.Delete(t);
                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {

            }
        }

    }
}

