using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static Test.Program;
using static Test.Program.Osoba;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Multiply();

            //FibonacciNiz();

            // DeljiviBrojevi();

            List<Osoba> listaOsoba = new List<Osoba>()
            {

            new Osoba("Dusan", 33, Pol.Muski),

            new Osoba("Marija", 44, Pol.Zenski),

            new Osoba("Dragan", 19, Pol.Muski),

            new Osoba("Mila", 21, Pol.Zenski),

            new Osoba("Milan", 32, Pol.Muski),
        };

            //osoba5.PrikaziInfo();

            //var sortiraneOsobePoGodinama = listaOsoba.OrderByDescending(osoba => osoba.starost).ToList();


            //foreach (var o in sortiraneOsobePoGodinama)
            //{
             //   o.PrikaziInfo();
             //   Console.WriteLine();

            //    Console.ReadLine();
           // }

            var sortiraneOsobePoPolu = listaOsoba.GroupBy(osoba => osoba.polOsobe)
            .Select(grupa => new
            {
                Pol = grupa.Key,
                Osobe = grupa.Select(osoba => new { Ime = osoba.ime, Godine = osoba.starost })
            });

            foreach (var sortirani in sortiraneOsobePoPolu)
            {
                Console.WriteLine($"Osobe sa polom {sortirani.Pol}");
                foreach(var osoba in sortirani.Osobe)
                {
                    Console.WriteLine($"Ime: {osoba.Ime}, Starost: {osoba.Godine} godina");
                }

                Console.WriteLine();
                Console.ReadLine();
            }





        }

        public class Osoba
        {

            public enum Pol
            {
                Muski,
                Zenski
            }

            public string ime { get; set; }
            public int starost { get; set; }
            public Pol polOsobe { get; set; }


            public Osoba (string naziv, int godine, Pol pol)
            {
                ime = naziv;
                starost = godine;
                polOsobe = pol;

            }

            public void PrikaziInfo ()
            {
                Console.WriteLine($"Ime: {ime}");

                Console.WriteLine($"Starost: {starost}");

                Console.WriteLine($"Pol osobe: {polOsobe}");
            }

        }

        public static void DeljiviBrojevi()
        {
            Console.WriteLine("Unesite broj N");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                List<int> brojevi = Enumerable.Range(1, 100).ToList();
                Console.WriteLine($"Brojevi iz liste koji su deljivi sa {n}");

                foreach (int i in brojevi) 
                {
                    if ( i % n == 0)
                    {
                        Console.WriteLine(i);
                    }
                    
                }
                
            }
            else
            {
                Console.WriteLine("Niste uneli dobar broj!");
            }

            Console.ReadLine();
        }

        public static void FibonacciNiz() {
            Console.WriteLine("Unesite pozitivan N broj za ispis prvih N brojeva u fibonacijevom nizu: ");
            if (int.TryParse(Console.ReadLine(), out int N) && N > 0)
            {
                Console.WriteLine("Prvih " + N + " brojeva u Fibonacci nizu su:");

                int prviBroj = 0;
                int drugiBroj = 1;

                for (int i =0; i < N; i++)
                {
                    Console.WriteLine(prviBroj);
                    int temp = prviBroj;
                    prviBroj = drugiBroj;
                    drugiBroj = temp + drugiBroj;
                }
            }
            else
            {
                Console.WriteLine("Niste uneli pozitivan broj...");
            }

            Console.ReadLine();
        }

        public static void Multiply()
        {
            Console.WriteLine("Dobrodosli u kalkulator mnozenja!");
            Console.WriteLine("Unesite broj za izracunavanje kvadrata...");

            while (true) {

                Console.Write("Unesite broj ili karakter X za izlazak ");
                string unos = Console.ReadLine();

                if (unos.ToLower() == "x") {

                    break;                
                }

                if (double.TryParse(unos, out double broj)) {
                    double kvadrat = broj * broj;
                    Console.WriteLine($"Kvadrat broja {broj} je {kvadrat}");
                }

                else
                {
                    Console.WriteLine("Niste uneli validan broj ili slovo");
                }
        }


           
            

            
        
    

















        }






    }
}

    


    
 

