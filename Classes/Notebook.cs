using Lab3.Interfaces;
using System;
using System.Collections.Generic;

namespace Lab3.Classes
{
    [Serializable]
    class Notebook : IDevice
    {
        string IDevice.Name => "Notebook";
        public IEnumerable<string> Components => new List<string>()
        {
            "Keyboard: 108",
            "Display: FullHD",
            "Mouse: -" ,
            "TouchPad: 1-button" ,
            "CPU: 2cores" ,
            "RAM: 8Gb" ,
            "ROM: 512Gb"
        };

        public IPrototype Clone()
        {
            return new Notebook();
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
