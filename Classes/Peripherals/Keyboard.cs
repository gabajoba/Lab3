using Lab3.Interfaces;

namespace Lab3.Classes.Peripherals
{
    class Keyboard : IPeripheral
    {
        public string Name { get; set;}           

        public decimal Price { get;set;}

        public Keyboard(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }
        public override string ToString()
        {
            return $"Keyboard - {Name}, Price  - {Price}";
        }

    }
}
