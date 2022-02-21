using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Disponibile
    {
        int IdCTCDisponibila { get; set; }  
        int IdCapacitateTransport { get; set; }
        Firme_Capacitati_Transport CapacitateTransport { get; set; }
        bool Disponibila { set; get; }
        int IdTaraD { set; get; }
        Lista_Tari TaraD { set; get; }
        int IdOrasD { set; get; }
        Lista_Orase OrasD { set; get; }
        DateTime DataD { set; get; }
    }
}
