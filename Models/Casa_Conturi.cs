using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Casa_Conturi
    {
        int Id { get; set; }
        int IdContulAnalitic { get; set; }
        Lista_Conturi ContulAnalitic { get; set; }
        int IdContulSintetic { get; set; }
        Lista_Conturi ContulSintetic { get; set; }
    }
}
