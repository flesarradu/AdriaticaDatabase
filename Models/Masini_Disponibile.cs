using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Masini_Disponibile
    {
        int IdMD { get; set; }
        int IdFirmaCarausMD { get; set; }
        Firme FirmaCarausMD {get; set; }
        bool DisponibilaMD { get; set; }
        int IdOrasFirmaMD { get; set; }
        Lista_Orase OrasFirmaMd { get; set; }
        int IdFelAutoMD { get; set; }
        Lista_Tipuri_CT FelAutoMD { get; set; }
        int SarcinaUtilaMD { get; set; }
        int VolumUtilMD { get; set; }
        int IdOrasMD { get; set; }
        Lista_Orase OrasMD { get; set; }
        int IdTaraMD { get; set; }
        Lista_Tari TaraMD { get; set; }
        DateTime DataDisponibilaMD { get; set; }
        String NrAutoMD { get; set; }
        bool ProprieMD { get; set; }
        String ObservatiiMD { get; set; }
        bool MasinaIntrodusaMD { get; set; }

    }
}
