using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaRazor.Models;

namespace PizzaRazor.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }

        public float PizzaPrice { get; set; }

        public IActionResult OnPost()
        {

            PizzaPrice = Pizza.BasePrice;
            if (Pizza.TomatoSauce || Pizza.Mushroom || Pizza.Pinapple)
            {
                PizzaPrice += 1;
            }
            if (Pizza.Cheese)
            {
                PizzaPrice += 2;
            }

            return RedirectToPage("/Checkout/Checkout", new {Pizza.PizzaName, PizzaPrice});
        }
        public void OnGet()
        {
        }
    }
}
