using Final_DiazRuiz_Calidad.DB;
using Final_DiazRuiz_Calidad.Interfaces;
using Final_DiazRuiz_Calidad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final_DiazRuiz_Calidad.Servicios
{
    public class ServicioGasto: IServicioGasto
    {
        private AppConexionDB conexion;

        public ServicioGasto()
        {
            this.conexion = new AppConexionDB();
        }
        public List<Gasto> ObtenerGastos()
        {
            return conexion.Gastos.ToList();
        }

        public void GuardarGasto(Gasto gasto)
        {
            conexion.Gastos.Add(gasto);
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