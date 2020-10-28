using Lab3.Interfaces;

namespace Lab3.Classes.Peripherals
{
    class ROM : IPeripheral
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public ROM(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
        public override string ToString()
        {
            return $"ROM - {Name}, Price - {Price}";
        }
    }
}
