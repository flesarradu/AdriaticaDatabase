using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Facturi_Emise_Detalii
    {
        int IdServiciu { get; set; }
        int IdFacturaServ { get; set; }
        Facturi_Emise FacturaServ { get; set; }
        int IdFacturaServPartida { get; set; }
        Partide FacturaServPartida { get; set; }
        String Serviciu { get; set; }
        String UMServ { get; set; }
        double CantitateServ { get; set; }
        double PretServ { get; set; }
        double ValoareServ { get; set; }
        double ValoareTVAServ { get; set; }
        int IdContDebitServ { get; set; }
        Lista_Conturi ContDebitServ { get; set; }
        int IdContCreditServ { get; set; }
        Lista_Conturi ContCreditServ { get; set; }
        double ValoareServEUR { get; set; }
        double ValoareTVAServEUR { get; set; }
        String IdFacturataComandaNr { get; set; }
        int IdTVAFactLinie { get; set; }
        Lista_Cota_TVA TVAFactLinie { get; set; }
        String CodProdusFacturat { get; set; }
        double PretIntrareProdus { get; set; }
        bool ProdusDinComandaServ { get; set; }
        bool ProdusServ { get; set; }
        double RabatPeProdusProcentFact { get; set; }
        double ValoareRabatPeProdusFact { get; set; }
        double ValoareTVARabatPeProdusFact { get; set; }
        int IdProdusPentruServiciu { get; set; }
        Lista_Produse ProdusPentruServiciu { get; set; }
        double ProcAdaosServiciu { get; set; }
        double PretVanzareProdusServiciu { get; set; }
        double PretServFaraRabat { get; set; }
        double ValoareServFaraRabat { set; get; }
        double TVALaValServFaraRabat { get; set; }
        DateTime DataIntrareProdusFacturat { get; set; }
        DateTime DataIesireProdusFacturat { get; set; }
        double PretServLeiVechi { get; set; }
        double ValoareServLeiVechi { set; get; }
        double ValoareTVAServLeiVechi { get; set; }
        int  IdGestiuneFactDet { get; set; }
        Lista_Gestiuni GestiuneFactDet { set; get; }
        int IdContDebitDescGest { get; set; }
        Lista_Conturi ContDebitDescGest { set; get; }
        int IdContCreditDescGest { get; set; }
        Lista_Conturi ContCreditDescGest { get; set; }
        bool TVANeexigibil { get; set; }
    }
}
