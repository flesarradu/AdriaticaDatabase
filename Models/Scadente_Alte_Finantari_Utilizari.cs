using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Scadente_Alte_Finantari_Utilizari
    {
        int IdFinantareUtilizare { get; set; }
        int IdFinantare { get; set; }
        double ValoareUtilizataFinantare { get; set; }
        DateTime DataUtilizariiFinantare { get; set; }
        int IdValutaValoareUtilizata { get; set; }
        Lista_Valute ValutaValoareUtilizata { get; set; }
    }
}
