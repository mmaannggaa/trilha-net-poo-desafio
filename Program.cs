using DesafioPOO.Models;

Console.WriteLine("Smartphone Iphone:");

Smartphone iphone = new Iphone("(14) 99999-0000", "15 ProMax", "175SM258", 256);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia("(14) 98888-1234", "NS 30", "128NK258", 128);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");


// TODO: Realizar os testes com as classes Nokia e Iphone