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
    public class CuentaController : Controller
    {
        private readonly IServicioCueta service;
        public CuentaController(IServicioCueta service)
        {
            this.service = service;
        }
        private AppConexionDB conexion = new AppConexionDB();
        // GET: Cuenta
        public ActionResult Index()
        {
            return View(service.ObtenerCuentas().ToList());
        }
        [HttpGet]
        public ActionResult Crear()
        {
            return View(new Cuenta());
        }
        [HttpPost]
        public ActionResult Crear(Cuenta cuenta)
        {
            if(cuenta.Categoria!=null && cuenta.Nombre!=null && cuenta.SaldoInicial != 0)
            {
                service.GuardarCuenta(cuenta);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}