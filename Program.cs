using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
class Program
{
    static void Main(string[] args)
    {
        Smartphone nokia = new Nokia("1191234-5678", "Nokia Tijolão", "123456789012345", 32);
        Console.WriteLine("=== NOKIA ===");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        Smartphone iphone = new Iphone("1198765-4321", "iPhone 17", "987654321098765", 128);
        Console.WriteLine("=== IPHONE ===");
        iphone.ReceberLigacao();
        iphone.Ligar();
        iphone.InstalarAplicativo("Instagram");
    }
}