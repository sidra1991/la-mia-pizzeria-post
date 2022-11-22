namespace la_mia_pizzeria_static.Models
{


    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageAddress { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public Pizza()
        {

        }
        public Pizza(string name, string imageAddress, string description, int price)
        {
            Name = name;
            ImageAddress = imageAddress;
            Description = description;
            Price = price;
        }

    }
}
