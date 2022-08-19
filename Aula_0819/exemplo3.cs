using System;

class Program {
  public static void Main() {
    // while             repetem alguma coisa
    // do-while          enquanto um teste
    // for               é verdadeiro
    string s = Console.ReadLine();
    while(s != "fim") {
      Console.WriteLine(s);
      s = Console.ReadLine();
    }
    int i = 1;
    while(i < 11) {
      Console.WriteLine(i + " - Olá");
      i++;
    }
    Console.WriteLine(i);
    //   0123456
    s = "InfoWeb";
    foreach(char c in s) 
      Console.WriteLine(c);
    i = s.Length - 1;
    while (i >= 0) {
      Console.WriteLine(s[i]);
      i--;
    }
    Console.WriteLine(i);
   
  }
}