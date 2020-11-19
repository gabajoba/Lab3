using Lab3.Interfaces;

namespace Lab3.Classes.Peripherals
{
    class CPU : IPeripheral
    {
        public string _name { get; set; }

        public decimal _price { get; set; }

        public CPU(string name,decimal price)
        {
            this._name = name;
            this._price = price;
        }
        public override string ToString()
        {
            return $"CPU - {_name}, Price  - {_price}";
        }
    }
}
