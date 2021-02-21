using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shorts_Street
{
    public class pacco
    {
        public int peso;
        public int volume;
        public bool usato;
        public pacco(int Peso, int Volume ,bool Usato)
        {
            peso = Peso;
            volume = Volume;
            usato = Usato;
        }
    }
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
    public class Funzioni
    {
        public static int calcoloPeso(pacco[] pesi, List<int> numeri)
        {
            int peso = 0;
            foreach (int i in numeri)
            {
                peso = peso + pesi[i].peso;
            }
            return peso;
        }
        public static int calcoloVolume(pacco[] volumi, List<int> numeri)
        {
            int volume = 0;
            foreach (int i in numeri)
            {
                volume = volume + volumi[i].volume;
            }
            return volume;
        }
        //scrittura viaggio 
        public static string scrittura(List<int> numeri)
        {
            string viaggio = "";
            foreach (int i in numeri)
            {
                viaggio = viaggio + i.ToString() + " "; ;
            }
            return viaggio;
        }
        public static soluzione CalcoloPercorso(List<vertici> dati)
        {
            List<int> minPercorso = new List<int>();
            List<int> percorso = new List<int>();
            int minPrezzo = int.MaxValue;
            soluzione sol = new soluzione(minPrezzo, minPercorso);
            int prezzo = 0;

            percorso.Add(dati[0].Vertice);
            asd(dati[0].Collegati, percorso, dati, prezzo, ref sol);
            return (sol);
        }
        public static List<int> asd(List<int> coll, List<int> percorso, List<vertici> dati, int prezzo, ref soluzione sol)
        {
            foreach (int i in coll)
            {
                if (!percorso.Contains(dati[i - 1].Vertice))
                {
                    percorso.Add(i);
                    var temp = dati[i - 1].Collegati;
                    percorso = asd(temp, percorso, dati, prezzo, ref sol);
                }
            }
            if (percorso.Count == dati.Count)
            {
                prezzo = 0;
                if (dati[0].Collegati.Contains(percorso[percorso.Count - 1]))
                {
                    int posizione = 0;
                    int x = 0;
                    foreach (int i in percorso)
                    {
                        vertici elemento = dati.Where(y => y.Vertice == i).FirstOrDefault();
                        if (i == percorso[percorso.Count - 1])
                        {
                            foreach (int a in dati[0].Collegati)
                            {
                                if (a == percorso[percorso.Count - 1])
                                {
                                    prezzo = prezzo + elemento.Costi[0];
                                    break;
                                }
                            }
                            if (sol.Prezzo > prezzo)
                            {
                                sol.Prezzo = prezzo;
                                sol.Percorso.Clear();
                                foreach (int g in percorso)
                                {
                                    sol.Percorso.Add(g);
                                }
                            }
                            break;
                        }
                        else
                        {
                            foreach (int a in elemento.Collegati)
                            {
                                if (a == percorso[x + 1])
                                {
                                    prezzo = prezzo + elemento.Costi[posizione];
                                    posizione = 0;
                                    break;
                                }
                                posizione++;
                            }
                        }
                        x++;
                    }
                }
                percorso.RemoveRange(percorso.Count - 1, 1);
            }
            else
                percorso.RemoveRange(percorso.Count - 1, 1);

            return (percorso);
        }
    }
}
