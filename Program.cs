using DesafioPOO.Models;

// Implementado
Console.WriteLine("Nokia:");
Nokia n1 = new Nokia(numero:"61911552233",modelo:"Tijolão 01",imei:"05010203096",memoria:32);
n1.Ligar();
n1.InstalarAplicativo("WhatsApp");

Console.WriteLine("Iphone");
Iphone i1 = new Iphone(numero:"61980808185", modelo:"ProMax 23",imei:"3333555666",memoria:128 );
i1.ReceberLigacao();
i1.InstalarAplicativo("Instagram");