using System;

class Program {
  public static void Main () {
    int x = 5;
    int y = 10;
    Console.WriteLine(x);
    Console.WriteLine(y);
    Triangulo t1 = new Triangulo();
    t1.b = 10;
    t1.h = 20;
    Console.WriteLine(t1.b);
    Console.WriteLine(t1.h);
    Console.WriteLine(t1.b * t1.h / 2);
    Console.WriteLine(t1.CalcArea());
    Triangulo t2 = new Triangulo();
    t2.b = 50;
    t2.h = 60;
    Console.WriteLine(t2.CalcArea());
  }
}
class Triangulo {
  public double b, h;        // Campo ou atributo
  public double CalcArea() { // Método
    return b * h / 2;
  }
}
