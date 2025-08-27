using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda_Onlina;


namespace Aplicacion_tienda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int roll;

            bool ConsolaActiva = true;

            List<Producto> ProductosStock = new List<Producto>();

            List<Producto> carrito = new List<Producto>();

            List<Cliente> Clientecreado = new List<Cliente>();
            

            while (ConsolaActiva)
            {
                Console.WriteLine("¡Bienvenido a la tienda online de Laura!\r\n Seleccione su rol.\n\r \r\n Cliente 1 \r\n Administrador 2 \n\r");
                roll = int.Parse(Console.ReadLine());

                switch (roll)
                {

                    case 1:

                        if (roll == 1)
                        {
                            
                            Console.WriteLine("Seleccione una de las siguientes opciones:\n\r1. Ver productos disponible.\n\r2. Agregar productos al carrito.\n\r3. Ver carrito.\n\r4. Confirmar compra.\n\r5. Volver al menu principal.");
                            int Opcion = int.Parse(Console.ReadLine());

                            switch (Opcion)
                            {

                                case 1:

                                    if (Opcion == 1)
                                    {
                                        foreach (Producto Producto in ProductosStock)
                                        {

                                            Console.WriteLine($"Nombre: {Producto.Nombre}, Precio: {Producto.Precio}$ c/u, Cantidad: {Producto.Cantidad}\n\r");

                                        }

                                    }

                                    break;

                                case 2:
                                    if (Opcion == 2)
                                    {
                                        Console.WriteLine("ingrese el nombre del producto que desea guardar en el carrito");
                                        string NombrePaCarrito = Console.ReadLine();


                                        foreach (Producto Producto in ProductosStock)
                                        {

                                            if(NombrePaCarrito == Producto.Nombre)
                                            {

                                                Producto.Cantidad--;

                                                carrito.Add(Producto);

                                            }

                                        }


                                    }
                                    

                                    break;

                                case 3:


                                    if (Opcion == 3)
                                    {
                                        foreach (Producto Producto in carrito)

                                            Console.WriteLine($"Nombre: {Producto.Nombre}, Precio: {Producto.Precio}$ c/u, Cantidad: {Producto.Cantidad}\n\r");

                                    }
                                    break;


                                case 4:

                                    if (Opcion == 4)
                                    {
                                        int impuestostotales = 0;
                                        int Preciototal = 0;
                                        int iva = 0;

                                        foreach(Producto Producto in carrito)
                                        {

                                            iva = ((Producto.Precio * 21) / 100);

                                            impuestostotales += iva;
                                            Preciototal += (Producto.Precio + iva);



                                            Console.WriteLine("usted lleva: ");
                                            Console.WriteLine($"{Producto.Nombre}, {Producto.Precio}");
                                            Console.WriteLine($"el impuesto de este producto es de {iva}");

                                        }
                                        Console.WriteLine($"usted esta pagando en impuestos un total de {impuestostotales}");

                                        Console.WriteLine($"el precio total es de {Preciototal}");
                                    }

                                    break;

                                case 5:

                                    ConsolaActiva = true;
                                    Console.WriteLine("Regresando al inicio...\n\r");
                                    break;

                            }

                        }

                        break;

                      
                        

                    case 2:

                        if (roll == 2)
                        {


                            Console.WriteLine("seleccione una de las siguientes opciones:\n\r1. Ver productos.\n\r2. Agregar productos.\n\r3. Aumentar Stock de un producto existente.\n\r4. Crear Cliente.\n\r5. Volver al menu principal. ");
                            int Opcion = int.Parse(Console.ReadLine());

                            switch (Opcion)
                            {

                                case 1:
                                    if (Opcion == 1)
                                    {
                                        foreach (Producto Producto in ProductosStock)
                                        {

                                            Console.WriteLine($"Nombre: {Producto.Nombre}, Precio: {Producto.Precio}$ c/u, Cantidad: {Producto.Cantidad}\n\r");

                                        }

                                    }
                                    
                                    break;


                                case 2:

                                    if (Opcion == 2)
                                    {

                                        Console.WriteLine("ingrese el nombre del producto a agregar");
                                        string NNuevoProd = Console.ReadLine();
                                        Console.WriteLine("ingrese el precio del producto");
                                        int NPrecioProd = int.Parse(Console.ReadLine());
                                        Console.WriteLine("ingrese la cantidad del producto");
                                        int NCantidadProd = int.Parse(Console.ReadLine());

                                        Producto Productonuevo = new Producto(NNuevoProd, NPrecioProd, NCantidadProd);

                                        ProductosStock.Add(Productonuevo);

                                       
                                    }

                                    break;

                                case 3:

                                    if (Opcion == 3)
                                    {
                                        foreach (Producto Producto in ProductosStock)
                                        {

                                            Console.WriteLine($"{Producto.Nombre}, {Producto.Cantidad}");

                                        }
                                        Console.WriteLine("ingrese el nombre del producto al que le quiera aumentar el stock");
                                        string Nombreastockear = Console.ReadLine();

                                        foreach (Producto Producto in ProductosStock)
                                        {
                                            if (Nombreastockear == Producto.Nombre)
                                            {

                                                Console.WriteLine("ingrese la cantidad que agregara del producto");
                                                int CantNueva = int.Parse(Console.ReadLine());

                                                Producto.Cantidad += CantNueva ;


                                            }


                                        }




                                    }


                                    

                                    break;

                                case 4:

                                    if (Opcion == 4)
                                    {

                                        Console.WriteLine("ingrese el nombre del cliente");
                                        string NombreCliente = Console.ReadLine();
                                        Console.WriteLine("ingrese la direccion del cliente");
                                        string DirecCliente = Console.ReadLine();

                                        Cliente Clientenuevo = new Cliente(NombreCliente, DirecCliente);

                                        Clientecreado.Add(Clientenuevo);


                                    }

                                    break;

                                case 5:
                                   
                                    ConsolaActiva = true;
                                    Console.WriteLine("Regresando al inicio...\n\r");
                                    
                                    break;

                            }

                        }

                        break;


                }

            }


        }    
    }
}

