using System;

class Program {
  public static void Main() {
    Console.WriteLine("Digite dois valores inteiros");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int maior, menor;
    if (a > b) {
      maior = a;
      menor = b;
    }
    else {
      maior = b;
      menor = a;
    }
    //int maior = Math.Max(a, b);
    //int menor = Math.Min(a, b);
    int x = maior;
    while (x >= menor) {
      Console.WriteLine(x);
      x--; 
    }    
  }
}