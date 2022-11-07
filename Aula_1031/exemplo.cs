using System;

class Program {
  public static void Main() {
    int[] vetor = new int[4] { 10, 5, 6, 4 };
    Console.WriteLine(vetor[0]);
    Console.WriteLine(vetor[1]);
    Console.WriteLine(vetor[2]);
    Console.WriteLine(vetor[3]);
    Console.WriteLine(vetor.Length);
    for (int i = 0; i < vetor.Length; i++)
      Console.WriteLine(vetor[i]);
    int[] w = { 8, 6, 4, 2 };
    int[] z = w;
    z[0] = 20;
    Console.WriteLine(w[0]);
    Console.WriteLine(w[1]);
    Console.WriteLine(w[2]);
    Console.WriteLine(w[3]);
    // Console.WriteLine(vetor[4]);
    string s = "Teste";
    Console.WriteLine(s[0]);
    Console.WriteLine(s[1]);
    Console.WriteLine(s[2]);
    Console.WriteLine(s[3]);
    Console.WriteLine(s[4]);
    // s[0] = "Q";
    string[] vs = {"Tecnico", "Informatica"};
    Console.WriteLine(vs[0][3]);
    
  }
}