using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test_array
{
    class Program
    {
        // Funge da #define
        const int MAX = 20;
        static void Main()
        {
            // dichiarazione array C#
            int[] vet;
            int i, ne;

            // Inserimento dati nell'array
            vet = new int[MAX];
            Random rand = new Random();

            LeggiNumero(out ne);

            for (i = 0; i < ne; i++)
                vet[i] = rand.Next(100);

            Console.WriteLine("Array disordinato:");
            Visualizza(vet, ne);
            Ordina(vet, ne);
            Console.WriteLine("Array ordinato:");
            Visualizza(vet, ne);
            Console.ReadKey();
        }// end main

        static void LeggiNumero(out int ne)
        {
            do
            {
                Console.Write("Numero elementi: ");
                ne = Convert.ToInt32(Console.ReadLine());
            }while (ne > MAX);
        }
        // Visualizzazione di un array
        static void Visualizza(int[] v, int ne)
        {
            //Console.Clear();
            for (int i = 0; i < ne; i++)
                Console.WriteLine("v[{0}] = {1}", i, v[i]);
        }

        static void Ordina(int[] v, int ne)
        {
            int i, j, app;
            for ( i=0; i<ne; i++)
                for( j=i+1; j<ne; j++)
                    if (v[i] > v[j])
                    {
                        Scambia(ref v[i], ref v[j]);
                    }
        }

        static void Scambia(ref int x, ref int y)
        {
            int app = x;
            x = y;
            y = app;
        }
    }
}
