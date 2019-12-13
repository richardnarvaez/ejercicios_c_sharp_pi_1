//  

using System;

namespace ejercicio_5
{
  class Ej5 {

    public Ej5(){}

    public void Ejercicio5() {
                  int n,op;
            string aux;
       
            Console.Write("Cantidad de numeros: ");
            n = int.Parse(Console.ReadLine());

            string[] num = new string[n];
            string[] nom = new string[n];

            for (int i = 0; i < n; i++)
            {
   
                Console.Write("Nombre: ");
                nom[i] = Console.ReadLine();

                Console.Write("Numero: ");
                num[i] = Console.ReadLine();

            }
            Console.WriteLine("1: Por Nombre: ");
            Console.WriteLine("2: Por Numero: ");
            op = int.Parse(Console.ReadLine());

        
            switch (op)
            {
                case 1:
                    Console.Write("Nombre: ");
                    aux = Console.ReadLine();

                    for(int i = 0; i < n; i++)
                    {
                        if (aux == nom[i])
                        {
                            Console.WriteLine(aux+"::"+num[i]);
                            break;
                        }
                    }
                    break;
                case 2:
                    Console.Write("NUmero: ");
                    aux = Console.ReadLine();

                    for (int i = 0; i < n; i++)
                    {
                        if (aux == num[i])
                        {
                            Console.WriteLine(nom[i] + "::" + num[i]);
                            break;
                        }
                    }
                    break;
            }
            Console.ReadKey();
    }

  }
}