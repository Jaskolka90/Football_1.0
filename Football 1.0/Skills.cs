using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Football_1._0
{
    public class Skills
    {
        public byte Speed { get; private set; }
        public byte Acceleration { get; private set; }
        public byte Strength { get; private set; }
        public byte Condition { get; private set; }
        public byte Jumping { get; private set; }
        public byte ShortPassing { get; private set; }
        public byte LongPassing { get; private set; }
        public byte BallControl { get; private set; }
        public byte Dribbling { get; private set; }
        public byte Bravery { get; private set; }
        public byte Vision { get; private set; }
        public byte Finishing { get; private set; }
        public byte Head { get; private set; }
        public byte Shot { get; private set; }
        public byte Interceptions { get; private set; }
        public byte Marking { get; private set; }

        public int Atak { get; private set; }
        public int Pomoc { get; private set; }
        public int Obrona { get; private set; }

        internal void PodliczUmiejętnosci()
        {
            Console.Clear();
            try
            {
                Console.Write("Szybkość biegu: ");
                Speed = byte.Parse(Console.ReadLine());
                Console.Write("Przyśpieszenie: ");
                Acceleration = byte.Parse(Console.ReadLine());
                Console.Write("Siła: ");
                Strength = byte.Parse(Console.ReadLine());
                Console.Write("Kondycja: ");
                Condition = byte.Parse(Console.ReadLine());
                Console.Write("Skoczność: ");
                Jumping = byte.Parse(Console.ReadLine());
                Console.Write("Krótkie podanie: ");
                ShortPassing = byte.Parse(Console.ReadLine());
                Console.Write("Długie podanie: ");
                LongPassing = byte.Parse(Console.ReadLine());
                Console.Write("Kontrola piłki: ");
                BallControl = byte.Parse(Console.ReadLine());
                Console.Write("Drybling: ");
                Dribbling = byte.Parse(Console.ReadLine());
                Console.Write("Waleczność: ");
                Bravery = byte.Parse(Console.ReadLine());
                Console.Write("Przegląd pola: ");
                Vision = byte.Parse(Console.ReadLine());
                Console.Write("Wykończenie: ");
                Finishing = byte.Parse(Console.ReadLine());
                Console.Write("Główki: ");
                Head = byte.Parse(Console.ReadLine());
                Console.Write("Strzał: ");
                Shot = byte.Parse(Console.ReadLine());
                Console.Write("Odbiór piłki: ");
                Interceptions = byte.Parse(Console.ReadLine());
                Console.Write("Krycie: ");
                Marking = byte.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Wprowadziłeś niewłaścwe dane");         
            }
            catch (Exception)
            {
                Console.WriteLine("Wprowadziłeś niewłaścwe dane");
            }

            ZliczAtak();
            ZliczPomoc();
            ZliczObrone();
        }

        private void ZliczAtak()
        {
            Atak += Speed * 2;
            Atak += Acceleration * 2;
            Atak += Strength;
            Atak += Convert.ToInt16(Condition * 0.5);
            Atak += Jumping;
            Atak += ShortPassing;
            Atak += Convert.ToInt16(LongPassing * 0.5);
            Atak += BallControl * 2;
            Atak += Dribbling * 2;
            Atak += Bravery;
            Atak += Vision;
            Atak += Finishing * 2;
            Atak += Head;
            Atak += Shot * 2;
            Atak += Convert.ToInt16(Interceptions * 0.5);
            Atak += Convert.ToInt16(Marking * 0.5); 
        }

        private void ZliczPomoc()
        {
            Pomoc += Speed;
            Pomoc += Acceleration * 2;
            Pomoc += Convert.ToInt16(Strength * 0.5);
            Pomoc += Condition * 2;
            Pomoc += Convert.ToInt16(Jumping * 0.5);
            Pomoc += ShortPassing * 2;
            Pomoc += LongPassing * 2;
            Pomoc += BallControl * 2;
            Pomoc += Dribbling;
            Pomoc += Bravery;
            Pomoc += Vision * 2;
            Pomoc += Finishing;
            Pomoc += Convert.ToInt16(Head * 0.5);
            Pomoc += Shot;
            Pomoc += Interceptions;
            Pomoc += Convert.ToInt16(Marking * 0.5);
        }

        private void ZliczObrone()
        {
            Obrona += Convert.ToInt16(Speed * 0.5);
            Obrona += Acceleration;
            Obrona += Strength * 2;
            Obrona += Condition;
            Obrona += Jumping * 2;
            Obrona += ShortPassing;
            Obrona += LongPassing;
            Obrona += BallControl;
            Obrona += Convert.ToInt16(Dribbling * 0.5);
            Obrona += Bravery * 2;
            Obrona += Vision;
            Obrona += Convert.ToInt16(Finishing * 0.5);
            Obrona += Head * 2;
            Obrona += Convert.ToInt16(Shot * 0.5);
            Obrona += Interceptions * 2;
            Obrona += Marking * 2;
        }
    }
}
