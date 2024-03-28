namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string phoneNumber, string model, string imei, int memory) 
        : base(phoneNumber, model, imei, memory) { }

        public override void InstallApp(string appName)
        {
            Console.WriteLine($"Installing \"{appName}\" on Iphone {Model}");
        }
    }
}