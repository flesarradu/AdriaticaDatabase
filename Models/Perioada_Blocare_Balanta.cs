using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Perioada_Blocare_Balanta
    {
        DateTime DataInceput { get; set; }
        DateTime DataSfarsit { get; set; }
        String Modul { get; set; }
    }
}
