using System;

class Program {
  public static void Main() {
    Console.WriteLine("Informe o texto");
    string s = Console.ReadLine();
    Console.WriteLine(Vogais(s));
  }
  public static string Vogais(string s) {
    string x = "";
    foreach(char c in s)
      if (c == 'a' || c == 'e' || c == 'i' || 
          c == 'o' || c == 'u' ||
          c == 'A' || c == 'E' || c == 'I' || 
          c == 'O' || c == 'U')
        x = x + c;
    return x;
  }
}