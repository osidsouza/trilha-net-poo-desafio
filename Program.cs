using DesafioPOO.Models;

 // * IMPLEMENTADO *

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456", Modelo: "Modelo 1", Imei: "11111111", Memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone Iphone = new Iphone(numero: "123456", Modelo: "Modelo 1", Imei: "11111111", Memoria: 64);
Iphone.Ligar();
Iphone.InstalarAplicativo("Telegram");