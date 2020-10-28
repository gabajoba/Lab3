using Lab3.Classes.Peripherals;
using Lab3.Interfaces;
using System;
using System.Collections.Generic;

namespace Lab3.Classes
{
    class Notebook : IDevice
    {
        public string Name { get; set; }
        public IEnumerable<IPeripheral> Components { get; set; }
        
        public Notebook()
        {
            //default Notebook configuration
            Name = "Notebook";
            Components = new List<IPeripheral>()
            {
                new Keyboard("108",50),
                new Display("FullHD", 200),
                new TouchPad("1-button", 200),
                new CPU("2cores", 300),
                new RAM("8Gb", 150),
                new ROM("512Gb", 130)
            };
        }
        public Notebook(Notebook notebook)
        {
            this.Name = notebook.Name;
            this.Components = notebook.Components;
        }

        public IPrototype Clone()
        {
            return new Notebook(this);
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
