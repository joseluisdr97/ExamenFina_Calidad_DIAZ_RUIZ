using Final_DiazRuiz_Calidad.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace Final_DiazRuiz_Calidad.DB.Maps
{
    public class GastoMap : EntityTypeConfiguration<Gasto>
    {
        public GastoMap()
        {
            ToTable("Gasto");
            HasKey(o => o.IdGasto);

            //Relaciones

            HasRequired(o => o.Cuenta)
            .WithMany(o => o.Gastos)
            .HasForeignKey(o => o.IdCuenta);
        }
    }
}