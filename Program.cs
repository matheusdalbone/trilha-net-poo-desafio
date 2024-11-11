using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new("21995552457", "ST-kd3", "98318384828193823", 32);
Iphone iphone = new("21945122476", "12 PRO", "283184364813819328", 128);

Console.WriteLine("Smartphone Nokia:");
Console.WriteLine("IMEI: " + nokia.IMEI);
Console.WriteLine("Numero: " + nokia.Numero);
Console.WriteLine("Modelo: " + nokia.Modelo);
Console.WriteLine("Armazenamento: " + nokia.Memoria + " GB");
nokia.Ligar("21945122476");
nokia.InstalarAplicativo("whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Console.WriteLine("IMEI: " + iphone.IMEI);
Console.WriteLine("Numero: " + iphone.Numero);
Console.WriteLine("Modelo: " + iphone.Modelo);
Console.WriteLine("Armazemaneto: " + iphone.Memoria + " GB");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("telegram");