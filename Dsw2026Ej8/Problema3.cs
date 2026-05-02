using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Problema3
    { 
        public string ComprarCopias(int originalValue,Product product)
        {
            int copiaValue = originalValue;
            copiaValue++;
            Product copiarProducto = product;
            copiarProducto.SetDescription("CAMBIADO");
            return $"{originalValue}-{copiaValue}-{product.Description}";
        }
    }
}
