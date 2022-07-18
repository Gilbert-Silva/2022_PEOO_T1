using System;
class Program {
  public static void Main() {
    Mensagem();
    Bemvindo("Gilbert");
    Bemvindo("Eduardo");
    Bemvindo("Minora");
    Console.WriteLine(PI());
    Console.WriteLine(ProximoNumero(18));
    Console.WriteLine(ProximoNumeroPar(18));
    Console.WriteLine(ProximoNumeroPar(19));
    MostrarNumeros(1, 10);
    MostrarNumeros(91, 100);
    Console.WriteLine("Média = " + Media(100, 100, 50, 50));
    Console.WriteLine("Média = " + Media(50, 50, 100, 100));
    Console.WriteLine("Passar = " + NotaPassar(60, 60, 60));
    Console.WriteLine("Passar = " + NotaPassar(90, 90, 90));
    Console.WriteLine("Passar = " + NotaPassar(80, 80, 80));
  }
  public static void Mensagem() {
    Console.WriteLine("Olá");
  }
  public static int Media(int n1, int n2, int n3, int n4) {
    int m = (2*n1 + 2*n2 + 3*n3 + 3*n4) / 10;
    return m;
  }
  public static int NotaPassar(int n1, int n2, int n3) {
    int n4;
    n4 = (600 - 2*n1 - 2*n2 - 3*n3) / 3;
    return n4;
  }
  
  public static void MostrarNumeros(int x, int y) {
    int i = x;
    while (i <= y) {
      Console.WriteLine(i);
      i++;
    }
  }
  public static void Bemvindo(string s) {
    Console.WriteLine("Bem-vindo, " + s);
  }
  public static double PI() {
    return 3.1416;
  }
  public static int ProximoNumero(int x) {
    x = x + 1;
    return x;
  }
  public static int ProximoNumeroPar(int x) {
    x = ProximoNumero(x);
    if (x % 2 != 0) {
      x = ProximoNumero(x);
    }
    return x;
  }
}


/*

          2*n1 + 2*n2 + 3*n3 + 3*n4
m = 60 = ----------------------------
                      10


600 = 2*n1 + 2*n2 + 3*n3 + 3*n4

600 - 2*n1 - 2*n2 - 3*n3 = 3*n4


600 - 2*n1 - 2*n2 - 3*n3 
------------------------ = n4
             3


*/