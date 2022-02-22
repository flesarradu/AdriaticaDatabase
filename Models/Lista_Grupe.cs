using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Lista_Grupe
    {
        int IdGrupa { get; set; }
        String CodDeClasificareGrupa { get; set; }
        String DenumireGrupa { get; set; }
        int IdContGrupa { get; set; }
        Lista_Conturi ContGrupa { get; set; }
    }
}
