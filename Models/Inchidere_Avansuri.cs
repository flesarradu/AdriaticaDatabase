using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Inchidere_Avansuri
    {
        int IdInchidereAvans { get; set; }
        int IdPersoana { get; set; }
        Firme_Persoane_Contact Persoana { get; set; }
        bool Rezolvat { get; set; }
        DateTime DataRezolvat { get; set; }
        String NrDecont { get; set; }
        DateTime DataDeblocareInchidere { get; set; }
        String ObservatiiDeblocareInchidere { get; set; }
        double SoldInMonRef { get; set; }
        double SoldInLei { get; set; }
        DateTime DataIntroducerii { get; set; }
        DateTime OraIntroducerii { get; set; }
        int IdCursa { get; set; }
        Id_Curse Cursa { get; set; }
        bool BalantaEmisa { get; set; }
        DateTime DataAvansului { get; set; }
    }
}
