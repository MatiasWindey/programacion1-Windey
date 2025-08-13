using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videojuego
{
    public class Guerrero : Personaje 
    {

        public Guerrero(string Nombre, int Nivel) : base(Nombre, Nivel)
        {

            Vida = 150 + (15 * Nivel);
            Ataque = 30;
            Defensa = 15;

        }

    }
}
