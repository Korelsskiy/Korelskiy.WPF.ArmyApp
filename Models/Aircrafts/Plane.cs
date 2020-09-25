using System;
using System.Collections.Generic;
using System.IO;

namespace Korelskiy.WPF.ArmyApp.Models.Aircrafts
{
    internal class Plane
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public string FirstFlight { get; set; }

        public int InService { get; set; }

        public string ImagePath { get; set; }

        public static List<Plane> planes = new List<Plane>()
            {
                new Plane(){Name = "Су-24", Type = "Фронтовой бомбардирвщик", FirstFlight = Convert.ToDateTime("17.01.1970").ToShortDateString(), ImagePath = Path.GetFullPath(@"Images\Su-24.jpg"), InService = 274 },
                new Plane(){Name = "МиГ-29", Type = "Истребитель", FirstFlight = Convert.ToDateTime("06.10.1977").ToShortDateString(), ImagePath = Path.GetFullPath(@"Images\MiG-29.jpg"), InService = 249 },
                new Plane(){Name = "Су-27", Type = "Истребитель", FirstFlight = Convert.ToDateTime("20.05.1977").ToShortDateString(), ImagePath = Path.GetFullPath(@"Images\Su-27.jpg"), InService = 229 }
            };

        public static List<Plane> planes1 = new List<Plane>()
            {
                new Plane(){Name = "J-10", Type = "Истребитель", FirstFlight = Convert.ToDateTime("17.01.1970").ToShortDateString(), ImagePath = Path.GetFullPath(@"Images\J-10.jpg"), InService = 435 },
                new Plane(){Name = "J-7", Type = "Истребитель", FirstFlight = Convert.ToDateTime("06.10.1977").ToShortDateString(), ImagePath = Path.GetFullPath(@"Images\J-7.jpg"), InService = 388 },
                new Plane(){Name = "J-11", Type = "Истребитель", FirstFlight = Convert.ToDateTime("20.05.1977").ToShortDateString(), ImagePath = Path.GetFullPath(@"Images\J-11.jpg"), InService = 346 }
            };

    }

    internal class ProducingCountry
    {
        public string Name { get; set; }

        public List<Plane> Planes { get; set; }

        public static List<ProducingCountry> PrCountries = new List<ProducingCountry>()
        {
             new ProducingCountry(){Name = "Россия", Planes = Plane.planes},
             new ProducingCountry(){Name = "Китай", Planes = Plane.planes1}
        };
    }
}
