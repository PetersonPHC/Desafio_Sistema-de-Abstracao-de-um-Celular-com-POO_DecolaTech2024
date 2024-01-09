using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Nokia nokiaG11Plus = new Nokia(numero: "(11)98787-4545", modelo: "Nokia G11 Plus", imei: "123456789101112", memoria: 64);
nokiaG11Plus.Ligar();
nokiaG11Plus.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Iphone iphone14ProMax = new Iphone(numero: "(11)93636-2525", modelo: "Iphone 14 Pro Max", imei: "999897969594930", memoria: 128);
iphone14ProMax.Ligar();
iphone14ProMax.InstalarAplicativo("Telegram");
