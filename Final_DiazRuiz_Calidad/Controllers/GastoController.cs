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
    public class GastoController : Controller
    {
        // GET: Cuenta

        private readonly IServicioGasto service;
        public GastoController(IServicioGasto service)
        {
            this.service = service;
        }
        public ActionResult Index(int idCuenta)
        {
            ViewBag.IdCuenta = idCuenta;
            return View(service.ObtenerGastos().Where(a=>a.IdCuenta==idCuenta).ToList());
        }
        [HttpGet]
        public ActionResult Crear(int idCuenta)
        {
            ViewBag.IdCuenta = idCuenta;
            return View(new Gasto());
        }
        [HttpPost]
        public ActionResult Crear(Gasto gasto, int idCuenta)
        {
            var cuenta = service.obtenerCuenta(idCuenta);
            if ((cuenta.SaldoInicial - gasto.Monto) >= 0)
            {
                cuenta.SaldoInicial = cuenta.SaldoInicial - gasto.Monto;
                service.GuardarCuenta();
                ViewBag.IdCuenta = idCuenta;
                gasto.IdCuenta = idCuenta;
                service.GuardarGasto(gasto);
                
                return RedirectToAction("Index", new { idCuenta = idCuenta });
            }
            return View();
        }

    }
}