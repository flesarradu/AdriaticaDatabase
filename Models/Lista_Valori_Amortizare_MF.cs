using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Lista_Valori_Amortizare_MF
    {
        int IdMFAmortizare { get; set; }
        DateTime DataInceputAmortizare { get; set; }
        DateTime DataSfarsitAmortizare { get; set; }
        double ValoareDeAmortizare { get; set; }
        double ValoareMF { get; set; }
    }
}
