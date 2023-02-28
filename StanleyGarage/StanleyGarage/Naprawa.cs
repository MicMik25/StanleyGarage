using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StanleyGarage
{
   [Serializable]
    class Naprawa
    {
        internal string numer_rejestracyjny, nazwa_naprawy;
        internal DateTime data_oddania_do_naprawy;
        internal Mechanik mechanik;
        internal decimal koszt_uzytych_czesci;
        internal decimal czas_pracy_mechanika;
        internal decimal oblicz_wynagrodzenie => 0.02m * koszt_uzytych_czesci + 0.3m * mechanik.stawka_godzinowa * czas_pracy_mechanika;
        internal decimal oblicz_należność => (koszt_uzytych_czesci + (mechanik.stawka_godzinowa * czas_pracy_mechanika));

        internal object[] Values => new object[] { (mechanik.imie+" "+mechanik.nazwisko),data_oddania_do_naprawy.ToShortDateString(), nazwa_naprawy, numer_rejestracyjny, koszt_uzytych_czesci.ToString(), czas_pracy_mechanika.ToString() };
    }
}
