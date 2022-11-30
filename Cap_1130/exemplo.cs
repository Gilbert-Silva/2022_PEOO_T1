using System;

class Program {
  public static void Main(string[] args) {
    if (args.Length != 0) {
      Console.WriteLine(args[0]);
      Console.WriteLine(args[1]);
      Console.WriteLine(int.Parse(args[0]) +
                        int.Parse(args[1]));
    }
    ListaPresenca x = new ListaPresenca();
    x.Inserir("Gilbert");
    x.Inserir("Maria Cândida");
    x.Inserir("Milton");
    x.Inserir("Gabriel");
    x.Inserir("Thiago");
    Console.WriteLine(x.Listar());
    foreach(string s in x.Listar())
      Console.WriteLine(s);
    Console.WriteLine(x.Pesquisar("gilbert"));
    Console.WriteLine(x.Pesquisar("Gilbert"));
    Console.WriteLine(x.Pesquisar("Thiago"));
  }
}

class ListaPresenca {
  private string[] pessoas = new string[10]; 
  private int k = 0;
  public void Inserir(string pessoa) {
    pessoas[k] = pessoa;
    k++;
  }
  public string[] Listar() {
    string[] vetor = new string[k];
    Array.Copy(pessoas, vetor, k);
    //for(int i = 0; i < k; i++) vetor[i] = pessoas[i];
    return vetor;
  }
  public int GetNumPresentes() {
    return k;
  }
  public bool Pesquisar(string pessoa) {
    /*foreach(string s in pessoas)
      if (s == pessoa) return true;
    return false;    
    */
    return Array.IndexOf(pessoas, pessoa) != -1 ;
  }
}
