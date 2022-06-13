using System;
class Program {
  public static void Main() {
    int a = 1;
    double b = 2.5;
    char c = 'a';
    string d = "Informática";
    bool e = true;
    
    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(c);
    Console.WriteLine(d);
    Console.WriteLine(e);
    
    Console.WriteLine(a.GetType());
    Console.WriteLine(b.GetType());
    Console.WriteLine(c.GetType());
    Console.WriteLine(d.GetType());
    Console.WriteLine(e.GetType());
    
    string x = Console.ReadLine();
    int y = int.Parse(Console.ReadLine());
    double z = double.Parse(Console.ReadLine());
    
    if (y < 0)
      Console.WriteLine($"{y} é menor que zero");
    else
      if (y == 0)
        Console.WriteLine($"{y} é zero");
      else  
        Console.WriteLine($"{y} é maior que zero");
    
    int k = 1;
    while (k <= 10) {
      Console.WriteLine(k);
      k += 1;
    }
  }
}
