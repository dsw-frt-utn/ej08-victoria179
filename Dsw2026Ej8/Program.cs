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

            var problema3 = new Problema3();
            var producto = new Product { Code = 1, Description = "Lápiz" };

            string result = problema3.ComprarCopias(5, producto);
            Console.WriteLine(problema3.ComprarCopias(5, producto));

            Console.ReadKey();
        }
    }
}
    