using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Solduri_Generale_Salvate
    {
        DateTime DataCalcul { get; set; }
        double SoldGeneralBanca { get; set; }
        double SoldGeneralCasa { get; set; }
        double TotalDeIncasatII { get; set; }
        double TotalDeIncasatIE { get; set; }
        double TotalDeIncasatPE { get; set; }
        double TotalDeIncasatPI { get; set; }
        double TotalDeIncasatTotal { get; set; }
        double TotalDePlataII { get; set; }
        double TotalDePlataIE { get; set; }
        double TotalDePlataTotal { get; set; }
        double TotalDeIncasatAlte { get; set; }
        double TotalDePlataAlte { get; set; }
        double AlteCheltuieliPreconizate { get; set; }
        String ExplicatiiAlteCheltuieliPreconizate { get; set; }
        double SoldGeneral { get; set; }
        double TotalDeIncasatCumulat { get; set; }
        double TotalDePlataCumulat { get; set; }
        double SoldComisionBancar { get; set; }
        double Discount { get; set; }
        double CheltuieliPeCregitSoldG { get; set; }
        String ExplcatiiCreditSoldG { get; set; }
    }
}
