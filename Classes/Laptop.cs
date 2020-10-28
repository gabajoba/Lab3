using Lab3.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab3.Classes
{
    [Serializable]
    class Laptop : IDevice
    {
        string IDevice.Name => "Laptop";
        public IEnumerable<string> Components => new List<string>()
        {
            "Keyboard: 101",
            "Display: HD",
            "Mouse: -" ,
            "TouchPad: 2-button" ,
            "CPU: 2cores" ,
            "RAM: 4Gb" ,
            "ROM: 320Gb" 
        };

        public IPrototype Clone()
        {
            return new Laptop();
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
