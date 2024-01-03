using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone windowns = new Nokia(numero:"1234", modelo:"Windows", imei:"2222", memoria:120);
windowns.Ligar();
windowns.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero:"1234", modelo:"Iphone 13",imei:"5555",memoria:120);
iphone.Ligar();
iphone.InstalarAplicativo("TikTok");