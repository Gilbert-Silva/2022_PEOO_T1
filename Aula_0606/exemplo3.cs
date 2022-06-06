using System;

class Program {
  public static void Main() {
    int i, k, p;
    for (i = 1; i <= 9; i++) {
      // Console.WriteLine($"i = {i}");
      for (k = 1; k <= 9; k++) {
        p = i * k;
        Console.WriteLine($"{i} x {k} = {p}");
      }
      Console.WriteLine();
    }
  }
}