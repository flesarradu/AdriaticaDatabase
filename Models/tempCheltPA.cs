using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class tempCheltPA
    {
        int IdMasinaLink { get; set; }
        DateTime DataCheltuiala { get; set; }
        double SumaInLeiDPAC { get; set; }
        int IdDecontPACheltuieli { get; set; }
        Decont_ParcAuto_Cheltuieli DecontPACheltuieli { get; set; }
        double SumaDPAC { get; set; }
        int IdMonedaDPAC { get; set; }
        Lista_Valute MonedaDPAC { get; set; }
        int IdCLasaCPAuto { get; set; }
        Lista_CC_PAuto ClasaCPAuto { get; set; }
        int IdSubClasaCPAuto { get; set; }
        Lista_CC_Subclasa_PAuto SubClasaCPAuto { get; set; }
        String ExplicatiiDPAC { get; set; }
        DateTime DataDecontPAC { get; set; }
        String NrDecontPAC { get; set; }
        int IdPersoanaDPAC {get; set; }
        int KmBordDPAC { get; set; }
        double SumaMonedaRefDPAC { get; set; }
        bool AnulareDPAC { get; set; }
        bool NumerarDPAC { get; set; }
        bool ProductivaFCT { get; set; }

    }
}
