//  Hallar el área de un triangulo

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_8
{
  class Ej8 {

    public Ej8(){}

    public static void Ejercicio8() {
      int[] A = new int[10];
            int[] B = new int[10];
            int[] C = new int[10];

            for(int i = 0; i < 10; i++)
            {
                Console.Write("P{0} Existencia: ",(i+1));
                A[i] = int.Parse(Console.ReadLine());
                Console.Write("P{0} Pedido: ",(i+1));
                B[i] = int.Parse(Console.ReadLine());

                if (A[i] == B[i])
                {
                    C[i] = A[i];
                }
                else if(A[i] < B[i])
                {
                    C[i] = 2*(B[i] - A[i]);
                }
                else
                {
                    C[i] = B[i];
                }
                
            }
            Console.Clear();

            Console.WriteLine("Control de Existencias");


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Cantidad ruequerida en P"+(i+1) +": "+ C[i]);
            }

            Console.ReadKey();
    }

  }
}