using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videojuego
{
    public class Combate
    {
        public Personaje personaje1 {  get; set; }

        public Personaje personaje2 { get; set; }

        public Personaje personajeGanador { get; set; }

        public Personaje personajePerdedor { get; set; }

        public int turnosTotales { get; set; }

        

        public Combate (Personaje personaje1, Personaje personaje2)
        {
            this.personaje1 = personaje1;
            this.personaje2 = personaje2;
        }
        public void Pelea()
        {
            int vidaOriginalP1 = this.personaje1.Vida;

            int vidaOriginalP2 = this.personaje2.Vida;

            bool Personajesvivos = true;
            int contadorTurnos = 1;

            while (Personajesvivos)
            {
                this.turnosTotales = contadorTurnos;

                if (contadorTurnos % 2 != 0)
                {
                    
                   int vida2 = personaje2.Recibirdano(personaje1.Atacar(personaje2));
                    Console.WriteLine($"ataca {personaje1.Nombre}, su daño es {personaje1.Atacar(personaje2) + personaje2.Defensa}, la defensa del enemigo es {personaje2.Defensa}, entonces le inflije {personaje1.Atacar(personaje2)}");
                    Console.WriteLine($"el enemigo queda con {personaje2.Vida}");
                   if (vida2 <= 0)
                   {
                        Personajesvivos = false;
                        this.personajeGanador = personaje1;   
                        this.personajePerdedor = personaje2;
                   } 
                   

                }
                if (contadorTurnos % 2 == 0)
                {
                    int vida1 = personaje1.Recibirdano(personaje2.Atacar(personaje1));
                    Console.WriteLine($"ataca {personaje2.Nombre}, su daño es {personaje2.Atacar(personaje1) + personaje1.Defensa}, la defensa del enemigo es {personaje1.Defensa}, entonces le inflije {personaje2.Atacar(personaje1)}");
                    Console.WriteLine($"el enemigo queda con {personaje1.Vida}");
                    if (vida1 <= 0)
                    {
                        Personajesvivos = false;
                        this.personajeGanador = personaje2;
                        this.personajePerdedor = personaje1;
                    }

                }
                contadorTurnos++;
            }
            personaje1.Vida = vidaOriginalP1;
            personaje2.Vida = vidaOriginalP2;
        }
    }
}
