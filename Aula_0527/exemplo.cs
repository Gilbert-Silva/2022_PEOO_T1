using System;

class Program {
  public static void Main() {
    int x = 4;
    x = x << 1;
    Console.WriteLine(x);
    x = x >> 2;
    Console.WriteLine(x);
    x = 7;
    x = x >> 1;
    Console.WriteLine(x);
  }
}