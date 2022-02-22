using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Lista_Conturi_Casa
    {
        int IdCont { get; set; }
        String Contul { get; set; }
        String DescriereCont { get; set; }
        bool ValutaCont { get; set; }
        bool ContDebit { get; set; }
        bool ContCredit { get; set; }
    }
}
