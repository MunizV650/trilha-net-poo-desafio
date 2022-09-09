namespace DesafioPOO.Models
{
    
    public abstract class Smartphone
    {
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        // Implementado !!!
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string Imei { get; set; }
        public int Memoria { get; set; }

        public Smartphone()
        {

        }
        
        
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            // TODO: Passar os parâmetros do construtor para as propriedades
            // Implementado !!!
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;  
        }
        

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}