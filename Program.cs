using DesafioPOO.Models;

Console.WriteLine("Nokia!");
Smartphone nokia = new Nokia(numero: "123456", modelo: "26", imei: "11111111", memoria: "64");
nokia.Ligar();
nokia.InstalarAplicativo("YoutubeMusic");

Console.WriteLine("------------------------------------");

Console.WriteLine("Iphone");
Smartphone iphone = new Iphone(numero: "987654", modelo: "6", imei: "2222222222", memoria: "128");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Spotify");