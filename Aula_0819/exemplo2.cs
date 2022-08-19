using System;

class Program {
  public static void Main() {
    string s = "InfoWeb";
    foreach(char c in s)
      Console.WriteLine(c);

    int soma = 0;
    int prod = 1;
    int[] v = {1, 2, 3, 4, 5, 10, 15, 20, 25};
    foreach(int i in v) {
      Console.WriteLine(i);
      soma = soma + i;
      prod = prod * i;
    }
    Console.WriteLine("Soma = " + soma);
    Console.WriteLine("Produto = " + prod);

    string[] w = { "Tecnico", "em", "Informatica", "para", "Internet"};

    foreach(string p in w) {
      Console.WriteLine(p);
      foreach(char c in p)
        Console.WriteLine(c);
    }
    
  }
}