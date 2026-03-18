using System.Collections;
//Arraylists de supermercado
class supermercado
{
    public static void Main(string[] args)
    {
        int opcion, passw, opcionadmin;
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
                    Console.WriteLine($"*{p}");
                Console.WriteLine("Ingrese el producto a agregar al carrito");
                newproduct = Console.ReadLine();
                if (productos.Contains(newproduct))
                {
                    Console.WriteLine($"{newproduct} agregado con éxito");
                    Console.WriteLine("------Menú------");
                    Console.WriteLine(newproduct);
                }
                else
                {
                    Console.WriteLine("Opción no disponible");
                }
                break;

            case 2:
                Console.WriteLine("Ingrese datos de usuario");
                Console.WriteLine("Usuario:");
                string usuario = Console.ReadLine();
                Console.WriteLine("Contraseña:");
                passw= int.Parse(Console.ReadLine());
                if (usuario == "Admin")
                {
                    if (passw == 123)
                    {
                        Console.WriteLine("------Acceso permitido------");
                        ArrayList productosadmin = new ArrayList() { "frutas", "carnes", "productos de limpieza", "bebidas" };
                        foreach (string p in productosadmin)
                            Console.WriteLine($"*{p}");
                        Console.WriteLine("------Menú de opciones------");

                        Console.WriteLine("1. Agregar producto");
                        Console.WriteLine("2. Eliminar producto");
                        opcionadmin = int.Parse(Console.ReadLine());
                        switch (opcionadmin)
                        {
                            case 1:
                                Console.WriteLine("Ingrese el producto que desea agregar al almacén");
                                string newproductadmin = Console.ReadLine();
                                productosadmin.Insert(3, newproductadmin);
                                Console.WriteLine("------NewMenu------");
                                foreach (string p in productosadmin)
                                    Console.WriteLine($"*{p}");
                                break;
                            case 2:
                                Console.WriteLine("Ingrese el producto que desea eliminar");
                                string removeproduct = Console.ReadLine();
                                if (productosadmin.Contains(removeproduct))
                                {
                                    productosadmin.Remove(removeproduct);
                                    Console.WriteLine("Producto eliminado");

                                }
                                else
                                {
                                    Console.WriteLine("Producto no disponible");
                                }
                                
                                break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Contraseña incorrecta");
                    }

                }
                else
                {
                    Console.WriteLine("Usuario incorrecto");
                }
                

                break;

            default:
                Console.WriteLine("Error");
                break;
        }
       




}
}
//código modificado