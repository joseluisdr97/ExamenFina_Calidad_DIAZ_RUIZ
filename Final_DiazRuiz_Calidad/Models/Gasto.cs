using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final_DiazRuiz_Calidad.Models
{
    public class Gasto
    {
        public int IdGasto { get; set; }
        public int IdCuenta { get; set; }
        public DateTime FechaHora { get; set; }
        public string Descripcion { get; set; }
        public decimal Monto { get; set; }
        public Cuenta Cuenta { get; set; }
    }
}