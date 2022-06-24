using System;

class Program {
  public static void Main() {
    Console.WriteLine("Qual o seu nome?");
    string nome = Console.ReadLine();
    nome = RemoverEspacos2(nome);
    nome = FormatarNome(nome);
    Console.WriteLine("Onde você nasceu?");
    string cidade = Console.ReadLine();
    cidade = FormatarNome(cidade);
    Console.WriteLine(nome);
    Console.WriteLine(cidade);
  }
  public static string RemoverEspacos(string nome) {
    string[] v = nome.Split();
    string r = "";
    foreach(string p in v)
      if (p != "") r += (p + " ");
    return r;
  }
  public static string RemoverEspacos2(string nome) {
    while (nome[0] == ' ')
      nome = nome.Remove(0, 1);
    int k = nome.IndexOf("  ");
    while (k != -1) {
      nome = nome.Remove(k, 1);
      k = nome.IndexOf("  ");
    }
    return nome;
  }
  
  public static string FormatarNome(string nome) {
    string[] v = nome.ToLower().Split();
    string r = "";
    foreach(string p in v) { // cada palavra
      switch(p) {
        case "":
        case "da":
        case "de":  
        case "do":  
        case "das":
        case "dos":  
        case "e": r += (p + " "); break;
        default:  r += (p.Substring(0, 1).ToUpper() + 
                        p.Substring(1) + " "); break;
      }
    }
    return r;
  }
  /*
  public static string FormatarNome(string nome) {
    string[] v = s.ToLower().Split();
    string r = "";
    foreach(string p in v) {
      //Console.WriteLine(p);
      //Console.WriteLine(p.Substring(0, 1).ToUpper());
      //Console.WriteLine(p.Substring(1));
      string x = p.Substring(0, 1).ToUpper() + p.Substring(1);
      // Console.WriteLine(x);
      r = r + x + " ";
      // primeira letra
      // p[0]             -> char    char.ToUpper(p[0])
      //p.Substring(0, 1) -> string  p.Substring(0, 1).ToUpper()
    }
    Console.WriteLine(r);
    /*    
    Console.WriteLine(s);
    Console.WriteLine(s.ToUpper());
    Console.WriteLine(s.ToLower());
    char x = 'a';
    char y = 'B';
    Console.WriteLine(char.ToUpper(x));
    Console.WriteLine(char.ToLower(y));
    return "";
  }
  */
}