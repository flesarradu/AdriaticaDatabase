using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Note_Contabile_Ch_In_Avans
    {
        int IdNotaChAvans { get; set; }
        String ExplicatiiChAvans { get; set; }
        int IdSimbolCodDebit { get; set; }
        Lista_Conturi SimbolCodDebit { get; set; }
        int IdSimbolCodCredit { get; set; }
        Lista_Conturi SimbolCodCredit { get; set; }
        double SumChAvans { get; set; }
    }
}
