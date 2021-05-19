using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCTO
{
    public class Solution
    {
        public int Prezzo;
        public List<int> Percorso;
        public Solution(int prezzo, List<int> percorso)
        {
            Prezzo = prezzo;
            Percorso = percorso;
        }
    }
    public class Trip
    {
        public List<RoutingPoint> viaggioSingolo;
        public Solution Sol;

        public Trip(List<RoutingPoint> ViaggioSingolo, Solution Sol)
        {
            viaggioSingolo = ViaggioSingolo;
            this.Sol = Sol;

        }
    }
    public static class RoutingAlgorithm
    {

        public static IList<Trip> GetViaggio(IList<RoutingPoint> list)
        {
            var a = list.ToList();
                /*JsonConvert.DeserializeObject<List<RoutingPoint>>(File.ReadAllText(@"D:\pcto\pcto creazione dati\pcto creazione dati\bin\Debug\netcoreapp3.1\datiGrafo.json"));*/
            RoutingPoint[] dati = a.ToArray();
            List<int> eleViaggio = new List<int>();
            List<List<int>> tot = new List<List<int>>();
            int numPacchi = a.Count;
            int maxPeso = 10;
            int maxVolume = 20;
            bool verifica = true;

            int x = 0;
            int y = 0;
            //controllo pacchi sopra limite Peso
            x = 0;
            while (x < numPacchi)
            {
                if (dati[x].Weight > maxPeso)
                {
                    throw new ArgumentException($"vertice {x} non idoneo per il Peso");
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
                    throw new ArgumentException($"vertice {x} non idoneo per il Volume");
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
                        foreach (RoutingPoint v in dati)
                        {
                            if (v.IsUsed == false && eleViaggio.Count() == 1)
                            {
                                eleViaggio.Add(v.Id);
                            }
                        }
                        dati[eleViaggio[eleViaggio.Count() - 1] - 1].IsUsed = true;
                        x++;
                    }
                    else
                    {
                        vertice = calcoloVertice(dati, eleViaggio);
                        if (vertice == 0)
                            break;
                        if (calcoloPeso(dati, eleViaggio) + dati[vertice - 1].Weight < maxPeso && calcoloVolume(dati, eleViaggio) + dati[vertice - 1].Volume < maxVolume)
                        {
                            eleViaggio.Add(vertice);
                            dati[eleViaggio[eleViaggio.Count() - 1] - 1].IsUsed = true;
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
            List<int> casa = new List<int>(dati[0].Costs);
            List<Trip> totDati = new List<Trip>();
            foreach (List<int> b in tot)
            {
                dati[0].Costs = new List<int>(casa);
                Trip f = new Trip(new List<RoutingPoint>(), new Solution(default(int), new List<int>()));
                foreach (int s in b)
                {
                    f.viaggioSingolo.Add(dati[s - 1]);
                }
                List<int> vert = new List<int>();
                foreach (RoutingPoint g in f.viaggioSingolo)
                {
                    vert.Add(g.Id);
                }
                List<int> final = new List<int>();
                foreach (RoutingPoint g in f.viaggioSingolo)
                {
                    int cont = 1;
                    foreach (int h in g.Costs)
                    {
                        if (vert.Contains(cont))
                        {
                            final.Add(h);
                        }
                        cont++;
                    }
                    g.Costs = new List<int>(final);
                    g.Connected = new List<int>(vert);
                    final.Clear();
                }
                f.Sol = ElaborazioneVertici(f.viaggioSingolo, vert);

                totDati.Add(f);
                f = default(Trip);
            }
            int totSoluzioni = 0;
            foreach (Trip k in totDati)
            {
                totSoluzioni = totSoluzioni + k.Sol.Prezzo;
            }
            if(totDati.Count==0)
            {
                var routingPoints = new List<RoutingPoint>() { new RoutingPoint() { Id = 1, Volume = 0, Weight = 0, Costs = new List<int>(), Connected = new List<int>() } };
                var trip = new Trip(routingPoints, new Solution(0, new List<int>()));
                return new List<Trip>() { trip };
            }
            return totDati;
        }
        public static Solution ElaborazioneVertici(List<RoutingPoint> dati, List<int> vert)
        {
            int x = 0;
            int num = dati[0].Connected.Count();
            List<int> temp = new List<int>();
            while (x < num)
            {
                temp.Add(x + 1);
                x++;
            }
            x = 0;
            foreach (RoutingPoint a in dati)
            {
                a.Connected = new List<int>(temp);
                a.Id = x + 1;
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
        public static Solution CalcoloPercorso(List<RoutingPoint> dati)
        {
            List<int> minPercorso = new List<int>();
            List<int> percorso = new List<int>();
            int minPrezzo = int.MaxValue;
            Solution sol = new Solution(minPrezzo, minPercorso);
            int prezzo = 0;
            List<int> coll = new List<int>();
            int x = 0;
            while (dati[0].Connected.Count() > x)
            {
                coll.Add(x + 1);
                x++;
            }
            percorso.Add(dati[0].Id);
            asd(coll, percorso, dati, prezzo, ref sol);
            return (sol);
        }
        public static List<int> asd(List<int> coll, List<int> percorso, List<RoutingPoint> dati, int prezzo, ref Solution sol)
        {
            foreach (int i in coll)
            {
                if (!percorso.Contains(dati[i - 1].Id))
                {
                    percorso.Add(i);
                    percorso = asd(coll, percorso, dati, prezzo, ref sol);
                }
            }
            if (percorso.Count == dati.Count)
            {
                prezzo = 0;
                if (dati[0].Connected.Contains(percorso[percorso.Count - 1]))
                {
                    int posizione = 0;
                    int x = 0;
                    foreach (int i in percorso)
                    {
                        RoutingPoint elemento = dati.Where(y => y.Id == i).FirstOrDefault();
                        if (i == percorso[percorso.Count - 1])
                        {
                            foreach (int a in dati[0].Connected)
                            {
                                if (a == percorso[percorso.Count - 1])
                                {
                                    prezzo = prezzo + elemento.Costs[0];
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
                            foreach (int a in elemento.Connected)
                            {
                                if (a == percorso[x + 1])
                                {
                                    prezzo = prezzo + elemento.Costs[posizione];
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
        static int calcoloPeso(RoutingPoint[] pesi, List<int> numeri)
        {
            int Peso = 0;
            foreach (int i in numeri)
            {
                Peso = Peso + pesi[i - 1].Weight;
            }
            return Peso;
        }
        static int calcoloVolume(RoutingPoint[] volumi, List<int> numeri)
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
        static int calcoloVertice(RoutingPoint[] dati, List<int> viaggio)
        {
            int distanza = 0;
            int tot = int.MaxValue;
            int vertice = 0;
            foreach (RoutingPoint a in dati)
            {
                if (a.IsUsed != true)
                {
                    foreach (int s in viaggio)
                    {
                        if (s != 1)
                            distanza = distanza + a.Costs[s - 1];
                    }
                    if (tot > distanza)
                    {
                        tot = distanza;
                        vertice = a.Id;
                    }
                    distanza = 0;
                }
            }
            return vertice;
        }
    }
}

