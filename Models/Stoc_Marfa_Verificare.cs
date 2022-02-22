using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Stoc_Marfa_Verificare
    {
        int IdStocMarfa { get; set; }
        int IdProdusNIRDet { get; set; }
        Lista_Produse ProdusNIRDet { get; set; }
        String CodProdusFacturat { get; set; }
        String FelDoc { get; set; }
        String NrDoc { get; set; }
        DateTime DataDoc { get; set; }
        double StocDepozit { get; set; }
        double PretIntrare { get; set; }
        double ValoareIntrareProdus { get; set; }
        double PretDeVanzare { get; set; }
        double ValoareVanzareProdus { get; set; }
        DateTime DataIntrare { get; set; }
        int IdGestiune { get; set; }
        Lista_Gestiuni Gestiune { get; set; }

    }
}
