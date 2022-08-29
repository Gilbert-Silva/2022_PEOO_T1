using System;

class Program {
  public static void Main() {
    Console.WriteLine("Qual a distância em km percorrida na sua viagem?");
    double dist = double.Parse(Console.ReadLine());
    Console.WriteLine("Quanto tempo você gastou (hh:mm:ss)?"); // "02:30" - 2h e 30 min
    string tempo = Console.ReadLine();
    
    Viagem minhaViagem = new Viagem();
    minhaViagem.SetDistancia(dist);
    minhaViagem.SetTempo(tempo);
    Console.WriteLine($"Distância percorrida: {minhaViagem.GetDistancia()} km");
    Console.WriteLine($"Tempo gasto: {minhaViagem.GetTempo()} h");
    Console.WriteLine($"Velocidade média: {minhaViagem.VelocidadeMedia()} km/h");
  }
}

class Viagem {
  private double distancia;
  private double tempo = 1;
  public void SetDistancia(double d) {
    if (d > 0) distancia = d;
  }
  public void SetTempo(double t) {
    if (t > 0) tempo = t;
  }
  public void SetTempo(string t) {   // "00:00:00"
    if (t != "00:00:00") {
      string[] v = t.Split(':'); // "02" "45"
      int h = int.Parse(v[0]);                  // Número de horas:   "02" -> 2
      int m = int.Parse(v[1]);                  // Número de minutos: "30" -> 30
      int s = int.Parse(v[2]);                  // Número de segundos
      double horas = h + m/60.0 + s/3600.0;     // Total de horas:    2,5 horas
      tempo = horas;
    }
  } 
  public double GetDistancia() {
    return distancia;
  }
  public double GetTempo() {
    return tempo;
  }
  public double VelocidadeMedia() {
    return distancia / tempo;
  }
}