using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videojuego
{
    public class Arquero : Personaje
    {

        public Arquero (string Nombre, int Nivel) : base(Nombre, Nivel)
        {

            Vida = 120 + (12*Nivel);
            Ataque = 25;
            Defensa = 10;
             

        }
        public override int Atacar(Personaje Enemigo)
        {
            
            Random random = new Random();
            int Probcrit = random.Next(1, 5);

            if (Probcrit== 1)
            {

                Console.WriteLine("¡¡¡GOLPE CRITICO!!!");
                return (Ataque*2) - Enemigo.Defensa;
               
            }

            return Ataque - Enemigo.Defensa;
           
        }
        

    }
}
