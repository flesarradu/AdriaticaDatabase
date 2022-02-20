using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Comanda_Client_Detalii
    {
        int IdComandaDetalii { get; set; }
        Comanda_Client ComandaDetalii { get; set; }
        String Explicatii { get; set; }
    }
}
