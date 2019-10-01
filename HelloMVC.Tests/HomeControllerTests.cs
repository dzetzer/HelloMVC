using HelloMVC.Controllers;
using HelloMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace HelloMVC.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index_Returns_ViewResult()
        {
            var controller = new HomeController();

            var result = controller.Index();

            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Greet_Index_Returns_ViewResult()
        {
            var controller = new GreetController();

            var result = controller.Index("ThisIsAString");

            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Index_Passes_GreetingModel_To_View()
        {
            var controller = new GreetController();

            var result = controller.Index("ThisIsAString");

            Assert.IsType<GreetingModel>(result.Model);
        }
        [Fact]
        public void Index_Sets_Name_On_Model()
        {
            var expectedName = "ExampleString";
            var controller = new GreetingController();

            var result = controller.Index(expectedName);

            var model = (GreetingModel)result.Model;
            Assert.Equal(expectedName, model.Name);
        }
    }
}
