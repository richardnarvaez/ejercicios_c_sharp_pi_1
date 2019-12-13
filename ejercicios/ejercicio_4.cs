//  Se trata de resolver el siguiente problema escolar. Dadas las notas de los alumnos de un colegio en el primer curso de bachillerato, en las diferentes asignaturas (5, por comodidad), se trata de calcular la media de cada alumno, la media de cada asignatura, la media total de la clase y ordenar los alumnos por orden decreciente de notas medias individuales.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_4
{
  class Ej4 {

    public Ej4(){}

    public void Ejercicio4() {
      int n;
            float medA;

            Console.Write("Cantidad de estudiantes: ");
            n = int.Parse(Console.ReadLine());

            float[,] clase = new float[(n + 1), 6];

            for (int i = 0; i < n; i++)
            {
                medA = 0;
                Console.WriteLine("Estudiante " + (i + 1) + ": ");
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("Nota " + (j + 1) + ": ");
                    clase[i, j] = float.Parse(Console.ReadLine());
                    medA = clase[i, j] + medA;
                }
                clase[i, 5] = medA / 5;
            }

            medianaA(clase, n);
            medianaC(clase, n);
            ordenado(clase, n);

            Console.ReadKey();
    }

    static void medianaA(float[,] cl, int n)
        {
            float med;
            for (int i = 0; i < 5; i++)
            {
                med = 0;
                for (int j = 0; j < n; j++)
                {
                    med = med + cl[j, i];
                }
                cl[n, i] = med / n;
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Media de Nota " + (i + 1) + ": " + cl[n, i]);
            }
        }
              static void medianaC(float[,] cl, int n)
        {
            float acum = 0;
            for (int i = 0; i < n; i++)
            {
                acum = acum + cl[i, 5];
            }
            Console.WriteLine("Media de la clase: " + (acum / n));
        }

        static void ordenado(float[,] cl, int n)
        {
            float aux;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (cl[i, 5] < cl[j, 5])
                    {
                        aux = cl[j, 5];
                        cl[i, 5] = cl[j, 5];
                        cl[j, 5] = aux;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Puesto " + (i + 1) + ": " + cl[i, 5]);
            }

        }

  }
}