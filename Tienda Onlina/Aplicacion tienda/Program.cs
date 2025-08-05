using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_tienda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int roll;



            Console.WriteLine("¡Bienvenido a la tienda online de Laura!\r\nSeleccione su rol:\r\n, \r\n Cliente 1, \r\n Administrador 2");

            if (int.TryParse(Console.ReadLine(), out roll))
            {

                if (roll == 1)
                {
                    int O_Cliente;
                    Console.WriteLine("1. Ver productos disponibles\r\n2. Agregar producto al carrito\r\n3. Ver carrito\r\n4. Confirmar compra\r\n5. Volver al menú principal\r\n");
                    if (int.TryParse(Console.ReadLine(),out O_Cliente))
                    {
                       
                        if(O_Cliente == 1)
                        {

                        }
                        if (O_Cliente == 2)
                        {

                        }
                        if(O_Cliente == 3)
                        {

                        }
                        if(O_Cliente == 4)
                        {

                        }
                        if(O_Cliente == 5)
                        {

                        }
                        else
                        {
                            Console.WriteLine("ingrese un caracter valido");
                        }

                    }

                }
                if (roll == 2)
                {

                    Console.WriteLine("1. Ver productos\r\n2. Agregar nuevo producto\r\n3. Aumentar stock de un producto existente\r\n4. Crear Cliente\r\n5.Volver al menú principal\r\n");

                }
                else
                {
                    Console.WriteLine("ingrese un caracter valido");
                }
            }
            Console.ReadKey();
        }
    }
}

