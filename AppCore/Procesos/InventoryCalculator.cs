using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Procesos
{
    public class InventoryCalculator
    {

        private decimal CostoTotal(decimal costo, int existencia)
        {
            return costo * existencia; 
        }
         
       
    }
}
