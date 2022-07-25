using System;

class Program {
  public static void Main() {
    Console.WriteLine("Informe o valor inicial");
    int inicio = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o valor final");
    int fim = int.Parse(Console.ReadLine());
    Console.WriteLine( Soma(inicio, fim) );
  }

public static int Soma(int inicio, int fim) {
  int soma = 0;
  int x = inicio;
  while (x <= fim) {
    soma = soma + x;
    x++;
  }
  return soma;
  }
}
  