using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Comanda_Decont
    {
        int IdComandaDecont { get; set; }
        int IdNumeFirmaProprie { get; set; }
        Firme NumeFirmaProprie { get; set; }
        int NrComDec { get; set; }
        DateTime DataComDec { get; set; }
        int IdNrAutoPropriuComDec { get; set; }
        Lista_NrAuto_Masini_Proprii NrAutoPropriuComDec { get; set; }
        int IdNrAutoComDecTerti { get; set; }
        Lista_NrAuto_Masini_Proprii NrAutoComDecTerti { get; set; }
        int KmBordAutoComDec { get; set; }
        int IdClientComDec { get; set; }
        Firme ClientComDec { get; set; }
        String NumeSoferComDec { get; set; }
        double TotalManoperaComDec { get; set; }
        double TotalMaterialeComDec { get; set; }
        double TotalGeneralComDec { get; set; }
        bool FacturatComDec { get; set; }
        bool ComDecPrestProprie { get; set; }
        double ValoareOraTarifara { get; set; }
        DateTime TermenExecutieComDec { get; set; }
        DateTime DataConfirmLucrareComDec { get; set; }
        int IdPersConfirmLucrareComDec { get; set; }
        Firme_Persoane_Contact PersConfirmLucrareComDec { get; set; }
        DateTime CTCDataComDec { get; set; }
        int IdCTCFunctieComDec { get; set; }
        Lista_Functii CTCFunctieComDec { get; set; }
        int IdNumeComDec { get; set; }
        Firme_Persoane_Contact NumeComDec { get; set; }
        int IdSefServiceComDec { get; set; }
        Firme_Persoane_Contact SefServiceComDec { get; set; }
        int IdCotaTVAComDec { get; set; }
        Lista_Cota_TVA CotaTVADec { get; set; }
        int IdBonConsumDetalii { get; set; }
        Bon_De_Consum_Detalii BonConsumDetalii { get; set; }
        String NrComandaClientComDec { get; set; }


    }
}
