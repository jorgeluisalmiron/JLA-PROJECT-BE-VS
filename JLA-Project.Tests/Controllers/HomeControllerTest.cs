using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JLA_Project;
using JLA_Project.Controllers;

namespace JLA_Project.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
