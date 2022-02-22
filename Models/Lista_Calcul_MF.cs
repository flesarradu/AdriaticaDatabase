using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Lista_Calcul_MF
    {
        int IdCalculMF { get; set; }
        int IdMFCalcul { get; set; }
        int IdLunaCalculMF { get; set; }
        Lista_Luni LunaCalculMF { get; set; }
        int AnulCalculMF { get; set; }
        double ValoareRamasaNeamortizataMF { get; set; }
        double ValoareAmortizataObiectMF { get; set; }
        double ValoareCrestere { get; set; }
        double ValoareAmortizataLunarMF { get; set; }
        double ValoareAmortizataReevaluareMF { get; set; }
        double ValoareRamasaNeamortizataMFVeche { get; set; }
        double ValoareAmortizataLunarMFVeche { get; set; }
        double ValoareAmortizataObiectMFVeche { get; set; }
        bool LunaStart { get; set; }
    }
}
