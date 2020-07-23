using Final_DiazRuiz_Calidad.DB;
using Final_DiazRuiz_Calidad.Interfaces;
using Final_DiazRuiz_Calidad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final_DiazRuiz_Calidad.Servicios
{
    public class ServicioCuenta: IServicioCueta
    {
        private AppConexionDB conexion;

        public ServicioCuenta()
        {
            this.conexion = new AppConexionDB();
        }

        public List<Cuenta> ObtenerCuentas()
        {
            return conexion.Cuentas.ToList();
        }

        public void GuardarCuenta(Cuenta cuenta)
        {
            conexion.Cuentas.Add(cuenta);
            conexion.SaveChanges();
        }
    }
}