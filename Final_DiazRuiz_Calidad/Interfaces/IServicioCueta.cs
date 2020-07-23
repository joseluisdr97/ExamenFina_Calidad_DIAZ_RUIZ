using Final_DiazRuiz_Calidad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_DiazRuiz_Calidad.Interfaces
{
    public interface IServicioCueta
    {
        List<Cuenta> ObtenerCuentas();
        void GuardarCuenta(Cuenta cuenta);
    }
}
