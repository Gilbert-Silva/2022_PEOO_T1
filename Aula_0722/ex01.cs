using System;

class Program {
  public static void Main() {
    Console.WriteLine( Menor(10.5, 5.6) );
    Console.WriteLine( Menor(0.5, 5.6) );
    Console.WriteLine("Digite dois valores");
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    Console.WriteLine( Menor(a, b) );
  }
  public static double Menor(double x, double y) {
    // Solução 1
    if (x < y) return x;
    else return y;

    // Solução 2
    // Operador condicional ternário
    // return x < y ? x : y; 

    // Solução 3
    // return Math.Min(x, y);
  }
}