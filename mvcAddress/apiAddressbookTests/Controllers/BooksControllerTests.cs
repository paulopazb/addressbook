using Microsoft.VisualStudio.TestTools.UnitTesting;
using apiAddressbook.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiAddressbook.Controllers.Tests
{
    [TestClass()]
    public class BooksControllerTests
    {
        [TestMethod()]
        public void PostBookTest()
        {
            var controller = new BooksController();
            controller.Request= new HttpRequestMessage();
            controller.Configuracion = new HttpConfiguracion();
            IhttpActionResult actionresult= controller.PostBook(new Models)

        }
    }
}