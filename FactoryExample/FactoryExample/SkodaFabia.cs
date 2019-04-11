using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    public class SkodaFabia : ICar
    {
        public string Color { get; set; }
        public string Engine { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }

        public SkodaFabia()
        {
            Color = "Blue";
            Engine = "Diesel 1.4";
            Model = "Fabia";
            Brand = "Skoda";
        }
    }
}
