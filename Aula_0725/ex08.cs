using System;

class Program {
  public static void Main() {
    double x = 4.5;
    Console.WriteLine(x);
    Console.WriteLine(MenorInteiro(x));
    Console.WriteLine("Menor Inteiro >= " 
                      + x + " = " + Math.Ceiling(x));
    Console.WriteLine("Maior Inteiro <= " 
                      + x + " = " + Math.Floor(x));
  }
  public static int MenorInteiro(double x) {
    int y = (int) x;
    if (x == y) return y;
    else return y + 1;
  }
}