using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Fisa_De_Magazie
    {
        int IdFM { get; set; }
        int IdProdusFM { get; set; }
        Lista_Produse ProdusFM { get; set; }
        int IdUMMaterialFM { get; set; }
        Lista_Varia UMMaterialFM { get; set; }
        double PretIntrareFM { get; set; }
        double PretVanzareFM { get; set; }
        int IdGestiuneFM { get; set; }
        Lista_Gestiuni GestiuneFM { get; set; }
        DateTime DataDocFM { get; set; }
        String NrDocFM { get; set; }
        String FelDocFM { get; set; }
        double CantIntrareFM { get; set; }
        double CantIesireFM { get; set; }
        double StocMaterialFM { get; set; }
        int IdClientFurnizorFM { get; set; }
        Firme ClientFurnizorFM { get; set; }

    }
}
