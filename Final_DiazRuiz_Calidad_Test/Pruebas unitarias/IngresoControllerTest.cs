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
    class IngresoControllerTest
    {

        [Test]
        public void ReturnCounListIngresosConEsaCuenta_IndexTest()
        {

            var faker = new Mock<IServicioIngreso>();
            faker.Setup(a => a.ObtenerIngresos()).Returns(new List<Ingreso>
                {
                 new Ingreso{IdIngreso=1, FechaHora=DateTime.Now, Descripcion="Ingreso 1", IdCuenta=1, Monto=100},
                 new Ingreso{IdIngreso=2, FechaHora=DateTime.Now, Descripcion="Ingreso 2", IdCuenta=3, Monto=200},
                 new Ingreso{IdIngreso=3, FechaHora=DateTime.Now, Descripcion="Ingreso 1", IdCuenta=1, Monto=100},
                });

            var controller = new IngresoController(faker.Object);
            var view = controller.Index(1) as ViewResult;
            var model = view.Model as List<Ingreso>;

            Assert.AreEqual(2, model.Count);
        }
        [Test]
        public void Return_IndexTest()
        {

            var faker = new Mock<IServicioIngreso>();
            faker.Setup(a => a.ObtenerIngresos()).Returns(new List<Ingreso>
                {
                 new Ingreso{IdIngreso=1, FechaHora=DateTime.Now, Descripcion="Ingreso 1", IdCuenta=1, Monto=100},
                 new Ingreso{IdIngreso=2, FechaHora=DateTime.Now, Descripcion="Ingreso 2", IdCuenta=3, Monto=200},
                 new Ingreso{IdIngreso=3, FechaHora=DateTime.Now, Descripcion="Ingreso 1", IdCuenta=1, Monto=100},
                });

            var controller = new IngresoController(faker.Object);
            var view = controller.Index(1) as ViewResult;

            Assert.IsInstanceOf<ViewResult>(view);
        }
    }
}
