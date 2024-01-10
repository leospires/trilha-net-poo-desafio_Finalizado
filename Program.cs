using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone



Console.WriteLine("Smartphone Nokia: ");

Smartphone nokia = new Nokia(numero: "12345", modelo: "Modelo 1", emei: "11111", memoria: "64");
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone: ");
Smartphone iphone = new Iphone(numero: "67890", modelo: "Modelo 2", emei: "2222" , memoria: "128");
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");



