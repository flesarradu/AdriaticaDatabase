using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Bon_Transfer
    {
        int IdBon { get; set; }
        DateTime DataBon { get; set; }
        int IdPredatorBon { get; set; }
        Firme_Persoane_Contact PredatorBon { get; set; }
        int IdPrimitorBon { get; set; }
        Firme_Persoane_Contact PriitorBon { get; set; }
        int NumarBon { get; set; }
        int NumarComanda { get; set; }
        int IdFirmaBon { get; set; }
        Firme FirmaBon { get; set; }
        bool BonBlocat { get; set; }
        bool BalantaEmisaBon { get; set; }
        bool NuInContaBon { get; set; }
    }
}
