﻿using Lab3.AbstractClasses;
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
            Name = tablet.Name;
            Components = new List<IPeripheral>();
            foreach (IPeripheral peripheral in tablet.Components)
            {
                Components.Add(peripheral);
            }
        }

        public override IDevice Clone()
        {
            return new Tablet(this);
        }
  
    }
}
