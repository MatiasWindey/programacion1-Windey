using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_2
{
    public class Prestamo
    {
        public int ISBM {  get; set; }

        public string fecha { get; set; }

        public string Nombresocio { get; set; }

        public int Prestamodias { get; set; }

        
        

        public Prestamo(int ISBM, string Fecha, string Nombresocio, int Prestamodias)
        {

            
            this.ISBM = ISBM;
            this.fecha = Fecha;
            this.Nombresocio = Nombresocio;
            this.Prestamodias = Prestamodias;
        }
    }
}
