namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string phoneNumber, string model, string imei, int memory) 
        : base(phoneNumber, model, imei, memory) { }

        public override void InstallApp(string appName)
        {
            Console.WriteLine($"Installing \"{appName}\" on Nokia {Model}");
        }
    }
}