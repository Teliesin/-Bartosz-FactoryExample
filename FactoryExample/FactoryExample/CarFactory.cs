using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    public class CarFactory : ICarsFactory
    {
        public ICar Create(CarType carType)
        {
            switch(carType)
            {
                case CarType.Fabia:
                    {
                        SkodaFabia fabia = new SkodaFabia3();
                        return fabia;
                    }
                case CarType.Octavia:
                    {
                        SkodaOctavia skodaOctavia = new SkodaOctavia();
                        return skodaOctavia;
                    }
                default:
                    {
                        return null;
                    }
            }
        }

        public ICar Create(CarType carType, string color)
        {
            ICar car = Create(carType);

            car.Color = color;
            return car;
        }
    }
}
