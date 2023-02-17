using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GepteremProjekt
{
    class PetrikLajosSzg
    {
        readonly List<Gepterem> geptermek = new List<Gepterem>();

        public List<Gepterem> Geptermek => geptermek;

        public PetrikLajosSzg(string filenev)
        {
           
                using (StreamReader sr = new StreamReader(filenev))
                {
                    while (!sr.EndOfStream)
                    {
                        string nev = sr.ReadLine();
                        string[] sor = sr.ReadLine().Split(';');
                        int sorDb = int.Parse(sor[0]);
                        int helyDb = int.Parse(sor[1]);
                        int[,] ertekeles = new int[sorDb, helyDb];
                        for (int i = 0; i < sorDb; i++)
                        {
                            sor = sr.ReadLine().Split(';');
                            for (int j = 0; j < helyDb; j++)
                            {
                                ertekeles[i, j] = int.Parse(sor[j]);
                            }
                        }
                        geptermek.Add(new Gepterem(nev, sorDb, helyDb, ertekeles));
                        sr.ReadLine();
                    }
                }
           
          
        }
    }
}
