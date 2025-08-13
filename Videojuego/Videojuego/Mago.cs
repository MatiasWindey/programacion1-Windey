using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videojuego
{
    public class Mago : Personaje
    {

        public Mago(string Nombre, int Nivel) : base(Nombre, Nivel)
        {

            Vida = 100 + (10 * Nivel);

            Ataque = 50;

            Defensa = 5;


        }
        
    }
}
