using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect_paw
{
    public class Transport
    {
       public int idTransport;
       public string orasPlecare;
       public string orasSosire;
       public int distanta;
       public int cantitate;
       public Masina masina;
       public Sofer sofer;

        public Transport()
        {
        }

        public Transport(int idTransport, string orasPlecare, string orasSosire, int distanta, int cantitate, Masina masina, Sofer sofer)
        {
            this.idTransport = idTransport;
            this.orasPlecare = orasPlecare;
            this.orasSosire = orasSosire;
            this.distanta = distanta;
            this.cantitate = cantitate;
            this.masina = masina;
            this.sofer = sofer;
        }
    }
}
