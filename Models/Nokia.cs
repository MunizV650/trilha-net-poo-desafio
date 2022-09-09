namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    // Implementado !!!
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        // Implementado !!!
        public Nokia()
        {

        }
        public Nokia(string numero, string modelo, string imei, int memoria)
        {
            
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o Aplicativo: {nomeApp} no Nokia");
        }
   
    }
}