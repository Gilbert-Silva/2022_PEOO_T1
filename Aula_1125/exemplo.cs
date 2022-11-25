using System;

class Program {
  public static void Main() {
    Cliente a = new Cliente("Arthur");
    Cliente b = new Cliente("Gabriel");
    Console.WriteLine(a);
    Console.WriteLine(b);
    a.SetSocio(b);
    Console.WriteLine(a);
    Console.WriteLine(b);
    Cliente c = new Cliente("Iraikare");
    Console.WriteLine(c);
    a.SetSocio(c);
    Console.WriteLine("Novas sociedades");
    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(c);
    
  }
}

class Cliente : object {
  private string nome;
  private Cliente socio;
  public Cliente(string nome) {
    this.nome = nome;
  }
  public void SetSocio(Cliente c) {
    Cliente x = this.socio;
    Cliente y = c.socio;
    if (x != null) x.socio = null;
    if (y != null) y.socio = null;
    this.socio = c;
    c.socio = this;
  }
  public override string ToString() {
    if (socio == null) return nome;
    else return nome + " - " + socio.nome;
  }
}