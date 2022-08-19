using System;

class Program {
  public static void Main() {
    Console.WriteLine("Digite o número de alunos:");
    int n = int.Parse(Console.ReadLine());
    int i = 1;
    int soma = 0;
    Console.WriteLine("Digite as notas dos alunos:");
    while(i <= n) {
      int nota = int.Parse(Console.ReadLine());
      soma = soma + nota;
      i++;
    }
    Console.WriteLine("Media = " + soma/n);
  }
}