﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionOASIS_LTF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
            MenuCliente();
            Console.WriteLine("Escoja una opción: ");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1: CrearCliente();
                    break;
            }
            } while (opcion !=5);


        }

        public static void MenuCliente() {
            Console.WriteLine("*****************************************************");
            Console.WriteLine("*************************MENÚ DE CLIENTE*************");
            Console.WriteLine("1. Crear un nuevo cliente. ");
            Console.WriteLine("2. Buscar un cliente. ");
            Console.WriteLine("3. Modificar un cliente. ");
            Console.WriteLine("4. Desactivar o Activar un cliente. ");
            Console.WriteLine("5. Salir.");
            Console.WriteLine("*****************************************************");

        }
        public static void MenuProducto() {
            Console.WriteLine("*****************************************************");
            Console.WriteLine("*************************MENÚ DE PRODUCTO************");
            Console.WriteLine("1. Crear un nuevo cliente. ");
            Console.WriteLine("2. Buscar un cliente. ");
            Console.WriteLine("3. Modificar un cliente. ");
            Console.WriteLine("4. Desactivar o Activar un cliente. ");
            Console.WriteLine("*****************************************************");
        }

        public static void CrearCliente()
        {
            var respuesta = "si";

            var listacliente = new List<Cliente>();
            while (respuesta != "no")
            {
                var cliente = new Cliente();

                Console.WriteLine("ingrese nombre del cliente ");
                cliente.Nombre = Console.ReadLine();
                Console.WriteLine("ingrese direccion del cliente ");
                cliente.Direccion = Console.ReadLine();
                Console.WriteLine("ingrese telefono del cleinte ");
                cliente.Telefono = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese cedula de cleinte ");
                cliente.IDCedula = int.Parse(Console.ReadLine());
                Console.WriteLine("*********************************************");
                Console.WriteLine("Compra.");
                while (respuesta != "no")
                {
                    var producto = new Producto();
                    Console.WriteLine("ingrese nombre de producto ");
                    producto.NombreProducto = Console.ReadLine();
                    Console.WriteLine("ingrese precio de producto ");
                    producto.PrecioProducto = double.Parse(Console.ReadLine());
                    Console.WriteLine("cantidad de producto que va a llevar ");
                    producto.CantidadProductocliente = int.Parse(Console.ReadLine());
                    Console.WriteLine("desea ingresar otro producto ? SI/NO");
                    respuesta = Console.ReadLine();
                    cliente.listaProductos.Add(producto);
                }
                listacliente.Add(cliente);
                Console.WriteLine("desea ingresar mas clientes ? SI/NO");
                respuesta = Console.ReadLine();
            }

        }

    }
}
