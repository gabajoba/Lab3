using Lab3.Classes.Peripherals;
using Lab3.Interfaces;
using System;
using System.Collections.Generic;

namespace Lab3.Classes
{    
    class Desktop : IDevice
    {       
        public string Name{ get; set; }
        public IEnumerable<IPeripheral> Components { get; set; }
        
        public Desktop()
        {

            //default Desktop configuration
            Name = "Desktop";
            Components = new List<IPeripheral>()
            {                
                new Mouse("2-button", 90),               
                new CPU("4cores", 350),
                new RAM("16Gb", 250),
                new ROM("1Tb", 160)
            };
        }
        public Desktop(Desktop desktop)
        {
            this.Name = desktop.Name;
            this.Components = desktop.Components;
        }
             
        public IPrototype Clone()
        {            
            return new Desktop(this);
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
