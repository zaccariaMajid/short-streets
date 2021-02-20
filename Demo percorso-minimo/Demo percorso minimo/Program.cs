using System;
using System.Collections.Generic;
using System.Linq;

namespace algoritmo_ordinamento
{
    class Program
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
        static void Main(string[] args)
        {
            List<int> coll = new List<int>();
            List<int> cost = new List<int>();
            List<vertici> dati = new List<vertici>();
            dati.Add(new vertici(1, new List<int>() { 2, 4, 5 }, new List<int>() { 2, 2, 1 }));
            dati.Add(new vertici(2, new List<int>() { 1, 3, 5 }, new List<int>() { 2, 2, 1 }));
            dati.Add(new vertici(3, new List<int>() { 2, 4, 5 }, new List<int>() { 2, 2, 1 }));
            dati.Add(new vertici(4, new List<int>() { 1, 3, 5 }, new List<int>() { 2, 2, 1 }));
            dati.Add(new vertici(5, new List<int>() { 1, 2, 3, 4 }, new List<int>() { 1, 1, 1, 1 }));
            /*
                        dati.Add(new vertici(1, new List<int>() {6,12,17,20 }, new List<int>() {4,2,3,3 }));
                        dati.Add(new vertici(2, new List<int>() {3,10,15,19 }, new List<int>() {4,2,2,3 }));
                        dati.Add(new vertici(3, new List<int>() {2,10,12,14,20 }, new List<int>() {4,3,2,3,2 }));
                        dati.Add(new vertici(4, new List<int>() {5,9,15 }, new List<int>() {4,2,2 }));
                        dati.Add(new vertici(5, new List<int>() {4,8,9,15 }, new List<int>() {4,6,3,2 }));
                        dati.Add(new vertici(6, new List<int>() {1,16,17 }, new List<int>() {4,2,1 }));
                        dati.Add(new vertici(7, new List<int>() {14,16 }, new List<int>() {2,3 }));
                        dati.Add(new vertici(8, new List<int>() {5,13 }, new List<int>() {6,5 }));
                        dati.Add(new vertici(9, new List<int>() {4,5,11 }, new List<int>() {2,3,7 }));
                        dati.Add(new vertici(10, new List<int>() {2,3,11,14,15 }, new List<int>() {2,2,4,4,1 }));
                        dati.Add(new vertici(11, new List<int>() {9,10,13,14,18 }, new List<int>() {7,4,6,5,1 }));
                        dati.Add(new vertici(12, new List<int>() {1,3,19 }, new List<int>() {2,2,1 }));
                        dati.Add(new vertici(13, new List<int>() {8,11,18 }, new List<int>() {5,6,1 }));
                        dati.Add(new vertici(14, new List<int>() {3,7,10,11 }, new List<int>() {3,2,4,5 }));
                        dati.Add(new vertici(15, new List<int>() {2,4,5,10 }, new List<int>() {2,2,2,1 }));
                        dati.Add(new vertici(16, new List<int>() {6,7 }, new List<int>() {2,3 }));
                        dati.Add(new vertici(17, new List<int>() {1,6 }, new List<int>() {3,1 }));
                        dati.Add(new vertici(18, new List<int>() {11,13 }, new List<int>() {1,1 }));
                        dati.Add(new vertici(19, new List<int>() {2,12 }, new List<int>() {3,1 }));
                        dati.Add(new vertici(20, new List<int>() {1,3 }, new List<int>() {3,2 }));
            */
            List<int> percorso = new List<int>();
            int minPrezzo = int.MaxValue;
            List<int> minPercorso = new List<int>();

            var a = CalcoloPercorso(dati, percorso, ref minPrezzo, minPercorso);

            minPercorso.ForEach(i => Console.Write("{0}\t", i));
            Console.WriteLine("\n" + minPrezzo);

            Console.ReadKey();
        }
        /// <summary>
        ///Restituisce il calcolodel percorso più breve
        /// </summary>
        /// <param name="dati">Contiene i dati</param>
        /// <param name="percorso">Conterrà il percorso minimo</param>
        /// <param name="minPrezzo">Conterrà il prezzo minimo finale</param>
        /// <param name="minPercorso">Conterrà il percorso minimo finale</param>
        /// <returns></returns>
        public static List<int> CalcoloPercorso(List<vertici> dati, List<int> percorso, ref int minPrezzo, List<int> minPercorso)
        {
            int prezzo = 0;
            percorso.Add(dati[0].Vertice);
            Calcolo(dati[0].Collegati, percorso, dati, prezzo, ref minPrezzo, minPercorso);
            return (percorso);
        }
        /// <summary>
        /// Calcola il percorso pù breve
        /// </summary>
        /// <param name="coll">Contiene i vertici collegati al vertice preso in esame</param>
        /// <param name="percorso">Conterrà il percorso minimo</param>
        /// <param name="dati">Contiene i dati</param>
        /// <param name="prezzo">Serve per verificare quale ramo collegato ha un minor costo</param>
        /// <param name="minPrezzo">Conterrà il prezzo minimo finale</param>
        /// <param name="minPercorso">Conterrà il percorso minimo finale</param>
        /// <returns></returns>
        public static List<int> Calcolo(List<int> coll, List<int> percorso, List<vertici> dati, int prezzo, ref int minPrezzo, List<int> minPercorso)
        {
            foreach (int i in coll)
            {
                if (!percorso.Contains(dati[i - 1].Vertice))
                {
                    percorso.Add(i);
                    var temp = dati[i - 1].Collegati;
                    percorso = Calcolo(temp, percorso, dati, prezzo, ref minPrezzo, minPercorso);
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
                            if (minPrezzo > prezzo)
                            {
                                minPrezzo = prezzo;
                                foreach(int e in percorso)
                                {
                                    minPercorso.Add(e);
                                }
                                Console.Clear();
                                minPercorso.ForEach(r => Console.Write("{0}\t", r));
                                Console.WriteLine("\n");
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
