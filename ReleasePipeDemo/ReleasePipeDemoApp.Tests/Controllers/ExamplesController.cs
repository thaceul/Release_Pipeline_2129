﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReleasePipeDemoApp;
using ReleasePipeDemoApp.Controllers;

namespace ReleasePipeDemoApp.Tests.Controllers
{
    [TestClass]
    public class ExamplesControllerTests
    {
        [TestMethod]
        public void Get()
        {
            // Arrange
            ExamplesController controller = new ExamplesController();

            // Act
            IEnumerable<string> result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("wrong", result.ElementAt(0));
            Assert.AreEqual("wrong", result.ElementAt(1));
        }

        [TestMethod]
        public void GetById()
        {
            // Arrange
            ExamplesController controller = new ExamplesController();

            // Act
            string result = controller.Get(5);

            // Assert
            Assert.AreEqual("wrong", result);
        }
    }
}