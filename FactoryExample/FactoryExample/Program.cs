using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FactoryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarsFactory factory = new CarFactory();

            ICar skodaFabia = factory.Create(CarType.Fabia);
            ICar skodaOctavia = factory.Create(CarType.Octavia);
            ICar skodaFabia2 = factory.Create(CarType.Fabia);
            ICar skodaFabia3 = factory.Create(CarType.Fabia);

            ICar skodaFabiaGreen = factory.Create(CarType.Fabia, "Green");

            Console.WriteLine(skodaFabiaGreen.Color);
            Console.WriteLine(skodaFabia.Color);
            Console.WriteLine(skodaOctavia.Color);

            Console.ReadKey();
        }
    }
}