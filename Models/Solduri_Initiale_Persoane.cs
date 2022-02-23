using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Solduri_Initiale_Persoane
    {
        int IdSoldInitialPersoana { get; set; }
        int IdPersoanaSold { get; set; }
        Firme_Persoane_Contact PersoanaSold { get; set; }
        double SumaSold { get; set; }
        int IdValutaSold { get; set; }
        Lista_Valute ValutaSold { get; set; }
        DateTime DataSold { get; set; }
        int IdSimbolCodDebit { get; set; }
        Lista_Conturi SimbolCodDebit { get; set; }
        int IdSimbolCodCredit { get; set; }
        Lista_Conturi SimbolCodCredit { get; set; }
        double EchivalentLei { get; set; }
        bool SoldInceputAn { get; set; }
        bool RulajAnteriorSold { get; set; }
        int IdInchidereAvansCLink { get; set; }
        Inchidere_Avansuri InchidereAvansCLink { get; set; }
        bool Numerar { get; set; }



    }
}
