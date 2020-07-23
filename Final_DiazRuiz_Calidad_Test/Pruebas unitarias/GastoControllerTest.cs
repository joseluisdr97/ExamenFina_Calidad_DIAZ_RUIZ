using Final_DiazRuiz_Calidad.Controllers;
using Final_DiazRuiz_Calidad.Interfaces;
using Final_DiazRuiz_Calidad.Models;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Final_DiazRuiz_Calidad_Test.Pruebas_unitarias
{
    [TestFixture]
    class GastoControllerTest
    {
        [Test]
        public void ReturnCounListGastosConEsaCuenta_IndexTest()
        {

            var faker = new Mock<IServicioGasto>();
            faker.Setup(a => a.ObtenerGastos()).Returns(new List<Gasto>
                {
                 new Gasto{IdGasto=1, FechaHora=DateTime.Now, Descripcion="Gasto 1", IdCuenta=1, Monto=100},
                 new Gasto{IdGasto=2, FechaHora=DateTime.Now, Descripcion="Gasto 2", IdCuenta=3, Monto=200},
                 new Gasto{IdGasto=3, FechaHora=DateTime.Now, Descripcion="Gasto 3", IdCuenta=1, Monto=100},
                });

            var controller = new GastoController(faker.Object);
            var view = controller.Index(1) as ViewResult;
            var model = view.Model as List<Gasto>;

            Assert.AreEqual(2, model.Count);
        }
        [Test]
        public void ReturnGastos_IndexTest()
        {

            var faker = new Mock<IServicioGasto>();
            faker.Setup(a => a.ObtenerGastos()).Returns(new List<Gasto>
                {
                 new Gasto{IdGasto=1, FechaHora=DateTime.Now, Descripcion="Gasto 1", IdCuenta=1, Monto=100},
                 new Gasto{IdGasto=2, FechaHora=DateTime.Now, Descripcion="Gasto 2", IdCuenta=3, Monto=200},
                 new Gasto{IdGasto=3, FechaHora=DateTime.Now, Descripcion="Gasto 3", IdCuenta=1, Monto=100},
                });

            var controller = new GastoController(faker.Object);
            var view = controller.Index(1) as ViewResult;

            Assert.IsInstanceOf<ViewResult>(view);
        }

    }
}
