using System;

class Program {
  public static void Main() {
    Console.WriteLine("Digite uma frase");
    string s = " " + Console.ReadLine();
    int k = 0;
    int n = 0;
    while (k < s.Length) {
      if (s[k] == ' ') {
        Console.Write(s[k+1]);
        
        int c = 0;
        while (c < n) {
          Console.Write(s[k+1]); 
          c++;
        }

        n++;
        Console.Write(" ");
      }
      k++;
    }
  }

  
  public static void Main2() {
    Console.WriteLine("Digite uma frase");
    string s = Console.ReadLine();
    string[] v = s.Split();
    //foreach(string p in v) Console.WriteLine(p);
    int k = 0;
    while (k < v.Length) {
      string p = v[k];
      //Console.WriteLine(k);
      Console.Write(p[0]); 
      int c = 0;
      while (c < k) {
        Console.Write(p[0]); 
        c++;
      }
      Console.Write(" ");
      // p[0] (char) = p.Substring(0, 1) (string)
      k++;
    }
  }
}
