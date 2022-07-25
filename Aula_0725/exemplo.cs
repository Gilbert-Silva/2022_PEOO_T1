using System;

class Program {
  public static void Main() {
    int a = 10; int b;
    Console.WriteLine(a);
    Metodo1(a);
    Console.WriteLine(a);
    Metodo2(out b);
    Console.WriteLine(b);
    Metodo3(ref a);
    Console.WriteLine(a);
  }
  public static void Metodo1(int x)     { x = 20; }
  public static void Metodo2(out int x) { x = 30; }
  public static void Metodo3(ref int x) { x = 40; }
}