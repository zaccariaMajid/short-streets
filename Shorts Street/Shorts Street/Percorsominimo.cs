using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shorts_Street
{
    public class vertici
    {
        public int Vertice;
        public List<int> Collegati;
        public List<int> Costi;
        public vertici(int vertice, List<int> collegati, List<int> costi)
        {
            Vertice = vertice;
            Collegati = collegati;
            Costi = costi;
        }

    }
    public class soluzione
    {
        public int Prezzo;
        public List<int> Percorso;
        public soluzione(int prezzo, List<int> percorso)
        {
            Prezzo = prezzo;
            Percorso = percorso;
        }

    }
}
