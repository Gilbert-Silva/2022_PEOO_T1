using System;
class Program {
  public static void Main() {
    Cliente c1 = new Cliente("Gabriel", "1234", 1000); 
    Cliente c2 = new Cliente("João", "4321", 1500); 
    Cliente c3 = new Cliente("Jordson", "0101", 1200); 
    c1.SetSocio(c2);
    Console.WriteLine(c1);
    Console.WriteLine(c2);
    Console.WriteLine(c3);
    Console.WriteLine(c1.GetLimite());
    Console.WriteLine(c2.GetLimite());
    Console.WriteLine(c3.GetLimite());
    c1.SetSocio(c3);
    Console.WriteLine(c1.GetLimite());
    Console.WriteLine(c2.GetLimite());
    Console.WriteLine(c3.GetLimite());

    Empresa emp = new Empresa("IFRN");
    emp.Inserir(c1);
    emp.Inserir(c2);
    emp.Inserir(c3);
    foreach(Cliente c in emp.Listar())
      Console.WriteLine(c);    
    /*
    Cliente[] vetor = new Cliente[10];
    vetor[0] = c1;
    vetor[1] = c2;
    vetor[2] = c3;
    foreach(Cliente c in vetor)
      Console.WriteLine(c);
    */
  }
}

class Empresa {
  private string nome;
  private Cliente[] clientes = new Cliente[10];
  private int k = 0;
  public Empresa(string n) {
    nome = n;
  }
  public void Inserir(Cliente c) {
    clientes[k] = c;
    k++;
  }
  public Cliente[] Listar() {
    Cliente[] vetor = new Cliente[k];
    Array.Copy(clientes, vetor, k);
    return vetor;
  }
}

class Cliente : object {
  private string nome, cpf;
  private double limite;
  private Cliente socio;
  public Cliente(string n, string c, double l) {
    nome = n;
    cpf = c;
    if (l > 0) limite = l;
  }
  public void SetSocio(Cliente c) {
    // Ajustar a sociedade entre os clientes this e c
    // Testar se this tem algum sócio
    if (this.socio != null) {
      Cliente sociodethis = this.socio;
      sociodethis.socio = null;
    }
    // Testar se c tem algum sócio
    if (c.socio != null) c.socio.socio = null;    
    this.socio = c;
    c.socio = this;
  }
  public double GetLimite() {
    if (socio == null) return limite;
    else return limite + socio.limite;
  }
  public override string ToString() {
    return $"{nome} - {cpf} - {limite:0.00} - {GetLimite():0.00}";
  }
}
