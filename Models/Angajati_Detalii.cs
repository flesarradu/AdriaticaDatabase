using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Angajati_Detalii
    {
        int  IdNumeAngajati { get; set; }
        Firme_Persoane_Contact NumeAngajati { get; set; }
        String BIAngajati { get; set; }
        String CNPAngajati { get; set; }
        DateTime DataNastereAngajati { get; set; }
        DateTime DataAngajariiAngajati { get; set; }
        int VarstaAngajati { get; set; }
        String AdresaAngajati { get; set; }
        bool StareaCivilaAngajati { get; set; }
        int CopiiAngajati { get; set; }
        DateTime DataExpirareVizaAngajati { get; set; }
        DateTime DataExpirarePasaportAngajati { get; set; }
        DateTime DataExpirarePermisAngajati { get; set; }
        DateTime DataExpirareVizaMedAngajati { get; set; }
        DateTime DataExpirarePsihoAngajati { get; set; }
        DateTime DataExpirareADRAngajati { get; set; }
        String NrPasaportAngajati { get; set; }
        String TelefonAcasaAngajati { get; set; }
        String ObservatiiAngajati { get; set; }
        bool AnulareAngajati { get; set; }
        DateTime DataPlecareAngajati { get; set; }
        String VizaTariAngajati { get; set; }
        String ClasaADR { get; set; }
        String CodAngajati { get; set; }
        String NrPasaport2Angajati { get; set; }
        DateTime DataExpirarePasaport2Angajati { get; set; }
        String EliberatDeBIAngajati { get; set; }
        String SeriePermisAngajati { get; set; }
        String SerieCertificatADRAngajati { get; set; }
        String SerieVizaMedicalaAngajati { get; set; }
        DateTime DataExpirareAtestatProfesional { get; set; }
        String SerieAtestatProfesionalAngajati { get; set; }
        String SerieAvizPsihologicAngajati { get; set; }
        DateTime DataExpirareAsigSanatateAngajati { get; set; }
        String SerieAsigSanatateAngajati { get; set; }

    }
}
