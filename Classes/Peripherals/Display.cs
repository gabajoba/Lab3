using Lab3.Interfaces;

namespace Lab3.Classes.Peripherals
{
    class Display : IPeripheral
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Display(string name,decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
        public override string ToString()
        {
            return $"Display - {Name}, Price - {Price}";
        }

    }
}
