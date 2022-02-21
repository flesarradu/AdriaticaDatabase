using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Lista_Incadrari_Detalii
    {
        int IdIncadrareDetalii { get; set; }
        String IncadrareDetalii { set; get; }
        int IdIncadrare { get; set; }
        Lista_Incadrari Incadrare { get; set; }

    }
}
