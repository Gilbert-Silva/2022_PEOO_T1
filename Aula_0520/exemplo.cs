using System;

class Program {
  public static void Main() {
    int x = 1;
    double y = 1.5;
    string s = "Texto";
    char c = '%';
    bool b = true; // false

    Console.WriteLine("Qualquer valor");
    string r = Console.ReadLine();
    x = int.Parse(r);
    string t = Console.ReadLine();
    y = double.Parse(t);
  }  
}
