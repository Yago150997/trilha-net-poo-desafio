namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string model, string imei, int memoria) : base( numero,  model,  imei, memoria)
        {
            Console.WriteLine("Smartphone Iphone: ");
        }
        
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp}...");
        }

    }
}