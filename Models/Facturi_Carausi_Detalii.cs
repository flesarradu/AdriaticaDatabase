using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Facturi_Carausi_Detalii
    {
        int IdServiciuFCDetalii { get; set; }
        int IdFacturaServFCDetalii { get; set; }
        Facturi_Carausi FacturaServFCDetalii { get; set; }
        int IdFacturaServPartidaFCDetalii { get; set; }
        Curse FacturaServPartidaFCDetalii { get; set; }
        String ServiciuFCDetalii { get; set; }
        double CantitateServFCDetalii { get; set; }
        double PretServFCDetalii { get; set; }
        double ValoareServFCDetalii { get; set; }
        double ValoareTVAServFCDetalii { get; set; }
        int IdContDebitFCDetalii { get; set; }
        Lista_Conturi ContDebitFCDetalii { get; set; }
        int IdContCreditFCDetalii { get; set; }
        Lista_Conturi ContCreditFCDetalii { get; set; }
        double ValoareServEUR { get; set; }
        double ValoareTVAServEUR { get; set; }
        int IdIncadrareServ { get; set; }
        Lista_Incadrari IncadrareServ { get; set; }
        int IdTVAFCarausLinie { get; set; }
        Lista_Cota_TVA TVAFCarausLinie { get; set; }
        int IdSubIncadrareServ { get; set; }
        Lista_Incadrari_Detalii SubIncadrareServ { get; set; }
        double PretServFCDetaliiLeiVechi { get; set; }
        double ValoareServFCDetaliiLeiVechi { get; set; }
        double ValoareTVAServFCDetaliiLeiVechi { get; set; }
        bool ReprezintaVenitFCDetalii { set; get; }
        bool TVANeexigibil { set; get; }
    }
}
