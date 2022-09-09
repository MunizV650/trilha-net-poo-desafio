using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// Implementado !!!

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo Tal", imei: "111111", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("'Whatsapp'");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "4987", modelo: "Modelo 2", imei: "222222", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("'Telegram'");

