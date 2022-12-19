using System;

class Program {
  public static void Main() {
    //string s = "Programação";
    //s.Length
    //Triangulo t = new Triangulo(10, 20);
    Triangulo t = new Triangulo { Base = 10, Altura = 20 };
    Console.WriteLine($"Base = {t.Base}");
    Console.WriteLine($"Altura = {t.Altura}");
    Console.WriteLine($"Área = {t.Area}");
    Console.WriteLine(t);
    t.Base = 20; // Set
    t.Altura = 40;
    Console.WriteLine($"Área = {t.Area}");
    Console.WriteLine(t);
  }
}

class Triangulo {
  public override string ToString() {
    return $"Base = {Base}, Altura = {Altura}";
  }
  public double Base { set; get; }   // Propriedade Auto-Implementada
  public double Altura { set; get; }
  public double Area { // Propriedade somente-leitura
    get { return Base * Altura / 2; }
  }
}