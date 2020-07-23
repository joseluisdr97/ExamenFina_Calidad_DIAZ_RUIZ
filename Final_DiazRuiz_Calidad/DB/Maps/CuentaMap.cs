using Final_DiazRuiz_Calidad.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Final_DiazRuiz_Calidad.DB.Maps
{
    public class CuentaMap : EntityTypeConfiguration<Cuenta>
    {
        public CuentaMap()
        {
            ToTable("Cuenta");
            HasKey(o => o.IdCuenta);
        }
    }
}