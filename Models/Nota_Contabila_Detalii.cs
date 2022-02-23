using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Nota_Contabila_Detalii
    {
        int IdOperatiune { get; set; }
        DateTime DataOperatiune { get; set; }
        String ExplicatiiOperatiune { get; set; }
        int IdSimbolCodDebit { get; set; }
        Lista_Conturi SimbolCodDebit { get; set; }
        int IdSimbolCodCredit { get; set; }
        Lista_Conturi SimbolCodCredit { get; set; }
        double SumaOperatiune { get; set; }
        String NrDocumentOperatiune { get; set; }
        String TipDocumentOperatiune { get; set; }
        int IdClientFurnizorOperatiune { get; set; }
        Firme ClientFurnizorOperatiune { get; set; }
        String NrNotaOperatiune { get; set; }
        int IdValutaOperatiune { set; get;  }
        Lista_Valute ValutaOperatiune { get; set; }
        double SumaEchivalentLeiOperatiune { get; set; }
        bool NotaIntroduse { get; set; }
        int IdPersoanaNotaContabila { get; set; }
        Firme_Persoane_Contact PersoanaNotaContabila { set; get;  }
        String ModulNota { get; set; }
        int IdModulNota { get; set; }
        bool BalantaEmisaNota { get; set; }
        bool NotaSalariu { get; set; }
        bool NotaAmortizare { get; set; }
        bool SoldInitial { get; set; }
        bool RulajAnterior { get; set; }
        int IdRegistruBanca { get; set; }
        Registru_Banca RegistruBanca { set; get; }
        int IdRegistruCasa { get; set; }
        Registru_Casa RegistruCasa { set; get; }
        DateTime OraDataCurenta { get; set; }
        bool InJurnal { get; set; }
        String TipNota { get; set; }
        String SimbolCodDebitSintetic { get; set; }
        String SimbolCodCreditSintetic { get; set; }
        int NrPVC { get; set; }
        bool NotaChAvans { get; set; }
        bool NotaReevaluareSolduriClienti { get; set; }
        bool NotaReevaluareSolduriFurnizori { get; set; }
    }
}
