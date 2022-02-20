using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Bon_De_Consum
    {
        int IdBonCons { get; set; }
        int IdFirmaBonCons { get; set; }
        Firme FirmaBonCons { get; set; }
        int IdProdusLucrareBonCons { get; set; }
        Denumire_Operatie ProdusLucrareBonCons { get; set; }
        String NrDocumentBonCons { get; set; }
        DateTime DataBonCons { get; set; }
        String CodPredatorBonCons { get; set; }
        String CodPrimitorBonCons { get; set; }
        String CodProdusBonCons { get; set; }
        int IdSefCompartBonCons { get; set; }
        Angajati_Detalii SefCompartBonCons { get; set; }
        int IdGestionarBonCons { get; set; }
        Angajati_Detalii GestionarBonCons { get; set; }
        int IdPrimitorBonCons { get; set; }
        Firme_Persoane_Contact PrimitorBonCons { get; set; }
        double TotalValoareBonCons { get; set; }
        double TotalValCuAdaosBonCons { get; set; }
        bool BonFacturatBonCons { get; set; }
        int SelectieTipBon { get; set; }
        bool BonExpCheltPABonCons { get; set; }
        bool ReparatiiMasinaProprie { get; set; }
        int IdNrAutoBonCons { get; set; }
        Lista_NrAuto_Masini_Proprii NrAutoBonCons { get; set; }
        bool BonScazutDinFisaMagazie { get; set; }
        String PrimitorAltiiBonCons { get; set; }
        bool BonBlocat { get; set; }
        bool BalantaEmisaBonCons { get; set; }
        double TotalValoareBonConsCuTVA { get; set; }
        double TotalValCuAdaosBonConsCuTVA { get; set; }
        int IdCotaTVABonCons { get; set; }
        Lista_Cota_TVA CotaTVABonCons { get; set; }
        bool NuInContabilitate { get; set; }
        int IdGestiuneaBon { get; set; }
        Lista_Gestiuni GestiuneaBon { get; set; }
        String NrComandaClientBonCons { get; set; }
    }
}
