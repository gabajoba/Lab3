using System.Collections.Generic;

namespace Lab3.Interfaces
{
    interface IDevice
    {
        string Name { get; set; }
        ICollection<IPeripheral> Components { get; set; }
        void GetInfo();
        IDevice Clone();
    }
}
