using System;

class Program {
  public static void Main() {
    int[] x = new int[10];
    for (int i = 0; i < x.Length; i++) {
      x[i] = int.Parse(Console.ReadLine());
      if (x[i] <= 0) x[i] = 1;
    }
    for (int i = 0; i < x.Length; i++)
      Console.WriteLine($"X[{i}] = {x[i]}");
  }
}

    /*
    x[0] = int.Parse(Console.ReadLine());
    x[1] = int.Parse(Console.ReadLine());
    x[2] = int.Parse(Console.ReadLine());
    x[3] = int.Parse(Console.ReadLine());
    x[4] = int.Parse(Console.ReadLine());
    x[5] = int.Parse(Console.ReadLine());
    x[6] = int.Parse(Console.ReadLine());
    x[7] = int.Parse(Console.ReadLine());
    x[8] = int.Parse(Console.ReadLine());
    x[9] = int.Parse(Console.ReadLine());
    */
