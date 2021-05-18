using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace pcto_2
{
    class Program
    {
        public class vertice
        {
            public int Vertice;
            public List<int> Collegati;
            public List<int> Costi;
            public int Peso;
            public int Volume;
            public bool Usato;
            public vertice(int vertice, List<int> collegati, List<int> costi, int peso, int volume, bool usato)
            {
                Vertice = vertice;
                Collegati = collegati;
                Costi = costi;
                Peso = peso;
                Volume = volume;
                Usato = usato;
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
        public class viaggio
        {
            public List<vertice> viaggioSingolo;
            public soluzione sol;

            public viaggio(List<vertice> ViaggioSingolo, soluzione Sol)
            {
                viaggioSingolo = ViaggioSingolo;
                sol = Sol;

            }

        }
        static void Main(string[] args)
        {
            var a = JsonConvert.DeserializeObject<List<vertice>>(File.ReadAllText(@"D:\pcto\pcto creazione dati\pcto creazione dati\bin\Debug\netcoreapp3.1\datiGrafo.json"));
            vertice[] dati = new vertice[a.Count];
            dati = a.ToArray();
            List<int> eleViaggio = new List<int>();
            List<List<int>> tot = new List<List<int>>();
            int numPacchi = a.Count;
            int maxPeso = 100000000;
            int maxVolume = 100000;
            bool verifica = true;

            int x = 0;
            int y = 0;
            //controllo pacchi sopra limite Peso
            x = 0;
            while (x < numPacchi)
            {
                if (dati[x].Peso > maxPeso)
                {
                    Console.WriteLine($"vertice {x} non idoneo per il Peso");
                    verifica = false;
                }
                x++;
            }
            //controllo pacchi sopra limite Volume
            x = 0;
            while (x < numPacchi)
            {
                if (dati[x].Volume > maxVolume)
                {
                    Console.WriteLine($"vertice {x} non idoneo per il Volume");
                    verifica = false;
                }
                x++;
            }
            //creazione dei viaggi e scrittura in output
            x = 1;
            int vertice = 0;
            eleViaggio.Add(1);
            while (x < dati.Count())
            {
                while (true)
                {
                    if (eleViaggio.Count() == 1)
                    {
                        foreach (vertice v in dati)
                        {
                            if (v.Usato == false && eleViaggio.Count() == 1)
                            {
                                eleViaggio.Add(v.Vertice);
                            }
                        }
                        dati[eleViaggio[eleViaggio.Count() - 1] - 1].Usato = true;
                        x++;
                    }
                    else
                    {
                        vertice = calcoloVertice(dati, eleViaggio);
                        if (vertice == 0)
                            break;
                        if (calcoloPeso(dati, eleViaggio) + dati[vertice - 1].Peso < maxPeso && calcoloVolume(dati, eleViaggio) + dati[vertice - 1].Volume < maxVolume)
                        {
                            eleViaggio.Add(vertice);
                            dati[eleViaggio[eleViaggio.Count() - 1] - 1].Usato = true;
                            x++;
                        }
                        else
                            break;
                    }
                }
                tot.Add(new List<int>(eleViaggio));
                eleViaggio.Clear();
                eleViaggio.Add(1);
            }
            List<int> casa = new List<int>(dati[0].Costi);
            List<viaggio> totDati = new List<viaggio>();
            foreach (List<int> b in tot)
            {
                dati[0].Costi = new List<int>(casa);
                viaggio f = new viaggio(new List<vertice>(), new soluzione(default(int), new List<int>()));
                foreach (int s in b)
                {
                    f.viaggioSingolo.Add(dati[s - 1]);
                }
                List<int> vert = new List<int>();
                foreach (vertice g in f.viaggioSingolo)
                {
                    vert.Add(g.Vertice);
                }
                List<int> final = new List<int>();
                foreach (vertice g in f.viaggioSingolo)
                {
                    int cont = 1;
                    foreach (int h in g.Costi)
                    {
                        if (vert.Contains(cont))
                        {
                            final.Add(h);
                        }
                        cont++;
                    }
                    g.Costi = new List<int>(final);
                    g.Collegati = new List<int>(vert);
                    final.Clear();
                }
                f.sol = ElaborazioneVertici(f.viaggioSingolo, vert);

                totDati.Add(f);
                f = default(viaggio);
            }
            int totSoluzioni = 0;
            foreach (viaggio k in totDati)
            {
                totSoluzioni = totSoluzioni + k.sol.Prezzo;
                foreach (int f in k.sol.Percorso)
                {
                    Console.Write(f + " ");
                }
                Console.WriteLine("\n" + k.sol.Prezzo);
            }

            Console.WriteLine("Fine.");
            Console.ReadKey();
        }
        public static soluzione ElaborazioneVertici(List<vertice> dati, List<int> vert)
        {
            int x = 0;
            int num = dati[0].Collegati.Count();
            List<int> temp = new List<int>();
            while (x < num)
            {
                temp.Add(x + 1);
                x++;
            }
            x = 0;
            foreach (vertice a in dati)
            {
                a.Collegati = new List<int>(temp);
                a.Vertice = x + 1;
                x++;
            }
            var sol = CalcoloPercorso(dati);
            x = 0;
            while (x < sol.Percorso.Count())
            {
                sol.Percorso[x] = vert[sol.Percorso[x] - 1];
                x++;
            }
            return (sol);
        }
        public static soluzione CalcoloPercorso(List<vertice> dati)
        {
            List<int> minPercorso = new List<int>();
            List<int> percorso = new List<int>();
            int minPrezzo = int.MaxValue;
            soluzione sol = new soluzione(minPrezzo, minPercorso);
            int prezzo = 0;
            List<int> coll = new List<int>();
            int x = 0;
            while (dati[0].Collegati.Count() > x)
            {
                coll.Add(x + 1);
                x++;
            }
            percorso.Add(dati[0].Vertice);
            asd(coll, percorso, dati, prezzo, ref sol);
            return (sol);
        }
        public static List<int> asd(List<int> coll, List<int> percorso, List<vertice> dati, int prezzo, ref soluzione sol)
        {
            foreach (int i in coll)
            {
                if (!percorso.Contains(dati[i - 1].Vertice))
                {
                    percorso.Add(i);
                    percorso = asd(coll, percorso, dati, prezzo, ref sol);
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
                        vertice elemento = dati.Where(y => y.Vertice == i).FirstOrDefault();
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
        //calcolo Peso e Volume presente in quel momento nel viaggio
        static int calcoloPeso(vertice[] pesi, List<int> numeri)
        {
            int Peso = 0;
            foreach (int i in numeri)
            {
                Peso = Peso + pesi[i - 1].Peso;
            }
            return Peso;
        }
        static int calcoloVolume(vertice[] volumi, List<int> numeri)
        {
            int Volume = 0;
            foreach (int i in numeri)
            {
                Volume = Volume + volumi[i - 1].Volume;
            }
            return Volume;
        }
        //scrittura viaggio
        static string scrittura(List<int> numeri)
        {
            string viaggio = "";
            foreach (int i in numeri)
            {
                viaggio = viaggio + i.ToString() + " "; ;
            }
            return viaggio;
        }
        static int calcoloVertice(vertice[] dati, List<int> viaggio)
        {
            int distanza = 0;
            int tot = int.MaxValue;
            int vertice = 0;
            foreach (vertice a in dati)
            {
                if (a.Usato != true)
                {
                    foreach (int s in viaggio)
                    {
                        if (s != 1)
                            distanza = distanza + a.Costi[s - 1];
                    }
                    if (tot > distanza)
                    {
                        tot = distanza;
                        vertice = a.Vertice;
                    }
                    distanza = 0;
                }
            }
            return vertice;
        }
    }
}

