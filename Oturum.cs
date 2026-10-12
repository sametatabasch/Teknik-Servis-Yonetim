using System;
using System.Collections.Generic;
using System.Text;
using Teknik_Servis_Yönetim.Models;

namespace Teknik_Servis_Yönetim
{
    internal static class Oturum
    {
        public static Calisan? AktifKullnici { get; set; }

        public static void GirisYap(Calisan kullanici)
        {
            AktifKullnici = kullanici;
        }

        public static bool GirisYapildiMi()
        {
            return AktifKullnici != null;
        }

        public static void CikisYap()
        {
            AktifKullnici = null;
        }
    }
}
