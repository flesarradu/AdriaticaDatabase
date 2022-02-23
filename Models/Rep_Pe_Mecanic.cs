using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Rep_Pe_Mecanic
    {
        String NumePC { get; set; }
        String NrAutoManisiProprii { get; set; }
        String NumeLuna { get; set; }
        int AnReparatie { get; set; }
        double TotalOreMasinaRep { get; set; }
        double TotalNrOre { get; set; }
    }
}
