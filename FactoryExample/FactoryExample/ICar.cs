using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    public interface ICar
    {
        string Color { get; set; }
        string Engine { get; set; }
        string Model { get; set; }
        string Brand { get; set; }
    }
}