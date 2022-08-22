using System;

class Program {
  public static void Main() {
    int k = 1;
    Console.WriteLine($"Digite o nome da {k}ª pessoa");
    string nome = Console.ReadLine();
    string data;
    string nomeMaisNovo = "", dataMaisNovo = "";
    while (nome != "fim") {
      Console.WriteLine("Digite a data de nascimento");
      data = Console.ReadLine();
      if (k == 1) { // Dados da 1ª pessoa
        nomeMaisNovo = nome;
        dataMaisNovo = data;
      }      
      if (k > 1) { // Comparar os dados da 2ª pessoa em diante
        string[] v = data.Split('/');
        string[] w = dataMaisNovo.Split('/');
        int vi = int.Parse(v[2] + v[1] + v[0]);
        int wi = int.Parse(w[2] + w[1] + w[0]);  
        if (vi > wi) {
          nomeMaisNovo = nome;
          dataMaisNovo = data;
        }
      }
      k++;
      Console.WriteLine($"Digite o nome da {k}ª pessoa");
      nome = Console.ReadLine();
    }
    Console.WriteLine($"Mais novo = {nomeMaisNovo}");
    Console.WriteLine($"Nasceu em = {dataMaisNovo}");
  }
}

