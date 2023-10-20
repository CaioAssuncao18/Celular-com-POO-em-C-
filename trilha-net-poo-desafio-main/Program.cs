using System;
using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando um Nokia
            Nokia nokia = new Nokia("123456", "Nokia 8", "IMEI12345", 64);

            // Chamando métodos do Nokia
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");

            // Exibindo informações do Nokia
            Console.WriteLine("Informações do Nokia:");
            Console.WriteLine($"Número: {nokia.Numero}");
            Console.WriteLine($"Modelo: {nokia.Modelo}");
            Console.WriteLine($"IMEI: {nokia.IMEI}");
            Console.WriteLine($"Memória: {nokia.Memoria} GB");


            // Criando um iPhone
            Iphone iphone = new Iphone("987654", "iPhone 12", "IMEI54321", 128);

            // Chamando métodos do iPhone
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");

            // Exibindo informações do iPhone
            Console.WriteLine("\nInformações do iPhone:");
            Console.WriteLine($"Número: {iphone.Numero}");
            Console.WriteLine($"Modelo: {iphone.Modelo}");
            Console.WriteLine($"IMEI: {iphone.IMEI}");
            Console.WriteLine($"Memória: {iphone.Memoria} GB");

        }
    }
}
