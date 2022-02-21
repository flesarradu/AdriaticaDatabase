using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class DevizEstim
    {
        int IdDevizEstim { get; set; }
        DateTime DevizData { get; set; }
        double DevizValoare { get; set; }
        double DevizAdaos { get; set; }
        String NumarDeviz { get; set; }
        int IdClientDeviz { get; set; }
        Firme ClientDeviz { get; set; }
    }
}
