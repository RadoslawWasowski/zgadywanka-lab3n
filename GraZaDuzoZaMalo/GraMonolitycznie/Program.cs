using System;
using System.Diagnostics;
using System.IO;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            StringReaderwejscie = new StringReader(test1);

            //wczytaj sekwencję s
            string line1 = Console.ReadLine(); // zamienic na Console
            int n = Convert.ToInt32(line1);
            string line2 = Console.ReadLine(); // zamienic na Console
            string[] tab2 = line2.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Debug.Assert(tab2.Length == n);

            int[] s = new int[n];
            for (int i = 0; i < n; i++)
            {
                s[i] = int.Parse(tab2[i]);
            }

            //wczytaj sekwencję q
            string line3 = wejscie.ReadLine(); //
            int n = Convert.ToInt32(line1);
            string line4 = wejscie.ReadLine();  //
            string[] tab4 = line2.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);


            Debug.Assert(tab4.Length == m);

            int[] q = new int[n];
            for (int i = 0; i < nm; i++)
            {
                q[i] = int.Parse(tab4[i]);
            }
            //oblicz 
            string wynik = "";
            for (int i = 0; i < Math.Min(n, m); i++)
            {
                if (s[i] == q[i])
                    wynik += (i + " ");

            }
        }

        static string test1 = @"5
-2 -2 -1 1 4 
6
-3 -2 -1 1 2 3";


        static string test2 = "5\n-2 -2 -1 1 4\n6\n-3 -2 -1 1 2 3";
    }
}
