using Final_DiazRuiz_Calidad.DB.Maps;
using Final_DiazRuiz_Calidad.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Final_DiazRuiz_Calidad.DB
{
    public class AppConexionDB:DbContext
    {
        public IDbSet<Cuenta> Cuentas { get; set; }
        public IDbSet<Gasto> Gastos { get; set; }
        public IDbSet<Ingreso> Ingresos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new CuentaMap());
            modelBuilder.Configurations.Add(new IngresoMap());
            modelBuilder.Configurations.Add(new GastoMap());
        }
    }
}