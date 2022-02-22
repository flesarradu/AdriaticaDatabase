using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Tabel_Static_Inchidere_Avansuri
    {
        int IdInchidereStatic { get; set; }
        double SumaStatic { get; set; }
        int IdMonedaStatic { get; set; }
        Lista_Valute MonedaStatic { get; set; }

    }
}
