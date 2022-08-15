using System;

class Program {
  public static void Main() {
    Console.WriteLine("Informe uma data no formato dd/mm/aaaa");
    string data = Console.ReadLine();
    string[] v = data.Split('/');
    int ano = int.Parse(v[2]);
    bool teste = 
        (ano % 400 == 0) ||
        (ano % 4 == 0 && ano % 100 != 0);
    if (teste) {// Faz o próximo comando se V
      Console.WriteLine("O ano é bissexto");
    }
    else { // Faz o próximo comando se F
      Console.WriteLine("O ano não é bissexto");
    }
  }
}