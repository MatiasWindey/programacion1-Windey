using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Onlina
{
    public class Cliente
    {

        public int ClienteId = 0;

        public string Nombre { get; set; }

        public string Direccion {  get; set; }


        public Cliente(string Nombre, string Direccion)
        {
            this.ClienteId++;
            this.Nombre = Nombre;
            this.Direccion = Direccion;
        }
    }
}
