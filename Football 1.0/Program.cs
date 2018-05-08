using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Football 1.0";
            bool koniec = false;
            Gracz gracz = new Gracz();

            try
            {
                while (!koniec)
                {
                    Console.Clear();
                    Console.WriteLine("Wprowadź odpowiedni numer:");
                    Console.WriteLine("1. Dodaj nowego gracza");
                    Console.WriteLine("2. Wyświetl graczy");
                    Console.WriteLine("3. Zakoncz");
                    int opcja = int.Parse(Console.ReadLine());

                    if (opcja == 1)
                    {
                        gracz.StworzGracza();
                        Console.ReadKey();
                    }
                    else if (opcja == 2)
                    {
                        Console.Clear();
                        gracz.WyswietlGraczy();
                    }
                    else if (opcja == 3)
                    {
                        koniec = !koniec;
                        gracz.ZapiszIZakoncz();
                    }
                    else
                    {
                        Console.WriteLine("Wprowadziłeś niewłaścwe dane wybierz: 1, 2 lub 3");
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Błędne dane koniec programu");
            }   
        }
    }
}
