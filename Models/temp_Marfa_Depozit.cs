using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class temp_Marfa_Depozit
    {
        String CodProdusNIRDet { get; set; }
        String DenumireProdus { get; set; }
        double Stoc { get; set; }
        double PretNIRDet { get; set; }
        int IdProdus { get; set; }
        double Valoare { get; set; }
        double PretDeVanzare { get; set; }
        double ValoareVanzareProdus { get; set; }
        int IdGestiune { get; set; }
        Lista_Gestiuni Gestiune { get; set;}

    }
}
