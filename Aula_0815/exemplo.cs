using System;

class Program {
  public static void Main() {
    Console.WriteLine("Informe uma data no formato dd/mm/aaaa");
    string data = Console.ReadLine();
    string[] v = data.Split('/');
    Console.WriteLine(v[0]);
    Console.WriteLine(v[1]);
    Console.WriteLine(v[2]);
    int ano = int.Parse(v[2]) + 1;
    int mes = int.Parse(v[1]);
    if (mes == 1) Console.WriteLine("janeiro");
     
    
    switch (mes) {
      case 1: Console.WriteLine("janeiro"); break;
        
    }
    Console.WriteLine(ano);
    Console.WriteLine($"{v[0]}/{v[1]}/{ano}");
  }  
}