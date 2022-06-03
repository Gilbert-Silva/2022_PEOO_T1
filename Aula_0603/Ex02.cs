using System;

public class Program { 
  public static void Main(string[] args) { 
    int a = int.Parse(Console.ReadLine()); 
    int b = int.Parse(Console.ReadLine()); 
    int c = int.Parse(Console.ReadLine()); 
    int d = int.Parse(Console.ReadLine()); 

    //int q = 8 / 5;  // Quociente
    //int r = 8 % 5;  // Resto
    int soma = 0;
    if (a % 2 == 0) soma = soma + a;
    if (b % 2 == 0) soma = soma + b;
    if (c % 2 == 0) soma = soma + c;
    if (d % 2 == 0) soma = soma + d;
    Console.WriteLine(soma);

    //if (a % 2 == 0) 
    //  Console.WriteLine($"O número {a} é par");
    //if (a % 2 == 1) 
    //  Console.WriteLine($"O número {a} é par");

    
  }
}