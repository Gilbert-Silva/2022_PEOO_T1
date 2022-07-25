using System;

class Program {
  public static void Main() {
    Console.WriteLine("Informe a base do retângulo");
    double b = double.Parse(Console.ReadLine());
    Console.WriteLine("Informe a altura");
    double h = double.Parse(Console.ReadLine());
    Console.WriteLine( Diagonal(b, h) );
  }
  public static double Diagonal(double b, double h) {
    double x = Math.Sqrt(b*b + h*h);
    return x;
  }
}