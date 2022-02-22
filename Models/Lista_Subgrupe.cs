using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Lista_Subgrupe
    {
        int IdSubGrupa { get; set; }
        String CodDeClasificare { get; set; }
        String DenumireSubgrupa { get; set; }
        int IdGrupaSubgrupa { get; set; }
        Lista_Grupe GrupaSubgrupa { get; set; }
        int IdContSubgrupa { get; set; }
        Lista_Conturi ContSubgrupa { get; set; }
        int IdContAmortizareSubgrupa { get; set; }
        Lista_Conturi ContAmortizareSubgrupa { set; get; }
        int IdContImobilizariCorporale { get; set; }
        Lista_Conturi ContImobilizariCorporale { set; get; }
        int IdContRezerveReevaluare { get; set; }
        Lista_Conturi ContRezerveReevaluare { set; get; }
    }
}
