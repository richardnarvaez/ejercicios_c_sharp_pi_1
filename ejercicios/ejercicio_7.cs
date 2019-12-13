//  

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_7
{
  class Ej7 {

    public Ej7(){}

    public static void Ejercicio7() {
      int n;
            float auxProm;
            string auxNom;
            Console.Write("Cantidad de estudiantes: ");
            n = int.Parse(Console.ReadLine());

            float[] prom = new float[n];
            string[] nom = new string[n];

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Esatudiante " + (i + 1));

                Console.Write("Nombre: ");
                nom[i] = Console.ReadLine();

                Console.Write("Promedio: ");
                prom[i] = float.Parse(Console.ReadLine());

            }

            for(int i = 0; i < n; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    if (prom[i] < prom[j])
                    {
                        auxNom = nom[i];
                        auxProm = prom[i];

                        prom[i] = prom[j];
                        nom[i] = nom[j];

                        nom[j] = auxNom;
                        prom[j] = auxProm;
                    }
                        
                }
            }

            Console.Clear();


            for(int i=0;i<n;i++)
            {
                Console.WriteLine("Estudiante {0}: ", (i + 1));
                Console.WriteLine("Nombre: {0}", nom[i]);
                Console.WriteLine("Promedio: "+ prom[i]);
            }

            Console.ReadKey();
    }

  }
}