using DesafioPOO.Models;

var iphone = new Iphone(phoneNumber: "99876-5432", imei: "8989-0909", model: "X", memory: 8);
var nokia = new Nokia(phoneNumber: "99123-4567", imei: "4040-6767", model: "Tijolao", memory: 1024);

Console.WriteLine("Iphone operations: ");
iphone.MakeCall();
iphone.ReceiveCall();
iphone.InstallApp("Youtube");

Console.WriteLine();

Console.WriteLine("Nokia operations: ");
nokia.MakeCall();
nokia.ReceiveCall();
nokia.InstallApp("Telegram");