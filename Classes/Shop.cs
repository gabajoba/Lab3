using Lab3.Classes.Peripherals;
using Lab3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab3.Classes
{
    class Shop
    {
        public IEnumerable<IDevice> _devices => new List<IDevice>
        {
            new Desktop()
            {
                Name = "TestDesktop",
                Components = new List<IPeripheral>
                { 
                    new Mouse("TestMouse",100),
                    new Keyboard("TestKeyboard",100),
                    new CPU("5 TestCores", 200),
                    new RAM("10Gb TestRam", 200),
                    new ROM("3Tb TestROM", 200)
                } 
            },
            new Desktop(),
            new Laptop(),
            new Notebook(),
            new Tablet(),
        };
        public void StartShoping(string name)
        {
            string temp = null;
            Console.WriteLine($"Hi, {name}, do you want to buy something?\n");
            do
            {
                var i = 0;
                foreach (IDevice device in _devices)
                {
                    i++;
                    Console.WriteLine($"{i} - {device.Name}");
                }
                Console.WriteLine("\n0 - exit\n");

                temp = Console.ReadLine();
                if (temp == "0") { break; }
                else
                {
                    try
                    {
                        Console.WriteLine($"\nYou choose {_devices.ToList()[Int32.Parse(temp) - 1].Name}\n");
                        ConfirmPurchase((IDevice)_devices.ToList()[Int32.Parse(temp) - 1].Clone());
                    }
                    catch
                    {
                        Console.WriteLine("Enter the required number\n");
                    }
                }
            } while (temp != "0");


        }
        public object ConfirmPurchase(IDevice device)
        {
            try
            {
                device.GetInfo();
                Console.WriteLine("\nDo you want to buy it?\n1 - Yes\nAnything else - No\n");
                var str = Console.ReadLine();
                if (str == "1")
                {
                    Console.WriteLine($"\nCongratulations, you bought {device.Name}\n");
                } else
                {
                    Console.WriteLine("\nWell, let's see another product\n");
                }

            }
            catch
            {
                Console.WriteLine("\nSomething went wrong\n");
            }
            
            return device;
        }
    }
}
