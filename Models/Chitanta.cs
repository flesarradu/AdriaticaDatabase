using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Chitanta
    { 
        int IdChitanta { get; set; }
        String NumarChitanta { get; set; }
        String SerieChitanta { get; set; }
        DateTime DataChitanta { get; set; }
        int IdFirmaChitanta { get; set; }
        Firme FirmaChitanta { get; set; }
        String AdresaChitanta { get; set; }
        double SumaChitanta { get; set; }
        int IdMonedaChitanta { get; set; }
        Lista_Valute MonedaChitanta { get; set; }
        String SumaLitereChitanta { get; set; }
        String MentiuniChitanta { get; set; }
        int IdFacturaChitanta { get; set; }
        Id_Facturi FacturaChitanta { get; set; }
    }
}
