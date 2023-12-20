// See https://aka.ms/new-console-template for more information
using sistema_celular_poo.Models;

class Program
{
    static void Main(string[] args)
    {
        
        Smartphone nokia = new Nokia(definirNumero: "11 975920735", definirModelo: "Nokia X", definirImei: "10108905", definirMemoria: 64);
        Console.WriteLine("Smartphone Nokia X:");
       
        Console.WriteLine();

        nokia.Ligar();
        nokia.ReceberLigacao();

        Console.WriteLine();

        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine();
        Console.WriteLine("///////////////");
        Console.WriteLine();

        Smartphone iphone = new Iphone(definirNumero: "11 908682510", definirModelo: "Iphone 15 PRO MAX", definirImei: "2120783", definirMemoria: 256);
        Console.WriteLine("Smartphone Iphone PRO MAX:");

        Console.WriteLine();

        iphone.Ligar();
        iphone.ReceberLigacao();

        Console.WriteLine();

        iphone.InstalarAplicativo("Instagram");




    }
}
