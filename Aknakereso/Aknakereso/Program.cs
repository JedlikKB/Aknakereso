using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aknakereso
{
    class Program
    {

        static void Main(string[] args)
        {
            char[,] pálya = new char[10, 10];
            Feltöltés(pálya);
            Kirajzoló(pálya);
            Console.ReadKey();
        }

        private static void Kirajzoló(char[,] pálya)
        {

        }

        private static void Feltöltés(char[,] pálya)
        {
            Random gép = new Random();
            for (int i = 0; i < pálya.GetLength(0); i++)
            {
                for (int j = 0; j < pálya.GetLength(1); j++)
                {
                    pálya[i, j] = '_';
                }
            }
            int sor, oszlop;
            for (int i = 0; i < 10; i++)
            {
                do
                {
                    sor = gép.Next(10);
                    oszlop = gép.Next(10);
                } while (pálya[sor,oszlop]=='B');
                pálya[sor, oszlop] = 'B';
            }
        }




    }
}
