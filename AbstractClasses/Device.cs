﻿using Lab3.Interfaces;
using System;
using System.Collections.Generic;

namespace Lab3.AbstractClasses
{
    abstract class Device : IDevice
    {
        public string Name { get; set; }

        public ICollection<IPeripheral> Components { get; set; }

        public abstract IDevice Clone();

        public void GetInfo()
        {
            decimal cost = 0;
            foreach (IPeripheral temp in Components)
            {
                cost += temp.Price;
                Console.WriteLine($"{temp}");
            }
            Console.WriteLine($"\nTotal price : {cost}\n");
        }
    }
}
