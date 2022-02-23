using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class NIR
    {
        int IdNIR { get; set; }
        int IdFurnizorNIR { get; set; }
        Firme FurnizorNIR { get; set; }
        DateTime DataNIR { get; set; }
        int IdCumparatorNIR { get; set; }
        Firme CumparatorNIR { get; set; }
        String NumarNIR { get; set; }
        String NumarAutoFurnizorNIR { get; set; }
        String NrFacturaFurnizorNIR { get; set; }
        DateTime DataFacturaFurnizorNIR { get; set; }
        int IdCotaTVANIR { get; set; }
        Lista_Cota_TVA CotaTVANIR { get; set; }
        int IdLocalitateFurnizorNIR { get; set; }
        Lista_Orase LocalitateFurnizorNIR { get; set; }
        double TotalValoareFaraTVANIR { get; set; }
        double TotalValoareCuTVANIR { get; set; }
        bool MarfaIesitaNIR { get; set; }
        int IdComisiaReceptie { get; set; }
        Firme_Persoane_Contact ComisiaReceptie { set; get; }
        String PrimitGestiune { get; set; }
        bool NIRActualizataInFisaMagazie { get; set; }
        bool NIRDusInFacturiPrimite { get; set; }
        int IdContDebitNIR { get; set; }
        Lista_Conturi ContDebitNIR { set; get; }
        int IdContCreditNIR { get; set; }
        Lista_Conturi ContCreditNIR { set; get; }
        String Observatii { get; set; }
        bool NIRBlocat { get; set; }
        double TotalValFaraTVAAdaosNIR { get; set; }
        double TotalValCuTVAAdaosNIR { set; get; }
        DateTime DataScadentaFacturaPrimita { get; set; }
        int IdGestiunea { get; set; }
        Lista_Gestiuni Gestiunea { set; get; }
        bool BalantaEmisaNIR { get; set; }

    }
}
