using System;

class Program {
  public static void Main() {
    Triangulo x = new Triangulo(); // Triangulo() - construtor
    Triangulo y = new Triangulo();
    Console.WriteLine(x);
    Console.WriteLine(x.GetBase());
    Console.WriteLine(x.GetAltura());
    x.SetBase(10);
    x.SetAltura(20);
    Console.WriteLine(x.GetBase());
    Console.WriteLine(x.GetAltura());
    Console.WriteLine(x.CalcArea());
    
    Console.WriteLine(y);
    Console.WriteLine(y.GetBase());
    Console.WriteLine(y.GetAltura());
    y.SetBase(-10);
    y.SetAltura(20);
    Console.WriteLine(y.GetBase());
    Console.WriteLine(y.GetAltura());
    Console.WriteLine(y.CalcArea());
  }
}

class Triangulo {
  private double b
  private double h; 
  public void SetBase(double valor) 
    { if (valor > 0) b = valor;  }
  public void SetAltura(double v)
    { if (v > 0) h = v;  }
  public double GetBase()   { return b; }
  public double GetAltura() { return h; }
  public double CalcArea() {
    double area = b * h / 2;
    return area;
  }
}