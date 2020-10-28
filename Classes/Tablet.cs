using Lab3.Interfaces;
using System;
using System.Collections.Generic;

namespace Lab3.Classes
{
    [Serializable]
    class Tablet : IDevice
    {
        string IDevice.Name => "Tablet";
        public IEnumerable<string> Components => new List<string>()
        {
            "Keyboard: -",
            "Display: UltraHD",
            "Mouse: -" ,
            "TouchPad: -" ,
            "CPU: 8cores" ,
            "RAM: 2Gb" ,
            "ROM: 128Gb"
        };

        public IPrototype Clone()
        {
            return new Tablet();
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
