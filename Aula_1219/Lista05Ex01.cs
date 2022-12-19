using System;

class Program {
  public static void Main() {
    Retangulo r = new Retangulo();
    r.Base = 10;
    r.Altura = 20;
    Console.WriteLine(r);
    Console.WriteLine($"Área = {r.Area}");
    Console.WriteLine($"Diagonal = {r.Diagonal:f2}");
  }
}

class Retangulo {
  private double b, h;
  public double Base {
    get { return b; }
    set { if (value > 0) b = value; }
  }
  public double Altura {
    get { return h; }
    set { if (value > 0) h = value; }
  }
  public double Area {
    get { return b * h; }
  }
  public double Diagonal {
    get { return Math.Sqrt(b*b + h*h); }
  }
  public override string ToString() { 
    return $"Retângulo de base = {b} e altura = {h}";
  }
}