using System;

public class Program { 
  public static void Main(string[] args) { 
    int a = int.Parse(Console.ReadLine()); 
    int b = int.Parse(Console.ReadLine()); 
    int c = int.Parse(Console.ReadLine()); 
    int d = int.Parse(Console.ReadLine()); 

    // Todos diferentes
    // (a != b && a != c && a != d && b != c && b != d && c != d) 

    // Algum igual
    if (a == b || a == c || a == d || b == c || b == d || c == d) {
      Console.WriteLine("Algum número está repetido");
    }
    else {
      int menor = a;
      if (b < menor) menor = b;
      if (c < menor) menor = c;
      if (d < menor) menor = d;
      int soma = a + b + c + d - menor;      
      Console.WriteLine(soma);
      // int m = Math.Min(Math.Min(a, b), Math.Min(c, d));
      // if (a < b && a < c && a < d) soma = b + c + d;
      // if (b < a && b < c && b < d) soma = a + c + d;
    }
  }
}