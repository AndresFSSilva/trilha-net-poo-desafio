using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
var nokia = new Nokia(numero: "5467", modelo: "Modelo 5", imei: "6745669823", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("-------------------------------------------------------");

Console.WriteLine("Smartphone Iphone:");
var iphone = new Iphone(numero: "8797", modelo: "Modelo 9", imei: "8832779123", memoria: 246);
iphone.Ligar();
iphone.InstalarAplicativo("Facebook");