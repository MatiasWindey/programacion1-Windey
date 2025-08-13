using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videojuego
{
    public class Personaje 
    {

        public int Id { get; set; }
        public int Nivel {  get; set; }
        public string Nombre { get; set; }
        public int Vida {  get; set; }
        public int Defensa { get; set; }
        public int Ataque { get; set; }

        public int Danoinflingidototal { get; set; }

        public int Danorecibidototal { get; set; }


        public Personaje(string Nombre, int Nivel)
        {

            this.Nombre = Nombre;
            this.Nivel = Nivel;

        }

        public virtual int Atacar(Personaje Enemigo)
        {
            int dano = Ataque - Enemigo.Defensa;

            this.Danoinflingidototal += dano;

            return dano;

        }
        public int Recibirdano(int dano)
        {
            int danorecibido = this.Vida -= dano;

            this.Danorecibidototal += danorecibido;

            return danorecibido;

        }
    }
}

           

