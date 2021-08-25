using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect_paw
{
    public class Sofer
    {
       public int idSofer;
       public string nume;
       public string prenume;
       public string cnp;
       public string catPermis;

        public Sofer()
        {
        }

        public Sofer(int idSofer, string nume, string prenume, string cnp, string catPermis)
        {
            this.idSofer = idSofer;
            this.nume = nume;
            this.prenume = prenume;
            this.cnp = cnp;
            this.catPermis = catPermis;
        }
    }
}
