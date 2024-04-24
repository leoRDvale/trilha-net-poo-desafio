using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero:64981819090, modelo:"Lumia 720", imei:01234567890, memoria:128);
nokia.Ligar();
nokia.InstalarAplicativo("GitHub");

Console.WriteLine("\n");
Console.WriteLine("-------------------------------");
Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero:64981510000, modelo:"13 Pro Max", imei:09876543210, memoria:128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Discord");