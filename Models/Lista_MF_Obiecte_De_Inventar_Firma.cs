using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Lista_MF_Obiecte_De_Inventar_Firma
    {
        int IdObiectMF { get; set; }
        String TipObiectMF { set; get; }
        String NumarDeInventareObiectMF { set; get; }
        String DenumireObiectMF { set; get; }
        double ValoareObiectMF { set; get; }
        int IdGrupaObiectMF { set; get; }
        Lista_Grupe GrupaObiectMF { set; get; }
        int IdSubgrupaObiectMF { set; get; }
        Lista_Subgrupe SubgrupaObiectMF { set; get; }
        int DurataDeAmortizareObiectMF { set; get; }
        double ValoareDeAmortizareLunaraObiectMF { set; get; }
        DateTime DataAchizitieObiectMF { get; set; }
        String NrFacturaObiectMF { get; set; }
        int IdFurnizorObiectMF { set; get; }
        Firme FurnizorObiectMF { get; set; }
        String LoculUndeSeGasesteObiectMF { get; set; }
        int IdTipAmortizareMijloc { set; get; }
        Lista_Tipuri_Amortizari TipAmortizareMijloc { get; set; }
        DateTime DataDareInFunctiuneObiectMF { get; set;}
        int IdLunaDareInFolosintaMF { set; get; }
        Lista_Luni LunaDareInFolosintaMF { get; set; }
        int AnDareInFolosintaMF { set; get; }
        bool MijlocFixAmortizat { get; set; }
        bool ObiectDeInventarCasat { get; set; }
        DateTime DataCasare { get; set; }
        DateTime DataAmortizareIntegralaMF { get; set; }
        bool InclusInFactura { get; set; }
        int IdCotaTVA { get; set; }
        Lista_Cota_TVA CotaTVA { set; get; }
        double ValoareObiectMFVeche { get; set; }
        double ValoareDeAmortizareLunaraObiectMFVeche { set; get; }
        bool MFVandut { get; set; }
        DateTime DataVanzare { get; set; }
        String NrFacturaMF { get; set; }
        int IdPersoanaGestiuneMF { get; set; }
        String TipMF { get; set; }
        bool MFConservat { get; set; }
        DateTime DataIncepereConservareMF { get; set; }
        DateTime DataSfarsitConservareMF { set; get; }
        DateTime DataCandAFostAmortizatMF { get; set; }
        int IdLunaCandAFostAmortizatMF { set; get; }
        Lista_Luni LunaCandAFostAmortizatMF { get; set; }
        int AnCandAFostAmortizatMF { get; set; }
        String StareMF { get; set; }

    }
}
