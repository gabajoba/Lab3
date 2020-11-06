using Lab3.AbstractClasses;
using Lab3.Classes.Peripherals;
using Lab3.Interfaces;
using System;
using System.Collections.Generic;

namespace Lab3.Classes
{
    class Notebook : Device
    {      
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

        public override IDevice Clone()
        {
            return new Notebook(this);
        }

        
    }
}
