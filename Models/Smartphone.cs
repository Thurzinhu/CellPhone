namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string PhoneNumber { get; set; }
        protected string Model { get; set; }
        protected string IMEI { get; set; }
        protected int Memory { get; set; }

        public Smartphone(string phoneNumber, string model, string imei, int memory)
        {
            PhoneNumber = phoneNumber;
            Model = model;
            IMEI = imei;
            Memory = memory;
        }

        public void MakeCall()
        {
            Console.WriteLine("Calling...");
        }

        public void ReceiveCall()
        {
            Console.WriteLine("Someone is calling");
        }

        public abstract void InstallApp(string appName);
    }
}