using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StanleyGarage
{
    [Serializable]
    class Mechanik
    {
        internal string imie, nazwisko;
        internal int data_rozpoczecia_pracy;
        internal decimal stawka_godzinowa;

        internal static List<Mechanik> Lista_mechanikow = new List<Mechanik>();
        static public int IndexOf(Mechanik mechanik)
        {
            for (int i = 0; i < Lista_mechanikow.Count; i++) 
                if(Lista_mechanikow[i] == mechanik)
                    return i;

            return -1;
        }

        public override string ToString()
        {
            return imie + " " + nazwisko + " (" + stawka_godzinowa.ToString("0.00") + " )";
        }

        static public bool operator==(Mechanik left,Mechanik right)
        {
            return (left.imie == right.imie && left.nazwisko == right.nazwisko);
        }

        static public bool operator !=(Mechanik left, Mechanik right)
        {
            return !(left == right);
        }

        internal static void Init()
        {
            if (Lista_mechanikow.Count > 0)
            {
                return;
            }
            Mechanik pierwszy, drugi, trzeci, czwarty;
            pierwszy = new Mechanik();
            drugi = new Mechanik();
            trzeci = new Mechanik();
            czwarty = new Mechanik();
            pierwszy.imie = "Heniek";
            pierwszy.nazwisko = " Kowalski";
            pierwszy.data_rozpoczecia_pracy = 2008; //ten najbardziej doświadczony
            pierwszy.stawka_godzinowa = 40m;


            drugi.imie = "Stasiek";
            drugi.nazwisko = " Suchodolski";
            drugi.data_rozpoczecia_pracy = 2010; // drugi względem stażu pracy
            drugi.stawka_godzinowa = 30.30m;

            trzeci.imie = "Waldek";
            trzeci.nazwisko = " Kononowicz";
            trzeci.data_rozpoczecia_pracy = 2017;
            trzeci.stawka_godzinowa = 20m;

            czwarty.imie = "Franek";
            czwarty.nazwisko = " Łoś";
            czwarty.data_rozpoczecia_pracy = 2022; // młody na warsztacie
            czwarty.stawka_godzinowa = 18.30m; //najniższa stawka z tytułu najkrótszego stażu

            Lista_mechanikow.Add(pierwszy);
            Lista_mechanikow.Add(drugi);
            Lista_mechanikow.Add(trzeci);
            Lista_mechanikow.Add(czwarty);
        }
    }
}
