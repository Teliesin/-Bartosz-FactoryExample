using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    public interface ICarsFactory
    {
        ICar Create(CarType carType);
        ICar Create(CarType carType, string color);
    }

    public enum CarType
    {
        Fabia = 1,
        Octavia = 2
    }
}