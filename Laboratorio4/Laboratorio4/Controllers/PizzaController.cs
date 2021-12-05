using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio4.Handlers;
using Laboratorio4.Models;

namespace Laboratorio4.Controllers
{
    public class PizzaController : Controller
    {
        public ActionResult listadoDePizzas()
        {
            PizzaHandler accesoDatos = new PizzaHandler();
            ViewBag.pizza = accesoDatos.obtenerTodoslasPizzas();
            return View();
        }

        public ActionResult menu()
        {
            ViewBag.Message = "El menu de la pizzeria";
            return View();
        }

        public ActionResult Pagar()
        {
            ViewBag.Message = "Formulario de pago";
            return View();
        }

        [HttpPost]
        public ActionResult Pagar(Pagar pizza)
        {
            ViewBag.ExitoAlCrear = false;
            
            ViewBag.Message = "Gracias por su compra!!!!";
            ModelState.Clear();
                   
            return View();

        }

        public ActionResult crearPizza()
        {
            return View();
        }

        [HttpPost]
        public ActionResult crearPizza(PizzaModel pizza)
        {
            ViewBag.ExitoAlCrear = false;
            try
            {
                if (ModelState.IsValid)
                {
                    PizzaHandler accesoDatos = new PizzaHandler();
                    ViewBag.ExitoAlCrear = accesoDatos.crearPizza(pizza);
                if (ViewBag.ExitoAlCrear)
                    {
                        ViewBag.Message = "El planeta" + " " + pizza.tipoPizza + " fue creado con éxito:)" ;
                         ModelState.Clear();
                    }
                }
                return View();
            }
            catch
            {
                ViewBag.Message = "Algo salió mal y no fue posible crear la pizza: (";
            return View(); 
            }
        }

    }
}