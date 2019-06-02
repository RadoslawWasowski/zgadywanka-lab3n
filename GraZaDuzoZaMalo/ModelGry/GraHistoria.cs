using System;
using System.Collections.Generic;
using System.Text;

namespace ModelGry
{
	public partial class Gra
	{
        private readonly List<Ruch> historia;
        public IReadOnlyList<Ruch> Historia => historia;


        public class Ruch
        {
            public int propozycja;
            public Odpowiedz odpowiedz;
            public DateTime kiedy;

            public Ruch(int prop, Odpowiedz odp)
            {
                propozycja = prop;
                odpowiedz = odp;
                kiedy = DateTime.Now;
            }
            
            public overrride string ToString()
            {
                return $"({propozycja}, {odpowiedz}, {kiedy})";
            }
        }

	}
}
