using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Inventar_Mecanic_Detalii
    {
        int IdDetaliiInventarMecanic { get; set; }
        int IdInventarDetaliiMecanic { get; set; }
        Inventar InventarDetaliiMecanic { set; get;  }
        int IdObiectulInventarDetaliiMecanic { get; set; }
        Lista_Obiecte_De_Inventar_Mecanic ObiectulInventarDetaliiMecanic { get; set; }
        int NrBucatiInventarDetaliiMecanic { get; set; }
        String DocumentPrimireDetaliiMecanic { get; set; }
        String DocumentPredareDetaliiMecanic { get; set; }
        int GradDeUzuraDetaliiMecanic { get; set; }
        bool LipsaInventarDetaliiMecanic { get; set; }  
        int BucatiLipsaInventarDetaliiMecanic { get; set; }

    }
}
