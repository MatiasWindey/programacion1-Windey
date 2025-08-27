using Sistema_de_viajes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {

            

            List<Vehiculo> VehiculoCreado = new List<Vehiculo>();

            List<Viaje> Listaviajes = new List<Viaje>();

        bool Consolaactiva = true;

            while (Consolaactiva)
            {

                Console.WriteLine("1.Agregar un vehiculo.\r\n2.Registrar un viaje para un vehiculo.\r\n3.Mostrar informacion del vehiculo\r\n4.Mostrar todos los vehiculos y estadisticas generales.\r\n5.Mostrar todas las patentes y tipos de vehiculos.\r\n6.Salir\r\n");
                if (int.TryParse(Console.ReadLine(), out int Opcionseleccionada))
                {

                    switch (Opcionseleccionada)
                    {

                        case 1:
                            Console.WriteLine("Seleccione uno de los siguientes vehiculos.\r\n1. Camion.\r\n2. Furgoneta.\r\n3. Motocicleta.\n\r");
                            int VehiculoSeleccionado = int.Parse(Console.ReadLine());
                            
                            if (VehiculoSeleccionado == 1)
                            { 
                                Console.WriteLine("Ingrese la placa del Camion\n\r");
                                string placa = Console.ReadLine();
                                Console.WriteLine("Ingrese los kilometros del Camion\n\r");
                                int kilometros = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese la capacidad de carga\n\r");
                                int Capacidadcarga = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese la capacidada adicional del Camion\n\r");
                                int Cargaadicional = int.Parse(Console.ReadLine());

                                Camion NuevoCamion = new Camion(placa,  kilometros,Capacidadcarga, Cargaadicional);

                                VehiculoCreado.Add(NuevoCamion);

                                
                            }
                            
                            if (VehiculoSeleccionado == 2)
                            {
                                Console.WriteLine("Ingrese la placa de la Furgoneta\n\r");
                                string placa = Console.ReadLine();
                                Console.WriteLine("Ingrese los kilometros de la Furgoneta\n\r");
                                int kilometros = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese la capacidada de carga de la Furgnoeta\n\r");
                                int Capacidadcarga = int.Parse(Console.ReadLine());

                                Furgoneta NuevaFurgonera = new Furgoneta(placa, kilometros, Capacidadcarga);

                                VehiculoCreado.Add(NuevaFurgonera);
                            }
                            if (VehiculoSeleccionado == 3)
                            {
                                Console.WriteLine("Ingrese la placa de la Motocicileta\n\r");
                                string placa = Console.ReadLine();
                                Console.WriteLine("Ingrese los kilometros de la Motocicleta\n\r");
                                int kilometros = int.Parse(Console.ReadLine());

                                Motocicleta NuevaMotocicleta = new Motocicleta(placa, kilometros);

                                VehiculoCreado.Add(NuevaMotocicleta);
                            }

                            
                            
                            
                            break;                           


                        case 2:
                            Console.WriteLine("ingrese la placa del vehiculo con el cual quiera realizar el viaje");
                            string Placaviaje = Console.ReadLine();

                            

                            foreach (var Vehiculo in VehiculoCreado)
                            {
                                if (Vehiculo.Placa == Placaviaje)
                                {

                                    if (Vehiculo is Motocicleta)
                                    {
                                        Console.WriteLine("ingrese el destino de la Motorola ");
                                        string Destinoseleccionado = Console.ReadLine();
                                        Console.WriteLine("ingrese los kilometros que debe recorrer");
                                        int Distanciaseleccionada = int.Parse(Console.ReadLine());
                                        Console.WriteLine("ingrese la fecha del viaje");
                                        string Fechaviaje = (Console.ReadLine());
                                        Console.WriteLine("dado que es una motocicleta el cargamento va a ser de 0Kg");
                                        int Cargadada = 0;
                                        Viaje ViajeEnCreacion = new Viaje(Placaviaje, Destinoseleccionado, Distanciaseleccionada, Fechaviaje, Cargadada);

                                        Listaviajes.Add(ViajeEnCreacion);

                                    }
                                    else
                                    {

                                        Console.WriteLine($"ingrese la carga a transportar. debe ser menor a {Vehiculo.Capacidadcarga}");
                                        int Cargadada = int.Parse(Console.ReadLine());
                                        if (Cargadada <= Vehiculo.Capacidadcarga)
                                        {
                                            Console.WriteLine("ingrese el destino");
                                            string Destinoseleccionado = Console.ReadLine();
                                            Console.WriteLine("ingrese la distancia a recorrer");
                                            int Distanciaseleccionada = int.Parse(Console.ReadLine());
                                            Console.WriteLine("ingrese la fecha del viaje");
                                            string Fechaviaje = (Console.ReadLine());

                                            Viaje ViajeEnCreacion = new Viaje(Placaviaje, Destinoseleccionado, Distanciaseleccionada, Fechaviaje, Cargadada);

                                            Vehiculo.Kilometros += Distanciaseleccionada;

                                            Listaviajes.Add(ViajeEnCreacion);
                                        }

                                        else
                                        {
                                            Console.WriteLine($"el valor ingresado {Cargadada} es mayor que {Vehiculo.Capacidadcarga} vuelva a intentarlo");
                                        }


                                    }
                                    
                                 

                                }
                            }
                            
                            

                            break;


                        case 3:

                            Console.WriteLine("$\n\ringrese la placa del vehiculo que gusta revisar\n\r");
                            string placaingresada = Console.ReadLine();

                            foreach (var vehiculo in VehiculoCreado)
                            {
                                if (vehiculo.Placa == placaingresada)
                                {
                                    if (vehiculo is Motocicleta motocicleta)
                                    {
                                        Console.WriteLine($"\n\rEl tipo de vehiculo es : {vehiculo.TipoVehiculo}, La placa es : {vehiculo.Placa}, Los kilometros son : {vehiculo.Kilometros}KM, {Infoglobal(vehiculo)}\n\r");
                                    }
                                    if (vehiculo is Camion camion)
                                    {
                                        Console.WriteLine($"\n\rEl tipo de vehiculo es : {vehiculo.TipoVehiculo}, La placa es : {vehiculo.Placa}, Los kilometros son : {vehiculo.Kilometros}KM, la capacidad de carga total es de {camion.Capacidadcarga},  la capacidad de carga adicional es {camion.Cargaadicional}, {Infoglobal(vehiculo)}\n\r");
                                    }
                                    if (vehiculo is Furgoneta furgoneta)
                                    {
                                        Console.WriteLine($"\n\rEl tipo de vehiculo es : {vehiculo.TipoVehiculo}, La placa es : {vehiculo.Placa}, Los kilometros son : {vehiculo.Kilometros}KM,  la capacidad de carga es de {furgoneta.Capacidadcarga}, {Infoglobal(vehiculo)} \n\r");
                                    }
                                }
                            }
                                                        

                            break;

                        case 4:

                            foreach (Vehiculo vehiculo in VehiculoCreado)
                            {

                                Console.WriteLine($"La placa es {vehiculo.Placa}, el tipo es {vehiculo.TipoVehiculo}, su kilometrajes es de {vehiculo.Kilometros}, {Infoglobal(vehiculo)}");

                            }

                            break;


                        case 5:

                            int Distanciatotalflota = 0;

                            int Cargatotalflota = 0;

                            foreach (var vehiculo in Listaviajes)
                            {
                                Distanciatotalflota += vehiculo.Distancia;

                            }
                            Console.WriteLine($"La flota transporto en total {Cargatotalflota}, recorrio {Distanciatotalflota} entre {VehiculoCreado.Count}");

                            break;


                        case 6:

                            Consolaactiva = false;
                            break;
                    }



                }

            }



            string Infoglobal(Vehiculo vehiculo)
            {
                int Kilometrostotales = 0;
                int Cargatotal = 0;
                int Cantidadviajes = 0;

                foreach (var viajes in Listaviajes)
                {

                    if(vehiculo.Placa == viajes.Placa)
                    {
                        Kilometrostotales += viajes.Distancia;

                        Cargatotal += viajes.Cargatransportada;

                        Cantidadviajes++;
                    }

                }                
                
                return $" Recorrio {Kilometrostotales}km en {Cantidadviajes} viajes y transporto {Cargatotal}Kg totales ";
            }






        }
    }
}
