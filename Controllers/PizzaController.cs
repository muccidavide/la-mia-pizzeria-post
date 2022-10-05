using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Design;
using la_mia_pizzeria_static.Data;

namespace la_mia_pizzeria_post.Controllers
{
    public class PizzaController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {

            /// FAKE DB
            Pizza pizzaMargherita = new("margherita", "pizza margherita", "/img/img-1.jpg", 13.30f);
            Pizza pizzaNapoli = new("napoli", "pizza napoli", "/img/img-2.jpeg", 10.00f);
            Pizza pizzaBufala = new("bufala", "pizza bufala", "/img/img-3.jpeg", 15.50f);
            Pizza pizzaMarinara = new("marinara", "pizza marinara", "/img/img-4.jpg", 12.30f);
            Pizza pizzaQuattroFormaggi = new("quattro formaggi", "pizza quatro formaggi", "/img/img-5.jpeg", 13.00f);
            Pizza pizzaBianca = new("bianca", "pizza bianca", "/img/img-6.jpeg", 15.50f);
            Pizza pizzaOliveeAcciughe = new("olive e acciughe", "pizza olive e acciughe", "/img/img-7.jpeg", 12.30f);
            Pizza pizzaRadicchio = new("raddicchio", "pizza raddicchio", "/img/img-8.jpeg", 13.00f);
            Pizza pizzaGenovese = new("genovese", "pizza genovese", "/img/img-9.jpg", 15.50f);

            List<Pizza> myMenu =new List<Pizza>();

            using (PizzaContext db = new PizzaContext())
            {
            //    db.Add(pizzaMargherita);
            //    db.Add(pizzaNapoli);
            //    db.Add(pizzaBufala);
            //    db.Add(pizzaMarinara);
            //    db.Add(pizzaQuattroFormaggi);
            //    db.Add(pizzaBianca);
            //    db.Add(pizzaOliveeAcciughe);
            //    db.Add(pizzaRadicchio);
            //    db.Add(pizzaGenovese);

            //    db.SaveChanges();

               myMenu = db.Pizzas.OrderBy(pizza => pizza.Name).ToList<Pizza>();

            }

            //myMenu.Clear();

            return View("Index", myMenu);
        }

        public IActionResult Details(int id)
        {

            Pizza pizzaMargherita = new("margherita", "pizza margherita", "/img/img-1.jpg", 13.30f);
            Pizza pizzaNapoli = new("napoli", "pizza napoli", "/img/img-2.jpeg", 10.00f);
            Pizza pizzaBufala = new("bufala", "pizza bufala", "/img/img-3.jpeg", 15.50f);
            Pizza pizzaMarinara = new("marinara", "pizza marinara", "/img/img-4.jpg", 12.30f);
            Pizza pizzaQuattroFormaggi = new("quattro formaggi", "pizza quatro formaggi", "/img/img-5.jpeg", 13.00f);
            Pizza pizzaBianca = new("bianca", "pizza bianca", "/img/img-6.jpeg", 15.50f);
            Pizza pizzaOliveeAcciughe = new("olive e acciughe", "pizza olive e acciughe", "/img/img-7.jpeg", 12.30f);
            Pizza pizzaRadicchio = new("raddicchio", "pizza raddicchio", "/img/img-8.jpeg", 13.00f);
            Pizza pizzaGenovese = new("genovese", "pizza genovese", "/img/img-9.jpg", 15.50f);

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
