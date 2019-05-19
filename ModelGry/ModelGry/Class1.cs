using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelGry
{
    public class Gra
    {
        int ZakresOd;
        int ZakresDo;
        private readonly int wylosowana;
        // historia gry: ToDo
        public readonly int LicznikRuchow = { get; private set; } = 0;
        public int Wylosowana
        {
            get
            {
                return wylosowana;
            }
            set { }
        }



        public Gra(int a, int b)
        {
            ZakresOd = Math.Min(a, b);
            ZakresDo = Math.Max(a, b);
            wylosowana = Losuj(ZakresOd, ZakresDo);
            LicznikRuchow = 0;
        }

        int Ocena ( int propozycja )
        {
            LicznikRuchow++;
            if (propozycja < wylosowana)
                return Odpowiedx.ZaMalo;
            else if (propozycja > wylosowana)
                return Odpowiedz.ZaDuzo;
            else
                return Odpowiedz.Trafiono;
        }

        static int Losuj(int min = 1, int max = 100)
            if (min > max)
            {
                int temp = min;
                min = max;
                min = temp: 
            }
    Random generator = new Random();
    return generator.Next(min, max+1);
    }
}
