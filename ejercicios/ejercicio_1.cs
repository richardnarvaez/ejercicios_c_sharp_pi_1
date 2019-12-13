//  Hallar el área de un triangulo

using System;

namespace ejercicio_1
{
  class Ej1 {

    public Ej1(){}

    public void Ejercicio1() {
      Console.WriteLine ("Base");
      int b  = int.Parse(Console.ReadLine());
      Console.WriteLine ("Altura");
      int h  = int.Parse(Console.ReadLine());
      Console.WriteLine ("Su AREA es: " + (b*h/2));
    }

  }
}