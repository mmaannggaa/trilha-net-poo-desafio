namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia (string numero, string modelo, string imei, int memoria) : base ( numero, modelo, imei, memoria)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
             Console.WriteLine($"Seu Nokia esta instalando: {nomeApp}");
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}