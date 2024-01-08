namespace DesafioPOO.Models
{
     // * IMPLEMENTADO *
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string Modelo, string Imei, int Memoria) : base(numero)
        {
        }

       // * IMPLEMENTADO *
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"{nomeApp} instalado com sucesso no Android!");
        }
    }
}