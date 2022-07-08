using System;

class Program {
  public static void Main() {
    Console.WriteLine("Digite um texto");
    string s = Console.ReadLine();
    //Console.WriteLine(s.Substring(0, 1));
    //Console.WriteLine(s.Substring(1));
    int i = 1;
    while (i <= s.Length) {
      s = s.Substring(1) + s.Substring(0, 1);
      Console.WriteLine(s);
      i++;
    }
  }

  
  
  
  
  public static void Main2() {
    int x = 1;
    int y = 1;
    while (x <= 10) {
      Console.WriteLine($"{x,2} {y,2} = {x*y,2}");
      x++;
      y = -y;
    }
  }
  public static void Main3() {
    int x = 1;
    while (x <= 10) {
      if (x % 2 == 0)
        Console.WriteLine(-x);
      else
        Console.WriteLine(x);
      x++;
    }
  }
}