using Lab3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.AbstractClasses
{
    abstract class Device : IDevice
    {
        public string Name { get; set; }
        public IEnumerable<IPeripheral> Components { get; set; }

        public abstract IDevice Clone();

        public void GetInfo()
        {
            decimal _cost = 0;
            foreach (IPeripheral temp in Components)
            {
                _cost += temp.Price;
                Console.WriteLine($"{temp}");
            }
            Console.WriteLine($"\nTotal price : {_cost}\n");
        }
    }
}
