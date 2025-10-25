using MedicinskaKlinika.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicinskaKlinika
{

    public class ZaposlenBasic
    {
        public virtual int JMBG { get; set; }
        public virtual DateTime DatumZaposlenja { get; set; }
        public virtual String Pozicija { get; set; }

        public virtual DateTime DatumRodjenja { get; set; }

        public virtual String Ime { get; set; }

        public virtual String Prezime { get; set; }

        public virtual String Adresa { get; set; }

        public virtual int Smena { get; set; }

        public virtual Lokacija AdresaLokacije { get; set; }

        public virtual IList<Odeljenje> Odeljenja { get; set; }

        public virtual IList<BrTelefonaZaposlenog> Telefons { get; set; }

        public virtual IList<EmailZaposlenog> Emails { get; set; }

        public ZaposlenBasic(IList<Odeljenje> Odeljenja, IList<BrTelefonaZaposlenog> Telefons, IList<EmailZaposlenog> Emails)
        {
            this.Odeljenja = new List<Odeljenje>();
            this.Telefons = new List<BrTelefonaZaposlenog>();
            this.Emails = new List<EmailZaposlenog>();
        }

        public ZaposlenBasic(int jMBG, DateTime datumZaposlenja, string pozicija, DateTime datumRodjenja, string ime, string prezime, string adresa, int smena, Lokacija adresaLokacije)
        {
            this.JMBG = jMBG;
            this.DatumZaposlenja = datumZaposlenja;
            this.Pozicija = pozicija;
            this.DatumRodjenja = datumRodjenja;
            this.Ime = ime;
            this.Prezime = prezime;
            this.Adresa = adresa;
            this.Smena = smena;
            this.AdresaLokacije = adresaLokacije;
        }

        public ZaposlenBasic()
        {

        }
    }

    public class ZaposlenPogled
    {
        public virtual int JMBG { get; set; }
        public virtual String Ime { get; set; }

        public virtual String Prezime { get; set; }

        public string PunoIme => Ime + " " + Prezime;

        public ZaposlenPogled(int jMBG, string ime, string prezime)
        {
            JMBG = jMBG;
            Ime = ime;
            Prezime = prezime;
        }
    }

    public class AdministrativnoOsobljeBasic : ZaposlenBasic
    {
        public AdministrativnoOsobljeBasic(IList<Odeljenje> Odeljenja, IList<BrTelefonaZaposlenog> Telefon, IList<EmailZaposlenog> Emails) : base(Odeljenja,Telefon,Emails)
        {
        
        }

        public AdministrativnoOsobljeBasic(int JMBG, DateTime DatumZaposlenja, String Pozicija, DateTime DatumRodjenja, String Ime, String Prezime, String Adresa,
            int Smena, Lokacija AdresaLokacije)
            : base(JMBG,DatumZaposlenja,Pozicija,DatumRodjenja,Ime,Prezime,Adresa,
           Smena,AdresaLokacije)
        {

        }

        public AdministrativnoOsobljeBasic()
        {

        }

    }

    public class MedicinskaSestraBasic : ZaposlenBasic
    {
        public virtual String OblastRada { get; set; }

        public virtual String Sertifikat { get; set; }
        public MedicinskaSestraBasic(IList<Odeljenje> Odeljenja, IList<BrTelefonaZaposlenog> Telefon, IList<EmailZaposlenog> Emails) : base(Odeljenja, Telefon, Emails)
        {

        }

        public MedicinskaSestraBasic(int JMBG, DateTime DatumZaposlenja, String Pozicija, DateTime DatumRodjenja, String Ime, String Prezime, String Adresa,
            int Smena, Lokacija AdresaLokacije, String OblastRada, String Sertifikat)
            : base(JMBG, DatumZaposlenja, Pozicija, DatumRodjenja, Ime, Prezime, Adresa,
           Smena, AdresaLokacije)
        {
            this.OblastRada = OblastRada;
            this.Sertifikat = Sertifikat;
        }

        public MedicinskaSestraBasic()
        {

        }
    }

    public class LaborantBasic : ZaposlenBasic
    {
        public virtual String OblastRada { get; set; }

        public virtual String Sertifikat { get; set; }

        public virtual IList<LaboratorijskaAnaliza> LaboratorijskeAnalize { get; set; }
        public LaborantBasic(IList<Odeljenje> Odeljenja, IList<BrTelefonaZaposlenog> Telefon, IList<EmailZaposlenog> Emails, IList<LaboratorijskaAnaliza> LaboratorijskeAnalize) : base(Odeljenja, Telefon, Emails)
        {
            this.LaboratorijskeAnalize = LaboratorijskeAnalize;
        }

        public LaborantBasic(int JMBG, DateTime DatumZaposlenja, String Pozicija, DateTime DatumRodjenja, String Ime, String Prezime, String Adresa,
            int Smena, Lokacija AdresaLokacije, String OblastRada, String Sertifikat)
            : base(JMBG, DatumZaposlenja, Pozicija, DatumRodjenja, Ime, Prezime, Adresa,
           Smena, AdresaLokacije)
        {
            this.OblastRada = OblastRada;
            this.Sertifikat = Sertifikat;
        }

        public LaborantBasic()
        {

        }
    }

    public class LekarBasic : ZaposlenBasic
    {
        public virtual String Specijalizacija { get; set; }
        public virtual int BrLicence { get; set; }

        // Veze lekara sa drugim entitetima
        public virtual Odeljenje Odeljenje { get; set; }
        public virtual IList<Racun> Racuni { get; set; }

        public virtual IList<Pacijent> Pacijenti { get; set; }


        public virtual IList<Termin> Termini { get; set; }

        public virtual IList<Pregled> Pregledi { get; set; }
        public LekarBasic(IList<Odeljenje> Odeljenja, IList<BrTelefonaZaposlenog> Telefon, IList<EmailZaposlenog> Emails,
           IList<Racun> Racuni, IList<Pacijent> Pacijenti, IList<Termin> Termini, IList<Pregled> Pregledi) : base(Odeljenja, Telefon, Emails)
        {
            this.Pacijenti = Pacijenti;
            this.Termini = Termini;
            this.Pregledi = Pregledi;
        }

        public LekarBasic(int JMBG, DateTime DatumZaposlenja, String Pozicija, DateTime DatumRodjenja, String Ime, String Prezime, String Adresa,
            int Smena, Lokacija AdresaLokacije, String Specijalizacija, int BrLicence, Odeljenje Odeljenje)
            : base(JMBG, DatumZaposlenja, Pozicija, DatumRodjenja, Ime, Prezime, Adresa,
           Smena, AdresaLokacije)
        {
            this.Specijalizacija = Specijalizacija;
            this.BrLicence = BrLicence;
            this.Odeljenje = Odeljenje;
        }

        public LekarBasic()
        {

        }
    }


    public class BrTelefonaPacijentaBasic {
        public virtual int Id { get; set; }
        public virtual Pacijent Pacijent { get; set; }
        public virtual String BrojTelefona { get; set; }

        public BrTelefonaPacijentaBasic(int Id, Pacijent Pacijent, String BrojTelefona)
        {
            this.Id = Id;
            this.Pacijent = Pacijent;
            this.BrojTelefona = BrojTelefona;
        }
        public BrTelefonaPacijentaBasic()
        {

        }
    }

    public class BrTelefonaZaposlenogBasic
    {
        public virtual int Id { get; set; }
        public virtual Zaposlen Zaposlen { get; set; }

        public virtual String BrojTelefona { get; set; }

        public BrTelefonaZaposlenogBasic(int Id, Zaposlen Zaposlen, String BrojTelefona)
        {
            this.Id = Id;
            this.Zaposlen = Zaposlen;
            this.BrojTelefona = BrojTelefona;
        }

        public BrTelefonaZaposlenogBasic()
        {

        }
    }

    public class EmailPacijentaBasic
    {
        public virtual int Id { get; set; }
        public virtual Pacijent Pacijent { get; set; }

        public virtual String Email { get; set; }

        public EmailPacijentaBasic()
        {

        }

        public EmailPacijentaBasic(int Id, Pacijent Pacijent, String Email)
        {
            this.Id = Id;
            this.Pacijent = Pacijent;
            this.Email = Email;
        }
    }

    public class EmailZaposlenogBasic
    {
        public virtual Zaposlen Zaposlen { get; set; }
        public virtual String Email { get; set; }

        public EmailZaposlenogBasic()
        {

        }
        public EmailZaposlenogBasic(Zaposlen Zaposlen, String Email)
        {
            this.Zaposlen = Zaposlen;
            this.Email = Email;
        }

    }

    public class LaboratorijskaAnalizaBasic
    {
        public virtual int IdAnalize { get; set; }
        public virtual Pacijent Pacijent { get; set; }

        public virtual Pregled Pregled { get; set; }

        public virtual String VrstaAnalize { get; set; }

        public virtual DateTime DatumUzorkovanja { get; set; }

        public virtual String Rezultat { get; set; }

        public virtual String ReferentnaVrednost { get; set; }

        public virtual DateTime Vreme { get; set; }

        public virtual String Komentar { get; set; }

        // Laborant koji je uradio analizu
        public virtual Laborant Laborant { get; set; }

        public LaboratorijskaAnalizaBasic(int IdAnalize, Pacijent Pacijent, Pregled Pregled, String VrstaAnalize,
            DateTime DatumUzorkovanja, String Rezultat, String ReferentnaVrednost, DateTime Vreme, String Komentar, Laborant Laborant)
        {
            this.IdAnalize = IdAnalize;
            this.Pacijent = Pacijent;
            this.Pregled = Pregled;
            this.VrstaAnalize = VrstaAnalize;
            this.DatumUzorkovanja = DatumUzorkovanja;
            this.Rezultat = Rezultat;
            this.ReferentnaVrednost = ReferentnaVrednost;
                this.Vreme = Vreme;
            this.Komentar = Komentar;
            this.Laborant = Laborant;
        }

        public LaboratorijskaAnalizaBasic()
        {

        }
    }

    public class LokacijaBasic
    {
        public virtual String Adresa { get; set; }

        public virtual String RadnoVreme { get; set; }

        // 1 lokacija može imati više zaposlenih
        public virtual IList<Zaposlen> Zaposleni { get; set; }

        public virtual IList<Odeljenje> Odeljenja { get; set; }

        public LokacijaBasic(IList<Zaposlen> Zaposleni, IList<Odeljenje> Odeljenja)
        {
            this.Zaposleni = Zaposleni;
            this.Odeljenja = Odeljenja;
        }

        public LokacijaBasic(String Adresa, String RadnoVreme)
        {
            this.Adresa = Adresa;
            this.RadnoVreme = RadnoVreme;
        }

        public LokacijaBasic()
        {

        }
    }

    public class LokacijaPogled
    {
        public virtual String Adresa { get; set; }

        public LokacijaPogled(String Adresa)
        {
            this.Adresa = Adresa;
        }

    }

    public class OdeljenjeBasic
    {
        public virtual String Naziv { get; set; }


        public virtual int BrProstorije { get; set; }

        public virtual String RadnoVreme { get; set; }

        public virtual Lekar GlavniLekar { get; set; }


        public virtual IList<Lokacija> Lokacije { get; set; }

        public virtual IList<Zaposlen> Zaposleni { get; set; }

        public virtual IList<Pregled> Pregledi { get; set; }

        public virtual IList<Termin> Termini { get; set; }

        public OdeljenjeBasic(IList<Lokacija> Lokacije, IList<Zaposlen> Zaposleni, IList<Pregled> Pregledi, IList<Termin> Termini)
        {
            this.Lokacije = Lokacije;
            this.Zaposleni = Zaposleni;
            this.Pregledi = Pregledi;
            this.Termini = Termini;
        }

        public OdeljenjeBasic(String Naziv, int BrProstorije, String RadnoVreme, Lekar GlavniLekar)
        {
            this.Naziv = Naziv;
            this.BrProstorije = BrProstorije;
            this.RadnoVreme = RadnoVreme;
            this.GlavniLekar = GlavniLekar;
        }
        OdeljenjeBasic()
        {

        }
    }

    public class OdeljenjePogled
    {
        public virtual String Naziv { get; set; }
        
        public OdeljenjePogled()
        {
            
        }

        public OdeljenjePogled(string Naziv)
        {
            this.Naziv = Naziv;
        }
    }

    public class PacijentBasic
    {
        public virtual String Adresa { get; set; }

        public virtual int IdKartona { get; set; }

        public virtual String Ime { get; set; }

        public virtual String Prezime { get; set; }


        public virtual DateTime DatumRodjenja { get; set; }

        public virtual String Pol { get; set; }

        public virtual Lekar Lekar { get; set; }

        public virtual IList<Racun> Racuni { get; set; }

        public virtual RFZO RFZO { get; set; }

        public virtual PrivatnoOsiguranje PrivatnoOsiguranje { get; set; }

        public virtual IList<Pregled> Pregledi { get; set; }

        public virtual IList<Termin> Termini { get; set; }

        public virtual IList<BrTelefonaPacijenta> Telefons { get; set; }

        public virtual IList<EmailPacijenta> Emails { get; set; }

        public PacijentBasic(String Adresa, int IdKartona, String Ime, String Prezime, DateTime DatumRodjenja,
            String Pol, Lekar Lekar, RFZO RFZO, PrivatnoOsiguranje PrivatnoOsiguranje)
        {
            this.Adresa = Adresa;
            this.IdKartona = IdKartona;
            this.Ime = Ime;
            this.Prezime = Prezime;
            this.DatumRodjenja = DatumRodjenja;
            this.Pol = Pol;
            this.Lekar = Lekar;
            this.RFZO = RFZO;
            this.PrivatnoOsiguranje = PrivatnoOsiguranje;
        }

        public PacijentBasic(IList<Racun> Racuni, IList<Pregled> Pregledi, IList<Termin> Termini, IList<BrTelefonaPacijenta> Telefons,
            IList<EmailPacijenta> Emails)
        {
            this.Racuni = Racuni;
            this.Pregledi = Pregledi;
            this.Telefons = Telefons;
            this.Emails = Emails;
            this.Termini = Termini;
        }
    }

    public class PacijentPogled
    {
        public virtual int IdKartona { get; set; }

        public virtual String Ime { get; set; }

        public virtual String Prezime { get; set; }

        public string PunoIme => Ime + " " + Prezime;

        public PacijentPogled(int idKartona, string ime, string prezime)
        {
            IdKartona = idKartona;
            Ime = ime;
            Prezime = prezime;
        }
    }

    public class TerminBasic
    {
        public virtual int IdTermina { get; set; }
        public virtual DateTime Datum { get; set; }

        public virtual DateTime Vreme { get; set; }

        public virtual Pacijent Pacijent { get; set; }

        public virtual Lekar Lekar { get; set; }

        public virtual Odeljenje Odeljenje { get; set; }

        public virtual Pregled Pregled { get; set; }
        public TerminBasic()
        {

        }

        public TerminBasic(int idTermina, DateTime datum, DateTime vreme, Pacijent pacijent, Lekar lekar, Odeljenje odeljenje, Pregled pregled)
        {
            this.IdTermina = idTermina;
            this.Datum = datum;
            this.Vreme = vreme;
            this.Pacijent = pacijent;
            this.Lekar = lekar;
            this.Odeljenje = odeljenje;
            this.Pregled = pregled;
        }
    }


    public class RFZOBasic
    {
        public virtual int IdOsiguranja { get; set; }

        public virtual Pacijent Pacijent { get; set; }

        public virtual IList<Placanje> Placanja { get; set; }

        public RFZOBasic()
        {

        }

        public RFZOBasic(IList<Placanje> Placanja)
        {
            this.Placanja = Placanja;
        }

        public RFZOBasic(int IdOsiguranja, Pacijent Pacijent)
        {
            this.IdOsiguranja = IdOsiguranja;
            this.Pacijent = Pacijent;
        }


    }

    public class RacunBasic
    {
        public virtual int Id { get; set; }
        public virtual int Popust { get; set; }

        public virtual String VrstaUsluge { get; set; }

        public virtual DateTime Datum { get; set; }

        public virtual double Cena { get; set; }

        public virtual Lekar Lekar { get; set; }

        public virtual Pacijent Pacijent { get; set; }

        public virtual Placanje Placanje { get; set; }

        public RacunBasic() { }

        public RacunBasic(int id, int popust, string vrstaUsluge, DateTime datum, double cena, Lekar lekar, Pacijent pacijent, Placanje placanje)
        {
            this.Id = id;
            this.Popust = popust;
            this.VrstaUsluge = vrstaUsluge;
            this.Datum = datum;
            this.Cena = cena;
            this.Lekar = lekar;
            this.Pacijent = pacijent;
            this.Placanje = placanje;
        }
    }

    public class PrivatnoOsiguranjeBasic
    {
        public virtual int IdOsiguranja { get; set; }
        public virtual int BrPolise { get; set; }

        public virtual String OsiguravajucaKuca { get; set; }

        public virtual Pacijent Pacijent { get; set; }

        public virtual IList<Placanje> Placanja { get; set; }

        public PrivatnoOsiguranjeBasic()
        {

        }

        public PrivatnoOsiguranjeBasic(IList<Placanje> Placanja)
        {
            this.Placanja = Placanja;
        }
        public PrivatnoOsiguranjeBasic(int idOsiguranja, int brPolise, string osiguravajucaKuca, Pacijent pacijent)
        {
            this.IdOsiguranja = idOsiguranja;
            this.BrPolise = brPolise;
            this.OsiguravajucaKuca = osiguravajucaKuca;
            this.Pacijent = pacijent;
        }
    }

    public class PregledBasic
    {
        public virtual int IdPregleda { get; set; }
        public virtual DateTime Datum { get; set; }

        public virtual DateTime Vreme { get; set; }

        public virtual String OpisTegoba { get; set; }

        public virtual String Dijagnoza { get; set; }

        public virtual String Terapija { get; set; }

        public virtual String PreporukaZaLecenje { get; set; }

        public virtual String VrstaPregleda { get; set; }


        public virtual Pacijent Pacijent { get; set; }

        public virtual Lekar Lekar { get; set; }

        public virtual Odeljenje Odeljenje { get; set; }

        public virtual Termin Termin { get; set; }

        public virtual Pregled DodatniPregled { get; set; }

        public virtual IList<LaboratorijskaAnaliza> LaboratorijskaAnaliza { get; set; }

        public PregledBasic() { }

        public PregledBasic(IList<LaboratorijskaAnaliza> LaboratorijskaAnaliza)
        {
            this.LaboratorijskaAnaliza = LaboratorijskaAnaliza;
        }

        public PregledBasic(int IdPregleda, DateTime Datum, DateTime Vreme, String OpisTegoba, String Dijagnoza, String Terapija, String PreporukaZaLecenje,
            String VrstaPregleda, Pacijent Pacijent, Lekar Lekar, Odeljenje Odeljenje, Termin Termin, Pregled DodatniPregled)
        {
            this.IdPregleda = IdPregleda;
            this.Datum = Datum;
            this.Vreme = Vreme;
            this.OpisTegoba = OpisTegoba;
            this.Dijagnoza = Dijagnoza;
            this.Terapija = Terapija;
            this.PreporukaZaLecenje = PreporukaZaLecenje;
            this.VrstaPregleda = VrstaPregleda;
            this.Pacijent = Pacijent;
            this.Lekar = Lekar;
            this.Odeljenje = Odeljenje;
            this.Termin = Termin;
            this.DodatniPregled = DodatniPregled;
        }

    }

    public class PlacanjeBasic
    {
        public virtual int IdPlacanja { get; set; }

        public virtual int ProcenatPacijenta { get; set; }

        public virtual String NacinPlacanja { get; set; }

        public virtual Boolean PlatioPacijent { get; set; }

        public virtual Racun Racun { get; set; }

        public virtual PrivatnoOsiguranje PrivatnoOsiguranje { get; set; }

        public virtual RFZO RFZO { get; set; }

        public PlacanjeBasic() { }

        public PlacanjeBasic(int idPlacanja, int procenatPacijenta, string nacinPlacanja, bool platioPacijent, Racun racun, PrivatnoOsiguranje privatnoOsiguranje, RFZO rFZO)
        {
            this.IdPlacanja = idPlacanja;
            this.ProcenatPacijenta = procenatPacijenta;
            this.NacinPlacanja = nacinPlacanja;
            this.PlatioPacijent = platioPacijent;
            this.Racun = racun;
            this.PrivatnoOsiguranje = privatnoOsiguranje;
            this.RFZO = rFZO;
        }
    }
}
