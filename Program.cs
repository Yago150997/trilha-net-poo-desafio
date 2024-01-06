using DesafioPOO.Models;

Smartphone Nokia = new Nokia(numero: "55893321", model: "M1", imei: "2225559", memoria: 256);
Nokia.Ligar();
Nokia.InstalarAplicativo("Netflix");
Console.WriteLine();

Smartphone Iphone = new Iphone(numero: "99315522", model: "M2", imei: "5423871235", memoria: 128);
Iphone.Ligar();
Iphone.ReceberLigacao();
Iphone.InstalarAplicativo("Prime Video");