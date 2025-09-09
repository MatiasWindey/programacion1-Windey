using Parcial_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace consola
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Libro> Librodigital = new List<Libro>();

            List<Libro> LibroFisico = new List<Libro>();


            List<Prestamo> LibroPrestado = new List<Prestamo>();



            bool Consolaactiva = true;


            while (Consolaactiva)
            {


                Console.WriteLine("Ingrese una de las siguientes opciones:\n\r1. registrar un libro.\n\r2. Realizar un prestamo de un libro.\n\r3. Mostrar informacion de un libro.\n\r4. Mostrar todos los libros y estadisticas generales.\n\r5. Salir");
                int Opcionseleccionada = int.Parse(Console.ReadLine());

                switch (Opcionseleccionada)
                {

                    case 1:

                        if (Opcionseleccionada == 1)
                        {

                            Console.WriteLine("Defina si el libro sera: 1.digital o 2.fisico");
                            int Tipolibro = int.Parse(Console.ReadLine());

                            if (Tipolibro == 1)
                            {

                                Console.WriteLine("ingrese el ISBN del libro");
                                int IDlibro = int.Parse(Console.ReadLine());

                                foreach (Libro libro in Librodigital)
                                {
                                    if (IDlibro == libro.ISBN)
                                    {
                                        

                                        Console.WriteLine("este libro ya existe, vuelva a intentarlo");

                                        break;
                                    }
                                    


                                }
                                Console.WriteLine("ingrese el autor del libro");
                                string AutorLibro = Console.ReadLine();
                                Console.WriteLine("ingrese el titulo del libro");
                                string TituloLibro = Console.ReadLine();
                                string Disponibilidad = "disponible";

                                Libro Libronuevo = new Libro(IDlibro, TituloLibro, AutorLibro, Disponibilidad);

                                Librodigital.Add(Libronuevo);


                            }
                            if (Tipolibro == 2)
                            {

                                Console.WriteLine("ingrese el ISBN del libro");
                                int IDlibro = int.Parse(Console.ReadLine());

                                foreach (Libro libro in LibroFisico)
                                {

                                    if (IDlibro == libro.ISBN)
                                    {

                                        Console.WriteLine("este libro ya existe, vuelva a intentarlo");

                                        Consolaactiva = true;

                                    }
                                    


                                }
                                Console.WriteLine("ingrese el Autor del libro");
                                string AutorLibro = Console.ReadLine();
                                Console.WriteLine("ingrese el titulo del libro");
                                string TituloLibro = Console.ReadLine();
                                string Disponibilidad = "Disponible";
                                Libro LibroNuevo = new Libro(IDlibro, AutorLibro, TituloLibro, Disponibilidad);

                                LibroFisico.Add(LibroNuevo);





                            }






                        }

                        break;

                    case 2:


                        Console.WriteLine("defina si el libro el cual quiere es 1.digital o 2.fisico");

                        foreach (Libro libro in Librodigital)
                        {

                            Console.WriteLine($"Libors digitales:\n\r {libro.ISBN} {libro.Titulo}\n\r ");


                        }
                        foreach (Libro libro in LibroFisico)
                        {

                            Console.WriteLine($"Libros fisicos:\n\r {libro.Titulo}");

                        }

                        int Opcionseleccionadalibro = int.Parse(Console.ReadLine());

                        if (Opcionseleccionadalibro == 1)
                        {



                            Console.WriteLine("ingrese el ISBN del libro que quiere retirar");
                            int IDlibroPrestamo = int.Parse(Console.ReadLine());
                            Console.WriteLine("ingrese su nombre de socio");
                            string Nombresocio = Console.ReadLine();
                            Console.WriteLine("ingrese la fecha en la que retira el dia");
                            string Fechaprestamo = Console.ReadLine();
                            Console.WriteLine("ingrese la cantidad de dias que va a conservar el libro");
                            int CantDiasPrestamo = int.Parse(Console.ReadLine());

                            Prestamo Nuevoprestamo = new Prestamo(IDlibroPrestamo, Fechaprestamo, Nombresocio, CantDiasPrestamo);

                            LibroPrestado.Add(Nuevoprestamo);




                        }
                        else
                        {

                            Console.WriteLine("ingrese el ISBN del libro que quiere retirar");
                            int IDlibroPrestamo = int.Parse(Console.ReadLine());



                            foreach (var libroprestado in LibroPrestado)
                            {

                                if (IDlibroPrestamo == libroprestado.ISBM)
                                {

                                    Console.WriteLine("El libro ya se encuentra alquilado");

                                    

                                }
                                else
                                {
                                    Console.WriteLine("ingrese su nombre de socio");
                                    string Nombresocio = Console.ReadLine();
                                    Console.WriteLine("ingrese la fecha en la que retira el dia");
                                    string Fechaprestamo = Console.ReadLine();
                                    Console.WriteLine("ingrese la cantidad de dias que va a conservar el libro");
                                    int CantDiasPrestamo = int.Parse(Console.ReadLine());

                                    

                                    Prestamo Nuevoprestamo = new Prestamo(IDlibroPrestamo, Fechaprestamo, Nombresocio, CantDiasPrestamo);

                                    LibroPrestado.Add(Nuevoprestamo);
                                }



                            }
                            
                            

                        }



                        break;



                    case 3:

                        Console.WriteLine("ingrese el ISBN del libro del cual desea mostrar la informacion");
                        int IDLibroSeleccionado = int.Parse(Console.ReadLine());



                        foreach (var libro in Librodigital)
                        {

                            if (IDLibroSeleccionado == libro.ISBN)
                            {

                                Console.WriteLine($"El titulo del libro es:\n\r {libro.Titulo}, El autor es: {libro.Autor}, la cantidad de prestamos de este ejemplar es de :  {libro.prestamoCont}");


                            }

                        }
                        foreach (Libro libro in LibroFisico)
                        {


                            if (IDLibroSeleccionado == libro.ISBN)
                            {

                                Console.WriteLine($"El titulo del libro es: {libro.Titulo}, El autor es: {libro.Autor},  la cantidad de prestamos de este ejemplar es de :  {libro.prestamoCont}");


                            }

                        }

                        break;

                    case 4:

                        int LibrostotalesPrestadosD = 0;
                        int LibrostotalesPrestadosF = 0;
                        int LibrostotalesPrestados = 0;

                        foreach (var item in Librodigital)
                        {

                            LibrostotalesPrestadosD += item.prestamoCont;

                            Console.WriteLine($"Caracteristicas generales del libro con el ISBN {item.ISBN} son: Titulo: {item.Titulo}");


                        }

                        foreach (var item in LibroFisico)
                        {


                            LibrostotalesPrestadosF += item.prestamoCont;

                            Console.WriteLine($"Caracteristicas generales del libro con el ISBN {item.ISBN} son: Titulo: {item.Titulo} ");


                            Console.WriteLine($"La cantidad de libros digitales y fisicos es de {LibroFisico.Count + Librodigital.Count}");
                        }

                        LibrostotalesPrestados += (LibrostotalesPrestadosF + LibrostotalesPrestadosD);


                            Console.WriteLine($"La cantidad de libros prestados totales es de {LibrostotalesPrestados}");

                        break;



                    case 5:

                        Consolaactiva = false;

                        break;

                }


            }

        }


    }
}

