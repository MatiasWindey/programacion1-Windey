using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videojuego
{
    public class Guerrero : Personaje 
    {

        public Guerrero(string nombre, int nivel) : base(nombre, nivel)
        {

            Vida = 150;
            Ataque = 30;
            Defensa = 15;

        }
        public int Atacar(Personaje Enemigo)
        {
           int dano = Ataque - Enemigo.Defensa;

            
           return dano;

        }
    }
}
