using System;
using System.Collections.Generic;

namespace Korelskiy.WPF.ArmyApp.Models.Aircrafts
{
    internal class Plane
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public DateTime FirstFlight { get; set; }
    }

    internal class ProducingCountry
    {
        public string Name { get; set; }

        public ICollection<Plane> Planes { get; set; }
    }
}
