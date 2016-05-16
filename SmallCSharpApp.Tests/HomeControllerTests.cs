using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmallCSharpApp.Controllers;
using SmallCSharpApp.Models;
using System.Web.Mvc;

namespace SmallCSharpApp.Tests
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void CalculatesProduct()
        {
            var controller = new HomeController();

            var result = (ViewResult)controller.Calculate(15, 5);
            var model = (CalculateViewModel)result.ViewData.Model;

            Assert.AreEqual(75, model.Product);
        }

        [TestMethod]
        public void CalculatesSum()
        {
            var controller = new HomeController();

            var result = (ViewResult)controller.Calculate(35, 5);
            var model = (CalculateViewModel)result.ViewData.Model;

            Assert.AreEqual(40, model.Sum);
        }

        [TestMethod]
        public void CalculatesDifference()
        {
            var controller = new HomeController();

            var result = (ViewResult)controller.Calculate(25, 2);
            var model = (CalculateViewModel)result.ViewData.Model;

            Assert.AreEqual(23, model.Difference);
        }

        [TestMethod]
        public void CalculatesQuotient()
        {
            var controller = new HomeController();

            var result = (ViewResult)controller.Calculate(40, 10);
            var model = (CalculateViewModel)result.ViewData.Model;

            Assert.AreEqual(4, model.Quotient);
        }
    }
}
