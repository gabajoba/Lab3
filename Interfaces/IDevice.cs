using System.Collections.Generic;

namespace Lab3.Interfaces
{
    interface IDevice : IPrototype
    {
        string Name { get; }
        IEnumerable<string> Components { get;}
        void GetInfo();
    }
}
