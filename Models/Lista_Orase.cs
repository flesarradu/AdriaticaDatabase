using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Lista_Orase
    {
        int IdOras { get; set; }
        int IdTaraOras { get; set; }
        Lista_Tari TaraOras { get; set; }
        String Oras { get; set; }
        String CodOras { get; set; }
        
    }
}
