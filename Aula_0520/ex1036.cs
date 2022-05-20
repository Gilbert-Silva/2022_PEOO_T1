using System;

class Program {
  public static void Main() {
    string s = Console.ReadLine();  // s = "10.0 20.1 5.1"
    string[] v = s.Split();
    double a = double.Parse(v[0]);  // a = 10.0
    double b = double.Parse(v[1]);  // b = 20.1
    double c = double.Parse(v[2]);  // c = 5.1

    double delta = b * b - 4 * a * c;
    double r1 = (-b + Math.Sqrt(delta)) / (2 * a);
    double r2 = (-b - Math.Sqrt(delta)) / (2 * a);

    if (delta < 0 || a == 0) 
      Console.WriteLine("Impossivel calcular");
    else {
      Console.WriteLine($"R1 = {r1:f5}");
      Console.WriteLine($"R1 = {r2:f5}");
    }
  }
}