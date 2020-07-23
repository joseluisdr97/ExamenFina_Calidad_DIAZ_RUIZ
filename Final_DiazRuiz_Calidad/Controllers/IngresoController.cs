using Final_DiazRuiz_Calidad.DB;
using Final_DiazRuiz_Calidad.Interfaces;
using Final_DiazRuiz_Calidad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Final_DiazRuiz_Calidad.Controllers
{
    public class IngresoController : Controller
    {  // GET: Gasto
            private AppConexionDB conexion = new AppConexionDB();
        // GET: Cuenta
        private readonly IServicioIngreso service;
        public IngresoController(IServicioIngreso service)
        {
            this.service = service;
        }
        public ActionResult Index(int idCuenta)
            {
                ViewBag.IdCuenta = idCuenta;
                return View(service.ObtenerIngresos().Where(a => a.IdCuenta == idCuenta).ToList());
            }
            [HttpGet]
            public ActionResult Crear(int idCuenta)
            {
                ViewBag.IdCuenta = idCuenta;
                return View(new Ingreso());
            }
            [HttpPost]
            public ActionResult Crear(Ingreso ingreso, int idCuenta)
            {
            var cuenta = service.obtenerCuenta(idCuenta);

                    cuenta.SaldoInicial = cuenta.SaldoInicial + ingreso.Monto;
                    service.GuardarCuenta();
                    ViewBag.IdCuenta = idCuenta;
                    ingreso.IdCuenta = idCuenta;
                    service.GuardarIngreso(ingreso);
                    return RedirectToAction("Index", new { idCuenta = idCuenta });
            }
    }

}