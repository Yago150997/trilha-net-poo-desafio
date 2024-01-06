namespace DesafioPOO.Models
{
    
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string model, string imei, int memoria) : base( numero,  model,  imei, memoria)
        {
            Console.WriteLine("Smartphone Nokia: ");
        }
        
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp}...");
        }

    }
    }
