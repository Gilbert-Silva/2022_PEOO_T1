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
  private double b, h;                     // Atributos
  public override string ToString() {
    return $"Base = {b}, Altura = {h}";
  }
  public double Base {                     // Propriedade
    set { if (value > 0) b = value; }
    get { return b; }
  }
  public double Altura {
    set { if (value > 0) h = value; }
    get { return h; }
  }  
  public double Area { // Propriedade somente-leitura
    get { return b * h / 2; }
  }
}