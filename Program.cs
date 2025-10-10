using DesafioPOO.Models;

var iphone = new Iphone("11922446688", "iPhone 14", "IMEI123456789", 2048);
var nokia = new Nokia("11988664422", "Nokia Phone", "IMEI987654321", 1024);

// Testa métodos herdados no Iphone
Console.WriteLine($"Testando funcionalidades {iphone.Modelo}");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

// Testa métodos herdados no Nokia
Console.WriteLine($"Testando funcionalidades {nokia.Modelo}");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");