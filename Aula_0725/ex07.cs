using System;

class Program {
  public static void Main() {
    int a, b;
    int x = 10;
    AntecessorSucessor(x, out a, out b);
    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(x);
  }
  public static void AntecessorSucessor (int x, out int antecessor, 
    out int sucessor) {
    antecessor = x - 1;
    sucessor = x + 1;
    x = 100;
  }
  public static int AntecessorSucessor (int x) {
    return x - 1;
    return x + 1;
  }
}
