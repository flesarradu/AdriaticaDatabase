using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Firme_Persoane_Contact
    {
        int IdPersoaneContact { get; set; }
        int IdFirma { get; set; }
        Firme Firma { get; set; }
        int IdFunctie { get; set; }
        Lista_Functii Functie { get; set; }
        String Nume { get; set; }
        int IdSex { get; set; }
        Lista_Varia Sex { get; set; }
        String Telefon { get; set; }
        bool AnulareTerti { get; set; }

    }
}
