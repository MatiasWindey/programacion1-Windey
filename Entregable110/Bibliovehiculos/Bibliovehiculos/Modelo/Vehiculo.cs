using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliovehiculos.Modelo
{
    public class Vehiculo
    {
        public int Id { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public int Anio { get; set; } 


        public Vehiculo(string Marca, string Modelo, int Anio)
        {

            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Anio = Anio;


        }

    }
}
