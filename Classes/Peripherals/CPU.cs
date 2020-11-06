using Lab3.Interfaces;

namespace Lab3.Classes.Peripherals
{
    class CPU : IPeripheral
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public CPU(string name,decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
        public override string ToString()
        {
            return $"CPU - {Name}, Price - {Price}";
        }
    }
}
