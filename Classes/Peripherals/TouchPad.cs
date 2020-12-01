using Lab3.Interfaces;

namespace Lab3.Classes.Peripherals
{
    class TouchPad : IPeripheral
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public TouchPad(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
        public override string ToString()
        {
            return $"TouchPad - {Name}, Price - {Price}";
        }
    }
}
