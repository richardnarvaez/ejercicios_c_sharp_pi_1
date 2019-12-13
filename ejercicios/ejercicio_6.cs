//  

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_6
{
  class Ej6 {

    public Ej6(){}

    public void Ejercicio6() {
      Random rand = new Random();

            int[] A = new int[100];
            int[] B = new int[60];
            int[] C = new int[160];

            for (int i = 0; i < 100; i++)
            {
                A[i] = rand.Next(50);
            }

            for (int i = 0; i < 60; i++)
            {
                B[i] = rand.Next(50);
            }
            C = A.Concat(B).ToArray();

            Array.Sort(A);
            Array.Sort(B);
            Array.Sort(C);

            Console.WriteLine("Lista A");

            for (int i = 0; i < 100; i++)
            {
                Console.Write(" " + A[i] + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("Lista B");

            for (int i = 0; i < 60; i++)
            {
                Console.Write(" " + B[i] + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("Lista C");

            for (int i = 0; i < 160; i++)
            {
                Console.Write(" " + C[i] + " ");
            }

            Console.ReadKey();
    }

  }
}