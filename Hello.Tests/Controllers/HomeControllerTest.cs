using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hello;
using Hello.Controllers;
using System.Web.Script.Serialization;
using Hello.Models;

namespace Hello.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            JsonResult result = controller.Get() as JsonResult;

            // Assert
            Assert.IsNotNull(result.ToString());
        }

    }
}
