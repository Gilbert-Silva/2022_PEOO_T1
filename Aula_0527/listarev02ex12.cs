using System;

class Program {
  public static void Main() {
    string s = Console.ReadLine();
    string[] v = s.Split('+', '-', '*', '/');
    Console.WriteLine(v[0]);
    Console.WriteLine(v[1]);
    int p = s.IndexOf('+');
    if (p == -1) s.IndexOf('-');
    if (p == -1) s.IndexOf('*');
    if (p == -1) s.IndexOf('/');
    switch(s[p]) {
      case '+' : 
      case '-' : 
      case '*' : 
      case '/' : 
    }
    
  }
}