namespace PizzaRazor.Models
{
    public class PizzasModel
    {
        public string PizzaName { get; set; }

        public int BasePrice { get; set; } = 2;

        public string ImageTitle { get; set; }

        public bool TomatoSauce { get; set; }

        public bool Mushroom { get; set; }
        
        public bool Cheese { get; set; }

        public bool Pinapple { get; set; }

        public float FinalPrice { get; set; }
    }
}
