using Lab3.Interfaces;

namespace Lab3.Classes.Peripherals
{
    class RAM : IPeripheral
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public RAM(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
        public override string ToString()
        {
            return $"RAM - {Name}, Price - {Price}";
        }
    }
}
