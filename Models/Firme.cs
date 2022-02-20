using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Firme
    {
        int IdFirma { get; set; }
        int IdFirmaTara { get; set; }
        Lista_Tari FirmaTara { get; set; }
        int IdFirmaOras { get; set; }
        Lista_Orase FirmaOras { get; set; }
        int IdFirmaJudet { get; set; }
        Lista_Judete FirmaJudete { get; set; }
        String FirmaNume { get; set; }
        bool FirmaProprie { get; set; }
        bool FirmaImportanta { get; set; }
        String FirmaFormaJuridica { get; set; }
        String FirmaCodFiscalLitere { get; set; }
        String FirmaCodFiscal { get; set; }
        String FirmaRegistruComert { get; set; }
        String FirmaAdresaStrada { get; set; }
        String FirmaAdresaNumar { get; set; }
        String FirmaAdresaDetalii { get; set; }
        String FirmaTelefon1 { get; set; }
        String FirmaTelefon2 { get; set; }
        String FirmaFax { get; set; }
        String FirmaCodPostal { get; set; }
        String FirmaEmail { get; set; }
        String FirmaWeb { get; set; }
        String FirmaCont { get; set; }
        String FirmaBanca { get; set; }
        String FirmaDestinatii { get; set; }
        String FirmaObservatii { get; set; }
        bool FirmaAnulare { get; set; }
        String CapitalSocialFirma { get; set; }
        bool FirmaPentruService { get; set; }
        bool FirmaExportataInService { get; set; }
        DateTime DataIntroduceriiFirma { get; set; }
        int IdPersoanaIntroducereFirma { get; set; }
        Firme_Persoane_Contact PersoanaIntroducereFirma { get; set; }
        bool FirmaPreferentialaITP { get; set; }
        bool ClientFZIncert { get; set; }
        bool NeplatitorTVA { get; set; }
        int IdFirmeDec394 { get; set; }
    }
}
