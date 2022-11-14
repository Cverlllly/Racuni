using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Racuni
{
    public class Racun
    {
        public double Stanje { set; get; }
        public double Limit { set; get; }
        public string Ime { set; get; }
        public string Priimek { set; get; }
        public Racun()
        {
            Stanje = 0;
            Limit = 0;
            Ime = "";
            Priimek = "";
        }
        public Racun(double stanje)
        {
            Stanje = stanje;
        }
        public Racun(double stanje, double limit)
        {
            Limit = limit;
            Stanje = stanje;
        }
        public Racun(double stanje, double limit, string ime, string priimek)
        {
            Stanje = stanje;
            Limit = limit;
            Ime = ime;
            Priimek = priimek;
        }
        public bool dvig(double znesek)
        {
            if (Limit >= znesek && Stanje >= znesek)
            {
                Stanje -= znesek;
                return true;
            }
            else
            {
                return false;
            }

        }
        public int polog(double znesek)
        {
            Stanje = Stanje + znesek;
            return 1;
        }

    }
    public class OsebniRacun : Racun
    {
        public bool Varcevalni { set; get; }
        public double obrestnaMera { set; get; }

        public OsebniRacun():base()
        {
            Varcevalni = false;
            obrestnaMera = 0;
        }
        public OsebniRacun(double stanje, double limit, string ime, string priimek)
        {
            Stanje = stanje;
            Limit = limit;
            Ime = ime;
            Priimek = priimek;
        }


        public OsebniRacun(double stanje, double limit,string ime, string priimek,bool varcevalni, double obresti):base(stanje,limit,ime,priimek)
        {
            Varcevalni=varcevalni;
            obrestnaMera=obresti;
        }
        public double NastaviObrestnoMero()
        {
            if (Varcevalni == true)
            {
                return obrestnaMera=obrestnaMera * 1.5;
            }
            else
            {
                return obrestnaMera;
            }
        }
        public double LetniPrihranek(double mesecnoStanje)
        {
            return mesecnoStanje * obrestnaMera * 12;
        }

    }
    public class ValutniRacun: Racun
    {

        private List<string> seznamValut = new List<string>() { "USD","GBP","EUR"};
        
        public List<string> SeznamValut
        {
            set
            {
               
            }
            get 
            {  
                return seznamValut; 
            }
        }

        public string primarnaValuta { set; get; }
        public ValutniRacun()
        {

        }
        public ValutniRacun(double stanje,double limit,string ime,string priimek)
        {
            Stanje = stanje;
            Limit = limit;
            Ime = ime;
            Priimek = priimek;
        }
        public ValutniRacun(double stanje, double limit, string ime, string priimek,string valuta) : base(stanje,limit,ime,priimek)
        {

            primarnaValuta = valuta;
        }
        public double zamenjajValuto(double menjalniTecaj)
        {
            return menjalniTecaj * Stanje;
        }
    }
    public class PoslovniRacun : Racun
    {
        public string nazivPodjetja { set; get; }
        public string tipPodjetja { set; get; }

        public PoslovniRacun()
        {

        }
        public PoslovniRacun(double stanje,double limit,string ime,string priimek) 
        {
            Stanje= stanje;
            Limit = limit;
            Ime= ime;
            Priimek= priimek;
        }
        public PoslovniRacun(double stanje, double limit, string ime, string priimek,string naziv,string tip): base(stanje,limit,ime, priimek)
        {
            nazivPodjetja = naziv;
            tipPodjetja = tip;
        }
        public bool Likvidno()
        {
            if (Stanje > 0)
            {
                return true;
            }
            else
            {
                return false;

            }
        }
    }

}