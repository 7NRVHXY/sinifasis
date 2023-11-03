using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal abstract class Vehicle
    {
        public abstract void Drive();
        public decimal Price { get; set; }
    }
}
