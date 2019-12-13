using System;
using ejercicio_1;
using ejercicio_2;
using ejercicio_3;
using ejercicio_4;
using ejercicio_5;
using ejercicio_6;
using ejercicio_7;
using ejercicio_8;
using ejercicio_9;

class MainClass {

  public static void Main() {
    Console.Write("Que ejercicio DESEAS?\n => ");
    int menu = int.Parse(Console.ReadLine());
    switch(menu){
      case 1: 
        new Ej1().Ejercicio1();
      break;
      case 2: 
        new Ej2().Ejercicio2();
      break;
      case 3: 
        new Ej3().Ejercicio3();
      break;
      case 4: 
        new Ej4().Ejercicio4();
      break;
       case 5: 
        new Ej5().Ejercicio5();
      break;
       case 6: 
        new Ej6().Ejercicio6();
      break;
       case 7: 
        new Ej7().Ejercicio7();
      break;
       case 8: 
        new Ej8().Ejercicio8();
      break;
       case 9: 
        new Ej9().Ejercicio9();
      break;

      default:
        Console.Write("Error");
      break;
    }
  }

}