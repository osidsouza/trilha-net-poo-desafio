namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }

        public string Imei { get; set; }

        public int Memoria { get; set; }
        // * IMPLEMENTADO *

        public Smartphone(string numero, string Modelo, string Imei, int Memoria)
        {
            Numero = numero;
            
       
            
            // * IMPLEMENTADO *
        }

        protected Smartphone(string numero)
        {
            Numero = numero;
            this.Modelo = Modelo;
            this.Imei = Imei;
            this.Memoria = Memoria;
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