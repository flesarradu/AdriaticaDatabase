using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Lista_Coeficienti_De_Drum
    {
        int IdCoeficient { get; set; }
        double Coeficientul { get; set; }
        int IdTaraCoeficient { get; set; }
        Lista_Tari TaraCoeficient { get; set; }
    }
}
