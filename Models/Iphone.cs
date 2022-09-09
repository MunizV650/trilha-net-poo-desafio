using System;
namespace DesafioPOO.Models

{
  // Implementado !!!
  // TODO: Herdar da classe "Smartphone"
  public class Iphone : Smartphone
  {
    // Implementado !!!
    // TODO: Sobrescrever o método "InstalarAplicativo"
    public Iphone()
    {

    }
    public Iphone(string numero, string modelo, string imei, int memoria)
    {
            
    }
    public override void InstalarAplicativo(string nomeApp)
    {
      Console.WriteLine($"Instalando o Aplicativo {nomeApp} no Iphone");
    }
  }
}