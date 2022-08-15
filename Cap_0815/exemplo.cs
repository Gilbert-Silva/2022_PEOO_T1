using System;

class Program {
  public static void Main() {           //         15/08/2022
    Console.WriteLine("Informe uma data no formato dd/mm/aaaa");
    string data = Console.ReadLine();
    Console.WriteLine(data);
    string[] v = data.Split('/');
    Console.WriteLine(v[0]);         // Dia
    Console.WriteLine(v[1]);         // Mes
    Console.WriteLine(v[2]);         // Ano
    int ano = int.Parse(v[2]) + 1;   // Próximo ano
    Console.WriteLine(ano);
    string novadata = $"{v[0]}/{v[1]}/{ano}";
    Console.WriteLine(novadata);
  }
}
