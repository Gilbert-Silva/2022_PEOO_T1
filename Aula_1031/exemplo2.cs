using System;

class Program {
  public static void Main() {
    int[] vetor = new int[4] { 10, 5, 6, 4 };
    Console.WriteLine(Array.IndexOf(vetor, 6));
    Console.WriteLine(Array.IndexOf(vetor, 9));
    Array.Resize(ref vetor, 6);
    Array.Reverse(vetor);
    foreach (int i in vetor)
      Console.WriteLine(i);  // i é o elemento
    for (int i = 3; i >= 0; i--)
      Console.WriteLine(vetor[i]); // i é a posição
    for (int i = 0; i < vetor.Length; i += 2)
      Console.WriteLine(vetor[i]); // i é a posição
  }
}