using aqefte_week06.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aqefte_week06.Entities
{
    internal class CarFactory : IToyFactory
    {
        public Toy CreateNew()
        {
            return new Car();   
        }
    }
}
