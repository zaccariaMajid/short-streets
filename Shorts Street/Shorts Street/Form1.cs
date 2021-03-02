using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shorts_Street
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnpercorsominimo_Click(object sender, EventArgs e)
        {
            List<int> coll = new List<int>();
            List<int> cost = new List<int>();
            List<vertici> dati = new List<vertici>();

            dati.Add(new vertici(1, new List<int>() { 6, 12, 17, 20 }, new List<int>() { 4, 2, 3, 3 }));
            dati.Add(new vertici(2, new List<int>() { 3, 10, 15, 19 }, new List<int>() { 4, 2, 2, 3 }));
            dati.Add(new vertici(3, new List<int>() { 2, 10, 12, 14, 20 }, new List<int>() { 4, 3, 2, 3, 2 }));
            dati.Add(new vertici(4, new List<int>() { 5, 9, 15 }, new List<int>() { 4, 2, 2 }));
            dati.Add(new vertici(5, new List<int>() { 4, 8, 9, 15 }, new List<int>() { 4, 6, 3, 2 }));
            dati.Add(new vertici(6, new List<int>() { 1, 16, 17 }, new List<int>() { 4, 2, 1 }));
            dati.Add(new vertici(7, new List<int>() { 14, 16 }, new List<int>() { 2, 3 }));
            dati.Add(new vertici(8, new List<int>() { 5, 13 }, new List<int>() { 6, 5 }));
            dati.Add(new vertici(9, new List<int>() { 4, 5, 11 }, new List<int>() { 2, 3, 7 }));
            dati.Add(new vertici(10, new List<int>() { 2, 3, 11, 14, 15 }, new List<int>() { 2, 2, 4, 4, 1 }));
            dati.Add(new vertici(11, new List<int>() { 9, 10, 13, 14, 18 }, new List<int>() { 7, 4, 6, 5, 1 }));
            dati.Add(new vertici(12, new List<int>() { 1, 3, 19 }, new List<int>() { 2, 2, 1 }));
            dati.Add(new vertici(13, new List<int>() { 8, 11, 18 }, new List<int>() { 5, 6, 1 }));
            dati.Add(new vertici(14, new List<int>() { 3, 7, 10, 11 }, new List<int>() { 3, 2, 4, 5 }));
            dati.Add(new vertici(15, new List<int>() { 2, 4, 5, 10 }, new List<int>() { 2, 2, 2, 1 }));
            dati.Add(new vertici(16, new List<int>() { 6, 7 }, new List<int>() { 2, 3 }));
            dati.Add(new vertici(17, new List<int>() { 1, 6 }, new List<int>() { 3, 1 }));
            dati.Add(new vertici(18, new List<int>() { 11, 13 }, new List<int>() { 1, 1 }));
            dati.Add(new vertici(19, new List<int>() { 2, 12 }, new List<int>() { 3, 1 }));
            dati.Add(new vertici(20, new List<int>() { 1, 3 }, new List<int>() { 3, 2 }));



            var sol = Funzioni.CalcoloPercorso(dati);

            sol.Percorso.ForEach(i => Console.Write(i + " "));
            Console.WriteLine("\n" + sol.Prezzo);

            Console.ReadKey();
        }

        private void button1_Click(object sender, EventArgs e)
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
            //controllo pacchi sopra limite peso
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
                            if (Funzioni.calcoloPeso(elePacchi, eleViaggio) + elePacchi[x].peso < maxPeso && Funzioni.calcoloPeso(elePacchi, eleViaggio) + elePacchi[x].volume < maxVolume)
                            {
                                elePacchi[x].usato = true;
                                eleViaggio.Add(x);
                                y++;
                            }
                            if (x == numPacchi - 1)
                            {
                                Console.WriteLine(Funzioni.scrittura(eleViaggio));
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
    }
}
