using Lab3.Interfaces;
using System;
using System.Collections.Generic;

namespace Lab3.Classes
{
    [Serializable]
    class Desktop : IDevice
    {
        string IDevice.Name => "Desktop";
        public IEnumerable<string> Components => new List<string>()
        {
            "Keyboard: -",
            "Display: -",
            "Mouse: 2-button" ,
            "TouchPad: -" ,
            "CPU: 4cores" ,
            "RAM: 16Gb" ,
            "ROM: 1Tb"
        };

        public IPrototype Clone()
        {
            return new Desktop();
        }

        public void GetInfo()
        {
            
            foreach (string temp in Components)
            {
                Console.WriteLine($"{temp}");
            }
            Console.WriteLine("\n");

        }
    }
}
