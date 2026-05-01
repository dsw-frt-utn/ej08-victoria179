namespace Dsw2026Ej8
{
    internal class Program  
    {
        static void Main(string[] args)
        {
            var helper = new ProductHelper();
            string etiqueta = helper.ObtenerEtiqueteProducto(123, "Camiseta Azul", 15000.50m);
            Console.WriteLine(etiqueta);

            Console.ReadKey(); 
        }
    }
}
    