using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Ev_Det
    {
        int IdEvDet { get; set; }
        int IdEv { get; set; }
        double NrOre { get; set; }
        int IdRep { get; set; }
        Denumire_Operatie Rep { get; set; }
        int IdOb { get; set; }
        Lista_Produse Ob { get; set; }
        int IdTipReparatie { get; set; }
        Lista_Reparatii TipReparatie { get; set; }
        double NrOreNormate { get; set; }
        String ExplcatiiReparatie { get; set; }
    }
}
