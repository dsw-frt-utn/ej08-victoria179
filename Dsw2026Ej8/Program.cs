namespace Dsw2026Ej8
{
    internal class Program  
    {
        static void Main(string[] args)
        {
            /*var helper = new ProductHelper();
            string etiqueta = helper.ObtenerEtiqueteProducto(123, "Camiseta Azul", 15000.50m);
            Console.WriteLine(etiqueta);*/

            var problema2 = new Problema2();
            string resultado = problema2.CrearResumenVenta(10, "Lápiz", 3, 100m);
            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
    