using System;

class Program {
  public static void Main() {
    Console.WriteLine(MMC(1, 2, 3));
    Console.WriteLine(MMC(2, 4, 8));
    Console.WriteLine(MMC(2, 4, 5));
  }
  public static int MMC(int x, int y, int z) {
    int m = 1;
    while (!(m % x == 0 && m % y == 0 && m % z == 0)) m++;
    return m;
  }
    public static int MDC(int x, int y) {
    int d = Math.Min(x, y);
    if (x < y) d = x; else d = y;
    while( !(x % d == 0 && y % d == 0) ) d--;
    return d;
  }
}