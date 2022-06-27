using System;

class Program {
  public static void Main() {
    int n = int.Parse(Console.ReadLine());
    for (int i = 1; i <= n; i++) {
      string s = Console.ReadLine();
      string[] v = s.Split();
      int x = int.Parse(v[0]);
      int y = int.Parse(v[1]);
      Console.WriteLine(MDC(x, y));      
    }
  }
  public static int MDC(int x, int y) {
    int d = Math.Min(x, y);
    if (x < y) d = x; else d = y;
    while( !(x % d == 0 && y % d == 0) ) d--;
    return d;
  }
}

