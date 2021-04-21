using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace creazionie_dati_grafo
{
    public class vertici
    {
        public int vertice;
        public int peso;
        public int volume;
        public int[] costi = new int[100];
        public vertici(int Vertice, int Peso, int Volume, int[] Costi)
        {
            vertice = Vertice;
            peso = Peso;
            volume = Volume;
            costi = Costi;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int minPeso = 0;
            int maxPeso = 0;
            int minVolume = 0;
            int maxVolume = 0;
            int minCosto = 0;
            int maxCosto = 0;
            Console.Write("Inserisci il numero di vertici del grafo: ");
            int numVertici = int.Parse(Console.ReadLine());
            if (numVertici != 123)
            {
                Console.Write("Inserisci il minimo peso: ");
                minPeso = int.Parse(Console.ReadLine());
                Console.Write("Inserisci il massimo peso: ");
                maxPeso = int.Parse(Console.ReadLine());
                Console.Write("Inserisci il minimo volume: ");
                minVolume = int.Parse(Console.ReadLine());
                Console.Write("Inserisci il massimo volume: ");
                maxVolume = int.Parse(Console.ReadLine());
                Console.Write("Inserisci il minimo costo: ");
                minCosto = int.Parse(Console.ReadLine());
                Console.Write("Inserisci il massimo costo: ");
                maxCosto = int.Parse(Console.ReadLine());
            }
            else
            {
                numVertici = 10;
                minPeso = 0;
                maxPeso = 10;
                minVolume = 0;
                maxVolume = 10;
                minCosto = 1;
                maxCosto = 10;
            }

            var rand = new Random();

            List<vertici> dati = new List<vertici>();
            int x = 0;
            int y = 0;
            while (x < numVertici)
            {
                y = x;
                int[] a = new int[numVertici];
                while (y < numVertici)
                {
                    a[y] = rand.Next(minCosto, maxCosto);
                    y++;
                }
                vertici temp = new vertici(x, rand.Next(minPeso, maxPeso), rand.Next(minVolume, maxVolume),a);
                dati.Add(temp);
                x++;
            }
            x = 0;
            foreach(vertici i in dati)
            {
                x = 0;
                while(i.vertice > x )
                {
                    i.costi[x] = dati[x].costi[i.vertice];
                    x++;
                }
            }

            foreach (vertici i in dati)
            {
                i.costi[i.vertice] = 0;
            }
            string outputJSON = Newtonsoft.Json.JsonConvert.SerializeObject(dati, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText(@"prova.json", outputJSON + Environment.NewLine);

            Console.ReadKey();
        }
    }
}