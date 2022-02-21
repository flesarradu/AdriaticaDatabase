using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Decont_Alte_Cheltuieli_Din_Avansuri
    {
        int IdDecont { get; set; }
        int IdInchidereAvansLink { get; set; }
        Inchidere_Avansuri InchidereAvansLink { set; get; }
        DateTime DataCheltuiala { get; set; }
        double Suma { get; set; }
        int IdMoneda { get; set; }
        Lista_Valute Moneda { get; set; }
        int IdClasa { get; set; }
        Lista_CC_Altele_Din_Avansuri Clasa { get; set; }
        String Explicatii { get; set; }
        DateTime DataDecont { get; set; }
        String NrDecont { get; set; }
        int IdPersoana { get; set; }
        Firme_Persoane_Contact Persoana { get; set; }
        double SumaMonedaRef { get; set; }
        bool Numerar { get; set; }
        bool Anulare { get; set; }
        double SumaInLei { get; set; }
        double ValoareFaraTVA { get; set; }
        double ValoareTVA { get; set; }
        int IdFurnizor { get; set; }
        Firme Furnizor { set; get; }
        int IdCotaTVA { get; set; }
        Lista_Cota_TVA CotaTVA { get; set; }
        double MonRefSumaFaraTVA { get; set; }
        bool ExportContabilitate { get; set; }
        int IdTipDocument { get; set; }
        Lista_Documente_Fiscale TipDocument { get; set; }
        String NrDocument { get; set; }
        bool BalantaEmisa { get; set; }
        bool InJurnal { get; set; }
        int IdNrAuto { get; set; }
        Lista_NrAuto_Masini_Proprii NrAuto { get; set; }
        double KmBordAlimentare { get; set; }
        double LitriiAlimentati { get; set; }
        int IdTipTVA { get; set; }
        Lista_Tip_TVA_Cumparari TipTva { get; set; }
        int IdContDebit { get; set; }
        Lista_Conturi ContDebit { get; set; }
        int IdContCredit { get; set; }
        Lista_Conturi ContCredit { get; set; }
    }
}
