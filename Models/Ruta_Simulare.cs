using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Ruta_Simulare
    {
        int IdRuta { get; set; }
        int IdRutaSimulare { get; set; }
        Simulare_Cursa RutaSimulare { get; set; }
        int IdOrasRutaSimulare { get; set; }
        Lista_Orase OrasRutaSimulare { get; set; }

    }
}
