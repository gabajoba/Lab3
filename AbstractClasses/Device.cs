using Lab3.Interfaces;
using System;
using System.Collections.Generic;

namespace Lab3.AbstractClasses
{
    abstract class Device : IDevice
    {
        public string _name { get; set; }

        public IEnumerable<IPeripheral> _components { get; set; }

        public abstract IDevice Clone();

        public void GetInfo()
        {
            decimal cost = 0;
            foreach (IPeripheral temp in _components)
            {
                cost += temp._price;
                Console.WriteLine($"{temp}");
            }
            Console.WriteLine($"\nTotal price : {cost}\n");
        }
    }
}
