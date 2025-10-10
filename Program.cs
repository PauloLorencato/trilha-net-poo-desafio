using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
var nokia = new Nokia("123456", "Modelo 1", "1111111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
var iphone = new Iphone("4987", "Modelo 2", "22222222222", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

