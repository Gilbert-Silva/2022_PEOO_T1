using System;

class Program {
  public static void Main() {
    Console.WriteLine("Informe a altura da caixa");
    double h = double.Parse(Console.ReadLine());
    Console.WriteLine("Informe a largura da caixa");
    double l = double.Parse(Console.ReadLine());
    Console.WriteLine("Informe a profundidade da caixa");
    double p = double.Parse(Console.ReadLine());
    Console.WriteLine( VolumeLitros(h, l, p) );
  }
  public static double VolumeLitros(double h, double l, double p) {
    double x = h * l * p * 1000;
    return x;
  }
}