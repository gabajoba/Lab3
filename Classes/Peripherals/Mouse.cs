using Lab3.Interfaces;

namespace Lab3.Classes.Peripherals
{
    class Mouse : IPeripheral
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
        public Mouse(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
        public override string ToString()
        {
            return $"Mouse - {Name}, Price  - {Price}";
        }

    }
}
