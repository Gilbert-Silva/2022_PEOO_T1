using System;

class Program {
  public static void Main() {
    string s = Console.ReadLine();   // s = "6 24"
    string[] v = s.Split();          // v = ["6", "24"]
    int a = int.Parse(v[0]);         // a = 6
    int b = int.Parse(v[1]);         // b = 24

    if (a % b == 0 || b % a == 0)
      Console.WriteLine("Sao Multiplos");
    else
      Console.WriteLine("Nao sao Multiplos");
  }
}