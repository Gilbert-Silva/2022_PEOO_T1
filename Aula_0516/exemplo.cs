using System;

class Program {
  public static void Main() {
    int x = int.Parse( Console.ReadLine() );
    int y = int.Parse( Console.ReadLine() );
    double d = x*y/12.0;
    Console.WriteLine($"{d:0.000}");  
  }
}
