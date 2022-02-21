using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Consum_Firma
    {
        int IdConsum { get; set; }
        DateTime LunaConsum { get; set; }
        int IdClasaConsumLink { get; set; }
        Lista_CC_Consum ClasaConsumLink { get; set; }
        double SumaConsum { get; set; }
        double Suma { get; set; }
        int IdValuta { get; set; }
        Lista_Valute Valuta { get; set; }
        bool CampIntrodus { get; set; }
        String Explicatii { get; set; }
        int IdIncadrareConsum { get; set; }
        Lista_Incadrari IncadrareConsum { get; set; }
        int IdSubIncadrareServ { get; set; }
        Lista_Incadrari_Detalii SubIncadrareServ { get; set; }
    }
}
