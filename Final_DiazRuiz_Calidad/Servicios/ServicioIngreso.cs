using Final_DiazRuiz_Calidad.DB;
using Final_DiazRuiz_Calidad.Interfaces;
using Final_DiazRuiz_Calidad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final_DiazRuiz_Calidad.Servicios
{
    public class ServicioIngreso: IServicioIngreso
    {
        private AppConexionDB conexion;

        public ServicioIngreso()
        {
            this.conexion = new AppConexionDB();
        }
        public List<Ingreso> ObtenerIngresos()
        {
            return conexion.Ingresos.ToList();
        }

        public void GuardarIngreso(Ingreso ingreso)
        {
            conexion.Ingresos.Add(ingreso);
            conexion.SaveChanges();
        }

        public Cuenta obtenerCuenta(int idCuenta)
        {
            return conexion.Cuentas.Find(idCuenta);
        }
        public void GuardarCuenta()
        {
            conexion.SaveChanges();
        }
    }
}