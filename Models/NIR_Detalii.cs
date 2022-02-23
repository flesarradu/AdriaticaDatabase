using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class NIR_Detalii
    {
        int IdNIRServiviu { get; set; }
        int IdNIRDetalii { get; set; }
        int NrCrtNIRDetalii { get; set; }
        int IdProdusNIRDet { get; set; }
        Lista_Produse ProdusNIRDet { get; set; }
        String DenumireProdAjutor { get; set; }
        String CodProdusNIRDet { get; set; }
        double CantNIRDet { get; set; }
        double PretNIRDet { get; set; }
        double ValNIRDet { get; set; }
        double TVAPeUMNIRDet { get; set; }
        double TVATotalNIRDet { get; set; }
        double TotalFactNIRDet { get; set; }
        double ProcentAdComNIRDet { get; set; }
        double SumaAdComNIRDet { get; set; }
        double PretUnitAmanuntFaraTVANIRDet { get; set; }
        double TVAAdComNIRDet { get; set; }
        double PretUnitAmanuntCuTVANIRDet { get; set; }
        double ValPretAmanuntFaraTVANIRDet { get; set; }
        double ValPretAmanuntCuTVANIRDet { get; set; }
        double TotalTVAPeUMNIRDet { get; set; }
        double TotalTVANIRDet { get; set; }
        int IdContDebitNIR { get; set; }
        Lista_Conturi ContDebitNIR { get; set; }
        int IdContCreditNIR { get; set; }
        Lista_Conturi ContCreditNIR { get; set; }
        int IdUMNIRDet { get; set;}
        Lista_Varia UMNIRDet { get; set; }
        DateTime DataIntrareProdusNIRDet { get; set; }
        int IdIncadrareNIR { get; set; }
        Lista_Incadrari IncadrareNIR { get; set; }
        int IdTVALinie { get; set; }
        Lista_Cota_TVA TVALinie { get; set; }
        int IdGestiuneNIRDet { get; set; }
        Lista_Gestiuni GestiuneNIRDet { get; set; }
    }
}
