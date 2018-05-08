using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Football_1._0
{
    public class Gracz
    {
        string Imie;
        Skills skills = new Skills();
        public List<ZapiszGracza> listaGraczy = OdczytajXML();

        internal void StworzGracza()
        {
            Console.Clear();
            Console.Write("Wprowadź imie => ");
            Imie = Console.ReadLine();
            Console.WriteLine("Cześć {0} za chwilę udzielisz odpowiedzi na 16 pytań,\npo skończeniu powiem Ci jaka formacja na boisku będzie dla Ciebie najkorzystniejsza.", Imie);
            Console.WriteLine("\nNa każde pytanie odpowiedz wprowadzając odpowiedni numer:");
            Console.WriteLine("1 => Bardzo słabo || 2 => Słabo || 3 => Przeciętnie || 4 => Dobrze || 5 => Bardzo dobrze");
            Console.WriteLine("Minimalna nota to 18punktów a maksymalna 98punktów, aby rozpocząć naciśnij dowolny klawisz...");
            Console.ReadKey();

            skills.PodliczUmiejętnosci();
            ZapiszGracza zg = new ZapiszGracza(Imie, skills.Atak, skills.Pomoc, skills.Obrona);
            listaGraczy.Add(zg);
            Wyswietl();
        }

        private void Wyswietl()
        {
            Console.WriteLine("\n{0} twoje umiejętności na poszczególnych formacjach wynoszą:", Imie);
            Console.WriteLine("Atak: {0}  ||  Pomoc: {1}  ||  Obrona: {2}", skills.Atak, skills.Pomoc, skills.Obrona);
        }

        internal void WyswietlGraczy()
        {
            if (0 == listaGraczy.Count)
            {
                Console.WriteLine("Brak zapisanych graczy");
            }
            else
            {
                foreach (var item in listaGraczy)
                {
                    Console.WriteLine(item);
                }
            }
            Console.ReadKey();
        }

        internal void ZapiszIZakoncz()
        {
            ZapiszXML(listaGraczy);
        }

        private static List<ZapiszGracza> OdczytajXML()
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<ZapiszGracza>));
            StreamReader plik = new StreamReader("GraczeXML.xml");
            List<ZapiszGracza> lista = (List<ZapiszGracza>)xs.Deserialize(plik);
            plik.Close();
            return lista;
        }

        private void ZapiszXML(List<ZapiszGracza> obj)
        {
            XmlSerializer xs = new XmlSerializer(obj.GetType());
            FileStream plik = File.Create("GraczeXML.xml");
            xs.Serialize(plik, obj);
            plik.Close();
        }
    }
}
