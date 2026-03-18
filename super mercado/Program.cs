using System.Collections;
//Arraylists de supermercado
class supermercado
{
    public static void Main(string[] args)
    {
        int opcion;
        string newproduct;
        Console.WriteLine("Ingrese al rol que le corresponda");
        Console.WriteLine("1. Cliente");
        Console.WriteLine("2. Administrador");
        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                ArrayList productos = new ArrayList() { "frutas", "carnes", "productos de limpieza", "bebidas" };
                foreach (string p in productos)
                    Console.WriteLine(p);
                Console.WriteLine("Ingrese el producto a agregar al carrito");
                newproduct = Console.ReadLine();
                if (productos.Contains(newproduct))
                {
                    Console.WriteLine($"{newproduct} agregado con éxito");
                 
                }
                else
                {
                    Console.WriteLine("Opción no disponible");
                }
                Console.WriteLine("------Menú------");
                Console.WriteLine(newproduct);

                break;

            case 2:
                Console.WriteLine("Hola");
                break;

            default:
                Console.WriteLine("Error");
                break;
        }
       




}
}
