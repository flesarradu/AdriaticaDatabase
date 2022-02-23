using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Note_Contabile_Salarii
    {
        int IdNotaSalariu { get; set; }
        String ExplicatiiSalarii { get; set; }
        int IdSimbolCodDebit { get; set; }
        Lista_Conturi SimbolCodDebit { get; set; }
        int IdSimbolCodCredit { get; set; }
        Lista_Conturi SimbolCodCredit { get; set; }

    }
}
