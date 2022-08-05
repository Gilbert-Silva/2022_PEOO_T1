using System;

class Program {
  public static void Main() {
    Console.WriteLine("Digite dois números inteiros:");
    int x = int.Parse(    Console.ReadLine()); 
    int y = int.Parse(Console.ReadLine());
    int q = x / y;
    int r = x % y;
    Console.WriteLine($"{x} / {y} = {q}");
    Console.WriteLine(x + " / " + y + " = " + q);
    Console.WriteLine($"{x} % {y} = {r}");
    //if (teste)
    //for ()
  }
}