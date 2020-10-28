using Lab3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Classes
{
    class Shop
    {
        public IEnumerable<IDevice> _devices => new List<IDevice>
        {
            new Desktop(),
            new Laptop(),
            new Notebook(),
            new Tablet(),
        };
        public void StartShoping(string name)
        {
            string temp = null;
            Console.WriteLine($"Hi, {name}, do you want to buy something?");
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


                try
                {
                    Console.WriteLine($"\nYou choose {_devices.ToList()[Int32.Parse(temp)-1].Name}\n");
                    ConfirmPurchase(_devices.ToList()[Int32.Parse(temp)-1].Clone());
                } catch
                {
                    Console.WriteLine("Enter the required number\n");
                }
            } while (temp != "0");


        }
        public object ConfirmPurchase(object device)
        {
            try
            {
                ((IDevice)device).GetInfo();
                Console.WriteLine("\nDo you want to buy it?\n1 - Yes\nAnything else - No");
                var str = Console.ReadLine();
                if (str == "1")
                {
                    Console.WriteLine($"Congratulations, you bought {((IDevice)device).Name}");
                } else
                {
                    Console.WriteLine("Well, let's see another product");
                }

            }
            catch
            {
                Console.WriteLine("Something went wrong");
            }
            
            return device;
        }
    }
}
