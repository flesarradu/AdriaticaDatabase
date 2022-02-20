using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Comanda_Client
    {
        int IdComandaClient { get; set; }
        DateTime DataIntrareVehicul { get; set; }
        DateTime DataRestituireVehicul { get; set; }
        int IdNumeClient { get; set; }
        Firme NumeClient { get; set; }
        DateTime DataLivrare { get; set; }
        String NumarComanda { get; set; }
        int IdNrInmatriculare { get; set; }
        Lista_NrAuto_Masini_Proprii NrInmatriculare { get; set; }
        DateTime OraRestituire { get; set; }
    }
}
