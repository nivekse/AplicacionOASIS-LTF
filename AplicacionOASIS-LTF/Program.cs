using System;

namespace AplicacionOASIS_LTF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var respuesta = "si";
            while (respuesta != "no") {

                var cliente = new Clientes();
                var listacliente = new list<Clientes>();
                Console.WriteLine("ingrese nombre del cliente ");
                cliente.Nombre = Console.ReadLine();
                Console.WriteLine("ingrese direccion del cliente ");
                cliente.Direccion = Console.ReadLine();
                Console.WriteLine("ingrese telefono del cleinte ");
                cliente.Telefono = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese cedula de cleinte ");
                cliente.IDCedula = int.Parse(Console.ReadLine());
                Console.WriteLine("desea ingresar mas clientes ? SI/NO");
                respuesta = Console.ReadLine();
                while (respuesta != "no") {
                    var producto = new Productos();
                    var listaproductos = new list<Productos>();
                    Console.WriteLine("ingrese nombre de producto ");
                    producto.NombreProducto = Console.ReadLine();
                    Console.WriteLine("ingrese precio de producto ");
                    producto.PrecioProducto = double.Parse(Console.ReadLine());
                    Console.WriteLine("cantidad de producto que va a llevar ");
                    producto.CantidadProductocliente = int.Parse(Console.ReadLine());


                
                
                }

            
            
            }
                
        }
    }
}
