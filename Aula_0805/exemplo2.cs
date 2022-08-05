using System;

class Program {
  public static void Main () {
    Triangulo t = new Triangulo();
    Console.WriteLine("Base = " + t.b + " Altura = " + t.h);
    Console.WriteLine("Digite o valor da base");
    t.b = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o valor da altura");
    t.h = double.Parse(Console.ReadLine());
    Console.WriteLine("Base = " + t.b + " Altura = " + t.h);
    Console.WriteLine($"A área do triângulo é {t.CalcArea()}");
  }
}
class Triangulo {
  public double b, h;        // Campo ou atributo
  public double CalcArea() { // Método
    return b * h / 2;
  }
}
