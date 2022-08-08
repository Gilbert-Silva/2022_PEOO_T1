using System;

class Program {
  public static void Main() {
    Aluno a = new Aluno();
    a.nome = "Gabriel Santa Rosa";
    a.matricula = "2021101111";

    Aluno b = new Aluno();
    b.nome = "Rebeca Andrielly";
    b.matricula = "2021101111";
    /*
    int x = 5;        // int x = new int();
    double y = 2.5;
    string s = "texto";
    */
    Console.WriteLine(a);
    Console.WriteLine(a.nome);
    Console.WriteLine(a.matricula);
    Console.WriteLine(a.PrimeiroNome());
    Console.WriteLine(a.NumAnos());
    Console.WriteLine(b);
    Console.WriteLine(b.nome);
    Console.WriteLine(b.matricula);
    Console.WriteLine(b.PrimeiroNome());
    Console.WriteLine(b.NumAnos());
    Console.WriteLine(a == b);
  }
}

class Aluno {
  public string nome;            // Atributo
  public string matricula;       // Atributo
  public string PrimeiroNome() { // Método
    string[] v = nome.Split();
    return v[0];
  }
  public int NumAnos() {
    int anoEntrada = int.Parse(matricula.Substring(0, 4));
    int anoAluno = 2022 - anoEntrada + 1;
    return anoAluno;
  }
}
