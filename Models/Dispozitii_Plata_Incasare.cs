using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Dispozitii_Plata_Incasare
    {
        int IdDispozitie { get; set; }
        String NrDispozitie { set; get; }
        DateTime DataDispozitie { set; get; }
        int IdAngajat { get; set; }
        Firme_Persoane_Contact Angajat { get; set; }
        int IdFunctia { get; set; }
        Lista_Functii Functia { get; set; }
        double SumaDispozitie { set; get; }
        int IdMoneda { get; set; }
        Lista_Valute Moneda { get; set; }
        String SumaInLitere { set; get; }
        String ScopDispozitie { set; get; }
        String BIAngajat { set; get; }
        String TipDispozitie { set; get; }
        bool Generat { get; set; }
        String NrDispPlataIncasareDisp { set; get; }
    }
}
