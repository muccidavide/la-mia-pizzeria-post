using System.Numerics;

namespace la_mia_pizzeria_post
{
    public class Pizza
    {
        public Pizza(string name, string description, string image, decimal price)
        {
            Name = name;
            Description = description;
            Image = image;
            Price = price;
        }

        public BigInteger Id { get; private set; }
        public string  Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }

    }
}
