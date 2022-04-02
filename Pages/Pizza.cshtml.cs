using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaRazor.Models;

namespace PizzaRazor.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakeList = new List<PizzasModel>()
        {
            new PizzasModel() { PizzaName = "Margerita", ImageTitle = "Margerita", Mushroom = true, Cheese = true, Pinapple = false, TomatoSauce = true, FinalPrice = 3},
            new PizzasModel() { PizzaName = "Bolognese", ImageTitle = "Bolognese", Mushroom = true, Cheese = true, Pinapple = false, TomatoSauce = true, FinalPrice = 3},
            new PizzasModel() { PizzaName = "Hawaiian", ImageTitle = "Hawaiian", Mushroom = false, Cheese = true, Pinapple = true, TomatoSauce = true, FinalPrice = 4},
        };
        public void OnGet()
        {
        }
    }
}
