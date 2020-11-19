﻿using Lab3.AbstractClasses;
using Lab3.Classes.Peripherals;
using Lab3.Interfaces;
using System.Collections.Generic;

namespace Lab3.Classes
{    
    class Desktop : Device
    {            
        public Desktop()
        {
            //default Desktop configuration
            _name = "Desktop";
            _components = new List<IPeripheral>()
            {                
                new Mouse("2-button", 90),               
                new CPU("4cores", 350),
                new RAM("16Gb", 250),
                new ROM("1Tb", 160)
            };
        }

        public Desktop(Desktop desktop)
        {
            this._name = desktop._name;
            this._components = desktop._components;
        }               

        public override IDevice Clone()
        {
            return new Desktop(this); 
        }
    }
}
