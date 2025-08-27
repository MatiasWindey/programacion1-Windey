using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda_Onlina
{
    public class Producto
    {

        public string Nombre {  get; set; }
        
        public int Precio { get; set; }

        public int Cantidad { get; set; }



        public  Producto(string Nombre, int Precio, int Cantidad)
        {
            this.Nombre = Nombre;
            this. Precio = Precio;
            this.Cantidad = Cantidad;
        }
    }
}
