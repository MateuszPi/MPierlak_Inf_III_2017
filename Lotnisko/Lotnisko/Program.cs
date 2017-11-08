using System;
using System.Collections.Generic;

namespace Lotnisko
{
    class Samolot
    {
        public string numerSamolotu { get; set; }
        public string modelSamolotu { get; set; }
        public string liniaLotniczaSkrot { get; set; }
    }   
    class Odloty
    {
        public Samolot Samolot { get; set; }
        public string nazwaLotu { get; set; }
        public DateTime Odlot { get; set; }
    }    
    class Lotnisko
    {
        public string nazwaLotniska { get; set; }
        private Odloty[] _odloty = new[]
        {
            new Odloty
            {
                Samolot = new Samolot
                {
                    numerSamolotu = "001",
                    modelSamolotu = "Boring 747",
                    liniaLotniczaSkrot = "AMA"
                },
                nazwaLotu = "AMA-452",
                Odlot = DateTime.Parse("9/11/2017 4:30:00 PM", 
                    System.Globalization.CultureInfo.InvariantCulture)
            },
            new Odloty
            {
                Samolot = new Samolot
                {
                    numerSamolotu = "1789",
                    modelSamolotu = "Aircart A340",
                    liniaLotniczaSkrot = "BA"
                },
                nazwaLotu = "BA-121",
                Odlot = DateTime.Parse("9/11/2017 4:45:00 PM", 
                    System.Globalization.CultureInfo.InvariantCulture)
            },
            new Odloty
            {
                Samolot = new Samolot
                {
                    numerSamolotu = "949",
                    modelSamolotu = "Aircart A340",
                    liniaLotniczaSkrot = "RA"
                },
                nazwaLotu = "RA-1",
                Odlot = DateTime.Parse("9/11/2017 5:00:00 PM", 
                    System.Globalization.CultureInfo.InvariantCulture)
            },
        };
        public void ShowOdloty()
        {
            Console.WriteLine("Odloty:");
            foreach (var Odloty in _odloty)
            {
                Console.WriteLine("Nazwa Lotu:");
                Console.WriteLine(Odloty.nazwaLotu);
                Console.WriteLine("Linia lotnicza:");
                Console.WriteLine(Odloty.Samolot.liniaLotniczaSkrot);
                Console.WriteLine("Odlot:");
                Console.WriteLine(Odloty.Odlot);
                Console.WriteLine("-----------------------------");
            }
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            var Airfield = new Lotnisko();
            Airfield.ShowOdloty();
        }
    }
}