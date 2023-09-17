using System;

namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        // Propriedades adicionais da classe Iphone
        public string ModeloIphone { get; set; }
        public string SistemaOperacional { get; set; }

        // Construtor para a classe Iphone
        public Iphone(string numero, string modelo, string imei, int memoria, string modeloIphone, string sistemaOperacional)
            : base(numero, modelo, imei, memoria)
        {
            ModeloIphone = modeloIphone;
            SistemaOperacional = sistemaOperacional;
        }

        // Implementação do método abstrato InstalarAplicativo
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no iPhone.");
        }
    }
}
