using Lab3.AbstractClasses;
using Lab3.Classes.Peripherals;
using Lab3.Interfaces;
using System.Collections.Generic;

namespace Lab3.Classes
{    
    class Tablet : Device
    {
        public Tablet()
        {
            //default Tablet configuration
            _name = "Tablet";
            _components = new List<IPeripheral>()
            {       
                new Display("UltraHD", 200),              
                new CPU("8cores", 600),
                new RAM("2Gb", 120),
                new ROM("128Gb", 80)
            };
        }

        public Tablet(Tablet tablet)
        {
            this._name = tablet._name;
            this._components = tablet._components;
        }

        public override IDevice Clone()
        {
            return new Tablet(this);
        }
  
    }
}
