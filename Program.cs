using System;
using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("SmartPhone Nokia");
        Smartphone nokia = new Nokia(numero: "777777", modelo: "Tijolao", imei: "1111", memoria: 256);
        Console.WriteLine($"Numero: {nokia.Numero}, Modelo: {nokia.Modelo}, IMEI: {nokia.Imei}, Memoria: {nokia.Memoria}GB");
        nokia.Ligar();
        nokia.InstalarAplicativo("Telegram");

        Console.WriteLine("\n");

        Console.WriteLine("SmartPhone Iphone");
        Smartphone iphone = new Iphone(numero: "999999", modelo: "XR", imei: "2222", memoria: 512);
        Console.WriteLine($"Numero: {iphone.Numero}, Modelo: {iphone.Modelo}, IMEI: {iphone.Imei}, Memoria: {iphone.Memoria}GB");
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("WhatsApp");
    }
}