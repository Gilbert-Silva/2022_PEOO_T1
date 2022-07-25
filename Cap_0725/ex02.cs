using System;

class Program {
  public static void Main() {
    Console.WriteLine("Informe o raio do círculo");
    double raio = double.Parse(Console.ReadLine());
    Console.WriteLine(AreaCirculo(raio));  
    int x, y, z;
    Metodo(out x, out y, out z);
    Console.WriteLine(x);
    Console.WriteLine(y);
    Console.WriteLine(z);
  }
  public static double AreaCirculo(double raio) {
    double area = Math.PI * raio * raio;
    return area;
  }

}
