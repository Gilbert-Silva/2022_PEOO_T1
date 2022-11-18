using System;

class Program {
  public static void Main() {
    int[,] m = new int[12,12];
    m[0,0] = 1;
    m[0,1] = 2;
    m[1,0] = 3;
    m[2,0] = 4;
    m[11,11] = 5;
    for (int i = 0; i < 12; i++) {
      for (int j = 0; j < 12; j++) {
        Console.Write(m[i,j] + " ");
      }
      Console.WriteLine();
    }
  }
}