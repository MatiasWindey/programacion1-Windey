using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Videojuego;
namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<Personaje> Personajes = new List<Personaje>();

            List<Combate>  Combates = new List<Combate>();


            bool Consolaactiva = true;

            while (Consolaactiva)
            {

                Console.WriteLine("1. Registar nuevo Personaje\r\n2. Ver Personajes creados\r\n3. Iniciar combates\r\n4. Ver Historial de combates\r\n5. Ver Estadisticas globales\r\n6.Salir\r\n");
                if (int.TryParse(Console.ReadLine(), out int Opcionseleccionada)) 

                switch (Opcionseleccionada)
                {
                    case 1:

                        Console.WriteLine("seleccione uno de los siguientes personajes\r\n. 1. Guerrero\r\n. 2. Mago\r\n. 3. Arquero\r\n");
                        if (int.TryParse(Console.ReadLine(), out int PersonajeSelecionado))
                        {
                            Console.WriteLine("ingrese el nombre de su personaje");
                            string Nombrepersonaje = Console.ReadLine();
                            Console.WriteLine("ingrese el nivel de su personaje");
                            int Nivelpersonaje = int.Parse(Console.ReadLine());

                            if (PersonajeSelecionado == 1)
                            {
                                Guerrero NuevoGuerrero = new Guerrero(Nombrepersonaje, Nivelpersonaje);

                                Personajes.Add(NuevoGuerrero);
                            }
                            if (PersonajeSelecionado == 2)
                            {
                                Mago NuevoMago = new Mago(Nombrepersonaje, Nivelpersonaje);

                                Personajes.Add(NuevoMago);
                            }
                            if (PersonajeSelecionado == 3)
                            {
                                Arquero NuevoArquero = new Arquero(Nombrepersonaje, Nivelpersonaje);

                                Personajes.Add(NuevoArquero);
                            }

                        }
                        break;

                    case 2:
                        foreach(Personaje pj in Personajes)
                        {
                            Console.WriteLine($"Nombre : {pj.Nombre}\tNivel : {pj.Nivel}\tVida : {pj.Vida}\tAtaque : {pj.Ataque}\tDefensa : {pj.Defensa}\r\n");
                        }
                        break;

                    case 3:
                        Console.WriteLine("ingrese el nombre del primer pj");
                        string pj1 = Console.ReadLine();
                        Personaje Champ1 = Personajes.Find(p => p.Nombre==pj1);
                        Console.WriteLine("ingrese el nombre del segundo pj");                        
                        string pj2 = Console.ReadLine();
                        Personaje Champ2 = Personajes.Find(p => p.Nombre == pj2);

                        Combate nuevoCombate = new Combate(Champ1, Champ2);

                        nuevoCombate.Pelea();

                        Combates.Add(nuevoCombate);

                        Console.WriteLine($"Ganador : {nuevoCombate.personajeGanador.Nombre} Perdedor : {nuevoCombate.personajePerdedor.Nombre} Turnos jugados {nuevoCombate.turnosTotales}");

                        break;

                    case 4:
                        foreach(Combate combate in Combates)
                        {
                            Console.WriteLine($"Ganador : {combate.personajeGanador.Nombre} Perdedor : {combate.personajePerdedor.Nombre} Turnos jugados {combate.turnosTotales}");
                        }
                        break;

                    case 5:
                        Console.WriteLine("ingrese el nombre del pj que quiera revisar");
                        string pSelec = Console.ReadLine();

                        int combatesJugadoC = 0;
                        int combatesGanadosC = 0;

                        Personaje personajeSeleccionado = Personajes.Find(p => p.Nombre == pSelec);

                        foreach(Combate combate in Combates)
                        {
                            if (combate.personajeGanador == personajeSeleccionado)
                            {
                                combatesGanadosC++;
                                combatesJugadoC++;
                            }
                            if (combate.personajePerdedor == personajeSeleccionado)
                            {
                                combatesJugadoC++;
                            }
                        }

                        Console.WriteLine($"la cantidad de combates jugados es de : {combatesJugadoC}\r\n la cantidad de combates ganados es de : {combatesGanadosC}\r\n la cantidad de combates perdidos es de : {combatesJugadoC - combatesGanadosC}\r\n");
                        Console.WriteLine($"Daño total inflingido : {personajeSeleccionado.Danoinflingidototal}\r\n el daño total recibido es : {personajeSeleccionado.Danorecibidototal}\r\n ");


                        break;

                    case 6:
                        Consolaactiva = false;
                        break;

                }






            }
        }
    }
}
