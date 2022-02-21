using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Lista_CC_Subclasa_PAuto
    {
        int IdCPAutoSubclasa { get; set; }
        int IdAutoClasa { get; set; }
        Lista_CC_PAuto AutoClasa { get; set; }
        String CPAutoCheltuialaSubclasa { get; set; }

    }
}
