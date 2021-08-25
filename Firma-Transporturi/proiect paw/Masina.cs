using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect_paw
{
    public class Masina
    {
       public int idMasina;
       public string nrInmatriculare;
       public string capacitate;
       public string categorie;

        public Masina()
        { }
        public Masina(int idMasina, string nrInmatriculare, string capacitate, string categorie)
        {
            this.idMasina = idMasina;
            this.nrInmatriculare = nrInmatriculare;
            this.capacitate = capacitate;
            this.categorie = categorie;
        }
    }
}
