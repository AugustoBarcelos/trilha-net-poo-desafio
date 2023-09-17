namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        // Propriedades adicionais da classe Nokia
        public string ModeloNokia { get; set; }
        public bool TemTeclado { get; set; }

        // Construtor para a classe Nokia
        public Nokia(string numero, string modelo, string imei, int memoria, string modeloNokia, bool temTeclado)
            : base(numero, modelo, imei, memoria)
        {
            ModeloNokia = modeloNokia;
            TemTeclado = temTeclado;
        }

        // Implementação do método abstrato InstalarAplicativo
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia.");
        }
    }
}
