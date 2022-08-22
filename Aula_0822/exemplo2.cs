using System;

class Program {
  public static void Main() {
    Console.WriteLine("Digite o raio do círculo");
    double r = double.Parse(Console.ReadLine());
    Circulo c = new Circulo();
    c.SetRaio(r);
    Console.WriteLine("Raio = " + c.GetRaio());
    Console.WriteLine("Circunferência = " + c.CalcCircunferencia());
    Console.WriteLine("Área = " + c.CalcArea());
  }
}

class Circulo {
  
}