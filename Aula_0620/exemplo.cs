using System;

class Program {
  public static void Main() {
    double a = 2.5;
    double b = 5;
    //double c = Maior(a, b);
    double c = Program.Maior(a, b);
    Console.WriteLine(c);
    Console.WriteLine(Program.Maior(6, 8));
    double d = Matematica.Maior(10,20);
    Console.WriteLine(d);
    Console.WriteLine(Matematica.Maior(3, 4));
    Console.WriteLine(Math.Max(3, 4));
  }
  public static double Maior(double x, double y) {
    if (x > y) return x;
    else return y;
  }
}
class Matematica {
  public static double Maior(double x, double y) {
    if (x > y) return x;
    else return y;
  }
}

