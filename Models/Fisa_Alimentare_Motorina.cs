using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Fisa_Alimentare_Motorina
    {
        int IdFisaAlimentMotorina { get; set; }
        int NrFisaFAM { get; set; }
        int IdNrAutoFAM { get; set; }
        Lista_NrAuto_Masini_Proprii NrAutoFAM { get; set; }
        int IdSoferFAM { get; set; }
        Firme_Persoane_Contact SoferFAM { get; set; }
        DateTime DataFAM { get; set; }
        double LitriAlimentatiFAM { get; set; }
        int IdResponsabilAlimentFAM { get; set; }
        Firme_Persoane_Contact ResponsabilAlimentFAM { get; set; }
        int KmBordCurentFAM { get; set; }

    }
}
