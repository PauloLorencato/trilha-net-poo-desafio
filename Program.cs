using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Nokia: ");
Nokia Nokia = new Nokia("13843483483", "ModeloNokia", "11111111111", 8);
Nokia.Ligar();
Nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("Iphone: ");
Iphone Iphone = new Iphone("66876468754", "ModeloIphone", "22222222222", 4);
Iphone.Ligar();
Iphone.InstalarAplicativo("Whatsapp");