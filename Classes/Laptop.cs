using Lab3.Classes.Peripherals;
using Lab3.Interfaces;
using System;
using System.Collections.Generic;

namespace Lab3.Classes
{
    class Laptop : IDevice
    {
        public string Name { get; set; }
        public IEnumerable<IPeripheral> Components { get; set; }
      
        public Laptop()
        {
            //default Laptop configuration
            Name = "Laptop";
            Components = new List<IPeripheral>()
            {
                new Keyboard("101",70),
                new Display("HD", 100),
                new TouchPad("2-button", 150),
                new CPU("2cores", 300),
                new RAM("4Gb", 180),
                new ROM("320Gb", 110)
            };
        }
        public Laptop(Laptop laptop)
        {
            this.Name = laptop.Name;
            this.Components = laptop.Components;
        }


        public IPrototype Clone()
        {
            return new Laptop(this);
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
