using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    public class SkodaOctavia : ICar
    {
        public SkodaOctavia()
        {
            Color = "Red";
            Engine = "Diesel 1.1";
            Model = "Octavia";
            Brand = "Skoda";
        }

        public string Color { get; set; }
        public string Engine { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
    }
}
