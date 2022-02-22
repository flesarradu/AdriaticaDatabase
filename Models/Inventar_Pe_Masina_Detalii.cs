using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Inventar_Pe_Masina_Detalii
    {
        int IdDetaliiInventar { get; set; }
        int IdInventarDetalii { get; set; }
        Inventar InventarDetalii { get; set; }
        int IdObiectulInventarDetalii { get; set; }
        Lista_Obiecte_De_Inventar ObiectulInventarDetalii { get; set; }
        int NrBucatiInventarDetalii { get; set; }
        String DocumentPrimireDetalii { get; set; }
        String DocumentPredareDetalii { get; set; }
        int GradDeUzuraDetalii { get; set; }
        bool LipsaInventarDetalii { get; set; }
        int BucatiLipsaInventar_Detalii { get; set; }
    }
}
