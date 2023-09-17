
using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testando a classe Iphone
            Iphone iphone = new Iphone("123456789", "iPhone 12", "IMEI123", 128, "iPhone 12 Pro", "iOS");
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("WhatsApp");

            // Testando a classe Nokia
            Nokia nokia = new Nokia("987654321", "Nokia 3310", "IMEI987", 16, "Nokia 3310", true);
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("Snake");

            // Pausa a execução para visualização dos resultados
            Console.ReadLine();
        }
    }
}
