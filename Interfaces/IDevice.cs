using System.Collections.Generic;

namespace Lab3.Interfaces
{
    interface IDevice
    {
        string _name { get; set; }
        IEnumerable<IPeripheral> _components { get; set; }
        void GetInfo();
        IDevice Clone();
    }
}
