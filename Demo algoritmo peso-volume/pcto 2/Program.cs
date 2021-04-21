using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace pcto_2
{
    class Program
    {
        struct pacco
        {
            public int peso;
            public int volume;
            public bool usato;
        }
        static void Main(string[] args)
        {
            List<int> eleViaggio = new List<int>();
            pacco[] elePacchi = new pacco[1000];
            int numPacchi = 0;
            int maxPeso = 1000;
            int maxVolume = 1000;
            bool verifica = true;

            int x = 0;
            int y = 0;
            StreamReader mioFile = new StreamReader("peso.txt");
            //caricamento dati peso
            x = 0;
            while (mioFile.EndOfStream == false)
            {
                elePacchi[x].peso = int.Parse(mioFile.ReadLine());
                x++;
                numPacchi++;
            }
            mioFile.Close();
            //caricamento dati volume
            mioFile = new StreamReader("volume.txt");
            x = 0;
            while (mioFile.EndOfStream == false)
            {
                elePacchi[x].volume = int.Parse(mioFile.ReadLine());
                x++;
            }
            mioFile.Close();
            //controllo pacchi sopra limite peso
            x = 0;
            while (x < numPacchi)
            {
                if (elePacchi[x].peso > maxPeso)
                {
                    Console.WriteLine($"pacco {x} non idoneo per il peso");
                    verifica = false;
                }
                x++;
            }
            //controllo pacchi sopra limite volume
            x = 0;
            while (x < numPacchi)
            {
                if (elePacchi[x].volume > maxVolume)
                {
                    Console.WriteLine($"pacco {x} non idoneo per il volume");
                    verifica = false;
                }
                x++;
            }
            //creazione dei viaggi e scrittura in output
            x = 0;
            if (verifica == true)
            {
                while (y < numPacchi)
                {
                    x = 0;
                    while (x < numPacchi)
                    {
                        if (elePacchi[x].usato != true)
                        {
                            if (calcoloPeso(elePacchi, eleViaggio) + elePacchi[x].peso < maxPeso && calcoloPeso(elePacchi, eleViaggio) + elePacchi[x].volume < maxVolume)
                            {
                                elePacchi[x].usato = true;
                                eleViaggio.Add(x);
                                y++;
                            }
                            if (x == numPacchi - 1)
                            {
                                Console.WriteLine(scrittura(eleViaggio));
                                eleViaggio.Clear();
                            }
                        }
                        x++;
                    }
                }
            }
            else
                Console.WriteLine("\nNon tutti i pacchi sono idonei al trasporto controllare e riprovare.");


            Console.WriteLine("Fine.");
            Console.ReadKey();
        }
        //calcolo peso e volume presente in quel momento nel viaggio 
        static int calcoloPeso(pacco[] pesi, List<int> numeri )
        {
            int peso = 0;
            foreach(int i in numeri)
            {
                peso = peso + pesi[i].peso;
            }
            return peso;
        }
        static int calcoloVolume(pacco[] volumi, List<int> numeri)
        {
            int volume = 0;
            foreach (int i in numeri)
            {
                volume = volume + volumi[i].volume;
            }
            return volume;
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
    }
}