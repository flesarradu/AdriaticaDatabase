using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Tabel_Intermediar_Inchidere_Avansuri
    {
        int IdInchiderea { get; set; }
        double Suma { get; set; }
        int IdMoneda { get; set; }
        Lista_Valute Moneda { get; set; }
        String ComputerName { get; set; }
        bool Numerar { get; set; }
    }
}
