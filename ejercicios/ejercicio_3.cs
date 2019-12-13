// Dado un vector x de n elementos reales, donde n es impar, diseñar una función que calcule y devuelva la mediana de ese vector. La mediana es el valor tal que la mitad de los números son mayores que el valor y la otra mitad son menores. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3
{
  class Ej3 {

    static bool impar(int a) {
      bool band;
      if (a % 2 == 0) {
        band = false;
      } else {
        band = true;
      }
      return band;
    }

    public Ej3(){}

    public static void Ejercicio3() {
      int n;

      Console.WriteLine("Cantidad de elementos a INTRODUCIR");
      do
      {
        Console.Write("Debe ser IMPAR => ");
        n = int.Parse(Console.ReadLine());
      } while (!impar(n));

      int[] vector = new int[n];

      for (int i = 0; i < n; i++)
      {
        Console.Write((i + 1) + ": ");
        vector[i] = int.Parse(Console.ReadLine());
      }

      Console.WriteLine("MEDIANA del vector es {0}", vector[n / 2]);
      Console.ReadKey();
    }

  }
}