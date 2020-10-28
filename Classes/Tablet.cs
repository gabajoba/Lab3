using Lab3.Classes.Peripherals;
using Lab3.Interfaces;
using System;
using System.Collections.Generic;

namespace Lab3.Classes
{    
    class Tablet : IDevice
    {
        public string Name { get; set; }
        public IEnumerable<IPeripheral> Components { get; set; }

        public Tablet()
        {
            //default Tablet configuration
            Name = "Tablet";
            Components = new List<IPeripheral>()
            {       
                new Display("UltraHD", 200),              
                new CPU("8cores", 600),
                new RAM("2Gb", 120),
                new ROM("128Gb", 80)
            };
        }

        public Tablet(Tablet tablet)
        {
            this.Name = tablet.Name;
            this.Components = tablet.Components;
        }

        public IPrototype Clone()
        {
            return new Tablet(this);
        }
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
