using Final_DiazRuiz_Calidad.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_DiazRuiz_Calidad.Interfaces
{
    public interface IServicioGasto
    {
        List<Gasto> ObtenerGastos();
        Cuenta obtenerCuenta(int idCuenta);
        void GuardarCuenta();
        void GuardarGasto(Gasto gasto);
    }
}
