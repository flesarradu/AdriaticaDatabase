using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Firme_Capacitati_Transport
    {
        int IdCapacitateTransport { get; set; }
        int IdFirmaCT { get; set; }
        Firme FirmaCT { get; set; }
        int IdTipFCT { get; set; }
        Lista_Tipuri_CT TipFCT { get; set; }
        int IdFelFCT { get; set; }
        Lista_Feluri_CT FelFCT { get; set; }
        double VolumUtilFCT { get; set; }
        double SarcinaUtilaFCT { get; set; }
        double LungimeUtilaFCT { get; set; }
        double LatimeUtilaFCT { get; set; }
        double InaltimeUtilaFCT { get; set; }
        int NumarVehiculeFCT { get; set; }
        String NumarAuto { get; set; }
        int MarcaAutor { get; set; }
        int Sofer { get; set; }
    }
}
