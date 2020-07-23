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
    class CuentaControllerTest
    {
        [Test]
        public void ReturnCounList_IndexTest()
        {
            
                var faker = new Mock<IServicioCueta>();
                faker.Setup(a => a.ObtenerCuentas()).Returns(new List<Cuenta>
                {
                 new Cuenta{IdCuenta=1, Categoria="Debito", Nombre="Jose luis", SaldoInicial=1000},
                 new Cuenta{IdCuenta=2, Categoria="Credito", Nombre="Carlos", SaldoInicial=2000},
                 new Cuenta{IdCuenta=3, Categoria="Debito", Nombre="Ricardo", SaldoInicial=700}
                });

                var controller = new CuentaController(faker.Object);
                var view = controller.Index() as ViewResult;
                var model = view.Model as List<Cuenta>;

                Assert.AreEqual(3,model.Count);
        }
        [Test]
        public void Return_IndexTest()
        {

            var faker = new Mock<IServicioCueta>();
            faker.Setup(a => a.ObtenerCuentas()).Returns(new List<Cuenta>
                {
                new Cuenta{IdCuenta=1, Categoria="Debito", Nombre="Jose luis", SaldoInicial=1000},
                 new Cuenta{IdCuenta=2, Categoria="Credito", Nombre="Carlos", SaldoInicial=2000},
                 new Cuenta{IdCuenta=3, Categoria="Debito", Nombre="Ricardo", SaldoInicial=700}
                });

            var controller = new CuentaController(faker.Object);
            var view = controller.Index();

            Assert.IsInstanceOf<ViewResult>(view);
        }
        [Test]
        public void Return_CrearGetTest()
        {
            var faker = new Mock<IServicioCueta>();
            var controller = new CuentaController(faker.Object);
            var view = controller.Crear() as ViewResult;

            Assert.IsInstanceOf<Cuenta>(view.Model);
        }
        [Test]
        public void ReturnNoCreo_CrearPostTest()
        {
            var cuenta = new Cuenta { IdCuenta = 1, Categoria = null, Nombre = "Jose luis", SaldoInicial = 1000 };
            var faker = new Mock<IServicioCueta>();
            var controller = new CuentaController(faker.Object);
            var view = controller.Crear(cuenta);

            Assert.IsInstanceOf<ViewResult>(view);
        }
        [Test]
        public void ReturnCreo_CrearPostTest()
        {
            var cuenta = new Cuenta { IdCuenta = 1, Categoria = "Debito", Nombre = "Jose luis", SaldoInicial = 1000 };
            var faker = new Mock<IServicioCueta>();
            var controller = new CuentaController(faker.Object);
            var view = controller.Crear(cuenta);

            Assert.IsInstanceOf<RedirectToRouteResult>(view);
        }
    }
}
