using System;

class Program {
  public static void Main() {
    int x = 2;
    while (x <= 100) {
      if (x % 2 == 0)
        Console.WriteLine(x);
      x++; 
    }
  }
  public static void Main2() {
    int x = 2;
    while (x <= 100) {
      Console.WriteLine(x);
      x = x + 2; 
    }
  }
}