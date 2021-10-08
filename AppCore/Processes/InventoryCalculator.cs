using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Processes
{
    public class InventoryCalculator
    {
        private decimal CostoTotal(decimal precio, int existencia)
        {
            return precio * existencia;
        }

    }
}
