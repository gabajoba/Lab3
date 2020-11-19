using Lab3.Interfaces;

namespace Lab3.Classes.Peripherals
{
    class Keyboard : IPeripheral
    {
        public string _name { get; set;}           

        public decimal _price { get;set;}

        public Keyboard(string name, decimal price)
        {
            this._name = name;
            this._price = price;
        }
        public override string ToString()
        {
            return $"Keyboard - {_name}, Price  - {_price}";
        }

    }
}
