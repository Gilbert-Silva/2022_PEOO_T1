using System;

class Program {
  public static void Main() {
    // Ler o número do mês e mostrar qual o trimestre do ano
    Console.WriteLine("Informe o mês entre 1 e 12");
    int mes = int.Parse(Console.ReadLine());
    switch(mes) {
      case 1:
      case 2:
      case 3: Console.WriteLine("1º Trimestre"); break;
      case 4:
      case 5:
      case 6: Console.WriteLine("2º Trimestre"); break;
      case 7:
      case 8:
      case 9: Console.WriteLine("3º Trimestre"); break;
      case 10:
      case 11:
      case 12: Console.WriteLine("4º Trimestre"); break;
      default: Console.WriteLine("Mês inválido"); break;
    }
    
    if (mes >= 1 && mes <= 3)  Console.WriteLine("1º Trimestre");
    if (mes >= 4 && mes <= 6)  Console.WriteLine("2º Trimestre");
    if (mes >= 7 && mes <= 9)  Console.WriteLine("3º Trimestre");
    if (mes >= 10 && mes <= 12)  Console.WriteLine("4º Trimestre");
    if (mes < 1 || mes > 12) Console.WriteLine("Mês inválido");

    if (mes >= 1 && mes <= 3)  Console.WriteLine("1º Trimestre");
    else
      if (mes >= 4 && mes <= 6)  Console.WriteLine("2º Trimestre");
      else
        if (mes >= 7 && mes <= 9)  Console.WriteLine("3º Trimestre");
        else
          if (mes >= 10 && mes <= 12)  Console.WriteLine("4º Trimestre");
          else Console.WriteLine("Mês inválido");
  }
}