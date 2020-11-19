using Lab3.AbstractClasses;
using Lab3.Classes.Peripherals;
using Lab3.Interfaces;
using System.Collections.Generic;

namespace Lab3.Classes
{
    class Laptop : Device
    {   
        public Laptop()
        {
            //default Laptop configuration
            _name = "Laptop";
            _components = new List<IPeripheral>()
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
            this._name = laptop._name;
            this._components = laptop._components;
        }

        public override IDevice Clone()
        {
            return new Laptop(this);
        }
        
    }
}
