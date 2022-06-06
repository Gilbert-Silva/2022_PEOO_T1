using System;

class Program {
  public static void Main() {
    Console.WriteLine("while");
    int i = 1;
    while (i <= 10) {
      Console.WriteLine(i);
      i += 2;
    }

    Console.WriteLine("for");
    for (i = 1; i <= 10; i+=2) {
      Console.WriteLine(i);
    }
    
    i = 1;
    Console.WriteLine("do - while");
    do {
      Console.WriteLine(i);
      i++;
    } while(i <= 10);

    Console.WriteLine("foreach");
    int[] v = { 5, 9, 1, 4, 3 };
    foreach(int x in v)
      Console.WriteLine(x);

    string s = "Informática para Internet";
    foreach(char c in s)
      Console.WriteLine(c);
  }
}