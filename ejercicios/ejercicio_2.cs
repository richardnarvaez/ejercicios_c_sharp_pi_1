//  Hallar el área de un triangulo

using System;

namespace ejercicio_2
{
  class Ej2 {

    public Ej2(){}

    public static void Ejercicio2() {
      Console.WriteLine ("Ingresa un ENTERO a:");
      int a = int.Parse(Console.ReadLine());
      
      Console.WriteLine ("Ingresa un ENTERO  b:");
      int b = int.Parse(Console.ReadLine());
      
      Console.WriteLine ("Ingresa un ENTERO  c:");
      int c = int.Parse(Console.ReadLine());
      
      Console.WriteLine ("Discriminante: " + ((b*b)-(4*a*c)));
    }

  }
}