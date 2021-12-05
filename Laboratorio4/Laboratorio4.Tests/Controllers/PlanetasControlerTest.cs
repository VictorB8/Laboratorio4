using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laboratorio4.Controllers;
using Laboratorio4.Models;
using System.Web.Mvc;
namespace UnitTestLab7.Controllers
{
    [TestClass]
    public class PlanetasControllerTest
    {
        [TestMethod]
        public void menuViewResultNotNull()
        {
            //Arrange
            PizzaController pizzaController = new PizzaController();
            //Act
            ActionResult vista = pizzaController.menu();
            //Assert
            Assert.IsNotNull(vista);
        }

        [TestMethod]
        public void sobreNosotrosViewResult()
        {
            HomeController HomeController = new HomeController();
            //Act
            ViewResult vista = HomeController.SobreNosotros() as ViewResult;
            //Assert
            Assert.AreEqual("SobreNosotros", vista.ViewName);
        }

        [TestMethod]
        public void pagarViewResultNotNull()
        {
            //Arrange
            PizzaController pizzaController = new PizzaController();
            //Act
            ActionResult vista = pizzaController.Pagar();
            //Assert
            Assert.IsNotNull(vista);

        }

        [TestMethod]
        public void TestCrearPlanetaViewResultNotNull()
        {
            //Arrange
            PlanetasController planetasController = new PlanetasController();
            //Act
            ActionResult vista = planetasController.crearPlaneta();
            //Assert
            Assert.IsNotNull(vista);
        }


        [TestMethod]
        public void TestCrearPlanetaViewResult()
        {
            //Arrange
            PlanetasController planetasController = new PlanetasController();
            //Act
            ViewResult vista = planetasController.crearPlaneta() as ViewResult;
            //Assert
            Assert.AreEqual("crearPlaneta", vista.ViewName);
        }

        [TestMethod]
        public void EditarPlanetaIdValidoVistaNoNula()
        {
            //Arrange
            int id = 1;
            PlanetasController planetasController = new PlanetasController();
            //Act
            ViewResult vista = planetasController.editarPlaneta(id) as ViewResult;
            //Assert
            Assert.IsNotNull(vista);
        }

        [TestMethod]
        public void EditarPlanetaValidoModeloRetornadoNoEsNulo()
        {
            //Arrange
            int id = 1;
            PlanetasController planetasController = new PlanetasController();
            //Act
            ViewResult vista = planetasController.editarPlaneta(id) as ViewResult;
            //Assert
            Assert.IsNotNull(vista.Model);
        }

        [TestMethod]
        public void EditarPlanetaConIdNoExistenteRedirectToLP()
        {
            //Arrange
            int idInvalido = -1;
            PlanetasController planetasController = new PlanetasController();
            //Act
            RedirectToRouteResult vista =
            planetasController.editarPlaneta(idInvalido) as RedirectToRouteResult;
            //Assert
            Assert.AreEqual("listadoDePlanetas", vista.RouteValues["action"]);
        }

        [TestMethod]
        public void EditarPlanetaElModeloEnviadoEsCorrecto()
        {
            //Arrange
            int id = 12;
            PlanetasController planetasController = new PlanetasController();
            //Act
            ViewResult vista = planetasController.editarPlaneta(id) as ViewResult;
            PlanetaModel planeta = vista.Model as PlanetaModel;
            //Assert
            Assert.IsNotNull(planeta);
            Assert.AreEqual(0, planeta.numeroAnillos);
            Assert.AreEqual("B 612", planeta.nombre);
        }

        [TestMethod]
        public void ListadoDePlanetasCantidadDePlanetasEsCorrecta()
        {
            //Arrange
            int numeroPlanetas = 12;
            PlanetasController planetasController = new PlanetasController();
            //Act
            ViewResult vista = planetasController.listadoDePlanetas() as
           ViewResult;
            //Assert
            Assert.AreEqual(numeroPlanetas, vista.ViewBag.planetas.Count);
        }

        // Ejercicios


        [TestMethod]
        public void TestEditarPlanetaViewResultNotNull()
        {
            int id = 1;
            //Arrange
            PlanetasController planetasController = new PlanetasController();
            //Act
            ActionResult vista = planetasController.editarPlaneta(id);
            //Assert
            Assert.IsNotNull(vista);
        }

        [TestMethod]
        public void EditarPlanetaElModeloEnviadoEsCorrecto2()
        {
            //Arrange
            int id = 12;
            PlanetasController planetasController = new PlanetasController();
            //Act
            ViewResult vista = planetasController.editarPlaneta(id) as ViewResult;
            PlanetaModel planeta = vista.Model as PlanetaModel;
            //Assert
            Assert.IsNotNull(planeta);
            Assert.AreEqual(0, planeta.numeroAnillos);
            Assert.AreEqual("B 612", planeta.nombre);
            Assert.AreEqual("Rocoso", planeta.tipo);
        }

    }

}
