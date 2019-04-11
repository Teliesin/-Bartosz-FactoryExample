using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample
{
    public class SkodaFabia3 : SkodaFabia
    {
        public string ABS { get; set; }

        public SkodaFabia3()
        {
            Color = "Orange";
        }
    }
}
