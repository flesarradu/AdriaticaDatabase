using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Lista_Acces_Aplicatie
    {
        int Id { get; set; }
        String Utilizator { get; set; }
        DateTime DataAcces { get; set; }
        DateTime DataIesire { get; set; }

    }
}
