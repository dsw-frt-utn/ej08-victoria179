using System.ComponentModel;

namespace Dsw2026Ej8
{
    internal class Program  
    {
        static void Main(string[] args)
        {
            /*var helper = new ProductHelper();
            string etiqueta = helper.ObtenerEtiqueteProducto(123, "Camiseta Azul", 15000.50m);
            Console.WriteLine(etiqueta);*/

            /*var problema2 = new Problema2();
            string resultado = problema2.CrearResumenVenta(10, "Lápiz", 3, 100m);
            Console.WriteLine(resultado);*/

            /* var problema3 = new Problema3();
             var producto = new Product { Code = 1, Description = "Lápiz" };

             string result = problema3.ComprarCopias(5, producto);
             Console.WriteLine(problema3.ComprarCopias(5, producto));*/

            /*var problema4 = new Problema4();
            double result = problema4.CalcularPromedio(10, null, 6);
            Console.WriteLine(result);

            result = problema4.CalcularPromedio(null, null, null);
            Console.WriteLine(result);

            result = problema4.CalcularPromedio(15, -5, null);
            Console.WriteLine(result);*/

            /*var problema5 = new Problema5();

            Sale ventaMinorista = new RetailSale { Amount = 100m };
            Sale ventaMayorista = new WholesaleSale { Amount = 100m };

            Console.WriteLine(problema5.ObtenerImporteFinal(ventaMinorista));
            Console.WriteLine(problema5.ObtenerImporteFinal(ventaMayorista));*/

            var problema6 = new Problema6();
            string ejemplo = " ab 123 x ";
            string resultado = problema6.NormalizarCodigoProducto(ejemplo);
            Console.WriteLine(resultado);
            Console.WriteLine(problema6.NormalizarCodigoProducto(null));


            Console.ReadKey();
        }
    }
}
    