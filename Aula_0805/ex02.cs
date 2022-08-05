using System;

class Program {
  public static void Main() {
    Console.WriteLine("Informe o número para contar os divisores:");
    int x = int.Parse(Console.ReadLine());
    int k = ContarDivisores(x);
    Console.WriteLine($"O número de divisores é: {k}");
  }
  public static int ContarDivisores(int x) {
    int k = 0;
    int d = 1;
    while (d <= x) {
      if (x % d == 0) k++;
      d++;
    }
    return k;
  }
    
}
