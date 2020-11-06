using Lab3.Classes;
using Lab3.Classes.Peripherals;
using Lab3.Interfaces;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        var Desk = new Desktop()
        {
            Name = "TestDesktop 123 ",
            Components = new List<IPeripheral>
                {
                    new Mouse("TestMouse 123 ",1600),
                    new Keyboard("TestKeyboard 123 ",500),
                    new CPU("5 TestCores 123 ", 3200),
                    new RAM("10Gb TestRam 123 ",5200),
                    new ROM("3Tb TestROM 123 ", 8200)
                }
        };
        var Desk2 = Desk.Clone();
        var Desk3 = Desk2.Clone();
        Desk3.GetInfo();
        //new Shop().StartShoping("Dmitry");
    }
}



