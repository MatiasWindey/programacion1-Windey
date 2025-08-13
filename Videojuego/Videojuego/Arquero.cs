using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videojuego
{
    internal class Arquero : Personaje
    {

        public Arquero (string Nombre, int Nivel) : base(Nombre, Nivel)
        {

            Vida = 120;
            Defensa = 25;
            Ataque = 10; 

        }


    }
}
