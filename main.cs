using System;
using System.Reflection;

class MainClass {

  public static void Main() {
    Console.Clear();
    Console.Write("Que ejercicio DESEAS?\n => ");
    int ej = int.Parse(Console.ReadLine());

    string meth = "Ejercicio" + ej;
    string typ = "ejercicio_" + ej + ".Ej" + ej ;

    Console.Clear();
    Type type = Type.GetType(typ);
    MethodInfo mth = type.GetMethod(meth);
    mth.Invoke(null, null);

    
  }

}