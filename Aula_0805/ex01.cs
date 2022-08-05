using System;

class Program {
  public static void Main() {
    Console.WriteLine("Informe a massa do material em kg:");
    double m = double.Parse(Console.ReadLine());
    Console.WriteLine("Informe o volume do material em litros:");
    double v = double.Parse(Console.ReadLine());
    double d = Densidade(m, v);
    Console.WriteLine($"A densidade do material é {d} kg/l."); 
  }
  public static double Densidade(double massa, double volume) {
    return massa/volume;
  }
}
