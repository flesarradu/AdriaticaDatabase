using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Scadente_Asigurari_Master
    {
        int IdAsigurare { get; set; }
        int IdTipAsigurare { get; set; }
        Lista_Tipuri_Asigurari TipAsigurare { get; set; }
        int IdAsiguratorAsigurare { get; set; }
        Firme AsiguratorAsigurare { get; set; }
        int IdPersoanaIntocmireAsigurare { get; set; }
        Firme_Persoane_Contact PersoanaIntocmireAsigurare { get; set; }
        DateTime DataIntroduceriiAsigurare { get; set; }
        DateTime OraIntroduceriiAsigurare { get; set; }
        int DurataContractLuni { get; set; }
        DateTime DataStartContract { get; set; }
        String NrContract { get; set; }


    }
}
