using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_post.Controllers
{
    public class PizzaController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {

            /// FAKE DB
            Pizza pizzaMargherita = new("margherita", "pizza margherita", "/img/img-1.jpg", 13.3m);
            Pizza pizzaNapoli = new("napoli", "pizza napoli", "/img/img-2.jpeg", 10);
            Pizza pizzaBufala = new("bufala", "pizza bufala", "/img/img-3.jpeg", 15.5m);
            Pizza pizzaMarinara = new("marinara", "pizza marinara", "/img/img-4.jpg", 12.3m);
            Pizza pizzaQuattroFormaggi = new("quattro formaggi", "pizza quatro formaggi", "/img/img-5.jpeg", 13);
            Pizza pizzaBianca = new("bianca", "pizza bianca", "/img/img-6.jpeg", 15.5m);
            Pizza pizzaOliveeAcciughe = new("olive e acciughe", "pizza olive e acciughe", "/img/img-7.jpeg", 12.3m);
            Pizza pizzaRadicchio = new("raddicchio", "pizza raddicchio", "/img/img-8.jpeg", 13);
            Pizza pizzaGenovese = new("genovese", "pizza genovese", "/img/img-9.jpg", 15.5m);

            List<Pizza> myMenu =new List<Pizza>();
            myMenu.Add(pizzaMargherita);
            myMenu.Add(pizzaNapoli);
            myMenu.Add(pizzaBufala);
            myMenu.Add(pizzaMarinara);
            myMenu.Add(pizzaQuattroFormaggi);
            myMenu.Add(pizzaBianca);
            myMenu.Add(pizzaOliveeAcciughe);
            myMenu.Add(pizzaRadicchio);
            myMenu.Add(pizzaGenovese);

            //myMenu.Clear();

            return View("Index", myMenu);
        }

        public IActionResult Details(int id)
        {

            Pizza pizzaMargherita = new("margherita", "pizza margherita", "/img/img-1.jpg", 13.3m);
            Pizza pizzaNapoli = new("napoli", "pizza napoli", "/img/img-2.jpeg", 10);
            Pizza pizzaBufala = new("bufala", "pizza bufala", "/img/img-3.jpeg", 15.5m);
            Pizza pizzaMarinara = new("marinara", "pizza marinara", "/img/img-4.jpg", 12.3m);
            Pizza pizzaQuattroFormaggi = new("quattro formaggi", "pizza quatro formaggi", "/img/img-5.jpeg", 13);
            Pizza pizzaBianca = new("bianca", "pizza bianca", "/img/img-6.jpeg", 15.5m);
            Pizza pizzaOliveeAcciughe = new("olive e acciughe", "pizza olive e acciughe", "/img/img-7.jpeg", 12.3m);
            Pizza pizzaRadicchio = new("raddicchio", "pizza raddicchio", "/img/img-8.jpeg", 13);
            Pizza pizzaGenovese = new("genovese", "pizza genovese", "/img/img-9.jpg", 15.5m);

            List<Pizza> myMenu = new List<Pizza>();
            myMenu.Add(pizzaMargherita);
            myMenu.Add(pizzaNapoli);
            myMenu.Add(pizzaBufala);
            myMenu.Add(pizzaMarinara);
            myMenu.Add(pizzaQuattroFormaggi);
            myMenu.Add(pizzaBianca);
            myMenu.Add(pizzaOliveeAcciughe);
            myMenu.Add(pizzaRadicchio);
            myMenu.Add(pizzaGenovese);

            Pizza pizza = myMenu[id];

            return View("Show", myMenu[id]);
        }
    }
}
